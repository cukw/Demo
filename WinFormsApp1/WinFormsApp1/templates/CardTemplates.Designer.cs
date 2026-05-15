namespace WinFormsApp1.templates
{
    partial class CardTemplates
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ImageItem = new PictureBox();
            InfoItem = new Panel();
            Count = new Label();
            Unit = new Label();
            Price = new Label();
            Dealer = new Label();
            Creator = new Label();
            Description = new Label();
            CountName = new Label();
            UnitName = new Label();
            PriceName = new Label();
            TransferName = new Label();
            CreatorName = new Label();
            DescriptionName = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Discount = new Label();
            NameItem = new Label();
            ((System.ComponentModel.ISupportInitialize)ImageItem).BeginInit();
            InfoItem.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ImageItem
            // 
            ImageItem.Location = new Point(3, 3);
            ImageItem.Name = "ImageItem";
            ImageItem.Size = new Size(229, 215);
            ImageItem.SizeMode = PictureBoxSizeMode.Zoom;
            ImageItem.TabIndex = 0;
            ImageItem.TabStop = false;
            // 
            // InfoItem
            // 
            InfoItem.Controls.Add(Count);
            InfoItem.Controls.Add(Unit);
            InfoItem.Controls.Add(Price);
            InfoItem.Controls.Add(Dealer);
            InfoItem.Controls.Add(Creator);
            InfoItem.Controls.Add(Description);
            InfoItem.Controls.Add(CountName);
            InfoItem.Controls.Add(UnitName);
            InfoItem.Controls.Add(PriceName);
            InfoItem.Controls.Add(TransferName);
            InfoItem.Controls.Add(CreatorName);
            InfoItem.Controls.Add(DescriptionName);
            InfoItem.Dock = DockStyle.Fill;
            InfoItem.Location = new Point(238, 3);
            InfoItem.Name = "InfoItem";
            InfoItem.Size = new Size(350, 215);
            InfoItem.TabIndex = 2;
            // 
            // Count
            // 
            Count.AutoSize = true;
            Count.Location = new Point(138, 199);
            Count.Name = "Count";
            Count.Size = new Size(38, 15);
            Count.TabIndex = 11;
            Count.Text = "label1";
            // 
            // Unit
            // 
            Unit.AutoSize = true;
            Unit.Location = new Point(128, 163);
            Unit.Name = "Unit";
            Unit.Size = new Size(38, 15);
            Unit.TabIndex = 10;
            Unit.Text = "label1";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(47, 125);
            Price.Name = "Price";
            Price.Size = new Size(38, 15);
            Price.TabIndex = 9;
            Price.Text = "label1";
            // 
            // Dealer
            // 
            Dealer.AutoSize = true;
            Dealer.Location = new Point(82, 84);
            Dealer.Name = "Dealer";
            Dealer.Size = new Size(38, 15);
            Dealer.TabIndex = 8;
            Dealer.Text = "label1";
            // 
            // Creator
            // 
            Creator.AutoSize = true;
            Creator.Location = new Point(104, 38);
            Creator.Name = "Creator";
            Creator.Size = new Size(38, 15);
            Creator.TabIndex = 7;
            Creator.Text = "label1";
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new Point(114, 3);
            Description.Name = "Description";
            Description.Size = new Size(38, 15);
            Description.TabIndex = 6;
            Description.Text = "label1";
            // 
            // CountName
            // 
            CountName.AutoSize = true;
            CountName.Location = new Point(4, 199);
            CountName.Name = "CountName";
            CountName.Size = new Size(128, 15);
            CountName.TabIndex = 5;
            CountName.Text = "Количество на складе";
            // 
            // UnitName
            // 
            UnitName.AutoSize = true;
            UnitName.Location = new Point(3, 163);
            UnitName.Name = "UnitName";
            UnitName.Size = new Size(119, 15);
            UnitName.TabIndex = 4;
            UnitName.Text = "Единица измерения:";
            // 
            // PriceName
            // 
            PriceName.AutoSize = true;
            PriceName.Location = new Point(3, 125);
            PriceName.Name = "PriceName";
            PriceName.Size = new Size(38, 15);
            PriceName.TabIndex = 3;
            PriceName.Text = "Цена:";
            // 
            // TransferName
            // 
            TransferName.AutoSize = true;
            TransferName.Location = new Point(3, 84);
            TransferName.Name = "TransferName";
            TransferName.Size = new Size(73, 15);
            TransferName.TabIndex = 2;
            TransferName.Text = "Поставщик:";
            // 
            // CreatorName
            // 
            CreatorName.AutoSize = true;
            CreatorName.Location = new Point(3, 38);
            CreatorName.Name = "CreatorName";
            CreatorName.Size = new Size(95, 15);
            CreatorName.TabIndex = 1;
            CreatorName.Text = "Производитель:";
            // 
            // DescriptionName
            // 
            DescriptionName.AutoSize = true;
            DescriptionName.Location = new Point(3, 3);
            DescriptionName.Name = "DescriptionName";
            DescriptionName.Size = new Size(105, 15);
            DescriptionName.TabIndex = 0;
            DescriptionName.Text = "Описание товара:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(ImageItem);
            flowLayoutPanel1.Controls.Add(InfoItem);
            flowLayoutPanel1.Controls.Add(Discount);
            flowLayoutPanel1.Location = new Point(3, 14);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(748, 218);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // Discount
            // 
            Discount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Discount.AutoSize = true;
            Discount.Location = new Point(594, 0);
            Discount.Name = "Discount";
            Discount.Size = new Size(124, 221);
            Discount.TabIndex = 4;
            Discount.Text = "Действующая скидка";
            Discount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameItem
            // 
            NameItem.AutoSize = true;
            NameItem.Location = new Point(6, 0);
            NameItem.Name = "NameItem";
            NameItem.Size = new Size(59, 15);
            NameItem.TabIndex = 12;
            NameItem.Text = "Артикул: ";
            // 
            // CardTemplates
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NameItem);
            Controls.Add(flowLayoutPanel1);
            Name = "CardTemplates";
            Size = new Size(754, 235);
            ((System.ComponentModel.ISupportInitialize)ImageItem).EndInit();
            InfoItem.ResumeLayout(false);
            InfoItem.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ImageItem;
        private Panel InfoItem;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label DescriptionName;
        private Label CountName;
        private Label UnitName;
        private Label PriceName;
        private Label TransferName;
        private Label CreatorName;
        private Label Count;
        private Label Unit;
        private Label Price;
        private Label Dealer;
        private Label Creator;
        private Label Description;
        private Label Discount;
        private Label NameItem;
    }
}
