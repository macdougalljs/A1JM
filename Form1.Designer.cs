namespace A1JeremiahMacDougall
{
    partial class BillCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillCalculator));
            this.cmbBeverages = new System.Windows.Forms.ComboBox();
            this.cmbAppetizers = new System.Windows.Forms.ComboBox();
            this.cmbMainCourse = new System.Windows.Forms.ComboBox();
            this.cmbDesserts = new System.Windows.Forms.ComboBox();
            this.listSelections = new System.Windows.Forms.ListBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblBeverages = new System.Windows.Forms.Label();
            this.lblAppetizers = new System.Windows.Forms.Label();
            this.lblMainCourses = new System.Windows.Forms.Label();
            this.lblDesserts = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.txtStudentInfo = new System.Windows.Forms.RichTextBox();
            this.boxMenuItems = new System.Windows.Forms.GroupBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.boxMenuItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBeverages
            // 
            this.cmbBeverages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBeverages.FormattingEnabled = true;
            this.cmbBeverages.Location = new System.Drawing.Point(124, 37);
            this.cmbBeverages.Name = "cmbBeverages";
            this.cmbBeverages.Size = new System.Drawing.Size(184, 24);
            this.cmbBeverages.TabIndex = 0;
            this.cmbBeverages.SelectedIndexChanged += new System.EventHandler(this.cmbBeverages_SelectedIndexChanged);
            // 
            // cmbAppetizers
            // 
            this.cmbAppetizers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppetizers.FormattingEnabled = true;
            this.cmbAppetizers.Location = new System.Drawing.Point(124, 89);
            this.cmbAppetizers.Name = "cmbAppetizers";
            this.cmbAppetizers.Size = new System.Drawing.Size(184, 24);
            this.cmbAppetizers.TabIndex = 1;
            this.cmbAppetizers.SelectedIndexChanged += new System.EventHandler(this.cmbAppetizers_SelectedIndexChanged);
            // 
            // cmbMainCourse
            // 
            this.cmbMainCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMainCourse.FormattingEnabled = true;
            this.cmbMainCourse.Location = new System.Drawing.Point(124, 141);
            this.cmbMainCourse.Name = "cmbMainCourse";
            this.cmbMainCourse.Size = new System.Drawing.Size(184, 24);
            this.cmbMainCourse.TabIndex = 2;
            this.cmbMainCourse.SelectedIndexChanged += new System.EventHandler(this.cmbMainCourse_SelectedIndexChanged);
            // 
            // cmbDesserts
            // 
            this.cmbDesserts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesserts.FormattingEnabled = true;
            this.cmbDesserts.Location = new System.Drawing.Point(124, 188);
            this.cmbDesserts.Name = "cmbDesserts";
            this.cmbDesserts.Size = new System.Drawing.Size(184, 24);
            this.cmbDesserts.TabIndex = 3;
            this.cmbDesserts.SelectedIndexChanged += new System.EventHandler(this.cmbDesserts_SelectedIndexChanged);
            // 
            // listSelections
            // 
            this.listSelections.FormattingEnabled = true;
            this.listSelections.ItemHeight = 16;
            this.listSelections.Location = new System.Drawing.Point(373, 81);
            this.listSelections.Name = "listSelections";
            this.listSelections.Size = new System.Drawing.Size(215, 244);
            this.listSelections.Sorted = true;
            this.listSelections.TabIndex = 4;
            this.listSelections.TabStop = false;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(370, 351);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(64, 17);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(370, 383);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(31, 17);
            this.lblTax.TabIndex = 5;
            this.lblTax.Text = "Tax";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(370, 415);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(485, 346);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubtotal.TabIndex = 6;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(485, 378);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 22);
            this.txtTax.TabIndex = 7;
            this.txtTax.TabStop = false;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(485, 410);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(373, 454);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Bill";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblBeverages
            // 
            this.lblBeverages.AutoSize = true;
            this.lblBeverages.Location = new System.Drawing.Point(15, 40);
            this.lblBeverages.Name = "lblBeverages";
            this.lblBeverages.Size = new System.Drawing.Size(76, 17);
            this.lblBeverages.TabIndex = 4;
            this.lblBeverages.Text = "Beverages";
            // 
            // lblAppetizers
            // 
            this.lblAppetizers.AutoSize = true;
            this.lblAppetizers.Location = new System.Drawing.Point(14, 93);
            this.lblAppetizers.Name = "lblAppetizers";
            this.lblAppetizers.Size = new System.Drawing.Size(68, 20);
            this.lblAppetizers.TabIndex = 10;
            this.lblAppetizers.Text = "Appetizers";
            this.lblAppetizers.UseCompatibleTextRendering = true;
            // 
            // lblMainCourses
            // 
            this.lblMainCourses.AutoSize = true;
            this.lblMainCourses.Location = new System.Drawing.Point(15, 148);
            this.lblMainCourses.Name = "lblMainCourses";
            this.lblMainCourses.Size = new System.Drawing.Size(94, 17);
            this.lblMainCourses.TabIndex = 11;
            this.lblMainCourses.Text = "Main Courses";
            // 
            // lblDesserts
            // 
            this.lblDesserts.AutoSize = true;
            this.lblDesserts.Location = new System.Drawing.Point(15, 195);
            this.lblDesserts.Name = "lblDesserts";
            this.lblDesserts.Size = new System.Drawing.Size(64, 17);
            this.lblDesserts.TabIndex = 12;
            this.lblDesserts.Text = "Desserts";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(513, 453);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 29);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(131, 25);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(377, 36);
            this.lblMainTitle.TabIndex = 14;
            this.lblMainTitle.Text = "Restaurant Bill Calculator";
            // 
            // txtStudentInfo
            // 
            this.txtStudentInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(215)))), ((int)(((byte)(211)))));
            this.txtStudentInfo.Location = new System.Drawing.Point(67, 341);
            this.txtStudentInfo.Name = "txtStudentInfo";
            this.txtStudentInfo.ReadOnly = true;
            this.txtStudentInfo.Size = new System.Drawing.Size(254, 141);
            this.txtStudentInfo.TabIndex = 15;
            this.txtStudentInfo.TabStop = false;
            this.txtStudentInfo.Text = "";
            // 
            // boxMenuItems
            // 
            this.boxMenuItems.Controls.Add(this.lblDesserts);
            this.boxMenuItems.Controls.Add(this.lblMainCourses);
            this.boxMenuItems.Controls.Add(this.lblAppetizers);
            this.boxMenuItems.Controls.Add(this.lblBeverages);
            this.boxMenuItems.Controls.Add(this.cmbBeverages);
            this.boxMenuItems.Controls.Add(this.cmbAppetizers);
            this.boxMenuItems.Controls.Add(this.cmbMainCourse);
            this.boxMenuItems.Controls.Add(this.cmbDesserts);
            this.boxMenuItems.Location = new System.Drawing.Point(24, 81);
            this.boxMenuItems.Name = "boxMenuItems";
            this.boxMenuItems.Size = new System.Drawing.Size(314, 233);
            this.boxMenuItems.TabIndex = 16;
            this.boxMenuItems.TabStop = false;
            this.boxMenuItems.Text = "Menu Items";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(556, 534);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(87, 17);
            this.lblVersion.TabIndex = 17;
            this.lblVersion.Text = "v2020.01.15";
            // 
            // BillCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(215)))), ((int)(((byte)(211)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(655, 560);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.boxMenuItems);
            this.Controls.Add(this.txtStudentInfo);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.listSelections);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BillCalculator";
            this.Text = "Restaurant Bill Calculator";
            this.Load += new System.EventHandler(this.frmTableBill_Load);
            this.boxMenuItems.ResumeLayout(false);
            this.boxMenuItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBeverages;
        private System.Windows.Forms.ComboBox cmbAppetizers;
        private System.Windows.Forms.ComboBox cmbMainCourse;
        private System.Windows.Forms.ComboBox cmbDesserts;
        private System.Windows.Forms.ListBox listSelections;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblBeverages;
        private System.Windows.Forms.Label lblAppetizers;
        private System.Windows.Forms.Label lblMainCourses;
        private System.Windows.Forms.Label lblDesserts;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.RichTextBox txtStudentInfo;
        private System.Windows.Forms.GroupBox boxMenuItems;
        private System.Windows.Forms.Label lblVersion;
    }
}

