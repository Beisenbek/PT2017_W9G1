namespace CalculatorApp
{
    partial class Form1
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
            this.display = new System.Windows.Forms.TextBox();
            this.digit7 = new System.Windows.Forms.Button();
            this.digit8 = new System.Windows.Forms.Button();
            this.digit9 = new System.Windows.Forms.Button();
            this.operationplus = new System.Windows.Forms.Button();
            this.operationequal = new System.Windows.Forms.Button();
            this.digit6 = new System.Windows.Forms.Button();
            this.digit5 = new System.Windows.Forms.Button();
            this.digit4 = new System.Windows.Forms.Button();
            this.digit0 = new System.Windows.Forms.Button();
            this.digit3 = new System.Windows.Forms.Button();
            this.digit2 = new System.Windows.Forms.Button();
            this.digit1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(99, 58);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(539, 106);
            this.display.TabIndex = 0;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // digit7
            // 
            this.digit7.Location = new System.Drawing.Point(99, 227);
            this.digit7.Name = "digit7";
            this.digit7.Size = new System.Drawing.Size(83, 107);
            this.digit7.TabIndex = 1;
            this.digit7.Text = "7";
            this.digit7.UseVisualStyleBackColor = true;
            this.digit7.Click += new System.EventHandler(this.digit_Click);
            // 
            // digit8
            // 
            this.digit8.Location = new System.Drawing.Point(260, 227);
            this.digit8.Name = "digit8";
            this.digit8.Size = new System.Drawing.Size(83, 107);
            this.digit8.TabIndex = 2;
            this.digit8.Text = "8";
            this.digit8.UseVisualStyleBackColor = true;
            this.digit8.Click += new System.EventHandler(this.digit_Click);
            // 
            // digit9
            // 
            this.digit9.Location = new System.Drawing.Point(422, 227);
            this.digit9.Name = "digit9";
            this.digit9.Size = new System.Drawing.Size(83, 107);
            this.digit9.TabIndex = 3;
            this.digit9.Text = "9";
            this.digit9.UseVisualStyleBackColor = true;
            this.digit9.Click += new System.EventHandler(this.digit_Click);
            // 
            // operationplus
            // 
            this.operationplus.Location = new System.Drawing.Point(579, 227);
            this.operationplus.Name = "operationplus";
            this.operationplus.Size = new System.Drawing.Size(83, 107);
            this.operationplus.TabIndex = 4;
            this.operationplus.Text = "+";
            this.operationplus.UseVisualStyleBackColor = true;
            this.operationplus.Click += new System.EventHandler(this.operation_Click);
            // 
            // operationequal
            // 
            this.operationequal.Location = new System.Drawing.Point(579, 429);
            this.operationequal.Name = "operationequal";
            this.operationequal.Size = new System.Drawing.Size(83, 107);
            this.operationequal.TabIndex = 8;
            this.operationequal.Text = "=";
            this.operationequal.UseVisualStyleBackColor = true;
            this.operationequal.Click += new System.EventHandler(this.operation_Click);
            // 
            // digit6
            // 
            this.digit6.Location = new System.Drawing.Point(422, 429);
            this.digit6.Name = "digit6";
            this.digit6.Size = new System.Drawing.Size(83, 107);
            this.digit6.TabIndex = 7;
            this.digit6.Text = "6";
            this.digit6.UseVisualStyleBackColor = true;
            this.digit6.Click += new System.EventHandler(this.digit_Click);
            // 
            // digit5
            // 
            this.digit5.Location = new System.Drawing.Point(260, 429);
            this.digit5.Name = "digit5";
            this.digit5.Size = new System.Drawing.Size(83, 107);
            this.digit5.TabIndex = 6;
            this.digit5.Text = "5";
            this.digit5.UseVisualStyleBackColor = true;
            this.digit5.Click += new System.EventHandler(this.digit_Click);
            // 
            // digit4
            // 
            this.digit4.Location = new System.Drawing.Point(99, 429);
            this.digit4.Name = "digit4";
            this.digit4.Size = new System.Drawing.Size(83, 107);
            this.digit4.TabIndex = 5;
            this.digit4.Text = "4";
            this.digit4.UseVisualStyleBackColor = true;
            this.digit4.Click += new System.EventHandler(this.digit_Click);
            // 
            // digit0
            // 
            this.digit0.Location = new System.Drawing.Point(579, 620);
            this.digit0.Name = "digit0";
            this.digit0.Size = new System.Drawing.Size(83, 107);
            this.digit0.TabIndex = 12;
            this.digit0.Text = "0";
            this.digit0.UseVisualStyleBackColor = true;
            this.digit0.Click += new System.EventHandler(this.digit_Click);
            // 
            // digit3
            // 
            this.digit3.Location = new System.Drawing.Point(422, 620);
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(83, 107);
            this.digit3.TabIndex = 11;
            this.digit3.Text = "3";
            this.digit3.UseVisualStyleBackColor = true;
            this.digit3.Click += new System.EventHandler(this.digit_Click);
            // 
            // digit2
            // 
            this.digit2.Location = new System.Drawing.Point(260, 620);
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(83, 107);
            this.digit2.TabIndex = 10;
            this.digit2.Text = "2";
            this.digit2.UseVisualStyleBackColor = true;
            this.digit2.Click += new System.EventHandler(this.digit_Click);
            // 
            // digit1
            // 
            this.digit1.Location = new System.Drawing.Point(99, 620);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(83, 107);
            this.digit1.TabIndex = 9;
            this.digit1.Text = "1";
            this.digit1.UseVisualStyleBackColor = true;
            this.digit1.Click += new System.EventHandler(this.digit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 763);
            this.Controls.Add(this.digit0);
            this.Controls.Add(this.digit3);
            this.Controls.Add(this.digit2);
            this.Controls.Add(this.digit1);
            this.Controls.Add(this.operationequal);
            this.Controls.Add(this.digit6);
            this.Controls.Add(this.digit5);
            this.Controls.Add(this.digit4);
            this.Controls.Add(this.operationplus);
            this.Controls.Add(this.digit9);
            this.Controls.Add(this.digit8);
            this.Controls.Add(this.digit7);
            this.Controls.Add(this.display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button digit7;
        private System.Windows.Forms.Button digit8;
        private System.Windows.Forms.Button digit9;
        private System.Windows.Forms.Button operationplus;
        private System.Windows.Forms.Button operationequal;
        private System.Windows.Forms.Button digit6;
        private System.Windows.Forms.Button digit5;
        private System.Windows.Forms.Button digit4;
        private System.Windows.Forms.Button digit0;
        private System.Windows.Forms.Button digit3;
        private System.Windows.Forms.Button digit2;
        private System.Windows.Forms.Button digit1;
    }
}

