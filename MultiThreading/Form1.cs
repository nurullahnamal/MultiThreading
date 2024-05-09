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
            if (listBox1.InvokeRequired)
            {
                listBox1.Invoke(new Action(() => Addlog(logMessage)));
                return;
            }

            logMessage = $"[{DateTime.Now:dd.MM.yyy HH.mm.ss:fff}] - {logMessage}";
            listBox1.Items.Add(logMessage);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;

        }

        private void btnListMailTasks_Click(object sender, EventArgs e)
        {
            var mailtask = new MailTask()
            {
                Second = 60
            };
            mailTaskBindingSource.Clear();
            mailTaskBindingSource.Add(mailtask);
        }

        private void mailTaskBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void mailTaskBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;

            if (mailTask == null) return;

            btnStartTask.Enabled = !mailTask.IsStarted;

            btnStopTask.Enabled = mailTask.IsStarted;
            btnRunTask.Enabled = mailTask.IsRunning && !mailTask.IsRunning;

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
    }
}
