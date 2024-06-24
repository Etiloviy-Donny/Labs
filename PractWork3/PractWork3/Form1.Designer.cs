namespace PractWork3
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
            label1 = new Label();
            inputTextBox = new TextBox();
            taskCountTextBox = new TextBox();
            label2 = new Label();
            CreateButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Поле ввода";
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(12, 27);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(188, 67);
            inputTextBox.TabIndex = 1;
            // 
            // taskCountTextBox
            // 
            taskCountTextBox.Location = new Point(54, 115);
            taskCountTextBox.Name = "taskCountTextBox";
            taskCountTextBox.Size = new Size(100, 23);
            taskCountTextBox.TabIndex = 2;
            taskCountTextBox.TextChanged += taskCountTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 97);
            label2.Name = "label2";
            label2.Size = new Size(157, 15);
            label2.TabIndex = 3;
            label2.Text = "Поле ввода кол-ва заданий";
            label2.Click += label2_Click;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(12, 144);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(188, 23);
            CreateButton.TabIndex = 4;
            CreateButton.Text = "Создать документ по шаблону ";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateButton);
            Controls.Add(label2);
            Controls.Add(taskCountTextBox);
            Controls.Add(inputTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputTextBox;
        private TextBox taskCountTextBox;
        private Label label2;
        private Button CreateButton;
    }
}
