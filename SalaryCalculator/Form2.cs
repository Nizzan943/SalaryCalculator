using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryCalculator.Parser;

namespace SalaryCalculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Calculate(int i)
        {
            double pow = Math.Pow(i, i);
        }

        public void DoWork(IProgress<int> progress)
        {
            // This method is executed in the context of
            // another thread (different than the main UI thread),
            // so use only thread-safe code
            for (int j = 0; j < 100000; j++)
            {
                Calculate(j);

                // Use progress to notify UI thread that progress has
                // changed
                if (progress != null)
                    progress.Report((j + 1) * 100 / 100000);
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;

            var progress = new Progress<int>(v =>
            {
                // This lambda is executed in context of UI thread,
                // so it can safely update form controls
                progressBar1.Value = v;
            });

            // Run operation in another thread
            await Task.Run(() => DoWork(progress));
            label3.Visible = true;

            var user = new User(boxCompanyID.Text, boxUserID.Text, boxPassword.Text,
                boxSite.Text, double.Parse(boxRate.Text));
            var session = new Session(user);
            session.GetInfo(user);
            boxTotalTime.Text = session.strTotalTimeHH;
            boxRegularTime.Text = session.strRegularTimeHH;
            boxExtraTime.Text = session.strExtraTimeHH;
            boxTotalPayment.Text = session.totalPayment.ToString();

        }

        private void user1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] userInfo = null;
            string fileName = "User.txt";
            string filePath = $@"{AppDomain.CurrentDomain.BaseDirectory}\{fileName}";
            userInfo = File.ReadAllLines(filePath);
            boxCompanyID.Text = userInfo[0].Split(':')[1];
            boxUserID.Text = userInfo[1].Split(':')[1];
            boxPassword.Text = userInfo[2].Split(':')[1];
            boxSite.Text = userInfo[3].Split(':')[1];
            boxRate.Text = userInfo[4].Split(':')[1];
        }

        private void user1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StringBuilder userInfo = new StringBuilder();
            userInfo.AppendLine($@"Company ID:{boxCompanyID.Text}");
            userInfo.AppendLine($@"User ID:{boxUserID.Text}");
            userInfo.AppendLine($@"Password:{boxPassword.Text}");
            userInfo.AppendLine($@"Site:{boxSite.Text}");
            userInfo.AppendLine($@"Rate:{boxRate.Text}");

            string fileName = "User.txt";
            string filePath = $@"{AppDomain.CurrentDomain.BaseDirectory}\{fileName}";
            try
            {
                File.WriteAllText(filePath, userInfo.ToString());

            }
            catch (Exception exception)
            {
                Console.WriteLine("Error saving user profile");
                throw;
            }
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuickSave_Click(object sender, EventArgs e)
        {
            StringBuilder userInfo = new StringBuilder();
            userInfo.AppendLine($@"Company ID:{boxCompanyID.Text}");
            userInfo.AppendLine($@"User ID:{boxUserID.Text}");
            userInfo.AppendLine($@"Password:{boxPassword.Text}");
            userInfo.AppendLine($@"Site:{boxSite.Text}");
            userInfo.AppendLine($@"Rate:{boxRate.Text}");

            string fileName = "User.txt";
            string filePath = $@"{AppDomain.CurrentDomain.BaseDirectory}\{fileName}";
            try
            {
                File.WriteAllText(filePath, userInfo.ToString());

            }
            catch (Exception exception)
            {
                Console.WriteLine("Error saving user profile");
                throw;
            }
        }

        private void btnQuickLoad_Click(object sender, EventArgs e)
        {
            string[] userInfo = null;
            string fileName = "User.txt";
            string filePath = $@"{AppDomain.CurrentDomain.BaseDirectory}\{fileName}";
            userInfo = File.ReadAllLines(filePath);
            boxCompanyID.Text = userInfo[0].Split(':')[1];
            boxUserID.Text = userInfo[1].Split(':')[1];
            boxPassword.Text = userInfo[2].Split(':')[1];
            boxSite.Text = userInfo[3].Split(':')[1];
            boxRate.Text = userInfo[4].Split(':')[1];
        }


    }
}

