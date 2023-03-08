namespace project2
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
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Operator = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(52, 56);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(100, 28);
            this.Num1.TabIndex = 1;
            this.Num1.TextChanged += new System.EventHandler(this.Num1_TextChanged);
            // 
            // Operator
            // 
            this.Operator.Location = new System.Drawing.Point(230, 56);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(100, 28);
            this.Operator.TabIndex = 2;
            this.Operator.TextChanged += new System.EventHandler(this.Operator_TextChanged);
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(395, 56);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(100, 28);
            this.Num2.TabIndex = 4;
            this.Num2.TextChanged += new System.EventHandler(this.Num2_TextChanged);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(628, 56);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 28);
            this.Result.TabIndex = 5;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(363, 214);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "计算";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Operator);
            this.Controls.Add(this.Num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.TextBox Operator;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Calculate;
    }
}

