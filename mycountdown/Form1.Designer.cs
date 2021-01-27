namespace countdown
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RUN_BTN = new System.Windows.Forms.Button();
            this.M_BOX = new System.Windows.Forms.TextBox();
            this.S_BOX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.H_BOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.X_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RUN_BTN
            // 
            this.RUN_BTN.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RUN_BTN.Location = new System.Drawing.Point(151, 4);
            this.RUN_BTN.Name = "RUN_BTN";
            this.RUN_BTN.Size = new System.Drawing.Size(45, 28);
            this.RUN_BTN.TabIndex = 4;
            this.RUN_BTN.Text = "開始";
            this.RUN_BTN.UseVisualStyleBackColor = true;
            this.RUN_BTN.Click += new System.EventHandler(this.RUN_BTN_Click);
            this.RUN_BTN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RUN_BTN_MouseDown);
            // 
            // M_BOX
            // 
            this.M_BOX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.M_BOX.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.M_BOX.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.M_BOX.Location = new System.Drawing.Point(51, 4);
            this.M_BOX.MaxLength = 2;
            this.M_BOX.Name = "M_BOX";
            this.M_BOX.Size = new System.Drawing.Size(45, 32);
            this.M_BOX.TabIndex = 2;
            this.M_BOX.Text = "00";
            this.M_BOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.M_BOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.M_BOX_KeyPress);
            this.M_BOX.Leave += new System.EventHandler(this.M_BOX_Leave);
            this.M_BOX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.M_BOX_MouseDown);
            // 
            // S_BOX
            // 
            this.S_BOX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.S_BOX.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.S_BOX.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.S_BOX.Location = new System.Drawing.Point(113, 4);
            this.S_BOX.MaxLength = 2;
            this.S_BOX.Name = "S_BOX";
            this.S_BOX.Size = new System.Drawing.Size(45, 32);
            this.S_BOX.TabIndex = 3;
            this.S_BOX.Text = "00";
            this.S_BOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.S_BOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.S_BOX_KeyPress);
            this.S_BOX.Leave += new System.EventHandler(this.S_BOX_Leave);
            this.S_BOX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.S_BOX_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(87, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // H_BOX
            // 
            this.H_BOX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.H_BOX.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.H_BOX.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.H_BOX.Location = new System.Drawing.Point(0, 4);
            this.H_BOX.MaxLength = 2;
            this.H_BOX.Name = "H_BOX";
            this.H_BOX.Size = new System.Drawing.Size(45, 32);
            this.H_BOX.TabIndex = 1;
            this.H_BOX.Text = "00";
            this.H_BOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.H_BOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.H_BOX_KeyPress);
            this.H_BOX.Leave += new System.EventHandler(this.H_BOX_Leave);
            this.H_BOX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.H_BOX_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(31, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // X_BTN
            // 
            this.X_BTN.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.X_BTN.Location = new System.Drawing.Point(199, 4);
            this.X_BTN.Name = "X_BTN";
            this.X_BTN.Size = new System.Drawing.Size(28, 28);
            this.X_BTN.TabIndex = 5;
            this.X_BTN.Text = "X";
            this.X_BTN.UseVisualStyleBackColor = true;
            this.X_BTN.Click += new System.EventHandler(this.X_BTN_Click);
            this.X_BTN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.X_BTN_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(230, 28);
            this.ControlBox = false;
            this.Controls.Add(this.X_BTN);
            this.Controls.Add(this.RUN_BTN);
            this.Controls.Add(this.M_BOX);
            this.Controls.Add(this.S_BOX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.H_BOX);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox H_BOX;
        private System.Windows.Forms.TextBox S_BOX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox M_BOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RUN_BTN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button X_BTN;
    }
}

