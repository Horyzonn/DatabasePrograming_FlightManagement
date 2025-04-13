namespace FlightManagement
{
    partial class Flight
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbRouteId = new System.Windows.Forms.ComboBox();
            this.dtpDeparture = new System.Windows.Forms.DateTimePicker();
            this.dtpArrival = new System.Windows.Forms.DateTimePicker();
            this.txtTicket1Qty = new System.Windows.Forms.TextBox();
            this.txtTicket1Booked = new System.Windows.Forms.TextBox();
            this.txtTicket2Qty = new System.Windows.Forms.TextBox();
            this.txtTicket2Booked = new System.Windows.Forms.TextBox();
            this.txtTicket1Price = new System.Windows.Forms.TextBox();
            this.txtTicket2Price = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvFlightSchedule = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlightSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(318, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý chuyến bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã lịch trình:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(537, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tuyến bay:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giờ cất cánh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(537, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giờ hạ cánh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng vé loại 1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(537, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số lượng đã đặt:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số lượng vé loại 2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(537, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số lượng đã đặt:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "Gía vé loại 1:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(537, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 29);
            this.label11.TabIndex = 10;
            this.label11.Text = "Gía vé loại 2:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(215, 114);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(252, 36);
            this.txtId.TabIndex = 11;
            // 
            // cbRouteId
            // 
            this.cbRouteId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRouteId.FormattingEnabled = true;
            this.cbRouteId.Location = new System.Drawing.Point(724, 113);
            this.cbRouteId.Name = "cbRouteId";
            this.cbRouteId.Size = new System.Drawing.Size(246, 37);
            this.cbRouteId.TabIndex = 12;
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeparture.Location = new System.Drawing.Point(215, 181);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Size = new System.Drawing.Size(252, 36);
            this.dtpDeparture.TabIndex = 13;
            // 
            // dtpArrival
            // 
            this.dtpArrival.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpArrival.Location = new System.Drawing.Point(724, 180);
            this.dtpArrival.Name = "dtpArrival";
            this.dtpArrival.Size = new System.Drawing.Size(246, 36);
            this.dtpArrival.TabIndex = 14;
            // 
            // txtTicket1Qty
            // 
            this.txtTicket1Qty.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket1Qty.Location = new System.Drawing.Point(320, 247);
            this.txtTicket1Qty.Name = "txtTicket1Qty";
            this.txtTicket1Qty.Size = new System.Drawing.Size(147, 36);
            this.txtTicket1Qty.TabIndex = 15;
            // 
            // txtTicket1Booked
            // 
            this.txtTicket1Booked.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket1Booked.Location = new System.Drawing.Point(816, 247);
            this.txtTicket1Booked.Name = "txtTicket1Booked";
            this.txtTicket1Booked.Size = new System.Drawing.Size(154, 36);
            this.txtTicket1Booked.TabIndex = 16;
            // 
            // txtTicket2Qty
            // 
            this.txtTicket2Qty.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket2Qty.Location = new System.Drawing.Point(320, 312);
            this.txtTicket2Qty.Name = "txtTicket2Qty";
            this.txtTicket2Qty.Size = new System.Drawing.Size(147, 36);
            this.txtTicket2Qty.TabIndex = 17;
            this.txtTicket2Qty.TextChanged += new System.EventHandler(this.txtTicket2Qty_TextChanged);
            // 
            // txtTicket2Booked
            // 
            this.txtTicket2Booked.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket2Booked.Location = new System.Drawing.Point(816, 312);
            this.txtTicket2Booked.Name = "txtTicket2Booked";
            this.txtTicket2Booked.Size = new System.Drawing.Size(154, 36);
            this.txtTicket2Booked.TabIndex = 18;
            // 
            // txtTicket1Price
            // 
            this.txtTicket1Price.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket1Price.Location = new System.Drawing.Point(320, 375);
            this.txtTicket1Price.Name = "txtTicket1Price";
            this.txtTicket1Price.Size = new System.Drawing.Size(147, 36);
            this.txtTicket1Price.TabIndex = 19;
            // 
            // txtTicket2Price
            // 
            this.txtTicket2Price.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket2Price.Location = new System.Drawing.Point(816, 379);
            this.txtTicket2Price.Name = "txtTicket2Price";
            this.txtTicket2Price.Size = new System.Drawing.Size(154, 36);
            this.txtTicket2Price.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(29, 453);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 41);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(226, 453);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 42);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(430, 453);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 42);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(627, 452);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 42);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // dgvFlightSchedule
            // 
            this.dgvFlightSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlightSchedule.Location = new System.Drawing.Point(29, 525);
            this.dgvFlightSchedule.Name = "dgvFlightSchedule";
            this.dgvFlightSchedule.RowHeadersWidth = 62;
            this.dgvFlightSchedule.RowTemplate.Height = 28;
            this.dgvFlightSchedule.Size = new System.Drawing.Size(941, 328);
            this.dgvFlightSchedule.TabIndex = 25;
            // 
            // Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 902);
            this.Controls.Add(this.dgvFlightSchedule);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTicket2Price);
            this.Controls.Add(this.txtTicket1Price);
            this.Controls.Add(this.txtTicket2Booked);
            this.Controls.Add(this.txtTicket2Qty);
            this.Controls.Add(this.txtTicket1Booked);
            this.Controls.Add(this.txtTicket1Qty);
            this.Controls.Add(this.dtpArrival);
            this.Controls.Add(this.dtpDeparture);
            this.Controls.Add(this.cbRouteId);
            this.Controls.Add(this.txtId);
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
            this.Controls.Add(this.label1);
            this.Name = "Flight";
            this.Text = "FlightForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlightSchedule)).EndInit();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cbRouteId;
        private System.Windows.Forms.DateTimePicker dtpDeparture;
        private System.Windows.Forms.DateTimePicker dtpArrival;
        private System.Windows.Forms.TextBox txtTicket1Qty;
        private System.Windows.Forms.TextBox txtTicket1Booked;
        private System.Windows.Forms.TextBox txtTicket2Qty;
        private System.Windows.Forms.TextBox txtTicket2Booked;
        private System.Windows.Forms.TextBox txtTicket1Price;
        private System.Windows.Forms.TextBox txtTicket2Price;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvFlightSchedule;
    }
}