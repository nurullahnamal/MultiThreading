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
        private DateTime? nExtRunning;

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
        public DateTime? NExtRunning
        {
            get => nExtRunning;
            set
            {
                nExtRunning = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NExtRunning)));
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        public async Task Run()
        {
            while (IsStarted)
            {
                IsStarted = true;
                IsRunning = false;

                NExtRunning = DateTime.Now.AddSeconds(Second);

                await Task.Delay(Second * 1000);
            }
        }

        public void Start()
        {
            IsStarted = true;
            NExtRunning = DateTime.Now.AddSeconds(Second);
        }

        public void Stop()
        {
            IsStarted = false;
            NExtRunning = null;
        }
    }
}
