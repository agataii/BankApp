using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Data
{
    public class Account
    {
        public delegate void AccountMessageHandler(string message);
        public event AccountMessageHandler NotifyEvent;

        private int _balance;
        private List<ListViewItem> _items= new List<ListViewItem>();

        public int Balance { get => _balance; }
        public List<ListViewItem> Items { get => _items;}

        public Account(int balance)
        {
            _balance = balance;
        }


        public bool TryTake(int value)
        {
            if (value <= _balance)
            {
                _balance -= value;

                NotifyEvent?.Invoke($"Со счёта было списано: {value}");

                return true;
            }
            else
            {
                NotifyEvent?.Invoke($"Недостаточно средств на балансе");

                return false;
            }
        }
    }
}
