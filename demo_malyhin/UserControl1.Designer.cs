﻿namespace demo_malyhin
{
    partial class UserControl1
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
            labelProductCost = new Label();
            labelProductLine = new Label();
            labelProductMaterials = new Label();
            labelProductArtc = new Label();
            labelProductName = new Label();
            labelProductType = new Label();
            pictureOfProduct = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureOfProduct).BeginInit();
            SuspendLayout();
            // 
            // labelProductCost
            // 
            labelProductCost.AutoSize = true;
            labelProductCost.Location = new Point(608, 19);
            labelProductCost.Name = "labelProductCost";
            labelProductCost.Size = new Size(83, 20);
            labelProductCost.TabIndex = 13;
            labelProductCost.Text = "Стоимость";
            // 
            // labelProductLine
            // 
            labelProductLine.AutoSize = true;
            labelProductLine.Font = new Font("Segoe UI", 11F);
            labelProductLine.Location = new Point(282, 14);
            labelProductLine.Name = "labelProductLine";
            labelProductLine.Size = new Size(17, 25);
            labelProductLine.TabIndex = 12;
            labelProductLine.Text = "|";
            // 
            // labelProductMaterials
            // 
            labelProductMaterials.AutoSize = true;
            labelProductMaterials.Location = new Point(169, 76);
            labelProductMaterials.Name = "labelProductMaterials";
            labelProductMaterials.Size = new Size(96, 20);
            labelProductMaterials.TabIndex = 11;
            labelProductMaterials.Text = "Материалы: ";
            // 
            // labelProductArtc
            // 
            labelProductArtc.AutoSize = true;
            labelProductArtc.Location = new Point(169, 42);
            labelProductArtc.Name = "labelProductArtc";
            labelProductArtc.Size = new Size(65, 20);
            labelProductArtc.TabIndex = 10;
            labelProductArtc.Text = "Артикул";
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Font = new Font("Segoe UI", 11F);
            labelProductName.Location = new Point(293, 14);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(227, 25);
            labelProductName.TabIndex = 9;
            labelProductName.Text = "Наименование продукта";
            // 
            // labelProductType
            // 
            labelProductType.AutoSize = true;
            labelProductType.Font = new Font("Segoe UI", 11F);
            labelProductType.Location = new Point(169, 14);
            labelProductType.Name = "labelProductType";
            labelProductType.Size = new Size(128, 25);
            labelProductType.TabIndex = 8;
            labelProductType.Text = "Тип продукта";
            // 
            // pictureOfProduct
            // 
            pictureOfProduct.Location = new Point(13, 14);
            pictureOfProduct.Margin = new Padding(3, 4, 3, 4);
            pictureOfProduct.Name = "pictureOfProduct";
            pictureOfProduct.Size = new Size(125, 101);
            pictureOfProduct.TabIndex = 7;
            pictureOfProduct.TabStop = false;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(labelProductCost);
            Controls.Add(labelProductLine);
            Controls.Add(labelProductMaterials);
            Controls.Add(labelProductArtc);
            Controls.Add(labelProductName);
            Controls.Add(labelProductType);
            Controls.Add(pictureOfProduct);
            Name = "UserControl1";
            Size = new Size(700, 133);
            Click += UserControl1_Click;
            ((System.ComponentModel.ISupportInitialize)pictureOfProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelProductCost;
        private Label labelProductLine;
        public Label labelProductMaterials;
        public Label labelProductArtc;
        public Label labelProductName;
        public Label labelProductType;
        public PictureBox pictureOfProduct;
    }
}
