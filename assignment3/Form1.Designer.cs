namespace assignment3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.weight_txt = new System.Windows.Forms.TextBox();
            this.height_txt = new System.Windows.Forms.TextBox();
            this.calculate_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.result_box = new System.Windows.Forms.TextBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Weight (pounds):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height (inches):";
            // 
            // weight_txt
            // 
            this.weight_txt.Location = new System.Drawing.Point(149, 26);
            this.weight_txt.Name = "weight_txt";
            this.weight_txt.Size = new System.Drawing.Size(100, 20);
            this.weight_txt.TabIndex = 5;
            // 
            // height_txt
            // 
            this.height_txt.Location = new System.Drawing.Point(149, 66);
            this.height_txt.Name = "height_txt";
            this.height_txt.Size = new System.Drawing.Size(100, 20);
            this.height_txt.TabIndex = 6;
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(297, 26);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(75, 23);
            this.calculate_button.TabIndex = 7;
            this.calculate_button.Text = "Calculate";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result";
            // 
            // result_box
            // 
            this.result_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.result_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_box.Location = new System.Drawing.Point(53, 115);
            this.result_box.Multiline = true;
            this.result_box.Name = "result_box";
            this.result_box.Size = new System.Drawing.Size(252, 55);
            this.result_box.TabIndex = 9;
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(297, 63);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 10;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 182);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.result_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.height_txt);
            this.Controls.Add(this.weight_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox weight_txt;
        private System.Windows.Forms.TextBox height_txt;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox result_box;
        private System.Windows.Forms.Button reset_btn;
    }
}

