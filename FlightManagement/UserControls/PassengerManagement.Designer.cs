namespace FlightManagement.UserControls
{
    partial class PassengerManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpDayOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnAddPassenger = new System.Windows.Forms.Button();
            this.btnUpdatePassenger = new System.Windows.Forms.Button();
            this.bynDeletePassenger = new System.Windows.Forms.Button();
            this.dgvPassengers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin hành khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quốc tịch:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(595, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(595, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số hộ chiếu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(595, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ngày sinh:";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(255, 90);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(262, 36);
            this.txtFullName.TabIndex = 8;
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(255, 147);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(262, 37);
            this.cbGender.TabIndex = 9;
            // 
            // txtNationality
            // 
            this.txtNationality.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationality.Location = new System.Drawing.Point(255, 203);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(262, 36);
            this.txtNationality.TabIndex = 10;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(255, 260);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(262, 36);
            this.txtPhoneNumber.TabIndex = 11;
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassportNumber.Location = new System.Drawing.Point(765, 148);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(252, 36);
            this.txtPassportNumber.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(765, 203);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(252, 36);
            this.txtEmail.TabIndex = 13;
            // 
            // dtpDayOfBirth
            // 
            this.dtpDayOfBirth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDayOfBirth.Location = new System.Drawing.Point(765, 91);
            this.dtpDayOfBirth.Name = "dtpDayOfBirth";
            this.dtpDayOfBirth.Size = new System.Drawing.Size(252, 36);
            this.dtpDayOfBirth.TabIndex = 14;
            // 
            // btnAddPassenger
            // 
            this.btnAddPassenger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.btnAddPassenger.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPassenger.ForeColor = System.Drawing.Color.White;
            this.btnAddPassenger.Location = new System.Drawing.Point(172, 321);
            this.btnAddPassenger.Name = "btnAddPassenger";
            this.btnAddPassenger.Size = new System.Drawing.Size(125, 46);
            this.btnAddPassenger.TabIndex = 15;
            this.btnAddPassenger.Text = "Thêm";
            this.btnAddPassenger.UseVisualStyleBackColor = false;
            // 
            // btnUpdatePassenger
            // 
            this.btnUpdatePassenger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.btnUpdatePassenger.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassenger.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePassenger.Location = new System.Drawing.Point(482, 322);
            this.btnUpdatePassenger.Name = "btnUpdatePassenger";
            this.btnUpdatePassenger.Size = new System.Drawing.Size(125, 46);
            this.btnUpdatePassenger.TabIndex = 16;
            this.btnUpdatePassenger.Text = "Sửa ";
            this.btnUpdatePassenger.UseVisualStyleBackColor = false;
            // 
            // bynDeletePassenger
            // 
            this.bynDeletePassenger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.bynDeletePassenger.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bynDeletePassenger.ForeColor = System.Drawing.Color.White;
            this.bynDeletePassenger.Location = new System.Drawing.Point(797, 321);
            this.bynDeletePassenger.Name = "bynDeletePassenger";
            this.bynDeletePassenger.Size = new System.Drawing.Size(125, 46);
            this.bynDeletePassenger.TabIndex = 17;
            this.bynDeletePassenger.Text = "Xóa";
            this.bynDeletePassenger.UseVisualStyleBackColor = false;
            // 
            // dgvPassengers
            // 
            this.dgvPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassengers.Location = new System.Drawing.Point(0, 385);
            this.dgvPassengers.Name = "dgvPassengers";
            this.dgvPassengers.RowHeadersWidth = 62;
            this.dgvPassengers.RowTemplate.Height = 28;
            this.dgvPassengers.Size = new System.Drawing.Size(1134, 478);
            this.dgvPassengers.TabIndex = 18;
            // 
            // PassengerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPassengers);
            this.Controls.Add(this.bynDeletePassenger);
            this.Controls.Add(this.btnUpdatePassenger);
            this.Controls.Add(this.btnAddPassenger);
            this.Controls.Add(this.dtpDayOfBirth);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassportNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PassengerManagement";
            this.Size = new System.Drawing.Size(1137, 866);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpDayOfBirth;
        private System.Windows.Forms.Button btnAddPassenger;
        private System.Windows.Forms.Button btnUpdatePassenger;
        private System.Windows.Forms.Button bynDeletePassenger;
        private System.Windows.Forms.DataGridView dgvPassengers;
    }
}
