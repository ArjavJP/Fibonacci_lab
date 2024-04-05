namespace Week11
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
            textBox1 = new TextBox();
            btn_genClick = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(277, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 31);
            textBox1.TabIndex = 0;
            // 
            // btn_genClick
            // 
            btn_genClick.Location = new Point(521, 82);
            btn_genClick.Name = "btn_genClick";
            btn_genClick.Size = new Size(145, 34);
            btn_genClick.TabIndex = 1;
            btn_genClick.Text = "Generate";
            btn_genClick.UseVisualStyleBackColor = true;
            btn_genClick.Click += btn_genClick_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(277, 164);
            listView1.Name = "listView1";
            listView1.Size = new Size(261, 341);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 972);
            Controls.Add(listView1);
            Controls.Add(btn_genClick);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btn_genClick;
        private ListView listView1;
    }
}
