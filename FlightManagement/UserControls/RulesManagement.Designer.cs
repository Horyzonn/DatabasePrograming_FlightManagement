using System;

namespace FlightManagement.UserControls
{
    partial class RulesManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpDate = new System.Windows.Forms.Button();
            this.txtMinTimeFlight = new System.Windows.Forms.TextBox();
            this.txtTimeBuy = new System.Windows.Forms.TextBox();
            this.txtTimeBook = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaxQuantityBetweenAirport = new System.Windows.Forms.TextBox();
            this.txtMaxTimeStayAirport = new System.Windows.Forms.TextBox();
            this.txtMinTimeStayAirport = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpDate);
            this.panel1.Controls.Add(this.txtMinTimeStayAirport);
            this.panel1.Controls.Add(this.txtMaxTimeStayAirport);
            this.panel1.Controls.Add(this.txtMaxQuantityBetweenAirport);
            this.panel1.Controls.Add(this.txtMinTimeFlight);
            this.panel1.Controls.Add(this.txtTimeBuy);
            this.panel1.Controls.Add(this.txtTimeBook);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(63, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 673);
            this.panel1.TabIndex = 0;
            // 
            // btnUpDate
            // 
            this.btnUpDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.btnUpDate.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpDate.ForeColor = System.Drawing.Color.White;
            this.btnUpDate.Location = new System.Drawing.Point(76, 556);
            this.btnUpDate.Name = "btnUpDate";
            this.btnUpDate.Size = new System.Drawing.Size(206, 78);
            this.btnUpDate.TabIndex = 3;
            this.btnUpDate.Text = "Cập nhật";
            this.btnUpDate.UseVisualStyleBackColor = false;
            this.btnUpDate.Click += new System.EventHandler(this.btnUpDate_Click);
            // 
            // txtMinTimeFlight
            // 
            this.txtMinTimeFlight.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinTimeFlight.Location = new System.Drawing.Point(663, 123);
            this.txtMinTimeFlight.Name = "txtMinTimeFlight";
            this.txtMinTimeFlight.Size = new System.Drawing.Size(128, 32);
            this.txtMinTimeFlight.TabIndex = 2;
            // 
            // txtTimeBuy
            // 
            this.txtTimeBuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeBuy.Location = new System.Drawing.Point(663, 503);
            this.txtTimeBuy.Name = "txtTimeBuy";
            this.txtTimeBuy.Size = new System.Drawing.Size(128, 32);
            this.txtTimeBuy.TabIndex = 2;
            // 
            // txtTimeBook
            // 
            this.txtTimeBook.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeBook.Location = new System.Drawing.Point(663, 430);
            this.txtTimeBook.Name = "txtTimeBook";
            this.txtTimeBook.Size = new System.Drawing.Size(128, 32);
            this.txtTimeBook.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.label6.Location = new System.Drawing.Point(132, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 36);
            this.label6.TabIndex = 1;
            this.label6.Text = "QUY ĐỊNH CỦA CHUYẾN BAY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(540, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thời gian giới hạn thanh toán vé trước giờ khởi hành (phút)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đặt vé trước giờ khởi hành ít nhất (phút)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian tối thiểu của chuyến bay (phút)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số sân bay trung gian tối đa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(487, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thời gian dừng tối thiểu tại sân bay trung gian (phút)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(464, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thời gian dừng tối đa tại sân bay trung gian (phút)";
            // 
            // txtMaxQuantityBetweenAirport
            // 
            this.txtMaxQuantityBetweenAirport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxQuantityBetweenAirport.Location = new System.Drawing.Point(663, 198);
            this.txtMaxQuantityBetweenAirport.Name = "txtMaxQuantityBetweenAirport";
            this.txtMaxQuantityBetweenAirport.Size = new System.Drawing.Size(128, 32);
            this.txtMaxQuantityBetweenAirport.TabIndex = 2;
            // 
            // txtMaxTimeStayAirport
            // 
            this.txtMaxTimeStayAirport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxTimeStayAirport.Location = new System.Drawing.Point(663, 351);
            this.txtMaxTimeStayAirport.Name = "txtMaxTimeStayAirport";
            this.txtMaxTimeStayAirport.Size = new System.Drawing.Size(128, 32);
            this.txtMaxTimeStayAirport.TabIndex = 2;
            // 
            // txtMinTimeStayAirport
            // 
            this.txtMinTimeStayAirport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinTimeStayAirport.Location = new System.Drawing.Point(663, 276);
            this.txtMinTimeStayAirport.Name = "txtMinTimeStayAirport";
            this.txtMinTimeStayAirport.Size = new System.Drawing.Size(128, 32);
            this.txtMinTimeStayAirport.TabIndex = 2;
            // 
            // RulesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "RulesManagement";
            this.Size = new System.Drawing.Size(1070, 685);
            this.Load += new System.EventHandler(this.RulesManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinTimeFlight;
        private System.Windows.Forms.TextBox txtTimeBuy;
        private System.Windows.Forms.TextBox txtTimeBook;
        private System.Windows.Forms.Button btnUpDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMinTimeStayAirport;
        private System.Windows.Forms.TextBox txtMaxTimeStayAirport;
        private System.Windows.Forms.TextBox txtMaxQuantityBetweenAirport;

        public EventHandler button1_Click { get; private set; }
    }
}
