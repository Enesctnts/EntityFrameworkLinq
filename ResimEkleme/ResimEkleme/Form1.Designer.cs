
namespace ResimEkleme
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
            this.components = new System.ComponentModel.Container();
            this.lblID = new System.Windows.Forms.Label();
            this.txtFilmId = new System.Windows.Forms.TextBox();
            this.txtFilmAdı = new System.Windows.Forms.TextBox();
            this.lblFilmAdı = new System.Windows.Forms.Label();
            this.txtFilmTürü = new System.Windows.Forms.TextBox();
            this.lblTürü = new System.Windows.Forms.Label();
            this.txtFilmPuan = new System.Windows.Forms.TextBox();
            this.lblPuan = new System.Windows.Forms.Label();
            this.txtResim = new System.Windows.Forms.TextBox();
            this.lblResim = new System.Windows.Forms.Label();
            this.txtFilmKategori = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.dgwGöster = new System.Windows.Forms.DataGridView();
            this.ResimBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnArana = new System.Windows.Forms.Button();
            this.filmArsivDataSet = new ResimEkleme.FilmArsivDataSet();
            this.tblFilmlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_FilmlerTableAdapter = new ResimEkleme.FilmArsivDataSetTableAdapters.Tbl_FilmlerTableAdapter();
            this.filmIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmTurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmPuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmKategoriDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.filmResimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGöster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResimBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmArsivDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilmlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Location = new System.Drawing.Point(39, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Film id:";
            // 
            // txtFilmId
            // 
            this.txtFilmId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmId.Location = new System.Drawing.Point(103, 12);
            this.txtFilmId.Multiline = true;
            this.txtFilmId.Name = "txtFilmId";
            this.txtFilmId.Size = new System.Drawing.Size(123, 29);
            this.txtFilmId.TabIndex = 1;
            // 
            // txtFilmAdı
            // 
            this.txtFilmAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmAdı.Location = new System.Drawing.Point(103, 44);
            this.txtFilmAdı.Multiline = true;
            this.txtFilmAdı.Name = "txtFilmAdı";
            this.txtFilmAdı.Size = new System.Drawing.Size(123, 29);
            this.txtFilmAdı.TabIndex = 3;
            // 
            // lblFilmAdı
            // 
            this.lblFilmAdı.AutoSize = true;
            this.lblFilmAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmAdı.Location = new System.Drawing.Point(31, 53);
            this.lblFilmAdı.Name = "lblFilmAdı";
            this.lblFilmAdı.Size = new System.Drawing.Size(66, 20);
            this.lblFilmAdı.TabIndex = 2;
            this.lblFilmAdı.Text = "Film Ad:";
            // 
            // txtFilmTürü
            // 
            this.txtFilmTürü.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmTürü.Location = new System.Drawing.Point(103, 78);
            this.txtFilmTürü.Multiline = true;
            this.txtFilmTürü.Name = "txtFilmTürü";
            this.txtFilmTürü.Size = new System.Drawing.Size(123, 29);
            this.txtFilmTürü.TabIndex = 5;
            // 
            // lblTürü
            // 
            this.lblTürü.AutoSize = true;
            this.lblTürü.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTürü.Location = new System.Drawing.Point(47, 87);
            this.lblTürü.Name = "lblTürü";
            this.lblTürü.Size = new System.Drawing.Size(45, 20);
            this.lblTürü.TabIndex = 4;
            this.lblTürü.Text = "Türü:";
            // 
            // txtFilmPuan
            // 
            this.txtFilmPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmPuan.Location = new System.Drawing.Point(103, 113);
            this.txtFilmPuan.Multiline = true;
            this.txtFilmPuan.Name = "txtFilmPuan";
            this.txtFilmPuan.Size = new System.Drawing.Size(123, 29);
            this.txtFilmPuan.TabIndex = 7;
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.Location = new System.Drawing.Point(47, 122);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(50, 20);
            this.lblPuan.TabIndex = 6;
            this.lblPuan.Text = "Puan:";
            // 
            // txtResim
            // 
            this.txtResim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtResim.Location = new System.Drawing.Point(103, 183);
            this.txtResim.Multiline = true;
            this.txtResim.Name = "txtResim";
            this.txtResim.Size = new System.Drawing.Size(123, 29);
            this.txtResim.TabIndex = 11;
            // 
            // lblResim
            // 
            this.lblResim.AutoSize = true;
            this.lblResim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResim.Location = new System.Drawing.Point(39, 192);
            this.lblResim.Name = "lblResim";
            this.lblResim.Size = new System.Drawing.Size(58, 20);
            this.lblResim.TabIndex = 10;
            this.lblResim.Text = "Resim:";
            // 
            // txtFilmKategori
            // 
            this.txtFilmKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmKategori.Location = new System.Drawing.Point(103, 148);
            this.txtFilmKategori.Multiline = true;
            this.txtFilmKategori.Name = "txtFilmKategori";
            this.txtFilmKategori.Size = new System.Drawing.Size(123, 29);
            this.txtFilmKategori.TabIndex = 9;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategori.Location = new System.Drawing.Point(25, 157);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(72, 20);
            this.lblKategori.TabIndex = 8;
            this.lblKategori.Text = "Kategori:";
            // 
            // dgwGöster
            // 
            this.dgwGöster.AutoGenerateColumns = false;
            this.dgwGöster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGöster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmIdDataGridViewTextBoxColumn,
            this.filmAdDataGridViewTextBoxColumn,
            this.filmTurDataGridViewTextBoxColumn,
            this.filmPuanDataGridViewTextBoxColumn,
            this.filmKategoriDataGridViewCheckBoxColumn,
            this.filmResimDataGridViewTextBoxColumn});
            this.dgwGöster.DataSource = this.tblFilmlerBindingSource;
            this.dgwGöster.Location = new System.Drawing.Point(12, 298);
            this.dgwGöster.Name = "dgwGöster";
            this.dgwGöster.Size = new System.Drawing.Size(776, 150);
            this.dgwGöster.TabIndex = 12;
            this.dgwGöster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwGöster_CellClick);
            // 
            // ResimBox
            // 
            this.ResimBox.Location = new System.Drawing.Point(330, 12);
            this.ResimBox.Name = "ResimBox";
            this.ResimBox.Size = new System.Drawing.Size(300, 280);
            this.ResimBox.TabIndex = 13;
            this.ResimBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(113, 218);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(103, 26);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnArana
            // 
            this.btnArana.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnArana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArana.Location = new System.Drawing.Point(232, 183);
            this.btnArana.Name = "btnArana";
            this.btnArana.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnArana.Size = new System.Drawing.Size(38, 29);
            this.btnArana.TabIndex = 16;
            this.btnArana.Text = "...";
            this.btnArana.UseVisualStyleBackColor = true;
            this.btnArana.Click += new System.EventHandler(this.btnArana_Click);
            // 
            // filmArsivDataSet
            // 
            this.filmArsivDataSet.DataSetName = "FilmArsivDataSet";
            this.filmArsivDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFilmlerBindingSource
            // 
            this.tblFilmlerBindingSource.DataMember = "Tbl_Filmler";
            this.tblFilmlerBindingSource.DataSource = this.filmArsivDataSet;
            // 
            // tbl_FilmlerTableAdapter
            // 
            this.tbl_FilmlerTableAdapter.ClearBeforeFill = true;
            // 
            // filmIdDataGridViewTextBoxColumn
            // 
            this.filmIdDataGridViewTextBoxColumn.DataPropertyName = "FilmId";
            this.filmIdDataGridViewTextBoxColumn.HeaderText = "FilmId";
            this.filmIdDataGridViewTextBoxColumn.Name = "filmIdDataGridViewTextBoxColumn";
            this.filmIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmAdDataGridViewTextBoxColumn
            // 
            this.filmAdDataGridViewTextBoxColumn.DataPropertyName = "FilmAd";
            this.filmAdDataGridViewTextBoxColumn.HeaderText = "FilmAd";
            this.filmAdDataGridViewTextBoxColumn.Name = "filmAdDataGridViewTextBoxColumn";
            // 
            // filmTurDataGridViewTextBoxColumn
            // 
            this.filmTurDataGridViewTextBoxColumn.DataPropertyName = "FilmTur";
            this.filmTurDataGridViewTextBoxColumn.HeaderText = "FilmTur";
            this.filmTurDataGridViewTextBoxColumn.Name = "filmTurDataGridViewTextBoxColumn";
            // 
            // filmPuanDataGridViewTextBoxColumn
            // 
            this.filmPuanDataGridViewTextBoxColumn.DataPropertyName = "FilmPuan";
            this.filmPuanDataGridViewTextBoxColumn.HeaderText = "FilmPuan";
            this.filmPuanDataGridViewTextBoxColumn.Name = "filmPuanDataGridViewTextBoxColumn";
            // 
            // filmKategoriDataGridViewCheckBoxColumn
            // 
            this.filmKategoriDataGridViewCheckBoxColumn.DataPropertyName = "FilmKategori";
            this.filmKategoriDataGridViewCheckBoxColumn.HeaderText = "FilmKategori";
            this.filmKategoriDataGridViewCheckBoxColumn.Name = "filmKategoriDataGridViewCheckBoxColumn";
            // 
            // filmResimDataGridViewTextBoxColumn
            // 
            this.filmResimDataGridViewTextBoxColumn.DataPropertyName = "FilmResim";
            this.filmResimDataGridViewTextBoxColumn.HeaderText = "FilmResim";
            this.filmResimDataGridViewTextBoxColumn.Name = "filmResimDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnArana);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.ResimBox);
            this.Controls.Add(this.dgwGöster);
            this.Controls.Add(this.txtResim);
            this.Controls.Add(this.txtFilmKategori);
            this.Controls.Add(this.txtFilmPuan);
            this.Controls.Add(this.txtFilmTürü);
            this.Controls.Add(this.txtFilmAdı);
            this.Controls.Add(this.txtFilmId);
            this.Controls.Add(this.lblResim);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.lblTürü);
            this.Controls.Add(this.lblFilmAdı);
            this.Controls.Add(this.lblID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGöster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResimBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmArsivDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilmlerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtFilmId;
        private System.Windows.Forms.TextBox txtFilmAdı;
        private System.Windows.Forms.Label lblFilmAdı;
        private System.Windows.Forms.TextBox txtFilmTürü;
        private System.Windows.Forms.Label lblTürü;
        private System.Windows.Forms.TextBox txtFilmPuan;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.TextBox txtResim;
        private System.Windows.Forms.Label lblResim;
        private System.Windows.Forms.TextBox txtFilmKategori;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.DataGridView dgwGöster;
        private System.Windows.Forms.PictureBox ResimBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnArana;
        private FilmArsivDataSet filmArsivDataSet;
        private System.Windows.Forms.BindingSource tblFilmlerBindingSource;
        private FilmArsivDataSetTableAdapters.Tbl_FilmlerTableAdapter tbl_FilmlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmTurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmPuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn filmKategoriDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmResimDataGridViewTextBoxColumn;
    }
}

