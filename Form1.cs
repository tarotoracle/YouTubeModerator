using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows;
using System.Linq;

namespace ChatScan
{
    public partial class Form1 : Form
    {
        List<String> lstChatPeople = new List<string>();
        List<String> lstChatText = new List<string>();
        Stopwatch stopWatch = new Stopwatch();
        int iStartupTicks = 0;
        String sQuestion = String.Empty;
        String sQueue = String.Empty;
        const String Title = "YouTube Moderator v1 - by TarotOracle";
        public Form1()
        {
            InitializeComponent();
        }

        private void ParseChatMessages(String result)
        {
            int iJSONStart = 0;
            int iJSONEnd = -1;
            String sFinalText = String.Empty;

            try
            {
                iJSONStart = result.IndexOf("window[\"ytInitialData\"] = ");
                iJSONEnd = result.IndexOf("</script>", iJSONStart);
                sFinalText = result.Substring(iJSONStart, result.Length - iJSONStart - 163);
                // sFinalText = sFinalText.Replace("</script><yt-live-chat-app><ytd-live-chat-config></ytd-live-chat-config><yt-native-buyflow-launcher></yt-native-buyflow-launcher></yt-live-chat-app></body></html>", "");
                sFinalText = sFinalText.Replace("window[\"ytInitialData\"] = ", "");
                // d2(sFinalText);
                var jsFile = JObject.Parse(sFinalText); //  File.ReadAllText(@"c:\temp\chat.json"));
                foreach (JToken j in (JArray)jsFile["contents"]["liveChatRenderer"]["actions"])
                {
                    if (j.SelectToken("addChatItemAction") != null)
                    {
                        // STANDARD CHAT MESSAGES
                        try
                        {
                            String chatText = String.Empty;
                            String chatter = j["addChatItemAction"]["item"]["liveChatTextMessageRenderer"]["authorName"]["simpleText"].ToString();
                            foreach (JToken k in (JArray)j["addChatItemAction"]["item"]["liveChatTextMessageRenderer"]["message"]["runs"])
                                chatText += k["text"].ToString();
                            if (!lstChatPeople.Contains(chatter) && !chatter.Contains("StreamElements"))
                            {
                                lstChatPeople.Add(chatter);
                                lstChatPeople.Sort();
                                lstChatters.Items.Clear();
                                lstChatters.BeginUpdate();
                                foreach (String u in lstChatPeople)
                                    lstChatters.Items.Add(u);
                                lstChatters.EndUpdate();
                            }
                            lstChatText.Add(chatter + " - " + chatText);
                        }
                        catch { };
                    }
                }
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Title;
            tmTimeStamper.Start();
            try
            {
                txtBefore.Text = File.ReadAllText(Application.StartupPath + "Before.txt");
                txtAfter.Text = File.ReadAllText(Application.StartupPath + "After.txt");
            }
            catch (Exception)
            {
            }
        }

        private void LoadYouTubeChat(String sURL)
        {
            try
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create("https://www.youtube.com/live_chat?is_popout=1&v=" + sURL);
                myRequest.Method = "GET";
                myRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.150 Safari/537.36";
                WebResponse myResponse = myRequest.GetResponse();
                StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                string result = sr.ReadToEnd();
                sr.Close();
                myResponse.Close();
                ParseChatMessages(result);
            }
            catch (Exception ec)
            {
                lblStatus1.Text = "Could not connect to URL/chat. " + ec.Message;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // https://youtube.com/live/FEoFybQJ8RY?feature=share
                int iSlash = txtStreamURL.Text.LastIndexOf("?v=");
                if (iSlash > -1)
                {
                    LoadYouTubeChat(txtStreamURL.Text.Substring(iSlash, txtStreamURL.Text.Length - iSlash).Trim().Replace("?v=", ""));
                }
                else
                    LoadYouTubeChat(txtStreamURL.Text.Trim());
            }
            catch (Exception ex)
            {
                lblStatus1.Text = "URL not found, please only include the last letters/digits";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "STOP")
            {
                tmGeneral.Enabled = false;
                button1.Text = "Start scanning";
            }
            else
            {
                lstChatText.Clear();
                ListBoxChatText.Items.Clear();
                lstChatters.Items.Clear();
                tmGeneral.Enabled = true;
                button1.Text = "STOP";
            }
            timer1_Tick(null, null);
        }

