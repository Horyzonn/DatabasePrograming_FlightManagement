namespace FlightManagement.User_Control
{
    partial class RouteManagement
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
            this.cbDepAirport = new System.Windows.Forms.ComboBox();
            this.cbArrAirport = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddRoute = new System.Windows.Forms.Button();
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAirportCode = new System.Windows.Forms.TextBox();
            this.txtAirportName = new System.Windows.Forms.TextBox();
            this.txtAirportLoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý tuyến bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ";
            // 
            // cbDepAirport
            // 
            this.cbDepAirport.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepAirport.FormattingEnabled = true;
            this.cbDepAirport.Location = new System.Drawing.Point(95, 196);
            this.cbDepAirport.Name = "cbDepAirport";
            this.cbDepAirport.Size = new System.Drawing.Size(251, 36);
            this.cbDepAirport.TabIndex = 2;
            // 
            // cbArrAirport
            // 
            this.cbArrAirport.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArrAirport.FormattingEnabled = true;
            this.cbArrAirport.Location = new System.Drawing.Point(495, 196);
            this.cbArrAirport.Name = "cbArrAirport";
            this.cbArrAirport.Size = new System.Drawing.Size(251, 36);
            this.cbArrAirport.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đến";
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.btnAddRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoute.ForeColor = System.Drawing.Color.White;
            this.btnAddRoute.Location = new System.Drawing.Point(797, 191);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(184, 46);
            this.btnAddRoute.TabIndex = 5;
            this.btnAddRoute.Text = "Thêm tuyến bay";
            this.btnAddRoute.UseVisualStyleBackColor = false;
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.btnAddAirport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAirport.ForeColor = System.Drawing.Color.White;
            this.btnAddAirport.Location = new System.Drawing.Point(797, 107);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(184, 46);
            this.btnAddAirport.TabIndex = 10;
            this.btnAddAirport.Text = "Thêm sân bay";
            this.btnAddAirport.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã";
            // 
            // txtAirportCode
            // 
            this.txtAirportCode.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAirportCode.Location = new System.Drawing.Point(82, 112);
            this.txtAirportCode.Name = "txtAirportCode";
            this.txtAirportCode.Size = new System.Drawing.Size(117, 35);
            this.txtAirportCode.TabIndex = 11;
            // 
            // txtAirportName
            // 
            this.txtAirportName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAirportName.Location = new System.Drawing.Point(261, 112);
            this.txtAirportName.Name = "txtAirportName";
            this.txtAirportName.Size = new System.Drawing.Size(197, 35);
            this.txtAirportName.TabIndex = 12;
            // 
            // txtAirportLoc
            // 
            this.txtAirportLoc.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAirportLoc.Location = new System.Drawing.Point(557, 112);
            this.txtAirportLoc.Name = "txtAirportLoc";
            this.txtAirportLoc.Size = new System.Drawing.Size(189, 35);
            this.txtAirportLoc.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vị trí";
            // 
            // RouteManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtAirportLoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAirportName);
            this.Controls.Add(this.txtAirportCode);
            this.Controls.Add(this.btnAddAirport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddRoute);
            this.Controls.Add(this.cbArrAirport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDepAirport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RouteManagement";
            this.Size = new System.Drawing.Size(1055, 562);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDepAirport;
        private System.Windows.Forms.ComboBox cbArrAirport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddRoute;
        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAirportCode;
        private System.Windows.Forms.TextBox txtAirportName;
        private System.Windows.Forms.TextBox txtAirportLoc;
        private System.Windows.Forms.Label label6;
    }
}
