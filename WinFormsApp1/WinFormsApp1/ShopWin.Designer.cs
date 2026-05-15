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
            flowLayoutPanel1 = new FlowLayoutPanel();
            FindLabel = new Label();
            Finding = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            ShowCardsItems.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ShowCardsItems.AutoScroll = true;
            ShowCardsItems.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ShowCardsItems.Location = new Point(0, 93);
            ShowCardsItems.Name = "ShowCardsItems";
            ShowCardsItems.Size = new Size(1964, 1328);
            ShowCardsItems.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(FindLabel);
            flowLayoutPanel1.Controls.Add(Finding);
            flowLayoutPanel1.Location = new Point(0, 52);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1964, 35);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // FindLabel
            // 
            FindLabel.Anchor = AnchorStyles.Left;
            FindLabel.AutoSize = true;
            FindLabel.Location = new Point(3, 0);
            FindLabel.Name = "FindLabel";
            FindLabel.Size = new Size(42, 15);
            FindLabel.TabIndex = 0;
            FindLabel.Text = "Поиск";
            // 
            // Finding
            // 
            Finding.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Finding.Location = new Point(51, 3);
            Finding.Name = "Finding";
            Finding.Size = new Size(100, 23);
            Finding.TabIndex = 1;
            Finding.KeyDown += Finding_KeyDown;
            // 
            // ShopWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1964, 1421);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(ShowCardsItems);
            Controls.Add(tableLayoutPanel1);
            Name = "ShopWin";
            Text = "Form2";
            Load += ShomWin_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button CloseWindow;
        private TableLayoutPanel tableLayoutPanel1;
        private Label Greeter;
        private FlowLayoutPanel ShowCardsItems;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label FindLabel;
        private TextBox Finding;
    }
}