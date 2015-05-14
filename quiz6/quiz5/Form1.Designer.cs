namespace quiz5
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxShape = new System.Windows.Forms.ComboBox();
            this.txtPara2 = new System.Windows.Forms.TextBox();
            this.txtPara1 = new System.Windows.Forms.TextBox();
            this.lblPara2 = new System.Windows.Forms.Label();
            this.lblPara1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtProperty = new System.Windows.Forms.TextBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.btnCompute = new System.Windows.Forms.Button();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.radioButtonInecrease = new System.Windows.Forms.RadioButton();
            this.radioButtonDecrease = new System.Windows.Forms.RadioButton();
            this.groupBoxSortTheShape = new System.Windows.Forms.GroupBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxSortTheShape.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxMaterial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "材質設定";
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Items.AddRange(new object[] {
            "鋁",
            "鐵",
            "鉛"});
            this.comboBoxMaterial.Location = new System.Drawing.Point(90, 31);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(207, 20);
            this.comboBoxMaterial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "材質類別";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxShape);
            this.groupBox2.Controls.Add(this.txtPara2);
            this.groupBox2.Controls.Add(this.txtPara1);
            this.groupBox2.Controls.Add(this.lblPara2);
            this.groupBox2.Controls.Add(this.lblPara1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(32, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "形狀設定";
            // 
            // comboBoxShape
            // 
            this.comboBoxShape.FormattingEnabled = true;
            this.comboBoxShape.Items.AddRange(new object[] {
            "球",
            "正方體",
            "圓柱體",
            "金字塔"});
            this.comboBoxShape.Location = new System.Drawing.Point(90, 21);
            this.comboBoxShape.Name = "comboBoxShape";
            this.comboBoxShape.Size = new System.Drawing.Size(207, 20);
            this.comboBoxShape.TabIndex = 5;
            this.comboBoxShape.SelectedIndexChanged += new System.EventHandler(this.comboBoxShape_SelectedIndexChanged);
            // 
            // txtPara2
            // 
            this.txtPara2.Location = new System.Drawing.Point(197, 50);
            this.txtPara2.Name = "txtPara2";
            this.txtPara2.Size = new System.Drawing.Size(100, 22);
            this.txtPara2.TabIndex = 4;
            this.txtPara2.Visible = false;
            // 
            // txtPara1
            // 
            this.txtPara1.Location = new System.Drawing.Point(49, 50);
            this.txtPara1.Name = "txtPara1";
            this.txtPara1.Size = new System.Drawing.Size(100, 22);
            this.txtPara1.TabIndex = 3;
            // 
            // lblPara2
            // 
            this.lblPara2.AutoSize = true;
            this.lblPara2.Location = new System.Drawing.Point(155, 61);
            this.lblPara2.Name = "lblPara2";
            this.lblPara2.Size = new System.Drawing.Size(33, 12);
            this.lblPara2.TabIndex = 2;
            this.lblPara2.Text = "哈囉!";
            this.lblPara2.Visible = false;
            // 
            // lblPara1
            // 
            this.lblPara1.AutoSize = true;
            this.lblPara1.Location = new System.Drawing.Point(9, 61);
            this.lblPara1.Name = "lblPara1";
            this.lblPara1.Size = new System.Drawing.Size(29, 12);
            this.lblPara1.TabIndex = 1;
            this.lblPara1.Text = "半徑";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "形狀類別";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Location = new System.Drawing.Point(32, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 95);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "增加Shape";
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(197, 49);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "數量";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "加入";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtProperty
            // 
            this.txtProperty.Location = new System.Drawing.Point(32, 349);
            this.txtProperty.Multiline = true;
            this.txtProperty.Name = "txtProperty";
            this.txtProperty.Size = new System.Drawing.Size(304, 178);
            this.txtProperty.TabIndex = 3;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(603, 68);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(394, 459);
            this.txtDisplay.TabIndex = 4;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(318, 349);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 178);
            this.vScrollBar1.TabIndex = 5;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(979, 68);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(18, 459);
            this.vScrollBar2.TabIndex = 6;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(603, 25);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 7;
            this.btnCompute.Text = "計算";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Items.AddRange(new object[] {
            "體積",
            "重量"});
            this.comboBoxSortBy.Location = new System.Drawing.Point(27, 37);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(164, 20);
            this.comboBoxSortBy.TabIndex = 8;
            // 
            // radioButtonInecrease
            // 
            this.radioButtonInecrease.AutoSize = true;
            this.radioButtonInecrease.Location = new System.Drawing.Point(27, 66);
            this.radioButtonInecrease.Name = "radioButtonInecrease";
            this.radioButtonInecrease.Size = new System.Drawing.Size(66, 16);
            this.radioButtonInecrease.TabIndex = 9;
            this.radioButtonInecrease.TabStop = true;
            this.radioButtonInecrease.Text = "Inecrease";
            this.radioButtonInecrease.UseVisualStyleBackColor = true;
            // 
            // radioButtonDecrease
            // 
            this.radioButtonDecrease.AutoSize = true;
            this.radioButtonDecrease.Location = new System.Drawing.Point(27, 88);
            this.radioButtonDecrease.Name = "radioButtonDecrease";
            this.radioButtonDecrease.Size = new System.Drawing.Size(64, 16);
            this.radioButtonDecrease.TabIndex = 10;
            this.radioButtonDecrease.TabStop = true;
            this.radioButtonDecrease.Text = "Decrease";
            this.radioButtonDecrease.UseVisualStyleBackColor = true;
            // 
            // groupBoxSortTheShape
            // 
            this.groupBoxSortTheShape.Controls.Add(this.buttonSort);
            this.groupBoxSortTheShape.Controls.Add(this.radioButtonDecrease);
            this.groupBoxSortTheShape.Controls.Add(this.radioButtonInecrease);
            this.groupBoxSortTheShape.Controls.Add(this.comboBoxSortBy);
            this.groupBoxSortTheShape.Location = new System.Drawing.Point(360, 125);
            this.groupBoxSortTheShape.Name = "groupBoxSortTheShape";
            this.groupBoxSortTheShape.Size = new System.Drawing.Size(214, 146);
            this.groupBoxSortTheShape.TabIndex = 11;
            this.groupBoxSortTheShape.TabStop = false;
            this.groupBoxSortTheShape.Text = "SortTheShape";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(116, 83);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(75, 27);
            this.buttonSort.TabIndex = 11;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 564);
            this.Controls.Add(this.groupBoxSortTheShape);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.txtProperty);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxSortTheShape.ResumeLayout(false);
            this.groupBoxSortTheShape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxShape;
        private System.Windows.Forms.TextBox txtPara2;
        private System.Windows.Forms.TextBox txtPara1;
        private System.Windows.Forms.Label lblPara2;
        private System.Windows.Forms.Label lblPara1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtProperty;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.RadioButton radioButtonInecrease;
        private System.Windows.Forms.RadioButton radioButtonDecrease;
        private System.Windows.Forms.GroupBox groupBoxSortTheShape;
        private System.Windows.Forms.Button buttonSort;
    }
}

