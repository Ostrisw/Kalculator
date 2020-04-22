namespace Matrix
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnD1Clear = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnD1Rand = new System.Windows.Forms.Button();
            this.matrixOne = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numCountCollum = new System.Windows.Forms.NumericUpDown();
            this.numCountRows = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnD2Clear = new System.Windows.Forms.Button();
            this.btnD2Rand = new System.Windows.Forms.Button();
            this.matrixTwo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numCollCountM2 = new System.Windows.Forms.NumericUpDown();
            this.numRowsCountM2 = new System.Windows.Forms.NumericUpDown();
            this.bPlus = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountCollum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountRows)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCollCountM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRowsCountM2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnD1Clear);
            this.groupBox1.Controls.Add(this.btnT);
            this.groupBox1.Controls.Add(this.btnD1Rand);
            this.groupBox1.Controls.Add(this.matrixOne);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numCountCollum);
            this.groupBox1.Controls.Add(this.numCountRows);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Матрица 1";
            // 
            // btnD1Clear
            // 
            this.btnD1Clear.Location = new System.Drawing.Point(179, 329);
            this.btnD1Clear.Name = "btnD1Clear";
            this.btnD1Clear.Size = new System.Drawing.Size(143, 23);
            this.btnD1Clear.TabIndex = 7;
            this.btnD1Clear.Text = "Очистить";
            this.btnD1Clear.UseVisualStyleBackColor = true;
            this.btnD1Clear.Click += new System.EventHandler(this.btnD1Clear_Click);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(9, 358);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(313, 23);
            this.btnT.TabIndex = 6;
            this.btnT.Text = "Транспонирование";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnD1Rand
            // 
            this.btnD1Rand.Location = new System.Drawing.Point(9, 329);
            this.btnD1Rand.Name = "btnD1Rand";
            this.btnD1Rand.Size = new System.Drawing.Size(143, 23);
            this.btnD1Rand.TabIndex = 5;
            this.btnD1Rand.Text = "Заполнить случайно";
            this.btnD1Rand.UseVisualStyleBackColor = true;
            this.btnD1Rand.Click += new System.EventHandler(this.btnD1Rand_Click);
            // 
            // matrixOne
            // 
            this.matrixOne.AllowUserToAddRows = false;
            this.matrixOne.AllowUserToDeleteRows = false;
            this.matrixOne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.matrixOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixOne.ColumnHeadersVisible = false;
            this.matrixOne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrixOne.DefaultCellStyle = dataGridViewCellStyle1;
            this.matrixOne.Location = new System.Drawing.Point(9, 45);
            this.matrixOne.Name = "matrixOne";
            this.matrixOne.RowHeadersVisible = false;
            this.matrixOne.RowHeadersWidth = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.matrixOne.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.matrixOne.RowTemplate.DefaultCellStyle.Format = "N0";
            this.matrixOne.RowTemplate.DefaultCellStyle.NullValue = "0";
            this.matrixOne.RowTemplate.ErrorText = "Не верный формат цифр";
            this.matrixOne.Size = new System.Drawing.Size(313, 278);
            this.matrixOne.TabIndex = 4;
            this.matrixOne.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.matrixOne_EditingControlShowing);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кол-во столбцов:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кол-во строк:";
            // 
            // numCountCollum
            // 
            this.numCountCollum.Location = new System.Drawing.Point(258, 19);
            this.numCountCollum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCountCollum.Name = "numCountCollum";
            this.numCountCollum.Size = new System.Drawing.Size(64, 20);
            this.numCountCollum.TabIndex = 1;
            this.numCountCollum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCountCollum.ValueChanged += new System.EventHandler(this.numCountCollum_ValueChanged);
            // 
            // numCountRows
            // 
            this.numCountRows.Location = new System.Drawing.Point(88, 19);
            this.numCountRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCountRows.Name = "numCountRows";
            this.numCountRows.Size = new System.Drawing.Size(64, 20);
            this.numCountRows.TabIndex = 0;
            this.numCountRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCountRows.ValueChanged += new System.EventHandler(this.numCountRows_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnD2Clear);
            this.groupBox2.Controls.Add(this.btnD2Rand);
            this.groupBox2.Controls.Add(this.matrixTwo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numCollCountM2);
            this.groupBox2.Controls.Add(this.numRowsCountM2);
            this.groupBox2.Location = new System.Drawing.Point(406, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 392);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Матрица 2";
            // 
            // btnD2Clear
            // 
            this.btnD2Clear.Location = new System.Drawing.Point(179, 329);
            this.btnD2Clear.Name = "btnD2Clear";
            this.btnD2Clear.Size = new System.Drawing.Size(143, 23);
            this.btnD2Clear.TabIndex = 7;
            this.btnD2Clear.Text = "Очистить";
            this.btnD2Clear.UseVisualStyleBackColor = true;
            this.btnD2Clear.Click += new System.EventHandler(this.btnD2Clear_Click);
            // 
            // btnD2Rand
            // 
            this.btnD2Rand.Location = new System.Drawing.Point(9, 329);
            this.btnD2Rand.Name = "btnD2Rand";
            this.btnD2Rand.Size = new System.Drawing.Size(143, 23);
            this.btnD2Rand.TabIndex = 5;
            this.btnD2Rand.Text = "Заполнить случайно";
            this.btnD2Rand.UseVisualStyleBackColor = true;
            this.btnD2Rand.Click += new System.EventHandler(this.btnD2Rand_Click);
            // 
            // matrixTwo
            // 
            this.matrixTwo.AllowUserToAddRows = false;
            this.matrixTwo.AllowUserToDeleteRows = false;
            this.matrixTwo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.matrixTwo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixTwo.ColumnHeadersVisible = false;
            this.matrixTwo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrixTwo.DefaultCellStyle = dataGridViewCellStyle3;
            this.matrixTwo.Location = new System.Drawing.Point(9, 45);
            this.matrixTwo.Name = "matrixTwo";
            this.matrixTwo.RowHeadersVisible = false;
            this.matrixTwo.RowHeadersWidth = 30;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.matrixTwo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.matrixTwo.RowTemplate.DefaultCellStyle.Format = "N0";
            this.matrixTwo.RowTemplate.DefaultCellStyle.NullValue = "0";
            this.matrixTwo.RowTemplate.ErrorText = "Не верный формат цифр";
            this.matrixTwo.Size = new System.Drawing.Size(313, 278);
            this.matrixTwo.TabIndex = 4;
            this.matrixTwo.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.matrixOne_EditingControlShowing);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кол-во столбцов:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Кол-во строк:";
            // 
            // numCollCountM2
            // 
            this.numCollCountM2.Location = new System.Drawing.Point(258, 19);
            this.numCollCountM2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numCollCountM2.Name = "numCollCountM2";
            this.numCollCountM2.Size = new System.Drawing.Size(64, 20);
            this.numCollCountM2.TabIndex = 1;
            this.numCollCountM2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numCollCountM2.ValueChanged += new System.EventHandler(this.numCollCountM2_ValueChanged);
            // 
            // numRowsCountM2
            // 
            this.numRowsCountM2.Location = new System.Drawing.Point(88, 19);
            this.numRowsCountM2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRowsCountM2.Name = "numRowsCountM2";
            this.numRowsCountM2.Size = new System.Drawing.Size(64, 20);
            this.numRowsCountM2.TabIndex = 0;
            this.numRowsCountM2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRowsCountM2.ValueChanged += new System.EventHandler(this.numRowsCountM2_ValueChanged);
            // 
            // bPlus
            // 
            this.bPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPlus.Location = new System.Drawing.Point(348, 103);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(51, 51);
            this.bPlus.TabIndex = 9;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.bPlus_Click);
            // 
            // bMul
            // 
            this.bMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bMul.Location = new System.Drawing.Point(348, 220);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(51, 51);
            this.bMul.TabIndex = 11;
            this.bMul.Text = "×";
            this.bMul.UseVisualStyleBackColor = true;
            this.bMul.Click += new System.EventHandler(this.bMul_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(348, 171);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 31);
            this.button5.TabIndex = 0;
            this.button5.Text = "-";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(749, 409);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bMul);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Матрицы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountCollum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountRows)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCollCountM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRowsCountM2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCountCollum;
        private System.Windows.Forms.NumericUpDown numCountRows;
        private System.Windows.Forms.DataGridView matrixOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnD1Rand;
        private System.Windows.Forms.Button btnD1Clear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnD2Clear;
        private System.Windows.Forms.Button btnD2Rand;
        private System.Windows.Forms.DataGridView matrixTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numCollCountM2;
        private System.Windows.Forms.NumericUpDown numRowsCountM2;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bMul;
        private System.Windows.Forms.Button button5;
    }
}

