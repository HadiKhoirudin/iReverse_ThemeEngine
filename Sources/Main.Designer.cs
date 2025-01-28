
namespace iReverse_Theme_Engine
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.button_set_dark = new System.Windows.Forms.Button();
            this.textBox_example = new System.Windows.Forms.TextBox();
            this.button_set_light = new System.Windows.Forms.Button();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label_close = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_time = new System.Windows.Forms.Label();
            this.timer_time = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label_example = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_set_dark
            // 
            this.button_set_dark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_set_dark.Location = new System.Drawing.Point(9, 49);
            this.button_set_dark.Name = "button_set_dark";
            this.button_set_dark.Size = new System.Drawing.Size(75, 23);
            this.button_set_dark.TabIndex = 2;
            this.button_set_dark.Text = "Set Dark";
            this.button_set_dark.UseVisualStyleBackColor = true;
            this.button_set_dark.Click += new System.EventHandler(this.button_set_dark_Click);
            // 
            // textBox_example
            // 
            this.textBox_example.Location = new System.Drawing.Point(72, 231);
            this.textBox_example.Name = "textBox_example";
            this.textBox_example.Size = new System.Drawing.Size(317, 22);
            this.textBox_example.TabIndex = 1;
            this.textBox_example.Text = "Hello World";
            // 
            // button_set_light
            // 
            this.button_set_light.Enabled = false;
            this.button_set_light.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_set_light.Location = new System.Drawing.Point(713, 49);
            this.button_set_light.Name = "button_set_light";
            this.button_set_light.Size = new System.Drawing.Size(75, 23);
            this.button_set_light.TabIndex = 3;
            this.button_set_light.Text = "Set Light";
            this.button_set_light.UseVisualStyleBackColor = true;
            this.button_set_light.Click += new System.EventHandler(this.button_set_light_Click);
            // 
            // panel_header
            // 
            this.panel_header.Controls.Add(this.label_close);
            this.panel_header.Controls.Add(this.label_title);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(800, 34);
            this.panel_header.TabIndex = 2;
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.Font = new System.Drawing.Font("Nirmala UI", 14.25F);
            this.label_close.Location = new System.Drawing.Point(775, 4);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(21, 25);
            this.label_close.TabIndex = 5;
            this.label_close.Text = "x";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Nirmala UI", 14.25F);
            this.label_title.Location = new System.Drawing.Point(4, 5);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(310, 25);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "iReverse Theme Engine Example C#";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_time);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 33);
            this.panel1.TabIndex = 3;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(12, 11);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(39, 13);
            this.label_time.TabIndex = 4;
            this.label_time.Text = "Time : ";
            // 
            // timer_time
            // 
            this.timer_time.Enabled = true;
            this.timer_time.Interval = 1000;
            this.timer_time.Tick += new System.EventHandler(this.timer_time_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(409, 89);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(379, 322);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Hola....";
            // 
            // label_example
            // 
            this.label_example.AutoSize = true;
            this.label_example.Location = new System.Drawing.Point(8, 234);
            this.label_example.Name = "label_example";
            this.label_example.Size = new System.Drawing.Size(58, 13);
            this.label_example.TabIndex = 5;
            this.label_example.Text = "Example : ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_example);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.textBox_example);
            this.Controls.Add(this.button_set_light);
            this.Controls.Add(this.button_set_dark);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_set_dark;
        private System.Windows.Forms.TextBox textBox_example;
        private System.Windows.Forms.Button button_set_light;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer timer_time;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label_example;
    }
}

