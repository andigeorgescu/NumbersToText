namespace NumbersToText
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NoInput = new System.Windows.Forms.TextBox();
            this.LangListBox = new System.Windows.Forms.ListBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NoInput
            // 
            this.NoInput.Location = new System.Drawing.Point(206, 134);
            this.NoInput.Name = "NoInput";
            this.NoInput.Size = new System.Drawing.Size(120, 20);
            this.NoInput.TabIndex = 0;
            // 
            // LangListBox
            // 
            this.LangListBox.FormattingEnabled = true;
            this.LangListBox.Location = new System.Drawing.Point(206, 160);
            this.LangListBox.Name = "LangListBox";
            this.LangListBox.Size = new System.Drawing.Size(120, 95);
            this.LangListBox.TabIndex = 1;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(228, 261);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.SubmitConvert);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 513);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.LangListBox);
            this.Controls.Add(this.NoInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NoInput;
        private System.Windows.Forms.ListBox LangListBox;
        private System.Windows.Forms.Button submit;
    }
}

