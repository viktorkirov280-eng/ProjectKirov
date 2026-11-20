namespace ProjectKirov
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtFac = new System.Windows.Forms.TextBox();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbStream1 = new System.Windows.Forms.RadioButton();
            this.rbStream2 = new System.Windows.Forms.RadioButton();
            this.chkActivity = new System.Windows.Forms.CheckBox();
            this.chkCourse = new System.Windows.Forms.CheckBox();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фак. номер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Име:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Точки (0-100):";
            // 
            // txtFac
            // 
            this.txtFac.Location = new System.Drawing.Point(359, 38);
            this.txtFac.Name = "txtFac";
            this.txtFac.Size = new System.Drawing.Size(100, 22);
            this.txtFac.TabIndex = 3;
            this.txtFac.TextChanged += new System.EventHandler(this.txtFac_TextChanged);
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(359, 97);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(100, 22);
            this.txtPoints.TabIndex = 4;
            this.txtPoints.TextChanged += new System.EventHandler(this.txtPoints_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(359, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbStream2);
            this.groupBox1.Controls.Add(this.rbStream1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 81);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поток";
            // 
            // rbStream1
            // 
            this.rbStream1.AutoSize = true;
            this.rbStream1.Checked = true;
            this.rbStream1.Location = new System.Drawing.Point(6, 28);
            this.rbStream1.Name = "rbStream1";
            this.rbStream1.Size = new System.Drawing.Size(78, 20);
            this.rbStream1.TabIndex = 7;
            this.rbStream1.TabStop = true;
            this.rbStream1.Text = "Поток 1";
            this.rbStream1.UseVisualStyleBackColor = true;
            this.rbStream1.CheckedChanged += new System.EventHandler(this.rbStream1_CheckedChanged);
            // 
            // rbStream2
            // 
            this.rbStream2.AutoSize = true;
            this.rbStream2.Location = new System.Drawing.Point(6, 54);
            this.rbStream2.Name = "rbStream2";
            this.rbStream2.Size = new System.Drawing.Size(78, 20);
            this.rbStream2.TabIndex = 8;
            this.rbStream2.Text = "Поток 2";
            this.rbStream2.UseVisualStyleBackColor = true;
            this.rbStream2.CheckedChanged += new System.EventHandler(this.rbStream2_CheckedChanged);
            // 
            // chkActivity
            // 
            this.chkActivity.AutoSize = true;
            this.chkActivity.Location = new System.Drawing.Point(18, 99);
            this.chkActivity.Name = "chkActivity";
            this.chkActivity.Size = new System.Drawing.Size(179, 20);
            this.chkActivity.TabIndex = 7;
            this.chkActivity.Text = "Активно участие (+5 т.)";
            this.chkActivity.UseVisualStyleBackColor = true;
            this.chkActivity.CheckedChanged += new System.EventHandler(this.chkActivity_CheckedChanged);
            // 
            // chkCourse
            // 
            this.chkCourse.AutoSize = true;
            this.chkCourse.Location = new System.Drawing.Point(18, 125);
            this.chkCourse.Name = "chkCourse";
            this.chkCourse.Size = new System.Drawing.Size(172, 20);
            this.chkCourse.TabIndex = 8;
            this.chkCourse.Text = "Курсова работа (+ 5т.)";
            this.chkCourse.UseVisualStyleBackColor = true;
            this.chkCourse.CheckedChanged += new System.EventHandler(this.chkCourse_CheckedChanged);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(21, 163);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(169, 23);
            this.btnEvaluate.TabIndex = 9;
            this.btnEvaluate.Text = "Оцени студент";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(21, 203);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(169, 23);
            this.btnSummary.TabIndex = 10;
            this.btnSummary.Text = "Обобщена справка";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 16;
            this.lstStudents.Location = new System.Drawing.Point(390, 226);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(398, 212);
            this.lstStudents.TabIndex = 11;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(18, 325);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(83, 16);
            this.lblSummary.TabIndex = 12;
            this.lblSummary.Text = "Статистика";
            this.lblSummary.Click += new System.EventHandler(this.lblSummary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.chkCourse);
            this.Controls.Add(this.chkActivity);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.txtFac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Виктор Киров - f123963";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFac;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbStream1;
        private System.Windows.Forms.RadioButton rbStream2;
        private System.Windows.Forms.CheckBox chkActivity;
        private System.Windows.Forms.CheckBox chkCourse;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Label lblSummary;
    }
}

