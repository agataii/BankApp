using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class TransferForm : Form
    {
        private Account _account;

        public TransferForm(Account account)
        {
            _account = account;
            _account.NotifyEvent += AccountNotifyEventHandler;

            InitializeComponent();

            _balanceValueText.Text = _account.Balance.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _inputValue.BackColor = Color.White;

            if (_account.TryTake(Convert.ToInt32(_inputValue.Text)))
            {
                ListViewItem listViewItem = new ListViewItem();

                listViewItem.Text = DateTime.Now.ToLongDateString();

                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();

                subItem.Text = _inputValue.Text;

                listViewItem.SubItems.Add(subItem);

                listViewItem.SubItems.Add(_transferTargetInput.Text);

                _transferListView.Items.Add(listViewItem);

                _account.Items.Add(listViewItem);

                _balanceValueText.Text = _account.Balance.ToString();
                _inputValue.Clear();
                _transferTargetInput.Clear();
            }
            else
            {
                _inputValue.BackColor = Color.Red;
            }
        }

        private void AccountNotifyEventHandler(string message)
        {
            _infoText.Text = message;
        }

        private void _backButton_Click(object sender, EventArgs e)
        {
            Hide();

            new MainMenuForm(_account).Show();
        }

        private void _inputValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListViewClear_Click(object sender, EventArgs e)
        {
            _transferListView.Items.Clear();
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {
            foreach (var item in _account.Items) 
            { 
                _transferListView.Items.Add(item);
            }
        }
    }
}
