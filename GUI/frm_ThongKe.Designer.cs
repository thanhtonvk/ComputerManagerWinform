namespace Quan_ly_cua_hang.GUI
{
    partial class frm_ThongKe
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
            this.dgv_doanhthu = new System.Windows.Forms.DataGridView();
            this.dgv_banchay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tukhoa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhthu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_banchay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_doanhthu
            // 
            this.dgv_doanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doanhthu.Location = new System.Drawing.Point(12, 176);
            this.dgv_doanhthu.Name = "dgv_doanhthu";
            this.dgv_doanhthu.Size = new System.Drawing.Size(394, 282);
            this.dgv_doanhthu.TabIndex = 0;
            // 
            // dgv_banchay
            // 
            this.dgv_banchay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_banchay.Location = new System.Drawing.Point(521, 176);
            this.dgv_banchay.Name = "dgv_banchay";
            this.dgv_banchay.Size = new System.Drawing.Size(373, 282);
            this.dgv_banchay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thống kê";
            // 
            // tb_tukhoa
            // 
            this.tb_tukhoa.Location = new System.Drawing.Point(12, 150);
            this.tb_tukhoa.Name = "tb_tukhoa";
            this.tb_tukhoa.Size = new System.Drawing.Size(313, 20);
            this.tb_tukhoa.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doanh thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(655, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bán chạy";
            // 
            // frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 470);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_tukhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_banchay);
            this.Controls.Add(this.dgv_doanhthu);
            this.Name = "frm_ThongKe";
            this.Text = "frm_ThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhthu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_banchay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_doanhthu;
        private System.Windows.Forms.DataGridView dgv_banchay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tukhoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}