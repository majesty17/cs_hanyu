namespace cs_hanyu
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
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_search = new System.Windows.Forms.Button();
            this.richTextBox_output = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_word = new System.Windows.Forms.CheckBox();
            this.checkBox_idiom = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_key
            // 
            this.textBox_key.Location = new System.Drawing.Point(72, 12);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(193, 27);
            this.textBox_key.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 970);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1345, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(271, 12);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(94, 29);
            this.button_search.TabIndex = 1;
            this.button_search.Text = "查找";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // richTextBox_output
            // 
            this.richTextBox_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_output.Location = new System.Drawing.Point(12, 57);
            this.richTextBox_output.Name = "richTextBox_output";
            this.richTextBox_output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_output.Size = new System.Drawing.Size(1321, 898);
            this.richTextBox_output.TabIndex = 99;
            this.richTextBox_output.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "关键词";
            // 
            // checkBox_word
            // 
            this.checkBox_word.AutoSize = true;
            this.checkBox_word.Checked = true;
            this.checkBox_word.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_word.Location = new System.Drawing.Point(573, 12);
            this.checkBox_word.Name = "checkBox_word";
            this.checkBox_word.Size = new System.Drawing.Size(61, 24);
            this.checkBox_word.TabIndex = 101;
            this.checkBox_word.Text = "词语";
            this.checkBox_word.UseVisualStyleBackColor = true;
            // 
            // checkBox_idiom
            // 
            this.checkBox_idiom.AutoSize = true;
            this.checkBox_idiom.Location = new System.Drawing.Point(677, 12);
            this.checkBox_idiom.Name = "checkBox_idiom";
            this.checkBox_idiom.Size = new System.Drawing.Size(61, 24);
            this.checkBox_idiom.TabIndex = 102;
            this.checkBox_idiom.Text = "成语";
            this.checkBox_idiom.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 996);
            this.Controls.Add(this.checkBox_idiom);
            this.Controls.Add(this.checkBox_word);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_output);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox_key);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_key;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button button_search;
        private RichTextBox richTextBox_output;
        private Label label1;
        private CheckBox checkBox_word;
        private CheckBox checkBox_idiom;
    }
}