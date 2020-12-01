namespace CZMLOY_jegyvasarlo
{
    partial class UserForm
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
            this.cmb_eloadasok = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pn_floor = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_upper = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_coupon = new System.Windows.Forms.TextBox();
            this.lb_coupon = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_cupon = new System.Windows.Forms.Button();
            this.dg_tickets = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tickets)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1014, 28);
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
            // cmb_eloadasok
            // 
            this.cmb_eloadasok.FormattingEnabled = true;
            this.cmb_eloadasok.Location = new System.Drawing.Point(115, 41);
            this.cmb_eloadasok.Name = "cmb_eloadasok";
            this.cmb_eloadasok.Size = new System.Drawing.Size(329, 24);
            this.cmb_eloadasok.TabIndex = 1;
            this.cmb_eloadasok.SelectedIndexChanged += new System.EventHandler(this.cmb_eloadasok_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Előadások";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(322, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "SZÍNPAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "zsöllye";
            // 
            // pn_floor
            // 
            this.pn_floor.Location = new System.Drawing.Point(61, 119);
            this.pn_floor.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pn_floor.Name = "pn_floor";
            this.pn_floor.Size = new System.Drawing.Size(620, 440);
            this.pn_floor.TabIndex = 8;
            // 
            // pn_upper
            // 
            this.pn_upper.Location = new System.Drawing.Point(61, 570);
            this.pn_upper.Name = "pn_upper";
            this.pn_upper.Size = new System.Drawing.Size(620, 400);
            this.pn_upper.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "karzat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(702, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Név";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(742, 121);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(156, 22);
            this.tb_name.TabIndex = 12;
            // 
            // tb_coupon
            // 
            this.tb_coupon.Location = new System.Drawing.Point(810, 523);
            this.tb_coupon.Name = "tb_coupon";
            this.tb_coupon.Size = new System.Drawing.Size(156, 22);
            this.tb_coupon.TabIndex = 14;
            // 
            // lb_coupon
            // 
            this.lb_coupon.AutoSize = true;
            this.lb_coupon.Location = new System.Drawing.Point(755, 526);
            this.lb_coupon.Name = "lb_coupon";
            this.lb_coupon.Size = new System.Drawing.Size(49, 17);
            this.lb_coupon.TabIndex = 13;
            this.lb_coupon.Text = "Kupon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(702, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kiválaszott jegyek";
            // 
            // btn_cupon
            // 
            this.btn_cupon.Location = new System.Drawing.Point(810, 564);
            this.btn_cupon.Name = "btn_cupon";
            this.btn_cupon.Size = new System.Drawing.Size(156, 23);
            this.btn_cupon.TabIndex = 17;
            this.btn_cupon.Text = "Aktiválás";
            this.btn_cupon.UseVisualStyleBackColor = true;
            // 
            // dg_tickets
            // 
            this.dg_tickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dg_tickets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dg_tickets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg_tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_tickets.ColumnHeadersVisible = false;
            this.dg_tickets.Location = new System.Drawing.Point(705, 192);
            this.dg_tickets.Name = "dg_tickets";
            this.dg_tickets.RowHeadersVisible = false;
            this.dg_tickets.RowHeadersWidth = 51;
            this.dg_tickets.RowTemplate.Height = 24;
            this.dg_tickets.Size = new System.Drawing.Size(297, 150);
            this.dg_tickets.TabIndex = 15;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 1042);
            this.Controls.Add(this.btn_cupon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dg_tickets);
            this.Controls.Add(this.tb_coupon);
            this.Controls.Add(this.lb_coupon);
            this.Controls.Add(this.tb_name);
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
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmb_eloadasok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel pn_floor;
        private System.Windows.Forms.FlowLayoutPanel pn_upper;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_coupon;
        private System.Windows.Forms.Label lb_coupon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_cupon;
        private System.Windows.Forms.DataGridView dg_tickets;
    }
}