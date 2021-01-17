using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using SalaryCalculator;


namespace SalaryCalculator.Parser
{
    class Site
    {
        private User user;
        private readonly string siteUrl;

        public Site(User user, string siteUrl)
        {
            this.user = user;
            this.siteUrl = siteUrl;
        }
    }
}
