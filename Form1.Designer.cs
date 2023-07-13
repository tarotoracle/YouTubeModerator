
namespace ChatScan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmGeneral = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtStreamURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQueue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAfter = new System.Windows.Forms.Label();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.lblBefore = new System.Windows.Forms.Label();
            this.txtBefore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRTF = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.lblQuestionTimeStamp = new System.Windows.Forms.Label();
            this.lblStreamTime = new System.Windows.Forms.Label();
            this.tmTimeStamper = new System.Windows.Forms.Timer(this.components);
            this.lstChatters = new System.Windows.Forms.ListBox();
            this.ListBoxChatText = new System.Windows.Forms.ListBox();
            this.lstQueue = new System.Windows.Forms.ListBox();
            this.rtfChatText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmGeneral
            // 
            this.tmGeneral.Interval = 5000;
            this.tmGeneral.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus1,
            this.lblStatus2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1007);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 20, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1938, 32);
            this.statusStrip1.TabIndex = 14;
            // 
            // lblStatus1
            // 
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(328, 25);
            this.lblStatus1.Text = "Fill in the YouTube URL to start scanning";
            this.lblStatus1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus2
            // 
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(0, 25);
            // 
            // txtStreamURL
            // 
            this.txtStreamURL.Location = new System.Drawing.Point(230, 22);
            this.txtStreamURL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStreamURL.Name = "txtStreamURL";
            this.txtStreamURL.Size = new System.Drawing.Size(212, 31);
            this.txtStreamURL.TabIndex = 11;
            this.txtStreamURL.TextChanged += new System.EventHandler(this.txtStreamURL_TextChanged);
            this.txtStreamURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStreamURL_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "YouTube Livestream URL:";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(450, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start Scanning";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblQueue);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblAfter);
            this.panel2.Controls.Add(this.txtAfter);
            this.panel2.Controls.Add(this.lblBefore);
            this.panel2.Controls.Add(this.txtBefore);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblRTF);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.lblQuestionTimeStamp);
            this.panel2.Controls.Add(this.lblStreamTime);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtStreamURL);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1938, 146);
            this.panel2.TabIndex = 12;
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQueue.ForeColor = System.Drawing.Color.Red;
            this.lblQueue.Location = new System.Drawing.Point(1159, 110);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(84, 28);
            this.lblQueue.TabIndex = 28;
            this.lblQueue.Text = "Copied!";
            this.lblQueue.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "CHAT TEXT, Press Spacebar to Move -->";
            // 
            // lblAfter
            // 
            this.lblAfter.AutoSize = true;
            this.lblAfter.Location = new System.Drawing.Point(674, 59);
            this.lblAfter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(147, 25);
            this.lblAfter.TabIndex = 32;
            this.lblAfter.Text = "After Queue Text:";
            // 
            // txtAfter
            // 
            this.txtAfter.Location = new System.Drawing.Point(828, 56);
            this.txtAfter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.Size = new System.Drawing.Size(970, 31);
            this.txtAfter.TabIndex = 31;
            this.txtAfter.TextChanged += new System.EventHandler(this.txtAfter_TextChanged);
            // 
            // lblBefore
            // 
            this.lblBefore.AutoSize = true;
            this.lblBefore.Location = new System.Drawing.Point(661, 18);
            this.lblBefore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.Size = new System.Drawing.Size(159, 25);
            this.lblBefore.TabIndex = 30;
            this.lblBefore.Text = "Before Queue Text:";
            // 
            // txtBefore
            // 
            this.txtBefore.Location = new System.Drawing.Point(828, 15);
            this.txtBefore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBefore.Name = "txtBefore";
            this.txtBefore.Size = new System.Drawing.Size(970, 31);
            this.txtBefore.TabIndex = 29;
            this.txtBefore.TextChanged += new System.EventHandler(this.txtBefore_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(823, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "QUEUE, Right Click to Copy to Clipboard";
            // 
            // lblRTF
            // 
            this.lblRTF.AutoSize = true;
            this.lblRTF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRTF.ForeColor = System.Drawing.Color.Red;
            this.lblRTF.Location = new System.Drawing.Point(1474, 110);
            this.lblRTF.Name = "lblRTF";
            this.lblRTF.Size = new System.Drawing.Size(200, 28);
            this.lblRTF.TabIndex = 4;
            this.lblRTF.Text = "Copied to Clipboard";
            this.lblRTF.Visible = false;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(1787, 73);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(91, 34);
            this.btnReload.TabIndex = 26;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Visible = false;
            // 
            // lblQuestionTimeStamp
            // 
            this.lblQuestionTimeStamp.AutoSize = true;
            this.lblQuestionTimeStamp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuestionTimeStamp.ForeColor = System.Drawing.Color.Maroon;
            this.lblQuestionTimeStamp.Location = new System.Drawing.Point(237, 64);
            this.lblQuestionTimeStamp.Name = "lblQuestionTimeStamp";
            this.lblQuestionTimeStamp.Size = new System.Drawing.Size(184, 28);
            this.lblQuestionTimeStamp.TabIndex = 24;
            this.lblQuestionTimeStamp.Text = "Questions go here";
            // 
            // lblStreamTime
            // 
            this.lblStreamTime.AutoSize = true;
            this.lblStreamTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStreamTime.Location = new System.Drawing.Point(24, 64);
            this.lblStreamTime.Name = "lblStreamTime";
            this.lblStreamTime.Size = new System.Drawing.Size(201, 30);
            this.lblStreamTime.TabIndex = 22;
            this.lblStreamTime.Text = "Running: 00:00:00";
            // 
            // tmTimeStamper
            // 
            this.tmTimeStamper.Interval = 1000;
            this.tmTimeStamper.Tick += new System.EventHandler(this.tmTimeStamper_Tick);
            // 
            // lstChatters
            // 
            this.lstChatters.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstChatters.FormattingEnabled = true;
            this.lstChatters.ItemHeight = 25;
            this.lstChatters.Location = new System.Drawing.Point(0, 146);
            this.lstChatters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstChatters.Name = "lstChatters";
            this.lstChatters.Size = new System.Drawing.Size(233, 861);
            this.lstChatters.TabIndex = 0;
            this.lstChatters.SelectedIndexChanged += new System.EventHandler(this.lstChatters_SelectedIndexChanged);
            // 
            // ListBoxChatText
            // 
            this.ListBoxChatText.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListBoxChatText.FormattingEnabled = true;
            this.ListBoxChatText.ItemHeight = 25;
            this.ListBoxChatText.Location = new System.Drawing.Point(233, 146);
            this.ListBoxChatText.Name = "ListBoxChatText";
            this.ListBoxChatText.Size = new System.Drawing.Size(572, 861);
            this.ListBoxChatText.TabIndex = 19;
            this.ListBoxChatText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBoxChatText_KeyDown);
            // 
            // lstQueue
            // 
            this.lstQueue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstQueue.FormattingEnabled = true;
            this.lstQueue.ItemHeight = 25;
            this.lstQueue.Location = new System.Drawing.Point(805, 146);
            this.lstQueue.Name = "lstQueue";
            this.lstQueue.Size = new System.Drawing.Size(454, 861);
            this.lstQueue.TabIndex = 20;
            this.lstQueue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstQueue_KeyDown);
            this.lstQueue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstQueue_MouseDown);
            // 
            // rtfChatText
            // 
            this.rtfChatText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfChatText.Location = new System.Drawing.Point(1259, 146);
            this.rtfChatText.Name = "rtfChatText";
            this.rtfChatText.Size = new System.Drawing.Size(679, 861);
            this.rtfChatText.TabIndex = 21;
            this.rtfChatText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "CHATTERS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1938, 1039);
            this.Controls.Add(this.rtfChatText);
            this.Controls.Add(this.lstQueue);
            this.Controls.Add(this.ListBoxChatText);
            this.Controls.Add(this.lstChatters);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTube Moderator v1.0 - by TarotOracle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmGeneral;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus2;
        private System.Windows.Forms.TextBox txtStreamURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer tmTimeStamper;
        private System.Windows.Forms.Label lblStreamTime;
        private System.Windows.Forms.Label lblQuestionTimeStamp;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRTF;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label lblAfter;
        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.Label lblBefore;
        private System.Windows.Forms.TextBox txtBefore;
        private System.Windows.Forms.ListBox lstChatters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ListBoxChatText;
        private System.Windows.Forms.ListBox lstQueue;
        private System.Windows.Forms.RichTextBox rtfChatText;
        private System.Windows.Forms.Label label1;
    }
}