        private void txtStreamURL_TextChanged(object sender, EventArgs e)
        {
            lstChatText.Clear();
            ListBoxChatText.Items.Clear();
            lstChatters.Items.Clear();
            tmGeneral.Enabled = false;
            button1.Text = "Start scanning";
            button1.Enabled = true;
        }

        private void lstChatters_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ay = String.Empty;
            int iy = -1;

            ListBoxChatText.Items.Clear();
            foreach (String u in lstChatText)
                if (u.Contains(lstChatters.GetItemText(lstChatters.SelectedItem) + " - "))
                {
                    iy = u.IndexOf(" - ");
                    if (iy > 0)
                    {
                        ay = u.Substring(iy, u.Length - iy).Replace(" - ", "");
                        if (!ListBoxChatText.Items.Contains(ay))
                            ListBoxChatText.Items.Add(ay);
                    }
                }
        }

        private void txtStreamURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstChatText.Clear();
                ListBoxChatText.Items.Clear();
                lstChatters.Items.Clear();
                tmGeneral.Enabled = true;
                button1.Text = "STOP";
                timer1_Tick(null, null);
                e.Handled = true;
            }
        }

        private void tmTimeStamper_Tick(object sender, EventArgs e)
        {
            iStartupTicks++;
            if (iStartupTicks == 5)
                stopWatch.Start();
            if (iStartupTicks > 5)
            {
                TimeSpan ts = stopWatch.Elapsed;
                lblStreamTime.Text = String.Format("Running: {0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            }
        }

        private void AppendTS()
        {
            TimeSpan ts = stopWatch.Elapsed;
            lblQuestionTimeStamp.Text = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds) + " - " + sQuestion;
        }

        private void UpdateQueue()
        {
            sQueue = "";

            foreach (var item in lstQueue.Items)
            {
                String u = item.ToString();
                int iy = u.IndexOf(" - ");
                if (iy > 0)
                    sQueue += u.Substring(0, iy).Replace(" - ", "") + ", ";
            }
            sQueue = sQueue.Trim().Substring(0, sQueue.Length - 2);  // remove last comma
            rtfChatText.Text = "Current queue (" + lstQueue.Items.Count + "): " + sQueue;
            lblQueue.Visible = false;
            lblRTF.Visible = true;
            if (txtBefore.Text.Length > 0)
                Clipboard.SetText(txtBefore.Text + " | " + rtfChatText.Text);
            else
                Clipboard.SetText(rtfChatText.Text);

            if (txtAfter.Text.Length > 0)
                Clipboard.SetText(Clipboard.GetText() + " | " + txtAfter.Text);
        }

        private void lstQueue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                lstQueue.Items.RemoveAt(lstQueue.SelectedIndex);
                lstQueue.SelectedIndex = 0;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            UpdateQueue();
        }

        private void ListBoxChatText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                AppendTS();
                lstQueue.Items.Add(lstChatters.GetItemText(lstChatters.SelectedItem) + " - " + ListBoxChatText.GetItemText(ListBoxChatText.SelectedItem.ToString()));
                UpdateQueue();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void ListBoxSaved_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                AppendTS();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void lstQueue_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                UpdateQueue();
            }
            else if (e.Button == MouseButtons.Right)
            {
                Clipboard.SetText(lstQueue.GetItemText(lstQueue.SelectedItem.ToString()));
                lblQueue.Visible = true;
                lblRTF.Visible = false;
            }
        }

        private void txtBefore_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "Before.txt", txtBefore.Text);
            Clipboard.Clear();
            lblRTF.Visible = false;
        }

        private void txtAfter_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "After.txt", txtAfter.Text);
            Clipboard.Clear();
            lblRTF.Visible = false;
            lblQueue.Visible = false;
        }
    }
}
