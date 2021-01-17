using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculator.Parser
{
    class User
    {
        private string companyID;
        private string userID;
        private string password;
        private double rate;

      

        public User(string companyId, string userId, string password)
        {
            companyID = companyId;
            userID = userId;
            this.password = password;
        }

        public string CompanyId
        {
            get => companyID;
            set => companyID = value;
        }

        public string UserId
        {
            get => userID;
            set => userID = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }
        public double Rate
        {
            get => rate;
            set => rate = value;
        }
    }
}
