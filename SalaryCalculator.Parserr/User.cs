using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculator.Parser
{
    public class User
    {
        private string _companyId;
        private string _userId;
        private string _password;
        private string _site;
        private double _rate;

        public User(string companyId, string userId, string password,string site,double rate)
        {
            _companyId = companyId;
            _userId = userId;
            _password = password;
            if (site == "TimeWatch")
            {
                _site= "https://checkin.timewatch.co.il/punch/punch.php";
            }

            _rate = rate;
        }

        public string Site
        {
            get => _site;
        }

        public string CompanyId
        {
            get => _companyId;
        }

        public string UserId
        {
            get => _userId;
        }

        public string Password
        {
            get => _password;
        }

        public double Rate
        {
            get => _rate;
        }
    }
}
