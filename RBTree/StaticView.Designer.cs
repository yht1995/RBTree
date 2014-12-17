namespace RBTree
{
    partial class StaticView
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxAverage = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxVariance = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生总数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "平均值";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "极值";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "方差";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(130, 38);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.ReadOnly = true;
            this.textBoxCount.Size = new System.Drawing.Size(100, 21);
            this.textBoxCount.TabIndex = 1;
            // 
            // textBoxAverage
            // 
            this.textBoxAverage.Location = new System.Drawing.Point(130, 87);
            this.textBoxAverage.Name = "textBoxAverage";
            this.textBoxAverage.ReadOnly = true;
            this.textBoxAverage.Size = new System.Drawing.Size(100, 21);
            this.textBoxAverage.TabIndex = 1;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(130, 136);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.ReadOnly = true;
            this.textBoxMin.Size = new System.Drawing.Size(41, 21);
            this.textBoxMin.TabIndex = 1;
            // 
            // textBoxVariance
            // 
            this.textBoxVariance.Location = new System.Drawing.Point(130, 185);
            this.textBoxVariance.Name = "textBoxVariance";
            this.textBoxVariance.ReadOnly = true;
            this.textBoxVariance.Size = new System.Drawing.Size(100, 21);
            this.textBoxVariance.TabIndex = 1;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(189, 136);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.ReadOnly = true;
            this.textBoxMax.Size = new System.Drawing.Size(41, 21);
            this.textBoxMax.TabIndex = 1;
            // 
            // StaticView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 246);
            this.Controls.Add(this.textBoxVariance);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxAverage);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StaticView";
            this.Text = "统计信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxAverage;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxVariance;
        private System.Windows.Forms.TextBox textBoxMax;
    }
}