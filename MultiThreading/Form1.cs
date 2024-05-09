using MultiThreading.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LogManager.Default.OnLogAdded += (s, e) => { Addlog(e); };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Addlog(string logMessage)
        {
            if (lbLogs.InvokeRequired)
            {
                lbLogs.Invoke(new Action(() => Addlog(logMessage)));
                return;
            }

            logMessage = $"[{DateTime.Now:dd.MM.yyy HH.mm.ss:fff}] - {logMessage}";
            lbLogs.Items.Add(logMessage);
            lbLogs.SelectedIndex = lbLogs.Items.Count - 1;

        }

        private void btnListMailTasks_Click(object sender, EventArgs e)
        {
            var smtpMailTaks= new MailTask(MailProviderType.Smtp)
            {
                Second = 10
            };
            var googleMailTaks = new MailTask(MailProviderType.GoogleMail)
            {
                Second = 60
            };

            mailTaskBindingSource.Clear();
            mailTaskBindingSource.Add(smtpMailTaks);
            mailTaskBindingSource.Add(googleMailTaks);

        }

        private void mailTaskBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void mailTaskBindingSource_CurrentItemChanged_1(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;

            if (mailTask == null)
                return;

            btnStartTask.Enabled = !mailTask.IsStarted;

            btnStopTask.Enabled = mailTask.IsStarted;
            btnRunTask.Enabled = mailTask.IsStarted && !mailTask.IsRunning;
        }



        private void btnStartTask_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
            mailTask.Start();
        }

        private void btnStopTask_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
            mailTask.Stop();

        }

        private async void btnRunTask_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;

            var numberOfMails = (int)numericMailCount.Value;



           
            await mailTask.Run(50);

        }
































        private void lbLogs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
