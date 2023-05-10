namespace Chess
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip = new MenuStrip();
            koloryToolStripMenuItem = new ToolStripMenuItem();
            polaToolStripMenuItem = new ToolStripMenuItem();
            pola2ToolStripMenuItem = new ToolStripMenuItem();
            wieżaToolStripMenuItem = new ToolStripMenuItem();
            czarnaToolStripMenuItem = new ToolStripMenuItem();
            białaToolStripMenuItem = new ToolStripMenuItem();
            inneToolStripMenuItem = new ToolStripMenuItem();
            losowanieToolStripMenuItem = new ToolStripMenuItem();
            escapeToLeaveToolStripMenuItem = new ToolStripMenuItem();
            rook = new PictureBox();
            colorDialog = new ColorDialog();
            timer = new System.Windows.Forms.Timer(components);
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rook).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { koloryToolStripMenuItem, inneToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(778, 33);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip";
            menuStrip.MouseHover += menuStrip_MouseHover;
            // 
            // koloryToolStripMenuItem
            // 
            koloryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { polaToolStripMenuItem, pola2ToolStripMenuItem, wieżaToolStripMenuItem });
            koloryToolStripMenuItem.Name = "koloryToolStripMenuItem";
            koloryToolStripMenuItem.Size = new Size(79, 29);
            koloryToolStripMenuItem.Text = "Kolory";
            // 
            // polaToolStripMenuItem
            // 
            polaToolStripMenuItem.Name = "polaToolStripMenuItem";
            polaToolStripMenuItem.Size = new Size(270, 34);
            polaToolStripMenuItem.Text = "Pola #1";
            polaToolStripMenuItem.Click += polaToolStripMenuItem_Click;
            // 
            // pola2ToolStripMenuItem
            // 
            pola2ToolStripMenuItem.Name = "pola2ToolStripMenuItem";
            pola2ToolStripMenuItem.Size = new Size(270, 34);
            pola2ToolStripMenuItem.Text = "Pola #2";
            pola2ToolStripMenuItem.Click += pola2ToolStripMenuItem_Click;
            // 
            // wieżaToolStripMenuItem
            // 
            wieżaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { czarnaToolStripMenuItem, białaToolStripMenuItem });
            wieżaToolStripMenuItem.Name = "wieżaToolStripMenuItem";
            wieżaToolStripMenuItem.Size = new Size(270, 34);
            wieżaToolStripMenuItem.Text = "Wieża";
            // 
            // czarnaToolStripMenuItem
            // 
            czarnaToolStripMenuItem.Name = "czarnaToolStripMenuItem";
            czarnaToolStripMenuItem.Size = new Size(270, 34);
            czarnaToolStripMenuItem.Text = "Czarna";
            czarnaToolStripMenuItem.Click += czarnaToolStripMenuItem_Click;
            // 
            // białaToolStripMenuItem
            // 
            białaToolStripMenuItem.Name = "białaToolStripMenuItem";
            białaToolStripMenuItem.Size = new Size(270, 34);
            białaToolStripMenuItem.Text = "Biała";
            białaToolStripMenuItem.Click += białaToolStripMenuItem_Click;
            // 
            // inneToolStripMenuItem
            // 
            inneToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { losowanieToolStripMenuItem, escapeToLeaveToolStripMenuItem });
            inneToolStripMenuItem.Name = "inneToolStripMenuItem";
            inneToolStripMenuItem.Size = new Size(62, 29);
            inneToolStripMenuItem.Text = "Inne";
            // 
            // losowanieToolStripMenuItem
            // 
            losowanieToolStripMenuItem.Name = "losowanieToolStripMenuItem";
            losowanieToolStripMenuItem.Size = new Size(240, 34);
            losowanieToolStripMenuItem.Text = "Losowanie";
            losowanieToolStripMenuItem.Click += losowanieToolStripMenuItem_Click;
            // 
            // escapeToLeaveToolStripMenuItem
            // 
            escapeToLeaveToolStripMenuItem.Checked = true;
            escapeToLeaveToolStripMenuItem.CheckOnClick = true;
            escapeToLeaveToolStripMenuItem.CheckState = CheckState.Checked;
            escapeToLeaveToolStripMenuItem.Name = "escapeToLeaveToolStripMenuItem";
            escapeToLeaveToolStripMenuItem.Size = new Size(240, 34);
            escapeToLeaveToolStripMenuItem.Text = "Escape by wyjść";
            // 
            // rook
            // 
            rook.BackColor = Color.Transparent;
            rook.Image = (Image)resources.GetObject("rook.Image");
            rook.Location = new Point(300, 333);
            rook.Name = "rook";
            rook.Size = new Size(100, 100);
            rook.SizeMode = PictureBoxSizeMode.StretchImage;
            rook.TabIndex = 2;
            rook.TabStop = false;
            rook.PreviewKeyDown += rook_PreviewKeyDown;
            // 
            // colorDialog
            // 
            colorDialog.AllowFullOpen = false;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 810);
            Controls.Add(rook);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Name = "Main";
            Text = "Szach";
            KeyDown += Main_KeyDown;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem koloryToolStripMenuItem;
        private ToolStripMenuItem polaToolStripMenuItem;
        private ToolStripMenuItem inneToolStripMenuItem;
        private ToolStripMenuItem pola2ToolStripMenuItem;
        private ToolStripMenuItem wieżaToolStripMenuItem;
        private ToolStripMenuItem czarnaToolStripMenuItem;
        private ToolStripMenuItem białaToolStripMenuItem;
        private ToolStripMenuItem losowanieToolStripMenuItem;
        private PictureBox rook;
        private ColorDialog colorDialog;
        private System.Windows.Forms.Timer timer;
        private ToolStripMenuItem escapeToLeaveToolStripMenuItem;
    }
}