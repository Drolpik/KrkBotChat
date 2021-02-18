
namespace Chat
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.chatName = new System.Windows.Forms.Label();
            this.btnChatExit = new System.Windows.Forms.Button();
            this.panelMsg = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.textboxMsg = new System.Windows.Forms.TextBox();
            this.panelChat = new System.Windows.Forms.Panel();
            this.listboxChat = new System.Windows.Forms.ListBox();
            this.chatDC = new JDragControl.JDragControl(this.components);
            this.chatLabelDC = new JDragControl.JDragControl(this.components);
            this.panelHeader.SuspendLayout();
            this.panelMsg.SuspendLayout();
            this.panelChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.chatName);
            this.panelHeader.Controls.Add(this.btnChatExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 40);
            this.panelHeader.TabIndex = 0;
            // 
            // chatName
            // 
            this.chatName.AutoSize = true;
            this.chatName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chatName.ForeColor = System.Drawing.Color.White;
            this.chatName.Location = new System.Drawing.Point(286, 9);
            this.chatName.Name = "chatName";
            this.chatName.Size = new System.Drawing.Size(236, 23);
            this.chatName.TabIndex = 1;
            this.chatName.Text = "Czat z Kraków Atrakcje";
            this.chatName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChatExit
            // 
            this.btnChatExit.BackColor = System.Drawing.Color.Transparent;
            this.btnChatExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChatExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChatExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.btnChatExit.FlatAppearance.BorderSize = 0;
            this.btnChatExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnChatExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnChatExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChatExit.Image = ((System.Drawing.Image)(resources.GetObject("btnChatExit.Image")));
            this.btnChatExit.Location = new System.Drawing.Point(756, 0);
            this.btnChatExit.Name = "btnChatExit";
            this.btnChatExit.Size = new System.Drawing.Size(44, 40);
            this.btnChatExit.TabIndex = 0;
            this.btnChatExit.UseVisualStyleBackColor = false;
            this.btnChatExit.Click += new System.EventHandler(this.btnChatExit_Click);
            // 
            // panelMsg
            // 
            this.panelMsg.Controls.Add(this.btnSend);
            this.panelMsg.Controls.Add(this.textboxMsg);
            this.panelMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMsg.Location = new System.Drawing.Point(0, 361);
            this.panelMsg.Name = "panelMsg";
            this.panelMsg.Size = new System.Drawing.Size(800, 49);
            this.panelMsg.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.Location = new System.Drawing.Point(569, -3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(45, 34);
            this.btnSend.TabIndex = 1;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textboxMsg
            // 
            this.textboxMsg.Location = new System.Drawing.Point(12, 3);
            this.textboxMsg.Name = "textboxMsg";
            this.textboxMsg.Size = new System.Drawing.Size(551, 22);
            this.textboxMsg.TabIndex = 0;
            this.textboxMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxMsg_KeyDown);
            // 
            // panelChat
            // 
            this.panelChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.panelChat.Controls.Add(this.listboxChat);
            this.panelChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChat.Location = new System.Drawing.Point(0, 40);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(800, 321);
            this.panelChat.TabIndex = 2;
            // 
            // listboxChat
            // 
            this.listboxChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.listboxChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listboxChat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listboxChat.ForeColor = System.Drawing.Color.White;
            this.listboxChat.FormattingEnabled = true;
            this.listboxChat.ItemHeight = 23;
            this.listboxChat.Location = new System.Drawing.Point(12, 15);
            this.listboxChat.Name = "listboxChat";
            this.listboxChat.Size = new System.Drawing.Size(776, 299);
            this.listboxChat.TabIndex = 0;
            // 
            // chatDC
            // 
            this.chatDC.GetForm = this;
            this.chatDC.TargetControl = this.panelHeader;
            // 
            // chatLabelDC
            // 
            this.chatLabelDC.GetForm = this;
            this.chatLabelDC.TargetControl = this.chatName;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.panelMsg);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMsg.ResumeLayout(false);
            this.panelMsg.PerformLayout();
            this.panelChat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnChatExit;
        private System.Windows.Forms.Panel panelMsg;
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.Label chatName;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textboxMsg;
        private System.Windows.Forms.ListBox listboxChat;
        private JDragControl.JDragControl chatDC;
        private JDragControl.JDragControl chatLabelDC;
    }
}