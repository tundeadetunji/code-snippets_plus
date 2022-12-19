namespace Plus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textSnippet = new System.Windows.Forms.TextBox();
            this.buttonSection = new System.Windows.Forms.Button();
            this.dropSnippet = new System.Windows.Forms.ComboBox();
            this.dropSection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textSnippet
            // 
            this.textSnippet.Location = new System.Drawing.Point(12, 79);
            this.textSnippet.Multiline = true;
            this.textSnippet.Name = "textSnippet";
            this.textSnippet.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textSnippet.Size = new System.Drawing.Size(686, 208);
            this.textSnippet.TabIndex = 1;
            // 
            // buttonSection
            // 
            this.buttonSection.BackColor = System.Drawing.Color.Transparent;
            this.buttonSection.FlatAppearance.BorderSize = 0;
            this.buttonSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSection.Image = global::Plus.Properties.Resources.Alarm_Tick_icon_24;
            this.buttonSection.Location = new System.Drawing.Point(432, 13);
            this.buttonSection.Name = "buttonSection";
            this.buttonSection.Size = new System.Drawing.Size(43, 27);
            this.buttonSection.TabIndex = 3;
            this.buttonSection.UseVisualStyleBackColor = false;
            this.buttonSection.Visible = false;
            this.buttonSection.Click += new System.EventHandler(this.buttonSection_Click);
            // 
            // dropSnippet
            // 
            this.dropSnippet.FormattingEnabled = true;
            this.dropSnippet.Location = new System.Drawing.Point(12, 46);
            this.dropSnippet.Name = "dropSnippet";
            this.dropSnippet.Size = new System.Drawing.Size(686, 27);
            this.dropSnippet.TabIndex = 4;
            this.dropSnippet.SelectedIndexChanged += new System.EventHandler(this.dropSnippet_SelectedIndexChanged);
            // 
            // dropSection
            // 
            this.dropSection.FormattingEnabled = true;
            this.dropSection.Location = new System.Drawing.Point(12, 14);
            this.dropSection.Name = "dropSection";
            this.dropSection.Size = new System.Drawing.Size(414, 27);
            this.dropSection.TabIndex = 5;
            this.dropSection.SelectedIndexChanged += new System.EventHandler(this.dropSection_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(710, 299);
            this.Controls.Add(this.dropSection);
            this.Controls.Add(this.dropSnippet);
            this.Controls.Add(this.buttonSection);
            this.Controls.Add(this.textSnippet);
            this.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snippets Plus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textSnippet;
        private Button buttonSection;
        private ComboBox dropSnippet;
        private ComboBox dropSection;
    }
}