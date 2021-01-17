using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculator.Parser
{
    class Session
    {
        private User user;
        private Site site;
        private double normalHour = 0;
        private double extraHour = 0;
        private double normalPayment = 0;
        private double extraPayment = 0;
        private double rate = 0;
        private double totalTime = 0;
        private string parse = null;
        double totalPayment = 0;

        public Session(User user, Site site)
        {
            this.user = user;
            this.site = site;
        }

        public double NormalHour
        {
            get => normalHour;
            set => normalHour = value;
        }

        public double ExtraHour
        {
            get => extraHour;
            set => extraHour = value;
        }

        public double NormalPayment
        {
            get => normalPayment;
            set => normalPayment = value;
        }

        public double ExtraPayment
        {
            get => extraPayment;
            set => extraPayment = value;
        }

        public double Rate
        {
            get => rate;
            set => rate = value;
        }

        public double TotalTime
        {
            get => totalTime;
            set => totalTime = value;
        }

        public string Parse
        {
            get => parse;
            set => parse = value;
        }

        public double TotalPayment
        {
            get => totalPayment;
            set => totalPayment = value;
        }
    }
}
