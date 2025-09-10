
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHECKDB
{
    public partial class frmConfigApplication : MetroForm
    {
        public frmConfigApplication()
        {
       
            InitializeComponent();


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
		    string connectString = string.Format("Data Source={0},{1};Initial Catalog={2};User ID={3};Password={4};", txtServerName.Text,int.Parse(txtPort.Text), txtdbname.Text, txtUser.Text,txtPassword.Text);
            try
            {
                SQLHelper sql = new SQLHelper(connectString);
                if (sql.IsConnection)
                {
                    MessageBox.Show("Kết nối thành công");
                }
                else
                {
                    MessageBox.Show("Kết nối thất bại");

                }

            }
            catch (SqlException ex)
            {
                StringBuilder errorMessages = new StringBuilder();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show("Kết nối thất bại"+"\n"+ errorMessages.ToString());
             
            }
        }
	}
	public class SQLHelper
	{
		SqlConnection conn;

		public SQLHelper(string connectString)
		{

			conn = new SqlConnection(connectString);
		}
		public bool IsConnection
		{
			get
			{

				if (conn.State == ConnectionState.Closed)
				{
					conn.Open();
                    conn.Close();
				}
				return true;
			}
		}
	}
}
