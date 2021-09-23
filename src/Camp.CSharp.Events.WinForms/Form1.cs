using System;
using System.Windows.Forms;

namespace Camp.CSharp.Events.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userName = txt_UserName.Text;
            txt_UserName.Text = string.Empty;
            var userTerminal = new UserTerminal(userName);
            userTerminal.MoneyWithdrawal += AddTrace;
            userTerminal.MoneyReplenishment += AddTrace;
            userTerminal.Show();
        }

        private void AddTrace(object sender, MessageEventArgs args)
        {
            //var message = $"{txt_Trace.Text}\n{args.Message}";
            listView1.Items.Add(args.Message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
