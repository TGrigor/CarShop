namespace ShopCars
{
    partial class FormCarListAdmin
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
            this.lvCarList = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btbAddCar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrands
            // 
            this.lblBrands.AutoSize = true;
            this.lblBrands.Location = new System.Drawing.Point(12, 38);
            this.lblBrands.Name = "lblBrands";
            this.lblBrands.Size = new System.Drawing.Size(35, 13);
            this.lblBrands.TabIndex = 2;
            this.lblBrands.Text = "Brand";
            // 
            // comboBoxBrands
            // 
            this.comboBoxBrands.FormattingEnabled = true;
            this.comboBoxBrands.Location = new System.Drawing.Point(12, 55);
            this.comboBoxBrands.Name = "comboBoxBrands";
            this.comboBoxBrands.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBrands.TabIndex = 2;
            // 
            // lblModels
            // 
            this.lblModels.AutoSize = true;
            this.lblModels.Location = new System.Drawing.Point(182, 38);
            this.lblModels.Name = "lblModels";
            this.lblModels.Size = new System.Drawing.Size(36, 13);
            this.lblModels.TabIndex = 3;
            this.lblModels.Text = "Model";
            // 
            // comboBoxModels
            // 
            this.comboBoxModels.FormattingEnabled = true;
            this.comboBoxModels.Location = new System.Drawing.Point(185, 54);
            this.comboBoxModels.Name = "comboBoxModels";
            this.comboBoxModels.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModels.TabIndex = 3;
            // 
            // lvCarList
            // 
            this.lvCarList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Brand,
            this.Model,
            this.Color,
            this.Price});
            this.lvCarList.FullRowSelect = true;
            this.lvCarList.GridLines = true;
            this.lvCarList.Location = new System.Drawing.Point(12, 122);
            this.lvCarList.Name = "lvCarList";
            this.lvCarList.Size = new System.Drawing.Size(506, 280);
            this.lvCarList.TabIndex = 6;
            this.lvCarList.UseCompatibleStateImageBehavior = false;
            this.lvCarList.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            // 
            // Brand
            // 
            this.Brand.Text = "Brand";
            this.Brand.Width = 145;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 124;
            // 
            // Color
            // 
            this.Color.Text = "Color";
            this.Color.Width = 82;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 83;
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Location = new System.Drawing.Point(12, 12);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(75, 23);
            this.btnAddBrand.TabIndex = 0;
            this.btnAddBrand.Text = "Add Brand";
            this.btnAddBrand.UseVisualStyleBackColor = true;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // btnAddModel
            // 
            this.btnAddModel.Location = new System.Drawing.Point(185, 12);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(75, 23);
            this.btnAddModel.TabIndex = 1;
            this.btnAddModel.Text = "Add Model";
            this.btnAddModel.UseVisualStyleBackColor = true;
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(12, 79);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Color";
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxColor.Location = new System.Drawing.Point(15, 95);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(28, 21);
            this.pictureBoxColor.TabIndex = 10;
            this.pictureBoxColor.TabStop = false;
            this.pictureBoxColor.Click += new System.EventHandler(this.pictureBoxColor_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(182, 79);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(185, 96);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(58, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // btbAddCar
            // 
            this.btbAddCar.Location = new System.Drawing.Point(439, 12);
            this.btbAddCar.Name = "btbAddCar";
            this.btbAddCar.Size = new System.Drawing.Size(75, 23);
            this.btbAddCar.TabIndex = 8;
            this.btbAddCar.Text = "ADD";
            this.btbAddCar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Shahuyt";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormCarListAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btbAddCar);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pictureBoxColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnAddModel);
            this.Controls.Add(this.btnAddBrand);
            this.Controls.Add(this.lvCarList);
            this.Controls.Add(this.comboBoxModels);
            this.Controls.Add(this.lblModels);
            this.Controls.Add(this.comboBoxBrands);
            this.Controls.Add(this.lblBrands);
            this.MaximizeBox = false;
            this.Name = "FormCarListAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Car list";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrands;
        private System.Windows.Forms.ComboBox comboBoxBrands;
        private System.Windows.Forms.Label lblModels;
        private System.Windows.Forms.ComboBox comboBoxModels;
        private System.Windows.Forms.ListView lvCarList;
        private System.Windows.Forms.ColumnHeader Brand;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button btnAddBrand;
        private System.Windows.Forms.Button btnAddModel;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btbAddCar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader Id;
    }
}