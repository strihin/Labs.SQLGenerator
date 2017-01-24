namespace SQLGenerator
{
    partial class DishSelect
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
            System.Windows.Forms.CheckedListBox clbProducts;
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.cbFirst = new System.Windows.Forms.CheckBox();
            this.cbSecond = new System.Windows.Forms.CheckBox();
            this.cbSalad = new System.Windows.Forms.CheckBox();
            this.cbDessert = new System.Windows.Forms.CheckBox();
            this.btnGenerateSQL = new System.Windows.Forms.Button();
            this.rtbSQL = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            clbProducts = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.BackColor = System.Drawing.Color.Transparent;
            this.cbAll.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAll.ForeColor = System.Drawing.Color.Red;
            this.cbAll.Location = new System.Drawing.Point(3, 0);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(96, 20);
            this.cbAll.TabIndex = 1;
            this.cbAll.Text = "Все типы";
            this.cbAll.UseVisualStyleBackColor = false;
            // 
            // cbFirst
            // 
            this.cbFirst.AutoSize = true;
            this.cbFirst.BackColor = System.Drawing.Color.Transparent;
            this.cbFirst.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFirst.ForeColor = System.Drawing.Color.Red;
            this.cbFirst.Location = new System.Drawing.Point(3, 23);
            this.cbFirst.Name = "cbFirst";
            this.cbFirst.Size = new System.Drawing.Size(136, 20);
            this.cbFirst.TabIndex = 2;
            this.cbFirst.Text = "Первое блюдо";
            this.cbFirst.UseVisualStyleBackColor = false;
            // 
            // cbSecond
            // 
            this.cbSecond.AutoSize = true;
            this.cbSecond.BackColor = System.Drawing.Color.Transparent;
            this.cbSecond.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSecond.ForeColor = System.Drawing.Color.Red;
            this.cbSecond.Location = new System.Drawing.Point(1, 49);
            this.cbSecond.Name = "cbSecond";
            this.cbSecond.Size = new System.Drawing.Size(134, 20);
            this.cbSecond.TabIndex = 3;
            this.cbSecond.Text = "Второе блюдо";
            this.cbSecond.UseVisualStyleBackColor = false;
            this.cbSecond.UseWaitCursor = true;
            // 
            // cbSalad
            // 
            this.cbSalad.AutoSize = true;
            this.cbSalad.BackColor = System.Drawing.Color.Transparent;
            this.cbSalad.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSalad.ForeColor = System.Drawing.Color.Red;
            this.cbSalad.Location = new System.Drawing.Point(3, 69);
            this.cbSalad.Name = "cbSalad";
            this.cbSalad.Size = new System.Drawing.Size(72, 20);
            this.cbSalad.TabIndex = 4;
            this.cbSalad.Text = "Салат";
            this.cbSalad.UseVisualStyleBackColor = false;
            // 
            // cbDessert
            // 
            this.cbDessert.AutoSize = true;
            this.cbDessert.BackColor = System.Drawing.Color.Transparent;
            this.cbDessert.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDessert.ForeColor = System.Drawing.Color.Red;
            this.cbDessert.Location = new System.Drawing.Point(3, 95);
            this.cbDessert.Name = "cbDessert";
            this.cbDessert.Size = new System.Drawing.Size(82, 20);
            this.cbDessert.TabIndex = 5;
            this.cbDessert.Text = "Десерт";
            this.cbDessert.UseVisualStyleBackColor = false;
            // 
            // btnGenerateSQL
            // 
            this.btnGenerateSQL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerateSQL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerateSQL.Location = new System.Drawing.Point(100, 154);
            this.btnGenerateSQL.Name = "btnGenerateSQL";
            this.btnGenerateSQL.Size = new System.Drawing.Size(106, 33);
            this.btnGenerateSQL.TabIndex = 6;
            this.btnGenerateSQL.Text = "Нажать!";
            this.btnGenerateSQL.UseVisualStyleBackColor = true;
            this.btnGenerateSQL.Click += new System.EventHandler(this.btnGenerateSQL_Click);
            // 
            // rtbSQL
            // 
            this.rtbSQL.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbSQL.ForeColor = System.Drawing.Color.Gray;
            this.rtbSQL.Location = new System.Drawing.Point(12, 193);
            this.rtbSQL.Name = "rtbSQL";
            this.rtbSQL.Size = new System.Drawing.Size(306, 61);
            this.rtbSQL.TabIndex = 8;
            this.rtbSQL.Text = "";
            // 
            // clbProducts
            // 
            clbProducts.CheckOnClick = true;
            clbProducts.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            clbProducts.ForeColor = System.Drawing.Color.Gray;
            clbProducts.FormattingEnabled = true;
            clbProducts.Items.AddRange(new object[] {
            "Яблоко",
            "Морковь",
            "Банан",
            "Чеснок",
            "Сахар"});
            clbProducts.Location = new System.Drawing.Point(12, 10);
            clbProducts.Name = "clbProducts";
            clbProducts.Size = new System.Drawing.Size(135, 130);
            clbProducts.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbSecond);
            this.panel1.Controls.Add(this.cbAll);
            this.panel1.Controls.Add(this.cbFirst);
            this.panel1.Controls.Add(this.cbDessert);
            this.panel1.Controls.Add(this.cbSalad);
            this.panel1.Location = new System.Drawing.Point(168, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 128);
            this.panel1.TabIndex = 9;
            // 
            // DishSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 294);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtbSQL);
            this.Controls.Add(this.btnGenerateSQL);
            this.Controls.Add(clbProducts);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DishSelect";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbAll;
        private System.Windows.Forms.CheckBox cbFirst;
        private System.Windows.Forms.CheckBox cbSecond;
        private System.Windows.Forms.CheckBox cbSalad;
        private System.Windows.Forms.CheckBox cbDessert;
        private System.Windows.Forms.Button btnGenerateSQL;
        private System.Windows.Forms.RichTextBox rtbSQL;
        private System.Windows.Forms.Panel panel1;
    }
}

