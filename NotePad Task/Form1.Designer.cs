namespace NotePad_Task
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
            richTextBox1 = new RichTextBox();
            labelFont = new Label();
            btnFont = new Button();
            btnColor = new Button();
            labelColor = new Label();
            btnLoad = new Button();
            btnSave = new Button();
            textLoad = new TextBox();
            textBox1 = new TextBox();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            colorDialog2 = new ColorDialog();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 82);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1135, 491);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // labelFont
            // 
            labelFont.AutoSize = true;
            labelFont.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelFont.Location = new Point(12, 9);
            labelFont.Name = "labelFont";
            labelFont.Size = new Size(44, 23);
            labelFont.TabIndex = 1;
            labelFont.Text = "Font";
            // 
            // btnFont
            // 
            btnFont.Location = new Point(12, 35);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(100, 30);
            btnFont.TabIndex = 5;
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(226, 35);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(100, 30);
            btnColor.TabIndex = 6;
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelColor.Location = new Point(226, 7);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(50, 23);
            labelColor.TabIndex = 7;
            labelColor.Text = "Color";
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.Location = new Point(1025, 7);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(95, 28);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(1025, 48);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 28);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // textLoad
            // 
            textLoad.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textLoad.Location = new Point(769, 7);
            textLoad.Name = "textLoad";
            textLoad.Size = new Size(250, 27);
            textLoad.TabIndex = 10;
            textLoad.Text = "Enter name and Load File...";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(769, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 11;
            textBox1.Text = "Tap to enter name and save...";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 573);
            Controls.Add(textBox1);
            Controls.Add(textLoad);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(labelColor);
            Controls.Add(btnColor);
            Controls.Add(btnFont);
            Controls.Add(labelFont);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label labelFont;
        private Button btnFont;
        private Button btnColor;
        private Label labelColor;
        private Button btnLoad;
        private Button btnSave;
        private TextBox textLoad;
        private TextBox textBox1;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog2;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}