namespace CZMLOY_jegyvasarlo
{
    partial class AdminForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_eloadasok = new System.Windows.Forms.ComboBox();
            this.pn_floor = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pn_upper = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_sumincome = new System.Windows.Forms.Label();
            this.dg_buy = new System.Windows.Forms.DataGridView();
            this.lb_vipincome = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_upincome = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_lowincome = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_buy)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1151, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kilépésToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Előadások";
            // 
            // cmb_eloadasok
            // 
            this.cmb_eloadasok.FormattingEnabled = true;
            this.cmb_eloadasok.Location = new System.Drawing.Point(116, 44);
            this.cmb_eloadasok.Name = "cmb_eloadasok";
            this.cmb_eloadasok.Size = new System.Drawing.Size(329, 24);
            this.cmb_eloadasok.TabIndex = 3;
            this.cmb_eloadasok.SelectedIndexChanged += new System.EventHandler(this.cmb_eloadasok_SelectedIndexChanged);
            // 
            // pn_floor
            // 
            this.pn_floor.Location = new System.Drawing.Point(62, 123);
            this.pn_floor.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pn_floor.Name = "pn_floor";
            this.pn_floor.Size = new System.Drawing.Size(620, 440);
            this.pn_floor.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "zsöllye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(323, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "SZÍNPAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "karzat";
            // 
            // pn_upper
            // 
            this.pn_upper.Location = new System.Drawing.Point(62, 570);
            this.pn_upper.Name = "pn_upper";
            this.pn_upper.Size = new System.Drawing.Size(620, 400);
            this.pn_upper.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(687, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 46);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bevétel";
            // 
            // lb_sumincome
            // 
            this.lb_sumincome.AutoSize = true;
            this.lb_sumincome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_sumincome.Location = new System.Drawing.Point(855, 384);
            this.lb_sumincome.Name = "lb_sumincome";
            this.lb_sumincome.Size = new System.Drawing.Size(0, 46);
            this.lb_sumincome.TabIndex = 15;
            // 
            // dg_buy
            // 
            this.dg_buy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dg_buy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_buy.Location = new System.Drawing.Point(687, 123);
            this.dg_buy.Name = "dg_buy";
            this.dg_buy.RowHeadersVisible = false;
            this.dg_buy.RowHeadersWidth = 51;
            this.dg_buy.RowTemplate.Height = 24;
            this.dg_buy.Size = new System.Drawing.Size(458, 242);
            this.dg_buy.TabIndex = 16;
            // 
            // lb_vipincome
            // 
            this.lb_vipincome.AutoSize = true;
            this.lb_vipincome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_vipincome.Location = new System.Drawing.Point(859, 477);
            this.lb_vipincome.Name = "lb_vipincome";
            this.lb_vipincome.Size = new System.Drawing.Size(0, 36);
            this.lb_vipincome.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(699, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 36);
            this.label7.TabIndex = 17;
            this.label7.Text = "VIP";
            // 
            // lb_upincome
            // 
            this.lb_upincome.AutoSize = true;
            this.lb_upincome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_upincome.Location = new System.Drawing.Point(859, 513);
            this.lb_upincome.Name = "lb_upincome";
            this.lb_upincome.Size = new System.Drawing.Size(0, 36);
            this.lb_upincome.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(699, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 36);
            this.label9.TabIndex = 19;
            this.label9.Text = "Karzat";
            // 
            // lb_lowincome
            // 
            this.lb_lowincome.AutoSize = true;
            this.lb_lowincome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_lowincome.Location = new System.Drawing.Point(861, 549);
            this.lb_lowincome.Name = "lb_lowincome";
            this.lb_lowincome.Size = new System.Drawing.Size(0, 36);
            this.lb_lowincome.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(701, 549);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 36);
            this.label11.TabIndex = 21;
            this.label11.Text = "Zsöllye";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(699, 439);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 36);
            this.label12.TabIndex = 23;
            this.label12.Text = "Ebből";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 1055);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lb_lowincome);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb_upincome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_vipincome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dg_buy);
            this.Controls.Add(this.lb_sumincome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pn_upper);
            this.Controls.Add(this.pn_floor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_eloadasok);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_buy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_eloadasok;
        private System.Windows.Forms.FlowLayoutPanel pn_floor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel pn_upper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_sumincome;
        private System.Windows.Forms.DataGridView dg_buy;
        private System.Windows.Forms.Label lb_vipincome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_upincome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_lowincome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}