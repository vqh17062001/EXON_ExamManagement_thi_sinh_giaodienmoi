using DAO.DataProvider;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO.DAO
{
    public class AnswersheetDetailDAO
    {
        private static AnswersheetDetailDAO instance;
        public static AnswersheetDetailDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AnswersheetDetailDAO();
                }
                return instance;
            }
        }
        private AnswersheetDetailDAO() { }


        public void PushAnswerSheetDetail(AnswersheetDetail ansSheetDetail, out ErrorController EC, SqlConnection sql)
        {

            using (EXON_SYSTEM_TESTEntities db = new EXON_SYSTEM_TESTEntities())
            {
                try
                {
                    List<SqlParameter> para = new List<SqlParameter>();
                    para.Add(new SqlParameter("@AnswerSheetID", ansSheetDetail.AnswerSheetID));
                    para.Add(new SqlParameter("@SubQuestionID", ansSheetDetail.SubQuestionID));
                    List<ANSWERSHEET_DETAILS> adtemp = Utils.ExcuteObject<ANSWERSHEET_DETAILS>("SELECT * FROM ANSWERSHEET_DETAILS WHERE AnswerSheetID = @AnswerSheetID and SubQuestionID = @SubQuestionID", para, sql).ToList();

                    //ANSWERSHEET_DETAILS AD = db.ANSWERSHEET_DETAILS.SingleOrDefault(x => x.AnswerSheetID == ansSheetDetail.AnswerSheetID && x.SubQuestionID == ansSheetDetail.SubQuestionID);
                    ANSWERSHEET_DETAILS AD = adtemp.Count == 1 ? adtemp[0] : null;
                    if (AD != null)
                    {
                        double score = 0;
                        ANSWER ans = new ANSWER();
                        if (ansSheetDetail.AnswerContent != null)
                        {
                            para = new List<SqlParameter>();
                            para.Add(new SqlParameter("@SubQuestionID", ansSheetDetail.SubQuestionID));
                            List<ANSWER> anstemp = Utils.ExcuteObject<ANSWER>("SELECT * FROM ANSWERS WHERE SubQuestionID = @SubQuestionID", para, sql).ToList();

                            //ans = db.ANSWERS.Where(x => x.SubQuestionID == ansSheetDetail.SubQuestionID).SingleOrDefault();
                            ans = anstemp.Count == 1 ? anstemp[0] : null;
                            if (ans != null)
                            {
                                para = new List<SqlParameter>();
                                para.Add(new SqlParameter("@SubQuestionID", ans.SubQuestionID));
                                SUBQUESTION sub_ques = Utils.ExcuteObject<SUBQUESTION>("SELECT * FROM SUBQUESTIONS WHERE SubQuestionID = @SubQuestionID", para, sql).ToList()[0];

                                para = new List<SqlParameter>();
                                para.Add(new SqlParameter("@QuestionID", sub_ques.QuestionID));
                                QUESTION ques = Utils.ExcuteObject<QUESTION>("SELECT * FROM QUESTIONS WHERE QuestionID = @QuestionID", para, sql).ToList()[0];

                                //int Type = ans.SUBQUESTION.QUESTION.Type ?? default(int);
                                int Type = ques.Type ?? default(int);
                                if (Type == (int)EXON.Common.QuizTypeEnum.FillAudio || Type == (int)EXON.Common.QuizTypeEnum.Fill)
                                {

                                    List<string> lstAnswerContent = new List<string>();

                                    RichTextBox rtfDapAn = new RichTextBox();
                                    rtfDapAn.Rtf = ans.AnswerContent;

                                    lstAnswerContent = TachDapAn(rtfDapAn.Text);
                                    string strTraLoi = ChuanHoa(ansSheetDetail.AnswerContent);

                                    foreach (string ansc in lstAnswerContent)
                                    {
                                        string strDapAn = ChuanHoa(ansc);
                                        if (CheckAnswerContent(strDapAn, strTraLoi))
                                        {
                                            //score = ans.SUBQUESTION.Score.Value;
                                            score = sub_ques.Score.Value;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    AD.Score = 0;
                                }

                            }
                        }


                        //AD.ChoosenAnswer = ansSheetDetail.ChoosenAnswer;
                        //AD.LastTime = ansSheetDetail.LastTime;
                        //AD.SubQuestionID = ansSheetDetail.SubQuestionID;
                        //AD.AnswerContent = ansSheetDetail.AnswerContent;
                        //AD.Status = Common.STATUS_CHANGED;
                        //db.Entry(AD).State = EntityState.Modified;
                        //db.SaveChanges();
                        //dbtr.Commit();

                        SqlCommand sqlcmd = new SqlCommand("update ANSWERSHEET_DETAILS set ChoosenAnswer=@choosenanswer , " +
                            "LastTime = @LastTime,SubQuestionID= @SubQuestionID ," +
                            " AnswerContent=@AnswerContent, @Status=Status," +
                            " Score=@Score where AnswerSheetDetailID=@id ;", sql);
                        sqlcmd.Parameters.Add("@id", AD.AnswerSheetDetailID);

                        sqlcmd.Parameters.Add("@ChoosenAnswer", ansSheetDetail.ChoosenAnswer);

                        sqlcmd.Parameters.Add("@LastTime", ansSheetDetail.LastTime);
                        sqlcmd.Parameters.Add("@SubQuestionID", ansSheetDetail.SubQuestionID);
                        sqlcmd.Parameters.Add("@AnswerContent", ansSheetDetail.AnswerContent ?? (object)DBNull.Value);
                        sqlcmd.Parameters.Add("@Status", Common.STATUS_CHANGED);
                        sqlcmd.Parameters.Add("@Score", score);
                        int row = 0;
                        while (row == 0)
                        {
                            row = sqlcmd.ExecuteNonQuery();

                        }
                        EC = new ErrorController(Common.STATUS_OK, "Thay đổi status thành STATUS_CHANGED: 4002");

                    }
                    else
                    {
                        ANSWERSHEET_DETAILS dbAnsSheetDetail = new ANSWERSHEET_DETAILS();
                        ANSWER ans = new ANSWER();
                        double score = 0;
                        if (ansSheetDetail.AnswerContent != null)
                        {
                            para = new List<SqlParameter>();
                            para.Add(new SqlParameter("@SubQuestionID", ansSheetDetail.SubQuestionID));
                            List<ANSWER> anstemp = Utils.ExcuteObject<ANSWER>("SELECT * FROM ANSWERS WHERE SubQuestionID = @SubQuestionID", para, sql).ToList();

                            //ans = db.ANSWERS.Where(x => x.SubQuestionID == ansSheetDetail.SubQuestionID).SingleOrDefault();
                            ans = anstemp.Count == 1 ? anstemp[0] : null;
                            if (ans != null)
                            {
                                para = new List<SqlParameter>();
                                para.Add(new SqlParameter("@SubQuestionID", ans.SubQuestionID));
                                SUBQUESTION sub_ques = Utils.ExcuteObject<SUBQUESTION>("SELECT * FROM SUBQUESTIONS WHERE SubQuestionID = @SubQuestionID", para, sql).ToList()[0];

                                para = new List<SqlParameter>();
                                para.Add(new SqlParameter("@QuestionID", sub_ques.QuestionID));
                                QUESTION ques = Utils.ExcuteObject<QUESTION>("SELECT * FROM QUESTIONS WHERE QuestionID = @QuestionID", para, sql).ToList()[0];

                                //int Type = ans.SUBQUESTION.QUESTION.Type ?? default(int);
                                int Type = ques.Type ?? default(int);
                                if (Type == (int)EXON.Common.QuizTypeEnum.FillAudio || Type == (int)EXON.Common.QuizTypeEnum.Fill)
                                {
                                    List<string> lstAnswerContent = new List<string>();
                                    RichTextBox rtfDapAn = new RichTextBox();
                                    rtfDapAn.Rtf = ans.AnswerContent;

                                    lstAnswerContent = TachDapAn(rtfDapAn.Text);
                                    string strTraLoi = ChuanHoa(ansSheetDetail.AnswerContent);
                                    foreach (string ansc in lstAnswerContent)
                                    {
                                        string strDapAn = ChuanHoa(ansc);
                                        if (CheckAnswerContent(strDapAn, strTraLoi))
                                        {
                                            //score = ans.SUBQUESTION.Score.Value;
                                            score = sub_ques.Score.Value;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    score = 0;
                                }
                            }
                        }
                        //dbAnsSheetDetail.AnswerSheetID = ansSheetDetail.AnswerSheetID;
                        //dbAnsSheetDetail.ChoosenAnswer = ansSheetDetail.ChoosenAnswer;
                        //if (ansSheetDetail.AnswerContent != null)
                        //{
                        //    dbAnsSheetDetail.AnswerContent = ansSheetDetail.AnswerContent;
                        //}
                        //dbAnsSheetDetail.LastTime = ansSheetDetail.LastTime;
                        //dbAnsSheetDetail.SubQuestionID = ansSheetDetail.SubQuestionID;
                        //dbAnsSheetDetail.Status = Common.STATUS_INITIALIZE;
                        //db.ANSWERSHEET_DETAILS.Add(dbAnsSheetDetail);
                        //db.SaveChanges();

                        SqlCommand sqlcmd = new SqlCommand("INSERT INTO  ANSWERSHEET_DETAILS(AnswerSheetID,SubQuestionID,Status,LastTime,ChoosenAnswer,AnswerContent,Score) VALUES " +
                            "(@AnswerSheetID,@SubQuestionID,@Status,@LastTime,@ChoosenAnswer,@AnswerContent,@Score)  ", sql);

                        sqlcmd.Parameters.Add("@AnswerSheetID", ansSheetDetail.AnswerSheetID);


                        sqlcmd.Parameters.Add("@ChoosenAnswer", ansSheetDetail.ChoosenAnswer);

                        sqlcmd.Parameters.Add("@LastTime", ansSheetDetail.LastTime);
                        sqlcmd.Parameters.Add("@SubQuestionID", ansSheetDetail.SubQuestionID);
                        sqlcmd.Parameters.Add("@AnswerContent", ansSheetDetail.AnswerContent ?? (object)DBNull.Value);
                        sqlcmd.Parameters.Add("@Status", Common.STATUS_CHANGED);
                        sqlcmd.Parameters.Add("@Score", score);
                        int row = 0;
                        while (row == 0)
                        {
                            row = sqlcmd.ExecuteNonQuery();

                        }

                        EC = new ErrorController(Common.STATUS_OK, "Thêm mới ANSWERSHEET_DETAIL với  STATUS_INITIALIZE: 4001");
                    }


                }
                catch (Exception ex)
                {

                    EC = new ErrorController(Common.STATUS_UNKOWN_EXCEPTION, string.Format(Common.STR_STATUS_UNKOWN_EXCEPTION, ex.Message));
                }
            }
        }

        private List<string> TachDapAn(string answerContent)
        {
            List<string> lstAnswerContent = new List<string>();
            string[] arrLstString;
            //if (answerContent.Contains("/"))
            //{
            //    arrLstString = answerContent.Split('/');
            //    lstAnswerContent = arrLstString.ToList();
            //}
            //else if (answerContent.Contains("\\"))
            //{
            //    arrLstString = answerContent.Split('\\');
            //    lstAnswerContent = arrLstString.ToList();
            //}
            //else
            //{
            //    lstAnswerContent.Add(answerContent);
            //}
            arrLstString = answerContent.Split('{', '}');
            lstAnswerContent = arrLstString.ToList();
            return lstAnswerContent;
        }

        private string ChuanHoa(string answerContent)
        {
            string s = answerContent.Trim();
            while (s.IndexOf(" ") >= 0)
            {
                s = s.Replace(" ", "");
                s = s.Replace("\n", "");
            }
            StringBuilder kq = new StringBuilder(s.Length);
            foreach (char c in s)
            {
                if (Char.IsLower(c))
                {
                    kq.Append(char.ToUpper(c));
                }
                else kq.Append(c);

            }
            return kq.ToString();
        }

        private bool CheckAnswerContent(string strDapAn, string strTraLoi)
        {
            //TODO
            if (strDapAn.Trim().ToUpper() == strTraLoi.Trim().ToUpper())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GetHastableAnswersheetDetailByAnswerSheetID(ContestantInformation CI, out Hashtable hstbAnswersheetDetailOut, out ErrorController EC, SqlConnection sql)
        {
            using (EXON_SYSTEM_TESTEntities DB = new EXON_SYSTEM_TESTEntities())
            {
                try
                {
                    List<SqlParameter> para = new List<SqlParameter>();
                    para.Add(new SqlParameter("@ContestantTestID", CI.ContestantTestID));
                    List<ANSWERSHEET> ANStemp = Utils.ExcuteObject<ANSWERSHEET>("SELECT * FROM ANSWERSHEETS WHERE ContestantTestID = @ContestantTestID", para, sql).ToList();

                    //ANSWERSHEET ANS = DB.ANSWERSHEETS.SingleOrDefault(x => x.ContestantTestID == CI.ContestantTestID);
                    ANSWERSHEET ANS = ANStemp.Count == 1 ? ANStemp[0] : null;
                    if (ANS != null)
                    {
                        Hashtable hstbAnswersheetDetail = new Hashtable();
                        List<AnswersheetDetail> lstAnswersheetDetail = new List<AnswersheetDetail>();

                        para = new List<SqlParameter>();
                        para.Add(new SqlParameter("@AnswerSheetID", CI.AnswerSheetID));
                        List<ANSWERSHEET_DETAILS> lstDBAnswersheetDetail = Utils.ExcuteObject<ANSWERSHEET_DETAILS>("SELECT * FROM ANSWERSHEET_DETAILS WHERE AnswerSheetID = @AnswerSheetID", para, sql).ToList();
                        //List<ANSWERSHEET_DETAILS> lstDBAnswersheetDetail = DB.ANSWERSHEET_DETAILS.Where(x => x.AnswerSheetID == CI.AnswerSheetID).ToList();
                        foreach (ANSWERSHEET_DETAILS AD in lstDBAnswersheetDetail)
                        {
                            if (AD.AnswerContent == null)
                            {
                                hstbAnswersheetDetail.Add(AD.SubQuestionID, AD.ChoosenAnswer);
                            }
                            else
                            {
                                hstbAnswersheetDetail.Add(AD.SubQuestionID, AD.AnswerContent);
                            }
                        }
                        hstbAnswersheetDetailOut = hstbAnswersheetDetail;
                        EC = new ErrorController(Common.STATUS_OK, "Nhận danh sách câu trả lời thành công");
                    }
                    else
                    {
                        EC = new ErrorController(Common.STATUS_ERROR, "Không thể nhận ANSWERSHEET");
                        hstbAnswersheetDetailOut = null;
                    }
                }
                catch (Exception ex)
                {
                    hstbAnswersheetDetailOut = null;
                    EC = new ErrorController(Common.STATUS_UNKOWN_EXCEPTION, string.Format(Common.STR_STATUS_UNKOWN_EXCEPTION, ex.Message));
                }
            }
        }
        public void GetListAnswerSheetDetail(ContestantInformation CI, out List<AnswersheetDetail> rListASD, SqlConnection sql)
        {
            AnswersheetDetail AHD;
            List<AnswersheetDetail> lstAD = new List<AnswersheetDetail>();
            using (EXON_SYSTEM_TESTEntities DB = new EXON_SYSTEM_TESTEntities())
            {
                List<SqlParameter> para = new List<SqlParameter>();
                para = new List<SqlParameter>();
                para.Add(new SqlParameter("@AnswerSheetID", CI.AnswerSheetID));
                List<ANSWERSHEET_DETAILS> lstAHD = Utils.ExcuteObject<ANSWERSHEET_DETAILS>("SELECT * FROM ANSWERSHEET_DETAILS WHERE AnswerSheetID = @AnswerSheetID", para, sql).ToList();

                //List<ANSWERSHEET_DETAILS> lstAHD = DB.ANSWERSHEET_DETAILS.Where(x => x.AnswerSheetID == CI.AnswerSheetID).ToList();
                foreach (ANSWERSHEET_DETAILS ahd in lstAHD)
                {
                    AHD = new AnswersheetDetail();
                    AHD.ChoosenAnswer = ahd.ChoosenAnswer ?? default(int);
                    AHD.SubQuestionID = ahd.SubQuestionID;
                    AHD.AnswerSheetID = ahd.AnswerSheetID;
                    AHD.AnswerContent = ahd.AnswerContent;
                    AHD.AnswerSheetDetailID = ahd.AnswerSheetDetailID;

                    lstAD.Add(AHD);
                }
                rListASD = lstAD;
            }
        }
    }
}
