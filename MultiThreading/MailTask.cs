using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class MailTask : INotifyPropertyChanged
    {
        private bool isRunning;
        private bool isStarted;
        private DateTime? nextRunning;

        public Guid TaskId { get; set; } = Guid.NewGuid();
        public bool IsRunning
        {
            get => isRunning;
            set
            {
                isRunning = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsRunning)));
            }
        }

        public bool IsStarted
        {
            get => isStarted;
            set
            {
                isStarted = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(isStarted)));
            }
        }
        public int Second { get; set; } = 60;
        public DateTime? NextRunning
        {
            get => nextRunning;
            set
            {
                nextRunning = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NextRunning)));
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        public async Task Run()
        {

            var manager = new MailManager();

            while (IsStarted)
            {
                isRunning = true;

                var smtpMails = FakeDataCreator.GetMails(100);
                manager.AddMails(smtpMails);
                await manager.SendAllMails();

                IsRunning = false;

                NextRunning = DateTime.Now.AddSeconds(Second);

                await Task.Delay(Second * 1000);
            }
        }

        public void Start()
        {
            IsStarted = true;
            NextRunning = DateTime.Now.AddSeconds(Second);
        }

        public void Stop()
        {
            IsStarted = false;
            NextRunning = null;
        }
    }
}
