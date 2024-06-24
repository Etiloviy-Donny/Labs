namespace Task1
{
    partial class FilesForm
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            filesDataGridView = new DataGridView();
            ButtonTask2 = new Button();
            ButtonTask3 = new Button();
            textBoxT4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)filesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // FilesDataGridView
            // 
            filesDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            filesDataGridView.BackgroundColor = SystemColors.Control;
            filesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            filesDataGridView.Location = new Point(12, 39);
            filesDataGridView.Name = "FilesDataGridView";
            filesDataGridView.Size = new Size(776, 337);
            filesDataGridView.TabIndex = 0;
            // 
            // ButtonTask2
            // 
            ButtonTask2.Location = new Point(51, 405);
            ButtonTask2.Name = "ButtonTask2";
            ButtonTask2.Size = new Size(75, 23);
            ButtonTask2.TabIndex = 1;
            ButtonTask2.Text = "Task2";
            ButtonTask2.UseVisualStyleBackColor = true;
            ButtonTask2.Click += ButtonTask2_Click;
            // 
            // ButtonTask3
            // 
            ButtonTask3.Location = new Point(194, 405);
            ButtonTask3.Name = "ButtonTask3";
            ButtonTask3.Size = new Size(75, 23);
            ButtonTask3.TabIndex = 3;
            ButtonTask3.Text = "Task3";
            ButtonTask3.UseVisualStyleBackColor = true;
            ButtonTask3.Click += ButtonTask3_Click;
            // 
            // textBoxT4
            // 
            textBoxT4.Location = new Point(51, 10);
            textBoxT4.Name = "textBoxT4";
            textBoxT4.Size = new Size(100, 23);
            textBoxT4.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxT4);
            Controls.Add(ButtonTask3);
            Controls.Add(ButtonTask2);
            Controls.Add(filesDataGridView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)filesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView filesDataGridView;
        private Button ButtonTask2;
        private Button button1;
        private Button ButtonTask3;
        private TextBox textBoxT4;
    }
}
