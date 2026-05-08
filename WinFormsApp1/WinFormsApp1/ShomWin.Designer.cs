namespace WinFormsApp1
{
    partial class ShomWin
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
            FullName = new Label();
            SuspendLayout();
            // 
            // FullName
            // 
            FullName.AutoSize = true;
            FullName.Location = new Point(739, 9);
            FullName.Name = "FullName";
            FullName.Size = new Size(38, 15);
            FullName.TabIndex = 0;
            FullName.Text = "label1";
            // 
            // ShomWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FullName);
            Name = "ShomWin";
            Text = "Form2";
            Load += ShomWin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FullName;
    }
}