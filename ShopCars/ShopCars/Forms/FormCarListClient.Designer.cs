namespace ShopCars
{
    partial class FormCarListClient
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
            this.lblBrands = new System.Windows.Forms.Label();
            this.comboBoxBrands = new System.Windows.Forms.ComboBox();
            this.lblModels = new System.Windows.Forms.Label();
            this.comboBoxModels = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lvCarList = new System.Windows.Forms.ListView();
            this.Brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrands
            // 
            this.lblBrands.AutoSize = true;
            this.lblBrands.Location = new System.Drawing.Point(16, 11);
            this.lblBrands.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrands.Name = "lblBrands";
            this.lblBrands.Size = new System.Drawing.Size(46, 17);
            this.lblBrands.TabIndex = 0;
            this.lblBrands.Text = "Brand";
            // 
            // comboBoxBrands
            // 
            this.comboBoxBrands.FormattingEnabled = true;
            this.comboBoxBrands.Location = new System.Drawing.Point(16, 31);
            this.comboBoxBrands.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxBrands.Name = "comboBoxBrands";
            this.comboBoxBrands.Size = new System.Drawing.Size(160, 24);
            this.comboBoxBrands.TabIndex = 0;
            this.comboBoxBrands.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrands_SelectedIndexChanged);
            // 
            // lblModels
            // 
            this.lblModels.AutoSize = true;
            this.lblModels.Location = new System.Drawing.Point(284, 11);
            this.lblModels.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModels.Name = "lblModels";
            this.lblModels.Size = new System.Drawing.Size(46, 17);
            this.lblModels.TabIndex = 1;
            this.lblModels.Text = "Model";
            // 
            // comboBoxModels
            // 
            this.comboBoxModels.FormattingEnabled = true;
            this.comboBoxModels.Location = new System.Drawing.Point(288, 31);
            this.comboBoxModels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxModels.Name = "comboBoxModels";
            this.comboBoxModels.Size = new System.Drawing.Size(160, 24);
            this.comboBoxModels.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(524, 31);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lvCarList
            // 
            this.lvCarList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Brand,
            this.Model,
            this.Color,
            this.Price});
            this.lvCarList.FullRowSelect = true;
            this.lvCarList.GridLines = true;
            this.lvCarList.Location = new System.Drawing.Point(16, 80);
            this.lvCarList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvCarList.Name = "lvCarList";
            this.lvCarList.Size = new System.Drawing.Size(432, 344);
            this.lvCarList.TabIndex = 3;
            this.lvCarList.UseCompatibleStateImageBehavior = false;
            this.lvCarList.View = System.Windows.Forms.View.Details;
            this.lvCarList.SelectedIndexChanged += new System.EventHandler(this.lvCarList_SelectedIndexChanged);
            // 
            // Brand
            // 
            this.Brand.Text = "Brand";
            this.Brand.Width = 102;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 86;
            // 
            // Color
            // 
            this.Color.Text = "Color";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 73;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(457, 80);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(100, 28);
            this.btnBuy.TabIndex = 4;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // FormCarListClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 439);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.lvCarList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboBoxModels);
            this.Controls.Add(this.lblModels);
            this.Controls.Add(this.comboBoxBrands);
            this.Controls.Add(this.lblBrands);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormCarListClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Car list";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrands;
        private System.Windows.Forms.ComboBox comboBoxBrands;
        private System.Windows.Forms.Label lblModels;
        private System.Windows.Forms.ComboBox comboBoxModels;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvCarList;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ColumnHeader Brand;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.ColumnHeader Price;
    }
}