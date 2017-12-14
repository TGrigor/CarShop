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
            this.lvCarList = new System.Windows.Forms.ListView();
            this.Brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btbAddCar = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.lvCarList.Location = new System.Drawing.Point(12, 41);
            this.lvCarList.Name = "lvCarList";
            this.lvCarList.Size = new System.Drawing.Size(439, 131);
            this.lvCarList.TabIndex = 4;
            this.lvCarList.UseCompatibleStateImageBehavior = false;
            this.lvCarList.View = System.Windows.Forms.View.Details;
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
            this.btnAddModel.Location = new System.Drawing.Point(93, 12);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(75, 23);
            this.btnAddModel.TabIndex = 1;
            this.btnAddModel.Text = "Add Model";
            this.btnAddModel.UseVisualStyleBackColor = true;
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
            // 
            // btbAddCar
            // 
            this.btbAddCar.Location = new System.Drawing.Point(174, 12);
            this.btbAddCar.Name = "btbAddCar";
            this.btbAddCar.Size = new System.Drawing.Size(75, 23);
            this.btbAddCar.TabIndex = 2;
            this.btbAddCar.Text = "Add Car";
            this.btbAddCar.UseVisualStyleBackColor = true;
            this.btbAddCar.Click += new System.EventHandler(this.btbAddCar_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.Location = new System.Drawing.Point(376, 12);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(75, 23);
            this.btnRevenue.TabIndex = 3;
            this.btnRevenue.Text = "Revenue";
            this.btnRevenue.UseVisualStyleBackColor = true;
            // 
            // FormCarListAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 186);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.btbAddCar);
            this.Controls.Add(this.btnAddModel);
            this.Controls.Add(this.btnAddBrand);
            this.Controls.Add(this.lvCarList);
            this.MaximizeBox = false;
            this.Name = "FormCarListAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Car list";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvCarList;
        private System.Windows.Forms.ColumnHeader Brand;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button btnAddBrand;
        private System.Windows.Forms.Button btnAddModel;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btbAddCar;
        private System.Windows.Forms.Button btnRevenue;
    }
}