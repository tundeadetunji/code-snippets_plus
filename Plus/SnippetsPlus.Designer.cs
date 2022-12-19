namespace Plus
{
    partial class SnippetsPlus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnippetsPlus));
            this.buttonGCP = new System.Windows.Forms.Button();
            this.buttonAndroid = new System.Windows.Forms.Button();
            this.buttonKubernetes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGCP
            // 
            this.buttonGCP.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonGCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGCP.Image = global::Plus.Properties.Resources.google_icon_48;
            this.buttonGCP.Location = new System.Drawing.Point(67, 57);
            this.buttonGCP.Name = "buttonGCP";
            this.buttonGCP.Size = new System.Drawing.Size(81, 61);
            this.buttonGCP.TabIndex = 0;
            this.buttonGCP.UseVisualStyleBackColor = true;
            this.buttonGCP.Click += new System.EventHandler(this.buttonGCP_Click);
            // 
            // buttonAndroid
            // 
            this.buttonAndroid.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonAndroid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAndroid.Image = ((System.Drawing.Image)(resources.GetObject("buttonAndroid.Image")));
            this.buttonAndroid.Location = new System.Drawing.Point(154, 57);
            this.buttonAndroid.Name = "buttonAndroid";
            this.buttonAndroid.Size = new System.Drawing.Size(81, 61);
            this.buttonAndroid.TabIndex = 1;
            this.buttonAndroid.UseVisualStyleBackColor = true;
            this.buttonAndroid.Click += new System.EventHandler(this.buttonAndroid_Click);
            // 
            // buttonKubernetes
            // 
            this.buttonKubernetes.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonKubernetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKubernetes.Image = ((System.Drawing.Image)(resources.GetObject("buttonKubernetes.Image")));
            this.buttonKubernetes.Location = new System.Drawing.Point(241, 57);
            this.buttonKubernetes.Name = "buttonKubernetes";
            this.buttonKubernetes.Size = new System.Drawing.Size(81, 61);
            this.buttonKubernetes.TabIndex = 2;
            this.buttonKubernetes.UseVisualStyleBackColor = true;
            this.buttonKubernetes.Click += new System.EventHandler(this.buttonKubernetes_Click);
            // 
            // SnippetsPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(389, 175);
            this.Controls.Add(this.buttonKubernetes);
            this.Controls.Add(this.buttonAndroid);
            this.Controls.Add(this.buttonGCP);
            this.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SnippetsPlus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snippets Plus";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonGCP;
        private Button buttonAndroid;
        private Button buttonKubernetes;
    }
}