using System;
using System.Net.Http;
using System.Windows.Forms;
using System.Diagnostics;

namespace Chat
{
    public partial class ChatForm : Form
    {
        private readonly string chatWith = "Czat z ";
        private string currentNameChat;
        static readonly HttpClient client = new HttpClient();

        private readonly string linkToAttrAll = "http://krakow.nosiu.pl/index.php?all";
        private readonly string linkToAttrRandom = "http://krakow.nosiu.pl/index.php?random";
        private readonly string linkToAttrMsg = "http://krakow.nosiu.pl/index.php?message=";
        private readonly string linkToMpk = "http://krakow.nosiu.pl/index.php?mpk=";
        private readonly string linkToMain = "http://krakow.nosiu.pl/index.php?info=";

        public ChatForm()
        {
            InitializeComponent();
        }

        public string SetNewChat 
        {
            set
            {
                currentNameChat = value;
                chatName.Text = chatWith + currentNameChat;
            }
        }

        private void btnChatExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSend_Click(object sender, EventArgs e)
        {
            string currentMsg = textboxMsg.Text;
            if (!string.IsNullOrWhiteSpace(currentMsg))
            {
                listboxChat.Items.Add("Ty:      " + currentMsg);
                ScrollToBottom();
                checkMsg(currentMsg);
                currentMsg = string.Empty;
            }
        }

        private void checkMsg(string msg)
        {
            if (chatName.Text == "Czat z Kraków Atrakcje")
            {
                if (msg == "!help")
                {
                    listboxChat.Items.Add("BOT:     Oto twoje komendy: ");
                    listboxChat.Items.Add("!help - właśnie to czytasz");
                    listboxChat.Items.Add("!atrakcje - pokazuje wszystkie atrakcje");
                    listboxChat.Items.Add("!losuj - losuje atrakcję");
                    listboxChat.Items.Add("Wpisz nazwę atrakcji bądź jej część, aby uzyskać więcej informacji");
                    ScrollToBottom();
                    textboxMsg.Text = string.Empty;
                } 
                else if  (msg == "!atrakcje")
                    checkInDB(linkToAttrAll);
                else if(msg == "!losuj")
                    checkInDB(linkToAttrRandom);
                else
                    checkInDB(linkToAttrMsg + msg);
            }
            if (chatName.Text == "Czat z Kraków MPK")
            {
                if(msg == "!help")
                {
                    listboxChat.Items.Add("BOT:     Wpisz numer interesującej linii, aby otrzymać link");
                    textboxMsg.Text = string.Empty;
                }
                else
                    checkOneInDB(linkToMpk, msg);
            }
            if (chatName.Text == "Czat z Kraków Ogólny")
            {
                if(msg == "!help")
                {
                    listboxChat.Items.Add("BOT:     Wpisz: historia, położenie, populacja,");
                    listboxChat.Items.Add(" urząd miejski, prezydent, aby otrzymać informację");
                    textboxMsg.Text = string.Empty;
                }
                else
                    checkOneInDB(linkToMain, msg);
            }
        }

        private async void checkOneInDB(string linkTo, string msg = null)
        {
            try
            {
                string link;
                if (msg == null)
                    link = linkTo;
                else
                    link = linkTo + msg;

                HttpResponseMessage response = await client.GetAsync(link);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                string[] subs = responseBody.Split('#');

                foreach (var sub in subs)
                {
                    listboxChat.Items.Add(sub);
                    ScrollToBottom();
                }

                ScrollToBottom();
                listboxChat.SelectedIndexChanged += ListBoxSelectedIndexChanged;

                textboxMsg.Text = string.Empty;
            }
            catch (HttpRequestException e)
            {
                Debug.WriteLine("\nException Caught!");
                Debug.WriteLine("Message :{0} ", e.Message);
            }
        }

        private async void checkInDB(string linkTo, string msg = null)
        {
            try
            {
                string link;
                if(msg == null)
                    link = linkTo;
                else
                    link = linkTo + msg;

                HttpResponseMessage response = await client.GetAsync(link);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                string[] subs = responseBody.Split('#');

                listboxChat.Items.Add("BOT:     Znalazłem coś takiego:");
                listboxChat.Items.Add("");

                foreach (var sub in subs)
                {
                    listboxChat.Items.Add(sub);
                    ScrollToBottom();
                }

                textboxMsg.Text = string.Empty;
            }
            catch (HttpRequestException e)
            {
                Debug.WriteLine("\nException Caught!");
                Debug.WriteLine("Message :{0} ", e.Message);
            }
        }

        private void ScrollToBottom()
        {
            int visibleItems = listboxChat.ClientSize.Height / listboxChat.ItemHeight;
            listboxChat.TopIndex = Math.Max(listboxChat.Items.Count - visibleItems + 1, 0);
        }

        private void textboxMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
                // disable the beep sound
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void ListBoxSelectedIndexChanged(object pSender, EventArgs pArgs) {
            string link = (string)listboxChat.SelectedItem;
            if(link.Substring(0,4)=="http")
                Process.Start(link);
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            listboxChat.Items.Add("BOT:     Witaj na czacie! Aby mógł Ci pomóc wpisz !help" +
                " i wybierz interesujący dla Ciebie temat.");
        }
    }
}
