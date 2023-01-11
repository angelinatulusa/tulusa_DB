namespace DB_tulusa
{
    partial class klient
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
            this.hind_num = new System.Windows.Forms.NumericUpDown();
            this.kogus_num = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tsekk_btn = new System.Windows.Forms.Button();
            this.toode_pbox = new System.Windows.Forms.PictureBox();
            this.Hind_lbl = new System.Windows.Forms.Label();
            this.Kogus_lbl = new System.Windows.Forms.Label();
            this.Toode_lbl = new System.Windows.Forms.Label();
            this.lisa_btn = new System.Windows.Forms.Button();
            this.Kustuta_btn = new System.Windows.Forms.Button();
            this.test_lbl = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.hind_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kogus_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toode_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // hind_num
            // 
            this.hind_num.Location = new System.Drawing.Point(477, 153);
            this.hind_num.Margin = new System.Windows.Forms.Padding(4);
            this.hind_num.Name = "hind_num";
            this.hind_num.Size = new System.Drawing.Size(130, 22);
            this.hind_num.TabIndex = 31;
            // 
            // kogus_num
            // 
            this.kogus_num.Location = new System.Drawing.Point(477, 105);
            this.kogus_num.Margin = new System.Windows.Forms.Padding(4);
            this.kogus_num.Name = "kogus_num";
            this.kogus_num.Size = new System.Drawing.Size(130, 22);
            this.kogus_num.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(99, 306);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(456, 219);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // tsekk_btn
            // 
            this.tsekk_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tsekk_btn.Location = new System.Drawing.Point(303, 206);
            this.tsekk_btn.Margin = new System.Windows.Forms.Padding(4);
            this.tsekk_btn.Name = "tsekk_btn";
            this.tsekk_btn.Size = new System.Drawing.Size(153, 37);
            this.tsekk_btn.TabIndex = 25;
            this.tsekk_btn.Text = "Lisada tsekkile";
            this.tsekk_btn.UseVisualStyleBackColor = true;
            this.tsekk_btn.Click += new System.EventHandler(this.Tsekk_btn_Click);
            // 
            // toode_pbox
            // 
            this.toode_pbox.BackColor = System.Drawing.SystemColors.Control;
            this.toode_pbox.Location = new System.Drawing.Point(33, 23);
            this.toode_pbox.Margin = new System.Windows.Forms.Padding(4);
            this.toode_pbox.Name = "toode_pbox";
            this.toode_pbox.Size = new System.Drawing.Size(248, 244);
            this.toode_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toode_pbox.TabIndex = 23;
            this.toode_pbox.TabStop = false;
            // 
            // Hind_lbl
            // 
            this.Hind_lbl.AutoSize = true;
            this.Hind_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Hind_lbl.Location = new System.Drawing.Point(405, 153);
            this.Hind_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Hind_lbl.Name = "Hind_lbl";
            this.Hind_lbl.Size = new System.Drawing.Size(57, 26);
            this.Hind_lbl.TabIndex = 20;
            this.Hind_lbl.Text = "Hind";
            // 
            // Kogus_lbl
            // 
            this.Kogus_lbl.AutoSize = true;
            this.Kogus_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Kogus_lbl.Location = new System.Drawing.Point(386, 101);
            this.Kogus_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kogus_lbl.Name = "Kogus_lbl";
            this.Kogus_lbl.Size = new System.Drawing.Size(74, 26);
            this.Kogus_lbl.TabIndex = 19;
            this.Kogus_lbl.Text = "Kogus";
            // 
            // Toode_lbl
            // 
            this.Toode_lbl.AutoSize = true;
            this.Toode_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Toode_lbl.Location = new System.Drawing.Point(298, 47);
            this.Toode_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Toode_lbl.Name = "Toode_lbl";
            this.Toode_lbl.Size = new System.Drawing.Size(155, 26);
            this.Toode_lbl.TabIndex = 18;
            this.Toode_lbl.Text = "Toode nimetus";
            // 
            // lisa_btn
            // 
            this.lisa_btn.Location = new System.Drawing.Point(477, 206);
            this.lisa_btn.Margin = new System.Windows.Forms.Padding(4);
            this.lisa_btn.Name = "lisa_btn";
            this.lisa_btn.Size = new System.Drawing.Size(130, 37);
            this.lisa_btn.TabIndex = 32;
            this.lisa_btn.Text = "Lisa toode";
            this.lisa_btn.UseVisualStyleBackColor = true;
            this.lisa_btn.Click += new System.EventHandler(this.lisa_btn_Click);
            // 
            // Kustuta_btn
            // 
            this.Kustuta_btn.BackColor = System.Drawing.Color.IndianRed;
            this.Kustuta_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Kustuta_btn.Location = new System.Drawing.Point(303, 251);
            this.Kustuta_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Kustuta_btn.Name = "Kustuta_btn";
            this.Kustuta_btn.Size = new System.Drawing.Size(116, 36);
            this.Kustuta_btn.TabIndex = 33;
            this.Kustuta_btn.Text = "Kustuta tooded";
            this.Kustuta_btn.UseVisualStyleBackColor = false;
            this.Kustuta_btn.Click += new System.EventHandler(this.Kustuta_btn_Click);
            // 
            // test_lbl
            // 
            this.test_lbl.AutoSize = true;
            this.test_lbl.Location = new System.Drawing.Point(478, 58);
            this.test_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.test_lbl.Name = "test_lbl";
            this.test_lbl.Size = new System.Drawing.Size(16, 16);
            this.test_lbl.TabIndex = 34;
            this.test_lbl.Text = "   ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(477, 251);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "sodus";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(477, 278);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 20);
            this.checkBox2.TabIndex = 36;
            this.checkBox2.Text = "kilekott";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 554);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.test_lbl);
            this.Controls.Add(this.Kustuta_btn);
            this.Controls.Add(this.lisa_btn);
            this.Controls.Add(this.hind_num);
            this.Controls.Add(this.kogus_num);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tsekk_btn);
            this.Controls.Add(this.toode_pbox);
            this.Controls.Add(this.Hind_lbl);
            this.Controls.Add(this.Kogus_lbl);
            this.Controls.Add(this.Toode_lbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "klient";
            this.Text = "kassa";
            ((System.ComponentModel.ISupportInitialize)(this.hind_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kogus_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toode_pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown hind_num;
        private System.Windows.Forms.NumericUpDown kogus_num;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button tsekk_btn;
        private System.Windows.Forms.PictureBox toode_pbox;
        private System.Windows.Forms.Label Hind_lbl;
        private System.Windows.Forms.Label Kogus_lbl;
        private System.Windows.Forms.Label Toode_lbl;
        private System.Windows.Forms.Button lisa_btn;
        private System.Windows.Forms.Button Kustuta_btn;
        private System.Windows.Forms.Label test_lbl;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}