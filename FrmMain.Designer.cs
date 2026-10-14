namespace GUI26101404
{
    partial class FrmMain
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
            pnlMain = new Panel();
            btnClickMe = new Button();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.BackColor = Color.Gainsboro;
            pnlMain.BackgroundImageLayout = ImageLayout.Zoom;
            pnlMain.Controls.Add(btnClickMe);
            pnlMain.Location = new Point(12, 12);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1263, 526);
            pnlMain.TabIndex = 0;
            // 
            // btnClickMe
            // 
            btnClickMe.BackColor = Color.Azure;
            btnClickMe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnClickMe.ForeColor = Color.LimeGreen;
            btnClickMe.Location = new Point(547, 237);
            btnClickMe.Name = "btnClickMe";
            btnClickMe.Size = new Size(178, 57);
            btnClickMe.TabIndex = 0;
            btnClickMe.Text = "Click me! <3";
            btnClickMe.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 550);
            Controls.Add(pnlMain);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmMain";
            Text = "game";
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Button btnClickMe;
    }
}
