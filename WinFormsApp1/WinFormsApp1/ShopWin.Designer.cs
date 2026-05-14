namespace WinFormsApp1
{
    partial class ShopWin
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
            CloseWindow = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            Greeter = new Label();
            ShowCardsItems = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // CloseWindow
            // 
            CloseWindow.Location = new Point(3, 3);
            CloseWindow.Name = "CloseWindow";
            CloseWindow.Size = new Size(72, 44);
            CloseWindow.TabIndex = 1;
            CloseWindow.Text = "Назад";
            CloseWindow.UseVisualStyleBackColor = true;
            CloseWindow.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.52694F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.4730625F));
            tableLayoutPanel1.Controls.Add(CloseWindow, 0, 0);
            tableLayoutPanel1.Controls.Add(Greeter, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1964, 52);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // Greeter
            // 
            Greeter.AutoSize = true;
            Greeter.Dock = DockStyle.Fill;
            Greeter.Location = new Point(1525, 0);
            Greeter.Name = "Greeter";
            Greeter.Size = new Size(436, 52);
            Greeter.TabIndex = 2;
            Greeter.Text = "Вы авторизировали как: ";
            // 
            // ShowCardsItems
            // 
            ShowCardsItems.AutoScroll = true;
            ShowCardsItems.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ShowCardsItems.Dock = DockStyle.Fill;
            ShowCardsItems.Location = new Point(0, 52);
            ShowCardsItems.Name = "ShowCardsItems";
            ShowCardsItems.Size = new Size(1964, 1369);
            ShowCardsItems.TabIndex = 3;
            // 
            // ShopWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1964, 1421);
            Controls.Add(ShowCardsItems);
            Controls.Add(tableLayoutPanel1);
            Name = "ShopWin";
            Text = "Form2";
            Load += ShomWin_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button CloseWindow;
        private TableLayoutPanel tableLayoutPanel1;
        private Label Greeter;
        private FlowLayoutPanel ShowCardsItems;
    }
}