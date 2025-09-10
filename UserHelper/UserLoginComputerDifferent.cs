﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserHelper
{
    public class UserLoginComputerDifferent
    {
        //Hai code
        public string ContestantCode { get; set; }
        public string ContestantName { get; set; }
        public string ContestShift { get; set; }
        public string RoomTest { get; set; }
        public string ContestSubject { get; set; }
        public int TimeChange { get; set; }

        public string JsonDescription { get; set; }

        public UserLoginComputerDifferent()
        {
        }

        public UserLoginComputerDifferent(string contestantCode, string contestantName, string contestShift, string roomTest, string contestSubject, int timeChange)
        {
            ContestantCode = contestantCode;
            ContestantName = contestantName;
            ContestShift = contestShift;
            RoomTest = roomTest;
            ContestSubject = contestSubject;
            TimeChange = timeChange;
        }
    }
}
