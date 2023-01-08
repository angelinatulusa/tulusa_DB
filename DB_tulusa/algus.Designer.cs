namespace DB_tulusa
{
    partial class algus
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
            this.klient_btn = new System.Windows.Forms.Button();
            this.muuja_btn = new System.Windows.Forms.Button();
            this.omanik_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // klient_btn
            // 
            this.klient_btn.BackColor = System.Drawing.Color.LightGreen;
            this.klient_btn.Location = new System.Drawing.Point(37, 33);
            this.klient_btn.Name = "klient_btn";
            this.klient_btn.Size = new System.Drawing.Size(267, 176);
            this.klient_btn.TabIndex = 0;
            this.klient_btn.Text = "Klient";
            this.klient_btn.UseVisualStyleBackColor = false;
            this.klient_btn.Click += new System.EventHandler(this.klient_btn_Click);
            // 
            // muuja_btn
            // 
            this.muuja_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.muuja_btn.Location = new System.Drawing.Point(330, 33);
            this.muuja_btn.Name = "muuja_btn";
            this.muuja_btn.Size = new System.Drawing.Size(222, 119);
            this.muuja_btn.TabIndex = 1;
            this.muuja_btn.Text = "Müüja";
            this.muuja_btn.UseVisualStyleBackColor = false;
            this.muuja_btn.Click += new System.EventHandler(this.muuja_btn_Click);
            // 
            // omanik_btn
            // 
            this.omanik_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.omanik_btn.Location = new System.Drawing.Point(330, 158);
            this.omanik_btn.Name = "omanik_btn";
            this.omanik_btn.Size = new System.Drawing.Size(222, 51);
            this.omanik_btn.TabIndex = 2;
            this.omanik_btn.Text = "Omanik";
            this.omanik_btn.UseVisualStyleBackColor = false;
            this.omanik_btn.Click += new System.EventHandler(this.omanik_btn_Click);
            // 
            // algus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(591, 247);
            this.Controls.Add(this.omanik_btn);
            this.Controls.Add(this.muuja_btn);
            this.Controls.Add(this.klient_btn);
            this.Name = "algus";
            this.Text = "algus";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button klient_btn;
        private System.Windows.Forms.Button muuja_btn;
        private System.Windows.Forms.Button omanik_btn;
    }
}