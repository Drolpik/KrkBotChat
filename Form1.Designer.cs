
namespace Chat
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Header = new System.Windows.Forms.Panel();
            this.topPanelHeader = new System.Windows.Forms.Panel();
            this.leftPanelHeader = new System.Windows.Forms.Panel();
            this.rightPanelHeader = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.MainContent = new System.Windows.Forms.Panel();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnMpk = new System.Windows.Forms.Button();
            this.btnAttractions = new System.Windows.Forms.Button();
            this.mainDragControl = new JDragControl.JDragControl(this.components);
            this.leftPanelContent = new System.Windows.Forms.Panel();
            this.rightPanelContent = new System.Windows.Forms.Panel();
            this.bottomPanelContent = new System.Windows.Forms.Panel();
            this.Header.SuspendLayout();
            this.Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.MainContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Controls.Add(this.topPanelHeader);
            this.Header.Controls.Add(this.leftPanelHeader);
            this.Header.Controls.Add(this.rightPanelHeader);
            this.Header.Controls.Add(this.btnExit);
            this.Header.Controls.Add(this.btnMinimize);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(400, 40);
            this.Header.TabIndex = 0;
            // 
            // topPanelHeader
            // 
            this.topPanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.topPanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanelHeader.Location = new System.Drawing.Point(5, 0);
            this.topPanelHeader.Name = "topPanelHeader";
            this.topPanelHeader.Size = new System.Drawing.Size(390, 5);
            this.topPanelHeader.TabIndex = 3;
            // 
            // leftPanelHeader
            // 
            this.leftPanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.leftPanelHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanelHeader.Location = new System.Drawing.Point(0, 0);
            this.leftPanelHeader.Name = "leftPanelHeader";
            this.leftPanelHeader.Size = new System.Drawing.Size(5, 40);
            this.leftPanelHeader.TabIndex = 2;
            // 
            // rightPanelHeader
            // 
            this.rightPanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.rightPanelHeader.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanelHeader.Location = new System.Drawing.Point(395, 0);
            this.rightPanelHeader.Name = "rightPanelHeader";
            this.rightPanelHeader.Size = new System.Drawing.Size(5, 40);
            this.rightPanelHeader.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(353, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 40);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(310, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(44, 40);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.Logo.Controls.Add(this.label1);
            this.Logo.Controls.Add(this.pbLogo);
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 40);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(400, 116);
            this.Logo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(220, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "KrkBotChat";
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(181, 116);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // MainContent
            // 
            this.MainContent.Controls.Add(this.btnMain);
            this.MainContent.Controls.Add(this.btnMpk);
            this.MainContent.Controls.Add(this.btnAttractions);
            this.MainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContent.Location = new System.Drawing.Point(0, 156);
            this.MainContent.Name = "MainContent";
            this.MainContent.Size = new System.Drawing.Size(400, 368);
            this.MainContent.TabIndex = 2;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Transparent;
            this.btnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMain.ForeColor = System.Drawing.Color.White;
            this.btnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnMain.Image")));
            this.btnMain.Location = new System.Drawing.Point(0, 230);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(400, 115);
            this.btnMain.TabIndex = 2;
            this.btnMain.Text = "Kraków Ogólny";
            this.btnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnMpk
            // 
            this.btnMpk.BackColor = System.Drawing.Color.Transparent;
            this.btnMpk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMpk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnMpk.FlatAppearance.BorderSize = 0;
            this.btnMpk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnMpk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnMpk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMpk.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMpk.ForeColor = System.Drawing.Color.White;
            this.btnMpk.Image = ((System.Drawing.Image)(resources.GetObject("btnMpk.Image")));
            this.btnMpk.Location = new System.Drawing.Point(0, 115);
            this.btnMpk.Name = "btnMpk";
            this.btnMpk.Size = new System.Drawing.Size(400, 115);
            this.btnMpk.TabIndex = 1;
            this.btnMpk.Text = "Kraków MPK";
            this.btnMpk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMpk.UseVisualStyleBackColor = false;
            this.btnMpk.Click += new System.EventHandler(this.btnMpk_Click);
            // 
            // btnAttractions
            // 
            this.btnAttractions.BackColor = System.Drawing.Color.Transparent;
            this.btnAttractions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttractions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnAttractions.FlatAppearance.BorderSize = 0;
            this.btnAttractions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnAttractions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnAttractions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttractions.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAttractions.ForeColor = System.Drawing.Color.White;
            this.btnAttractions.Image = ((System.Drawing.Image)(resources.GetObject("btnAttractions.Image")));
            this.btnAttractions.Location = new System.Drawing.Point(0, 0);
            this.btnAttractions.Name = "btnAttractions";
            this.btnAttractions.Size = new System.Drawing.Size(400, 115);
            this.btnAttractions.TabIndex = 0;
            this.btnAttractions.Text = "Kraków Atrakcje";
            this.btnAttractions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAttractions.UseVisualStyleBackColor = false;
            this.btnAttractions.Click += new System.EventHandler(this.btnAttractions_Click);
            // 
            // mainDragControl
            // 
            this.mainDragControl.GetForm = this;
            this.mainDragControl.TargetControl = this.Header;
            // 
            // leftPanelContent
            // 
            this.leftPanelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.leftPanelContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanelContent.Location = new System.Drawing.Point(0, 156);
            this.leftPanelContent.Name = "leftPanelContent";
            this.leftPanelContent.Size = new System.Drawing.Size(5, 368);
            this.leftPanelContent.TabIndex = 3;
            // 
            // rightPanelContent
            // 
            this.rightPanelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.rightPanelContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanelContent.Location = new System.Drawing.Point(395, 156);
            this.rightPanelContent.Name = "rightPanelContent";
            this.rightPanelContent.Size = new System.Drawing.Size(5, 368);
            this.rightPanelContent.TabIndex = 3;
            // 
            // bottomPanelContent
            // 
            this.bottomPanelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.bottomPanelContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanelContent.Location = new System.Drawing.Point(5, 519);
            this.bottomPanelContent.Name = "bottomPanelContent";
            this.bottomPanelContent.Size = new System.Drawing.Size(390, 5);
            this.bottomPanelContent.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(400, 524);
            this.Controls.Add(this.bottomPanelContent);
            this.Controls.Add(this.rightPanelContent);
            this.Controls.Add(this.leftPanelContent);
            this.Controls.Add(this.MainContent);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Header.ResumeLayout(false);
            this.Logo.ResumeLayout(false);
            this.Logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.MainContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Panel MainContent;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAttractions;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnMpk;
        private System.Windows.Forms.Button btnExit;
        private JDragControl.JDragControl mainDragControl;
        private System.Windows.Forms.Panel bottomPanelContent;
        private System.Windows.Forms.Panel rightPanelContent;
        private System.Windows.Forms.Panel leftPanelContent;
        private System.Windows.Forms.Panel topPanelHeader;
        private System.Windows.Forms.Panel leftPanelHeader;
        private System.Windows.Forms.Panel rightPanelHeader;
        private System.Windows.Forms.Button btnMinimize;
    }
}

