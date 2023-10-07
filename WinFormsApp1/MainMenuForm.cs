using System.Security.Principal;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class MainMenuForm : Form
    {
        private Account _account;

        public MainMenuForm(Account account)
        {
            _account = account;

            InitializeComponent();

            _balanceValueText.Text = _account.Balance.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();

            TransferForm transferForm = new TransferForm(_account);
            transferForm.Show();
        }
    }
}