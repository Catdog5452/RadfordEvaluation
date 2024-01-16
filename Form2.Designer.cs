
namespace EvaluationProject
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cbStaffType = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleChar = new System.Windows.Forms.TextBox();
            this.txtHome = new System.Windows.Forms.TextBox();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.txtIRD = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbManagers = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Staff Member";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(456, 281);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(477, 35);
            this.txtTitle.TabIndex = 1;
            // 
            // cbStaffType
            // 
            this.cbStaffType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStaffType.FormattingEnabled = true;
            this.cbStaffType.Items.AddRange(new object[] {
            "Employee",
            "Manager"});
            this.cbStaffType.Location = new System.Drawing.Point(456, 173);
            this.cbStaffType.Name = "cbStaffType";
            this.cbStaffType.Size = new System.Drawing.Size(477, 37);
            this.cbStaffType.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(456, 387);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(477, 35);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(456, 599);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(477, 35);
            this.txtLastName.TabIndex = 4;
            // 
            // txtMiddleChar
            // 
            this.txtMiddleChar.Location = new System.Drawing.Point(456, 493);
            this.txtMiddleChar.Name = "txtMiddleChar";
            this.txtMiddleChar.Size = new System.Drawing.Size(477, 35);
            this.txtMiddleChar.TabIndex = 5;
            // 
            // txtHome
            // 
            this.txtHome.Location = new System.Drawing.Point(456, 705);
            this.txtHome.Name = "txtHome";
            this.txtHome.Size = new System.Drawing.Size(477, 35);
            this.txtHome.TabIndex = 6;
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(1513, 175);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(477, 35);
            this.txtCell.TabIndex = 7;
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(1513, 281);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(477, 35);
            this.txtExtension.TabIndex = 8;
            // 
            // txtIRD
            // 
            this.txtIRD.Location = new System.Drawing.Point(1513, 387);
            this.txtIRD.Name = "txtIRD";
            this.txtIRD.Size = new System.Drawing.Size(477, 35);
            this.txtIRD.TabIndex = 9;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Pending"});
            this.cbStatus.Location = new System.Drawing.Point(1513, 493);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(477, 37);
            this.cbStatus.TabIndex = 10;
            // 
            // cbManagers
            // 
            this.cbManagers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManagers.FormattingEnabled = true;
            this.cbManagers.Location = new System.Drawing.Point(1513, 601);
            this.cbManagers.Name = "cbManagers";
            this.cbManagers.Size = new System.Drawing.Size(477, 37);
            this.cbManagers.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(108, 819);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(324, 71);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(552, 819);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(324, 71);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(102, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "Staff Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(102, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 36);
            this.label3.TabIndex = 15;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(102, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 36);
            this.label4.TabIndex = 16;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(102, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "Middle Initial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(102, 598);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 36);
            this.label6.TabIndex = 18;
            this.label6.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(102, 704);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 36);
            this.label7.TabIndex = 19;
            this.label7.Text = "Home Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(1159, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 36);
            this.label8.TabIndex = 20;
            this.label8.Text = "Cell Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(1159, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 36);
            this.label9.TabIndex = 21;
            this.label9.Text = "IRD Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(1159, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 36);
            this.label10.TabIndex = 22;
            this.label10.Text = "Office Extension";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(1159, 492);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 36);
            this.label11.TabIndex = 23;
            this.label11.Text = "Status";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(1159, 598);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 36);
            this.label12.TabIndex = 24;
            this.label12.Text = "Manager";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2334, 1467);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbManagers);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtIRD);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.txtCell);
            this.Controls.Add(this.txtHome);
            this.Controls.Add(this.txtMiddleChar);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.cbStaffType);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cbStaffType;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMiddleChar;
        private System.Windows.Forms.TextBox txtHome;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.TextBox txtIRD;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbManagers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}