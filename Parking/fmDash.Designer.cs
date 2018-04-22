namespace Parking
{
    partial class fmDash
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.SideP = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.usrReports1 = new Parking.usrReports();
            this.usrRecords2 = new Parking.usrRecords();
            this.usrDashboard2 = new Parking.usrDashboard();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.SideP);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 557);
            this.panel2.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Parking.Properties.Resources.report_2_24;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(12, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(211, 64);
            this.button5.TabIndex = 3;
            this.button5.Text = "     Reports";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // SideP
            // 
            this.SideP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SideP.Location = new System.Drawing.Point(0, 40);
            this.SideP.Name = "SideP";
            this.SideP.Size = new System.Drawing.Size(10, 64);
            this.SideP.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Parking.Properties.Resources.list_view_24;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "     Records";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Parking.Properties.Resources.home_5_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "     Dashboard";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.usrDashboard2);
            this.panel3.Controls.Add(this.usrReports1);
            this.panel3.Controls.Add(this.usrRecords2);
            this.panel3.Location = new System.Drawing.Point(223, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(915, 557);
            this.panel3.TabIndex = 2;
            // 
            // usrReports1
            // 
            this.usrReports1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.usrReports1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.usrReports1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.usrReports1.Location = new System.Drawing.Point(0, 0);
            this.usrReports1.Margin = new System.Windows.Forms.Padding(5);
            this.usrReports1.Name = "usrReports1";
            this.usrReports1.Size = new System.Drawing.Size(915, 557);
            this.usrReports1.TabIndex = 2;
            // 
            // usrRecords2
            // 
            this.usrRecords2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.usrRecords2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.usrRecords2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.usrRecords2.Location = new System.Drawing.Point(0, 0);
            this.usrRecords2.Margin = new System.Windows.Forms.Padding(5);
            this.usrRecords2.Name = "usrRecords2";
            this.usrRecords2.Size = new System.Drawing.Size(915, 557);
            this.usrRecords2.TabIndex = 1;
            // 
            // usrDashboard2
            // 
            this.usrDashboard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.usrDashboard2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrDashboard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.usrDashboard2.Location = new System.Drawing.Point(0, 0);
            this.usrDashboard2.Margin = new System.Windows.Forms.Padding(5);
            this.usrDashboard2.Name = "usrDashboard2";
            this.usrDashboard2.Size = new System.Drawing.Size(915, 557);
            this.usrDashboard2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1056, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 32);
            this.button3.TabIndex = 1;
            this.button3.Text = "__";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1094, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 32);
            this.button4.TabIndex = 2;
            this.button4.Text = "x";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Local Time : ";
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(379, 18);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(106, 23);
            this.txtTime.TabIndex = 4;
            this.txtTime.Text = "00 : 00 : 00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username :";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Location = new System.Drawing.Point(754, 18);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(63, 21);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.Text = "txtuser";
            // 
            // fmDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1138, 620);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fmDash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parking Manager";
            this.Load += new System.EventHandler(this.fmDash_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel SideP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private usrDashboard usrDashboard2;
        private usrReports usrReports1;
        private usrRecords usrRecords2;
    }
}