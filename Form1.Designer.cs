namespace ArgoSL
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.line3 = new System.Windows.Forms.Label();
            this.destination1 = new System.Windows.Forms.Label();
            this.destination2 = new System.Windows.Forms.Label();
            this.destination3 = new System.Windows.Forms.Label();
            this.time1 = new System.Windows.Forms.Label();
            this.time2 = new System.Windows.Forms.Label();
            this.time3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Station Id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get realtime info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "LineNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Destination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Time";
            // 
            // line1
            // 
            this.line1.AutoSize = true;
            this.line1.Location = new System.Drawing.Point(25, 111);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(33, 13);
            this.line1.TabIndex = 7;
            this.line1.Text = "Line1";
            this.line1.Visible = false;
            // 
            // line2
            // 
            this.line2.AutoSize = true;
            this.line2.Location = new System.Drawing.Point(25, 133);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(33, 13);
            this.line2.TabIndex = 8;
            this.line2.Text = "Line1";
            this.line2.Visible = false;
            // 
            // line3
            // 
            this.line3.AutoSize = true;
            this.line3.Location = new System.Drawing.Point(25, 156);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(33, 13);
            this.line3.TabIndex = 9;
            this.line3.Text = "Line3";
            this.line3.Visible = false;
            // 
            // destination1
            // 
            this.destination1.AutoSize = true;
            this.destination1.Location = new System.Drawing.Point(90, 111);
            this.destination1.Name = "destination1";
            this.destination1.Size = new System.Drawing.Size(66, 13);
            this.destination1.TabIndex = 10;
            this.destination1.Text = "Destination1";
            this.destination1.Visible = false;
            // 
            // destination2
            // 
            this.destination2.AutoSize = true;
            this.destination2.Location = new System.Drawing.Point(90, 133);
            this.destination2.Name = "destination2";
            this.destination2.Size = new System.Drawing.Size(66, 13);
            this.destination2.TabIndex = 11;
            this.destination2.Text = "Destination2";
            this.destination2.Visible = false;
            // 
            // destination3
            // 
            this.destination3.AutoSize = true;
            this.destination3.Location = new System.Drawing.Point(90, 156);
            this.destination3.Name = "destination3";
            this.destination3.Size = new System.Drawing.Size(66, 13);
            this.destination3.TabIndex = 12;
            this.destination3.Text = "Destination3";
            this.destination3.Visible = false;
            // 
            // time1
            // 
            this.time1.AutoSize = true;
            this.time1.Location = new System.Drawing.Point(232, 110);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(36, 13);
            this.time1.TabIndex = 13;
            this.time1.Text = "Time1";
            this.time1.Visible = false;
            // 
            // time2
            // 
            this.time2.AutoSize = true;
            this.time2.Location = new System.Drawing.Point(232, 133);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(36, 13);
            this.time2.TabIndex = 14;
            this.time2.Text = "Time2";
            this.time2.Visible = false;
            // 
            // time3
            // 
            this.time3.AutoSize = true;
            this.time3.Location = new System.Drawing.Point(232, 156);
            this.time3.Name = "time3";
            this.time3.Size = new System.Drawing.Size(36, 13);
            this.time3.TabIndex = 15;
            this.time3.Text = "Time3";
            this.time3.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(828, 497);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.time3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.time2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.time1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.destination3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.destination2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.destination1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.line3);
            this.tabPage1.Controls.Add(this.line1);
            this.tabPage1.Controls.Add(this.line2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(820, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Realtime info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(820, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Station search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 521);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.Label line3;
        private System.Windows.Forms.Label destination1;
        private System.Windows.Forms.Label destination2;
        private System.Windows.Forms.Label destination3;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Label time2;
        private System.Windows.Forms.Label time3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

