using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp__Using_Events_and_delegatrtes__
{
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
        }

        public List<string> RecivedMsg = new List<string>();
        TextProcessor tp = TextProcessor.GetObject();

        private void ChatForm_Load(object sender, EventArgs e)
        {
            tp.SendButtonClick += Tp_SendButtonClick;
        }

        private void Tp_SendButtonClick(object sender, MessageArgs e)
        {
            DisplayBox.DataSource = null;
            RecivedMsg.Add("->" + e.UserText);
            DisplayBox.DataSource = RecivedMsg;

            //Method two :
            //TextRecive.Text = "->" + e.UserText + Environment.NewLine;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            tp.Initiator(SendTextBox.Text);
            SendTextBox.Text = "";
        }
    }
}
