namespace RBTree
{
    partial class RBTreeView
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxRBTree = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRand = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonTraversalB = new System.Windows.Forms.Button();
            this.buttonTraversalA = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxScoreH = new System.Windows.Forms.TextBox();
            this.textBoxScoreL = new System.Windows.Forms.TextBox();
            this.comboBoxRateS = new System.Windows.Forms.ComboBox();
            this.radioButtonScore = new System.Windows.Forms.RadioButton();
            this.radioButtonRate = new System.Windows.Forms.RadioButton();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonID = new System.Windows.Forms.RadioButton();
            this.textBoxNameS = new System.Windows.Forms.TextBox();
            this.textBoxIDS = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRBTree
            // 
            this.groupBoxRBTree.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRBTree.Name = "groupBoxRBTree";
            this.groupBoxRBTree.Size = new System.Drawing.Size(767, 423);
            this.groupBoxRBTree.TabIndex = 0;
            this.groupBoxRBTree.TabStop = false;
            this.groupBoxRBTree.Text = "红黑树";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRand);
            this.groupBox2.Controls.Add(this.buttonDel);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.textBoxScore);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxID);
            this.groupBox2.Controls.Add(this.textBoxName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(96, 441);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // buttonRand
            // 
            this.buttonRand.Location = new System.Drawing.Point(27, 101);
            this.buttonRand.Name = "buttonRand";
            this.buttonRand.Size = new System.Drawing.Size(75, 23);
            this.buttonRand.TabIndex = 3;
            this.buttonRand.Text = "随机生成";
            this.buttonRand.UseVisualStyleBackColor = true;
            this.buttonRand.Click += new System.EventHandler(this.buttonRand_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(186, 66);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "删除学生";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(186, 18);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "添加学生";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(60, 74);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(62, 21);
            this.textBoxScore.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "成绩";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(60, 47);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 21);
            this.textBoxID.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(60, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(62, 21);
            this.textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "学号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonTraversalB);
            this.groupBox3.Controls.Add(this.buttonTraversalA);
            this.groupBox3.Location = new System.Drawing.Point(369, 442);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(105, 137);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "遍历";
            // 
            // buttonTraversalB
            // 
            this.buttonTraversalB.Location = new System.Drawing.Point(15, 66);
            this.buttonTraversalB.Name = "buttonTraversalB";
            this.buttonTraversalB.Size = new System.Drawing.Size(75, 23);
            this.buttonTraversalB.TabIndex = 1;
            this.buttonTraversalB.Text = "层次遍历";
            this.buttonTraversalB.UseVisualStyleBackColor = true;
            // 
            // buttonTraversalA
            // 
            this.buttonTraversalA.Location = new System.Drawing.Point(15, 20);
            this.buttonTraversalA.Name = "buttonTraversalA";
            this.buttonTraversalA.Size = new System.Drawing.Size(75, 23);
            this.buttonTraversalA.TabIndex = 0;
            this.buttonTraversalA.Text = "中序遍历";
            this.buttonTraversalA.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSearch);
            this.groupBox4.Controls.Add(this.textBoxScoreH);
            this.groupBox4.Controls.Add(this.textBoxScoreL);
            this.groupBox4.Controls.Add(this.comboBoxRateS);
            this.groupBox4.Controls.Add(this.radioButtonScore);
            this.groupBox4.Controls.Add(this.radioButtonRate);
            this.groupBox4.Controls.Add(this.radioButtonName);
            this.groupBox4.Controls.Add(this.radioButtonID);
            this.groupBox4.Controls.Add(this.textBoxNameS);
            this.groupBox4.Controls.Add(this.textBoxIDS);
            this.groupBox4.Location = new System.Drawing.Point(480, 441);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 137);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "检索";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(182, 65);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(57, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "检索";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxScoreH
            // 
            this.textBoxScoreH.Location = new System.Drawing.Point(136, 89);
            this.textBoxScoreH.Name = "textBoxScoreH";
            this.textBoxScoreH.Size = new System.Drawing.Size(23, 21);
            this.textBoxScoreH.TabIndex = 3;
            // 
            // textBoxScoreL
            // 
            this.textBoxScoreL.Location = new System.Drawing.Point(97, 89);
            this.textBoxScoreL.Name = "textBoxScoreL";
            this.textBoxScoreL.Size = new System.Drawing.Size(23, 21);
            this.textBoxScoreL.TabIndex = 3;
            // 
            // comboBoxRateS
            // 
            this.comboBoxRateS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRateS.FormattingEnabled = true;
            this.comboBoxRateS.Location = new System.Drawing.Point(97, 67);
            this.comboBoxRateS.Name = "comboBoxRateS";
            this.comboBoxRateS.Size = new System.Drawing.Size(62, 20);
            this.comboBoxRateS.TabIndex = 2;
            // 
            // radioButtonScore
            // 
            this.radioButtonScore.AutoSize = true;
            this.radioButtonScore.Location = new System.Drawing.Point(6, 89);
            this.radioButtonScore.Name = "radioButtonScore";
            this.radioButtonScore.Size = new System.Drawing.Size(71, 16);
            this.radioButtonScore.TabIndex = 0;
            this.radioButtonScore.TabStop = true;
            this.radioButtonScore.Text = "分数范围";
            this.radioButtonScore.UseVisualStyleBackColor = true;
            // 
            // radioButtonRate
            // 
            this.radioButtonRate.AutoSize = true;
            this.radioButtonRate.Location = new System.Drawing.Point(6, 67);
            this.radioButtonRate.Name = "radioButtonRate";
            this.radioButtonRate.Size = new System.Drawing.Size(59, 16);
            this.radioButtonRate.TabIndex = 0;
            this.radioButtonRate.TabStop = true;
            this.radioButtonRate.Text = "成绩段";
            this.radioButtonRate.UseVisualStyleBackColor = true;
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(6, 45);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(47, 16);
            this.radioButtonName.TabIndex = 0;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "姓名";
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // radioButtonID
            // 
            this.radioButtonID.AutoSize = true;
            this.radioButtonID.Location = new System.Drawing.Point(6, 23);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Size = new System.Drawing.Size(47, 16);
            this.radioButtonID.TabIndex = 0;
            this.radioButtonID.TabStop = true;
            this.radioButtonID.Text = "学号";
            this.radioButtonID.UseVisualStyleBackColor = true;
            // 
            // textBoxNameS
            // 
            this.textBoxNameS.Location = new System.Drawing.Point(97, 44);
            this.textBoxNameS.Name = "textBoxNameS";
            this.textBoxNameS.Size = new System.Drawing.Size(62, 21);
            this.textBoxNameS.TabIndex = 1;
            // 
            // textBoxIDS
            // 
            this.textBoxIDS.Location = new System.Drawing.Point(97, 20);
            this.textBoxIDS.Name = "textBoxIDS";
            this.textBoxIDS.Size = new System.Drawing.Size(100, 21);
            this.textBoxIDS.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonExport);
            this.groupBox5.Controls.Add(this.buttonImport);
            this.groupBox5.Location = new System.Drawing.Point(13, 442);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(77, 135);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "文件操作";
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(7, 59);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(61, 23);
            this.buttonExport.TabIndex = 0;
            this.buttonExport.Text = "导出";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(7, 30);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(61, 23);
            this.buttonImport.TabIndex = 0;
            this.buttonImport.Text = "导入";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // RBTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 599);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxRBTree);
            this.Name = "RBTreeView";
            this.Text = " ";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRBTree;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRand;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonTraversalB;
        private System.Windows.Forms.Button buttonTraversalA;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonScore;
        private System.Windows.Forms.RadioButton radioButtonRate;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonID;
        private System.Windows.Forms.TextBox textBoxNameS;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxScoreH;
        private System.Windows.Forms.TextBox textBoxScoreL;
        private System.Windows.Forms.ComboBox comboBoxRateS;
        private System.Windows.Forms.TextBox textBoxIDS;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

