namespace Matrix2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelRowsA = new Label();
            labelColsA = new Label();
            labelRowsB = new Label();
            labelColsB = new Label();
            textBoxRowsA = new TextBox();
            textBoxColsA = new TextBox();
            textBoxRowsB = new TextBox();
            textBoxColsB = new TextBox();
            buttonGenerate = new Button();
            buttonMultiply = new Button();
            listBoxMatrixA = new ListBox();
            listBoxMatrixB = new ListBox();
            listBoxMatrixC = new ListBox();
            labelSequentialTime = new Label();
            labelParallelTime = new Label();
            SuspendLayout();
            // 
            // labelRowsA
            // 
            labelRowsA.AutoSize = true;
            labelRowsA.Location = new Point(42, 56);
            labelRowsA.Name = "labelRowsA";
            labelRowsA.Size = new Size(111, 15);
            labelRowsA.TabIndex = 0;
            labelRowsA.Text = "Строки матрицы A";
            // 
            // labelColsA
            // 
            labelColsA.AutoSize = true;
            labelColsA.Location = new Point(43, 138);
            labelColsA.Name = "labelColsA";
            labelColsA.Size = new Size(121, 15);
            labelColsA.TabIndex = 1;
            labelColsA.Text = "Столбцы матрицы A";
            // 
            // labelRowsB
            // 
            labelRowsB.AutoSize = true;
            labelRowsB.Location = new Point(43, 273);
            labelRowsB.Name = "labelRowsB";
            labelRowsB.Size = new Size(110, 15);
            labelRowsB.TabIndex = 2;
            labelRowsB.Text = "Строки матрицы B";
            // 
            // labelColsB
            // 
            labelColsB.AutoSize = true;
            labelColsB.Location = new Point(43, 333);
            labelColsB.Name = "labelColsB";
            labelColsB.Size = new Size(120, 15);
            labelColsB.TabIndex = 3;
            labelColsB.Text = "Столбцы матрицы B";
            // 
            // textBoxRowsA
            // 
            textBoxRowsA.Location = new Point(43, 77);
            textBoxRowsA.Name = "textBoxRowsA";
            textBoxRowsA.Size = new Size(100, 23);
            textBoxRowsA.TabIndex = 4;
            // 
            // textBoxColsA
            // 
            textBoxColsA.Location = new Point(43, 156);
            textBoxColsA.Name = "textBoxColsA";
            textBoxColsA.Size = new Size(100, 23);
            textBoxColsA.TabIndex = 5;
            // 
            // textBoxRowsB
            // 
            textBoxRowsB.Location = new Point(43, 291);
            textBoxRowsB.Name = "textBoxRowsB";
            textBoxRowsB.Size = new Size(100, 23);
            textBoxRowsB.TabIndex = 6;
            // 
            // textBoxColsB
            // 
            textBoxColsB.Location = new Point(43, 351);
            textBoxColsB.Name = "textBoxColsB";
            textBoxColsB.Size = new Size(100, 23);
            textBoxColsB.TabIndex = 7;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(252, 36);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(164, 23);
            buttonGenerate.TabIndex = 8;
            buttonGenerate.Text = "Сгенерировать матрицы!";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(252, 117);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(164, 23);
            buttonMultiply.TabIndex = 9;
            buttonMultiply.Text = "Умножить матрицы";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // listBoxMatrixA
            // 
            listBoxMatrixA.FormattingEnabled = true;
            listBoxMatrixA.HorizontalScrollbar = true;
            listBoxMatrixA.ItemHeight = 15;
            listBoxMatrixA.Location = new Point(438, 36);
            listBoxMatrixA.Name = "listBoxMatrixA";
            listBoxMatrixA.Size = new Size(312, 94);
            listBoxMatrixA.TabIndex = 10;
            // 
            // listBoxMatrixB
            // 
            listBoxMatrixB.FormattingEnabled = true;
            listBoxMatrixB.HorizontalScrollbar = true;
            listBoxMatrixB.ItemHeight = 15;
            listBoxMatrixB.Location = new Point(862, 36);
            listBoxMatrixB.Name = "listBoxMatrixB";
            listBoxMatrixB.Size = new Size(303, 94);
            listBoxMatrixB.TabIndex = 11;
            // 
            // listBoxMatrixC
            // 
            listBoxMatrixC.FormattingEnabled = true;
            listBoxMatrixC.HorizontalScrollbar = true;
            listBoxMatrixC.ItemHeight = 15;
            listBoxMatrixC.Location = new Point(654, 164);
            listBoxMatrixC.Name = "listBoxMatrixC";
            listBoxMatrixC.Size = new Size(299, 124);
            listBoxMatrixC.TabIndex = 12;
            // 
            // labelSequentialTime
            // 
            labelSequentialTime.AutoSize = true;
            labelSequentialTime.Location = new Point(308, 314);
            labelSequentialTime.Name = "labelSequentialTime";
            labelSequentialTime.Size = new Size(220, 15);
            labelSequentialTime.TabIndex = 13;
            labelSequentialTime.Text = "Время последовательного умножения";
            // 
            // labelParallelTime
            // 
            labelParallelTime.AutoSize = true;
            labelParallelTime.Location = new Point(308, 359);
            labelParallelTime.Name = "labelParallelTime";
            labelParallelTime.Size = new Size(197, 15);
            labelParallelTime.TabIndex = 14;
            labelParallelTime.Text = "Время параллельного умножения";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 450);
            Controls.Add(labelParallelTime);
            Controls.Add(labelSequentialTime);
            Controls.Add(listBoxMatrixC);
            Controls.Add(listBoxMatrixB);
            Controls.Add(listBoxMatrixA);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonGenerate);
            Controls.Add(textBoxColsB);
            Controls.Add(textBoxRowsB);
            Controls.Add(textBoxColsA);
            Controls.Add(textBoxRowsA);
            Controls.Add(labelColsB);
            Controls.Add(labelRowsB);
            Controls.Add(labelColsA);
            Controls.Add(labelRowsA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRowsA;
        private Label labelColsA;
        private Label labelRowsB;
        private Label labelColsB;
        private TextBox textBoxRowsA;
        private TextBox textBoxColsA;
        private TextBox textBoxRowsB;
        private TextBox textBoxColsB;
        private Button buttonGenerate;
        private Button buttonMultiply;
        private ListBox listBoxMatrixA;
        private ListBox listBoxMatrixB;
        private ListBox listBoxMatrixC;
        private Label labelSequentialTime;
        private Label labelParallelTime;
    }
}
