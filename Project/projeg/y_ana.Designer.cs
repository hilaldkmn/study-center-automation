namespace projeg
{
    partial class y_ana
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(y_ana));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeDataSet = new projeg.projeDataSet();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter = new projeg.projeDataSetTableAdapters.ogrenciTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ücretiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögretmenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.töplamdevamsizlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yorumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.günDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.anasayfaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // projeDataSet
            // 
            this.projeDataSet.DataSetName = "projeDataSet";
            this.projeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "ogrenci";
            this.ogrenciBindingSource.DataSource = this.projeDataSet;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numaraDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.dersDataGridViewTextBoxColumn,
            this.ücretiDataGridViewTextBoxColumn,
            this.ögretmenDataGridViewTextBoxColumn,
            this.töplamdevamsizlikDataGridViewTextBoxColumn,
            this.yorumDataGridViewTextBoxColumn,
            this.günDataGridViewTextBoxColumn,
            this.saatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(301, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(739, 353);
            this.dataGridView1.TabIndex = 1;
            // 
            // numaraDataGridViewTextBoxColumn
            // 
            this.numaraDataGridViewTextBoxColumn.DataPropertyName = "numara";
            this.numaraDataGridViewTextBoxColumn.HeaderText = "numara";
            this.numaraDataGridViewTextBoxColumn.Name = "numaraDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // dersDataGridViewTextBoxColumn
            // 
            this.dersDataGridViewTextBoxColumn.DataPropertyName = "ders";
            this.dersDataGridViewTextBoxColumn.HeaderText = "ders";
            this.dersDataGridViewTextBoxColumn.Name = "dersDataGridViewTextBoxColumn";
            // 
            // ücretiDataGridViewTextBoxColumn
            // 
            this.ücretiDataGridViewTextBoxColumn.DataPropertyName = "ücreti";
            this.ücretiDataGridViewTextBoxColumn.HeaderText = "ücreti";
            this.ücretiDataGridViewTextBoxColumn.Name = "ücretiDataGridViewTextBoxColumn";
            // 
            // ögretmenDataGridViewTextBoxColumn
            // 
            this.ögretmenDataGridViewTextBoxColumn.DataPropertyName = "ögretmen";
            this.ögretmenDataGridViewTextBoxColumn.HeaderText = "ögretmen";
            this.ögretmenDataGridViewTextBoxColumn.Name = "ögretmenDataGridViewTextBoxColumn";
            // 
            // töplamdevamsizlikDataGridViewTextBoxColumn
            // 
            this.töplamdevamsizlikDataGridViewTextBoxColumn.DataPropertyName = "töplam_devamsizlik";
            this.töplamdevamsizlikDataGridViewTextBoxColumn.HeaderText = "töplam_devamsizlik";
            this.töplamdevamsizlikDataGridViewTextBoxColumn.Name = "töplamdevamsizlikDataGridViewTextBoxColumn";
            // 
            // yorumDataGridViewTextBoxColumn
            // 
            this.yorumDataGridViewTextBoxColumn.DataPropertyName = "yorum";
            this.yorumDataGridViewTextBoxColumn.HeaderText = "yorum";
            this.yorumDataGridViewTextBoxColumn.Name = "yorumDataGridViewTextBoxColumn";
            // 
            // günDataGridViewTextBoxColumn
            // 
            this.günDataGridViewTextBoxColumn.DataPropertyName = "gün";
            this.günDataGridViewTextBoxColumn.HeaderText = "gün";
            this.günDataGridViewTextBoxColumn.Name = "günDataGridViewTextBoxColumn";
            // 
            // saatDataGridViewTextBoxColumn
            // 
            this.saatDataGridViewTextBoxColumn.DataPropertyName = "saat";
            this.saatDataGridViewTextBoxColumn.HeaderText = "saat";
            this.saatDataGridViewTextBoxColumn.Name = "saatDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(24, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 167);
            this.button1.TabIndex = 2;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(24, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 167);
            this.button2.TabIndex = 3;
            this.button2.Text = " ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // y_ana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1068, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "y_ana";
            this.Text = "y_ana";
            this.Load += new System.EventHandler(this.y_ana_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private projeDataSet projeDataSet;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private projeDataSetTableAdapters.ogrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ücretiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögretmenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn töplamdevamsizlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yorumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn günDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}