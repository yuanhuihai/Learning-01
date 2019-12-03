namespace Learning_01
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plcIp = new System.Windows.Forms.TextBox();
            this.plcRack = new System.Windows.Forms.TextBox();
            this.PlcSlot = new System.Windows.Forms.TextBox();
            this.DB块 = new System.Windows.Forms.Label();
            this.DBNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DBWNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.execResult = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.writeValue = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "机架号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "插  槽";
            // 
            // plcIp
            // 
            this.plcIp.Location = new System.Drawing.Point(79, 36);
            this.plcIp.Name = "plcIp";
            this.plcIp.Size = new System.Drawing.Size(133, 21);
            this.plcIp.TabIndex = 4;
            // 
            // plcRack
            // 
            this.plcRack.Location = new System.Drawing.Point(79, 64);
            this.plcRack.Name = "plcRack";
            this.plcRack.Size = new System.Drawing.Size(33, 21);
            this.plcRack.TabIndex = 5;
            // 
            // PlcSlot
            // 
            this.PlcSlot.Location = new System.Drawing.Point(180, 63);
            this.PlcSlot.Name = "PlcSlot";
            this.PlcSlot.Size = new System.Drawing.Size(32, 21);
            this.PlcSlot.TabIndex = 6;
            // 
            // DB块
            // 
            this.DB块.AutoSize = true;
            this.DB块.Location = new System.Drawing.Point(36, 111);
            this.DB块.Name = "DB块";
            this.DB块.Size = new System.Drawing.Size(29, 12);
            this.DB块.TabIndex = 8;
            this.DB块.Text = "DB块";
            // 
            // DBNum
            // 
            this.DBNum.Location = new System.Drawing.Point(79, 108);
            this.DBNum.Name = "DBNum";
            this.DBNum.Size = new System.Drawing.Size(33, 21);
            this.DBNum.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "DBW字";
            // 
            // DBWNum
            // 
            this.DBWNum.Location = new System.Drawing.Point(171, 108);
            this.DBWNum.Name = "DBWNum";
            this.DBWNum.Size = new System.Drawing.Size(40, 21);
            this.DBWNum.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "执行结果";
            // 
            // execResult
            // 
            this.execResult.Location = new System.Drawing.Point(96, 169);
            this.execResult.Name = "execResult";
            this.execResult.Size = new System.Drawing.Size(85, 21);
            this.execResult.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "读";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "写入值";
            // 
            // writeValue
            // 
            this.writeValue.Location = new System.Drawing.Point(83, 135);
            this.writeValue.Name = "writeValue";
            this.writeValue.Size = new System.Drawing.Size(29, 21);
            this.writeValue.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(245, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "写";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.writeValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.execResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DBWNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DBNum);
            this.Controls.Add(this.DB块);
            this.Controls.Add(this.PlcSlot);
            this.Controls.Add(this.plcRack);
            this.Controls.Add(this.plcIp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox plcIp;
        private System.Windows.Forms.TextBox plcRack;
        private System.Windows.Forms.TextBox PlcSlot;
        private System.Windows.Forms.Label DB块;
        private System.Windows.Forms.TextBox DBNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DBWNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox execResult;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox writeValue;
        private System.Windows.Forms.Button button3;
    }
}

