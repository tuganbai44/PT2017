namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.percent = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.memClear = new System.Windows.Forms.Button();
            this.memRead = new System.Windows.Forms.Button();
            this.memSum = new System.Windows.Forms.Button();
            this.memSubtract = new System.Windows.Forms.Button();
            this.memSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.memory = new System.Windows.Forms.Button();
            this.button1dx = new System.Windows.Forms.Button();
            this.pow = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ClearE = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.drob = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.negative = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // percent
            // 
            this.percent.BackColor = System.Drawing.SystemColors.Window;
            this.percent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percent.Location = new System.Drawing.Point(3, 138);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(70, 55);
            this.percent.TabIndex = 0;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = false;
            this.percent.Click += new System.EventHandler(this.percent_Click);
            // 
            // root
            // 
            this.root.BackColor = System.Drawing.SystemColors.Window;
            this.root.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.root.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.root.Location = new System.Drawing.Point(79, 138);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(70, 55);
            this.root.TabIndex = 1;
            this.root.Text = "√";
            this.root.UseVisualStyleBackColor = false;
            this.root.Click += new System.EventHandler(this.root_Click);
            // 
            // memClear
            // 
            this.memClear.BackColor = System.Drawing.SystemColors.Window;
            this.memClear.Location = new System.Drawing.Point(3, 109);
            this.memClear.Name = "memClear";
            this.memClear.Size = new System.Drawing.Size(45, 23);
            this.memClear.TabIndex = 24;
            this.memClear.Text = "MC";
            this.memClear.UseVisualStyleBackColor = false;
            this.memClear.Click += new System.EventHandler(this.memory_Click);
            // 
            // memRead
            // 
            this.memRead.BackColor = System.Drawing.SystemColors.Window;
            this.memRead.Location = new System.Drawing.Point(54, 109);
            this.memRead.Name = "memRead";
            this.memRead.Size = new System.Drawing.Size(45, 23);
            this.memRead.TabIndex = 25;
            this.memRead.Text = "MR";
            this.memRead.UseVisualStyleBackColor = false;
            this.memRead.Click += new System.EventHandler(this.memory_Click);
            // 
            // memSum
            // 
            this.memSum.BackColor = System.Drawing.SystemColors.Window;
            this.memSum.Location = new System.Drawing.Point(105, 109);
            this.memSum.Name = "memSum";
            this.memSum.Size = new System.Drawing.Size(45, 23);
            this.memSum.TabIndex = 26;
            this.memSum.Text = "M+";
            this.memSum.UseVisualStyleBackColor = false;
            this.memSum.Click += new System.EventHandler(this.memory_Click);
            // 
            // memSubtract
            // 
            this.memSubtract.BackColor = System.Drawing.SystemColors.Window;
            this.memSubtract.Location = new System.Drawing.Point(155, 109);
            this.memSubtract.Name = "memSubtract";
            this.memSubtract.Size = new System.Drawing.Size(45, 23);
            this.memSubtract.TabIndex = 27;
            this.memSubtract.Text = "M-";
            this.memSubtract.UseVisualStyleBackColor = false;
            this.memSubtract.Click += new System.EventHandler(this.memory_Click);
            // 
            // memSave
            // 
            this.memSave.BackColor = System.Drawing.SystemColors.Window;
            this.memSave.Location = new System.Drawing.Point(206, 109);
            this.memSave.Name = "memSave";
            this.memSave.Size = new System.Drawing.Size(45, 23);
            this.memSave.TabIndex = 28;
            this.memSave.Text = "MS";
            this.memSave.UseVisualStyleBackColor = false;
            this.memSave.Click += new System.EventHandler(this.memory_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(3, 12);
            this.textBox1.MaximumSize = new System.Drawing.Size(400, 400);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(298, 90);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // memory
            // 
            this.memory.BackColor = System.Drawing.SystemColors.Window;
            this.memory.Location = new System.Drawing.Point(256, 109);
            this.memory.Name = "memory";
            this.memory.Size = new System.Drawing.Size(45, 23);
            this.memory.TabIndex = 30;
            this.memory.Text = "M";
            this.memory.UseVisualStyleBackColor = false;
            this.memory.Click += new System.EventHandler(this.memory_Click);
            // 
            // button1dx
            // 
            this.button1dx.BackColor = System.Drawing.SystemColors.Window;
            this.button1dx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1dx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1dx.Location = new System.Drawing.Point(231, 138);
            this.button1dx.Name = "button1dx";
            this.button1dx.Size = new System.Drawing.Size(70, 55);
            this.button1dx.TabIndex = 32;
            this.button1dx.Text = "1/x";
            this.button1dx.UseVisualStyleBackColor = false;
            this.button1dx.Click += new System.EventHandler(this.button1dx_Click);
            // 
            // pow
            // 
            this.pow.BackColor = System.Drawing.SystemColors.Window;
            this.pow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pow.Location = new System.Drawing.Point(155, 138);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(70, 55);
            this.pow.TabIndex = 31;
            this.pow.Text = " Х²";
            this.pow.UseVisualStyleBackColor = false;
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.Window;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divide.Location = new System.Drawing.Point(231, 199);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(70, 55);
            this.divide.TabIndex = 36;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.operation_click);
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.SystemColors.Window;
            this.backspace.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.backspace.Font = new System.Drawing.Font("Algerian", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.Location = new System.Drawing.Point(155, 199);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(70, 55);
            this.backspace.TabIndex = 35;
            this.backspace.Text = "←";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.Window;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Clear.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(79, 199);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(70, 55);
            this.Clear.TabIndex = 34;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ClearE
            // 
            this.ClearE.BackColor = System.Drawing.SystemColors.Window;
            this.ClearE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClearE.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearE.Location = new System.Drawing.Point(3, 199);
            this.ClearE.Name = "ClearE";
            this.ClearE.Size = new System.Drawing.Size(70, 55);
            this.ClearE.TabIndex = 33;
            this.ClearE.Text = "CE";
            this.ClearE.UseVisualStyleBackColor = false;
            this.ClearE.Click += new System.EventHandler(this.ClearE_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.Window;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiply.Location = new System.Drawing.Point(231, 260);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(70, 55);
            this.multiply.TabIndex = 40;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.operation_click);
            // 
            // number9
            // 
            this.number9.BackColor = System.Drawing.SystemColors.Window;
            this.number9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.number9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number9.Location = new System.Drawing.Point(155, 260);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(70, 55);
            this.number9.TabIndex = 39;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = false;
            this.number9.Click += new System.EventHandler(this.number_click);
            // 
            // number8
            // 
            this.number8.BackColor = System.Drawing.SystemColors.Window;
            this.number8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.number8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number8.Location = new System.Drawing.Point(79, 260);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(70, 55);
            this.number8.TabIndex = 38;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = false;
            this.number8.Click += new System.EventHandler(this.number_click);
            // 
            // number7
            // 
            this.number7.BackColor = System.Drawing.SystemColors.Window;
            this.number7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.number7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number7.Location = new System.Drawing.Point(3, 260);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(70, 55);
            this.number7.TabIndex = 37;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = false;
            this.number7.Click += new System.EventHandler(this.number_click);
            // 
            // subtract
            // 
            this.subtract.BackColor = System.Drawing.SystemColors.Window;
            this.subtract.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subtract.Location = new System.Drawing.Point(231, 321);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(70, 55);
            this.subtract.TabIndex = 44;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = false;
            this.subtract.Click += new System.EventHandler(this.operation_click);
            // 
            // number6
            // 
            this.number6.BackColor = System.Drawing.SystemColors.Window;
            this.number6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.number6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number6.Location = new System.Drawing.Point(155, 321);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(70, 55);
            this.number6.TabIndex = 43;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = false;
            this.number6.Click += new System.EventHandler(this.number_click);
            // 
            // number5
            // 
            this.number5.BackColor = System.Drawing.SystemColors.Window;
            this.number5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number5.Location = new System.Drawing.Point(79, 321);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(70, 55);
            this.number5.TabIndex = 42;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = false;
            this.number5.Click += new System.EventHandler(this.number_click);
            // 
            // number4
            // 
            this.number4.BackColor = System.Drawing.SystemColors.Window;
            this.number4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number4.Location = new System.Drawing.Point(3, 321);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(70, 55);
            this.number4.TabIndex = 41;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = false;
            this.number4.Click += new System.EventHandler(this.number_click);
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.SystemColors.Window;
            this.sum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum.Location = new System.Drawing.Point(231, 382);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(70, 55);
            this.sum.TabIndex = 48;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = false;
            this.sum.Click += new System.EventHandler(this.operation_click);
            // 
            // number3
            // 
            this.number3.BackColor = System.Drawing.SystemColors.Window;
            this.number3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number3.Location = new System.Drawing.Point(155, 382);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(70, 55);
            this.number3.TabIndex = 47;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = false;
            this.number3.Click += new System.EventHandler(this.number_click);
            // 
            // number2
            // 
            this.number2.BackColor = System.Drawing.SystemColors.Window;
            this.number2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number2.Location = new System.Drawing.Point(79, 382);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(70, 55);
            this.number2.TabIndex = 46;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = false;
            this.number2.Click += new System.EventHandler(this.number_click);
            // 
            // number1
            // 
            this.number1.BackColor = System.Drawing.SystemColors.Window;
            this.number1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number1.Location = new System.Drawing.Point(3, 382);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(70, 55);
            this.number1.TabIndex = 45;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = false;
            this.number1.Click += new System.EventHandler(this.number_click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.Window;
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equal.Location = new System.Drawing.Point(231, 443);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(70, 55);
            this.equal.TabIndex = 52;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // drob
            // 
            this.drob.BackColor = System.Drawing.SystemColors.Window;
            this.drob.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.drob.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drob.Location = new System.Drawing.Point(155, 443);
            this.drob.Name = "drob";
            this.drob.Size = new System.Drawing.Size(70, 55);
            this.drob.TabIndex = 51;
            this.drob.Text = ".";
            this.drob.UseVisualStyleBackColor = false;
            this.drob.Click += new System.EventHandler(this.drob_Click);
            // 
            // number0
            // 
            this.number0.BackColor = System.Drawing.SystemColors.Window;
            this.number0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.number0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number0.Location = new System.Drawing.Point(79, 443);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(70, 55);
            this.number0.TabIndex = 50;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = false;
            this.number0.Click += new System.EventHandler(this.number0_Click);
            // 
            // negative
            // 
            this.negative.BackColor = System.Drawing.SystemColors.Window;
            this.negative.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.negative.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.negative.Location = new System.Drawing.Point(3, 443);
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(70, 55);
            this.negative.TabIndex = 49;
            this.negative.Text = "±";
            this.negative.UseVisualStyleBackColor = false;
            this.negative.Click += new System.EventHandler(this.negative_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 508);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.drob);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.negative);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ClearE);
            this.Controls.Add(this.button1dx);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.memory);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.memSave);
            this.Controls.Add(this.memSubtract);
            this.Controls.Add(this.memSum);
            this.Controls.Add(this.memRead);
            this.Controls.Add(this.memClear);
            this.Controls.Add(this.root);
            this.Controls.Add(this.percent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button memClear;
        private System.Windows.Forms.Button memRead;
        private System.Windows.Forms.Button memSum;
        private System.Windows.Forms.Button memSubtract;
        private System.Windows.Forms.Button memSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button memory;
        private System.Windows.Forms.Button button1dx;
        private System.Windows.Forms.Button pow;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ClearE;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button drob;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button negative;
    }
}

