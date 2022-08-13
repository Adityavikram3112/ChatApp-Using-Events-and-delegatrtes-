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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ChatHeadCreaterButoon_Click(object sender, EventArgs e)
        {
            ChatForm Chathead = new ChatForm();
            Chathead.Show();
        }
    }
}
