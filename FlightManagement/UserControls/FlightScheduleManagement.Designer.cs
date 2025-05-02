namespace FlightManagement.UserControls
{
    partial class FlightScheduleManagement
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDeparture = new System.Windows.Forms.DateTimePicker();
            this.dtpArrival = new System.Windows.Forms.DateTimePicker();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.btnDeleteFlight = new System.Windows.Forms.Button();
            this.dgvFlightSchedule = new System.Windows.Forms.DataGridView();
            this.numTicket1Qty = new System.Windows.Forms.NumericUpDown();
            this.numTicket2Qty = new System.Windows.Forms.NumericUpDown();
            this.numT1Price = new System.Windows.Forms.NumericUpDown();
            this.numT1Booked = new System.Windows.Forms.NumericUpDown();
            this.numT2Booked = new System.Windows.Forms.NumericUpDown();
            this.numT2Price = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRouteId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlightSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTicket1Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTicket2Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT1Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT1Booked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT2Booked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT2Price)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(237, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý chuyến bay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giờ cất cánh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(451, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giờ hạ cánh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng vé loại 1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số lượng vé loại 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(451, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số lượng đã đặt:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(451, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Gía vé loại 2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(451, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Số lượng đã đặt:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(68, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "Gía vé loại 1:";
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeparture.Location = new System.Drawing.Point(229, 94);
            this.dtpDeparture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Size = new System.Drawing.Size(178, 32);
            this.dtpDeparture.TabIndex = 13;
            // 
            // dtpArrival
            // 
            this.dtpArrival.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpArrival.Location = new System.Drawing.Point(634, 97);
            this.dtpArrival.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpArrival.Name = "dtpArrival";
            this.dtpArrival.Size = new System.Drawing.Size(178, 32);
            this.dtpArrival.TabIndex = 14;
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.btnAddFlight.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.ForeColor = System.Drawing.Color.White;
            this.btnAddFlight.Location = new System.Drawing.Point(116, 265);
            this.btnAddFlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(100, 32);
            this.btnAddFlight.TabIndex = 21;
            this.btnAddFlight.Text = "Thêm";
            this.btnAddFlight.UseVisualStyleBackColor = false;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // btnDeleteFlight
            // 
            this.btnDeleteFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.btnDeleteFlight.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFlight.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFlight.Location = new System.Drawing.Point(634, 265);
            this.btnDeleteFlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteFlight.Name = "btnDeleteFlight";
            this.btnDeleteFlight.Size = new System.Drawing.Size(100, 32);
            this.btnDeleteFlight.TabIndex = 23;
            this.btnDeleteFlight.Text = "Xóa";
            this.btnDeleteFlight.UseVisualStyleBackColor = false;
            this.btnDeleteFlight.Click += new System.EventHandler(this.btnDeleteFlight_Click);
            // 
            // dgvFlightSchedule
            // 
            this.dgvFlightSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlightSchedule.Location = new System.Drawing.Point(3, 318);
            this.dgvFlightSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFlightSchedule.Name = "dgvFlightSchedule";
            this.dgvFlightSchedule.RowHeadersWidth = 62;
            this.dgvFlightSchedule.RowTemplate.Height = 28;
            this.dgvFlightSchedule.Size = new System.Drawing.Size(884, 274);
            this.dgvFlightSchedule.TabIndex = 25;
            // 
            // numTicket1Qty
            // 
            this.numTicket1Qty.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTicket1Qty.Location = new System.Drawing.Point(266, 140);
            this.numTicket1Qty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numTicket1Qty.Name = "numTicket1Qty";
            this.numTicket1Qty.Size = new System.Drawing.Size(141, 32);
            this.numTicket1Qty.TabIndex = 26;
            this.numTicket1Qty.ValueChanged += new System.EventHandler(this.numT1Booked_ValueChanged);
            // 
            // numTicket2Qty
            // 
            this.numTicket2Qty.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTicket2Qty.Location = new System.Drawing.Point(266, 182);
            this.numTicket2Qty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numTicket2Qty.Name = "numTicket2Qty";
            this.numTicket2Qty.Size = new System.Drawing.Size(141, 32);
            this.numTicket2Qty.TabIndex = 27;
            // 
            // numT1Price
            // 
            this.numT1Price.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numT1Price.Location = new System.Drawing.Point(266, 220);
            this.numT1Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numT1Price.Name = "numT1Price";
            this.numT1Price.Size = new System.Drawing.Size(141, 32);
            this.numT1Price.TabIndex = 28;
            // 
            // numT1Booked
            // 
            this.numT1Booked.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numT1Booked.Location = new System.Drawing.Point(668, 140);
            this.numT1Booked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numT1Booked.Name = "numT1Booked";
            this.numT1Booked.Size = new System.Drawing.Size(143, 32);
            this.numT1Booked.TabIndex = 29;
            // 
            // numT2Booked
            // 
            this.numT2Booked.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numT2Booked.Location = new System.Drawing.Point(668, 182);
            this.numT2Booked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numT2Booked.Name = "numT2Booked";
            this.numT2Booked.Size = new System.Drawing.Size(143, 32);
            this.numT2Booked.TabIndex = 30;
            // 
            // numT2Price
            // 
            this.numT2Price.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numT2Price.Location = new System.Drawing.Point(668, 220);
            this.numT2Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numT2Price.Name = "numT2Price";
            this.numT2Price.Size = new System.Drawing.Size(143, 32);
            this.numT2Price.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã tuyến bay:";
            // 
            // cbRouteId
            // 
            this.cbRouteId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRouteId.FormattingEnabled = true;
            this.cbRouteId.Location = new System.Drawing.Point(435, 51);
            this.cbRouteId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRouteId.Name = "cbRouteId";
            this.cbRouteId.Size = new System.Drawing.Size(144, 32);
            this.cbRouteId.TabIndex = 12;
            // 
            // FlightScheduleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numT2Price);
            this.Controls.Add(this.numT2Booked);
            this.Controls.Add(this.numT1Booked);
            this.Controls.Add(this.numT1Price);
            this.Controls.Add(this.numTicket2Qty);
            this.Controls.Add(this.numTicket1Qty);
            this.Controls.Add(this.dgvFlightSchedule);
            this.Controls.Add(this.btnDeleteFlight);
            this.Controls.Add(this.btnAddFlight);
            this.Controls.Add(this.dtpArrival);
            this.Controls.Add(this.dtpDeparture);
            this.Controls.Add(this.cbRouteId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FlightScheduleManagement";
            this.Size = new System.Drawing.Size(890, 593);
            this.Load += new System.EventHandler(this.FlightManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlightSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTicket1Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTicket2Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT1Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT1Booked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT2Booked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT2Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDeparture;
        private System.Windows.Forms.DateTimePicker dtpArrival;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Button btnDeleteFlight;
        private System.Windows.Forms.DataGridView dgvFlightSchedule;
        private System.Windows.Forms.NumericUpDown numTicket1Qty;
        private System.Windows.Forms.NumericUpDown numTicket2Qty;
        private System.Windows.Forms.NumericUpDown numT1Price;
        private System.Windows.Forms.NumericUpDown numT1Booked;
        private System.Windows.Forms.NumericUpDown numT2Booked;
        private System.Windows.Forms.NumericUpDown numT2Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRouteId;
    }
}
