using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces2
{
    class Notification : INotifications
    {
        private string _sender;
        private string _message;
        private string _date;

        public Notification()
        {
            this._sender = "Admin";
            this._message = "Yo, what's up!";
            this._date = " ";
        }

        public Notification(string sender, string message, string date)
        {
            this._sender = sender;
            this._message = message;
            this._date = date;
        }

        public void ShowNotification() => Console.WriteLine($"Message: {this._message} - Sender: {this._sender}");

        public string GetDate() => this._date;
    }
}
