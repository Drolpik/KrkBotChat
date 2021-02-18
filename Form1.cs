using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class MainForm : Form
    {
        private bool statusWindowAttr = true;
        private bool statusWindowMpk = true;
        private bool statusWindowMain = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAttractions_Click(object sender, EventArgs e)
        {
            if(statusWindowAttr)
            {
                statusWindowAttr = false;
                ChatForm chatFormAttractions = new ChatForm();
                await runNewWindowAsync(chatFormAttractions, btnAttractions);
                statusWindowAttr = true;
            }
        }

        private async void btnMpk_Click(object sender, EventArgs e)
        {
            if (statusWindowMpk)
            {
                statusWindowMpk = false;
                ChatForm chatFormMpk = new ChatForm();
                await runNewWindowAsync(chatFormMpk, btnMpk);
                statusWindowMpk = true;
            }
        }

        private async void btnMain_Click(object sender, EventArgs e)
        {
            if (statusWindowMain)
            {
                statusWindowMain = false;
                ChatForm chatFormMain = new ChatForm();
                await runNewWindowAsync(chatFormMain, btnMain);
                statusWindowMain = true;
            }
        }

        private async Task runNewWindowAsync(ChatForm chatForm, Button selectedBtn)
        {
            await Task.Run(() =>
            {
                chatForm.SetNewChat = selectedBtn.Text;
                chatForm.ShowDialog();
            });
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
