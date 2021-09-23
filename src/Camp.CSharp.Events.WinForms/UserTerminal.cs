using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camp.CSharp.Events.WinForms
{
    public partial class UserTerminal : Form
    {
        private readonly string _userName;
        public event EventHandler<MessageEventArgs> MoneyWithdrawal;
        public event EventHandler<MessageEventArgs> MoneyReplenishment; 

        public UserTerminal(string userName)
        {
            _userName = userName;
            InitializeComponent();
            lbl_Welcome.Text = $"Welcome {userName}";
        }

        private void UserTerminal_Load(object sender, EventArgs e)
        {

        }

        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            var amount = numericUpDown1.Value;
            MoneyWithdrawal?.Invoke(this, new MessageEventArgs($"{_userName} withdraw {amount} UAH"));
        }

        private void btn_Replenishment_Click(object sender, EventArgs e)
        {
            var amount = numericUpDown1.Value;
            MoneyReplenishment?.Invoke(this, new MessageEventArgs($"{_userName} replenish on {amount} UAH"));
        }
    }
}
