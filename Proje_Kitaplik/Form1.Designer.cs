namespace Proje_Kitaplik
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
            this.btnList = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.txtBookPage = new System.Windows.Forms.TextBox();
            this.cmbBookType = new System.Windows.Forms.ComboBox();
            this.rdNew = new System.Windows.Forms.RadioButton();
            this.rdOld = new System.Windows.Forms.RadioButton();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(448, 6);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(129, 31);
            this.btnList.TabIndex = 8;
            this.btnList.Text = "LİSTELE";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(448, 43);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(129, 31);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "EKLE";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(448, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 31);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(448, 117);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 31);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtBooks
            // 
            this.dtBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBooks.Location = new System.Drawing.Point(12, 229);
            this.dtBooks.Name = "dtBooks";
            this.dtBooks.Size = new System.Drawing.Size(850, 234);
            this.dtBooks.TabIndex = 12;
            this.dtBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtBooks_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kitap ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kitap Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kitap Yazarı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sayfa Sayısı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kitap Türü :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Durum :";
            // 
            // txtBookID
            // 
            this.txtBookID.Enabled = false;
            this.txtBookID.Location = new System.Drawing.Point(177, 6);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(226, 29);
            this.txtBookID.TabIndex = 1;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(177, 41);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(226, 29);
            this.txtBookName.TabIndex = 16;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(177, 75);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(226, 29);
            this.txtAuthorName.TabIndex = 3;
            // 
            // txtBookPage
            // 
            this.txtBookPage.Location = new System.Drawing.Point(177, 146);
            this.txtBookPage.Name = "txtBookPage";
            this.txtBookPage.Size = new System.Drawing.Size(226, 29);
            this.txtBookPage.TabIndex = 4;
            // 
            // cmbBookType
            // 
            this.cmbBookType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookType.FormattingEnabled = true;
            this.cmbBookType.Items.AddRange(new object[] {
            "",
            "Hikaye",
            "Roman",
            "Masal",
            "Şiir",
            "Türk Klas",
            "Bilim",
            "Tarih",
            "Matematik"});
            this.cmbBookType.Location = new System.Drawing.Point(177, 109);
            this.cmbBookType.Name = "cmbBookType";
            this.cmbBookType.Size = new System.Drawing.Size(226, 30);
            this.cmbBookType.TabIndex = 5;
            // 
            // rdNew
            // 
            this.rdNew.AutoSize = true;
            this.rdNew.Location = new System.Drawing.Point(177, 181);
            this.rdNew.Name = "rdNew";
            this.rdNew.Size = new System.Drawing.Size(65, 26);
            this.rdNew.TabIndex = 6;
            this.rdNew.TabStop = true;
            this.rdNew.Text = "Sıfır";
            this.rdNew.UseVisualStyleBackColor = true;
            this.rdNew.CheckedChanged += new System.EventHandler(this.rdNew_CheckedChanged);
            // 
            // rdOld
            // 
            this.rdOld.AutoSize = true;
            this.rdOld.Location = new System.Drawing.Point(336, 181);
            this.rdOld.Name = "rdOld";
            this.rdOld.Size = new System.Drawing.Size(67, 26);
            this.rdOld.TabIndex = 7;
            this.rdOld.TabStop = true;
            this.rdOld.Text = "2. El";
            this.rdOld.UseVisualStyleBackColor = true;
            this.rdOld.CheckedChanged += new System.EventHandler(this.rdOld_CheckedChanged);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(730, 16);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(71, 22);
            this.lblDurum.TabIndex = 13;
            this.lblDurum.Text = "durum";
            this.lblDurum.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(448, 154);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 31);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "TEMİZLE";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(636, 181);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(226, 29);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(576, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ara :";
            this.label7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(874, 472);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.rdOld);
            this.Controls.Add(this.rdNew);
            this.Controls.Add(this.cmbBookType);
            this.Controls.Add(this.txtBookPage);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtBooks);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnList);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitaplık Projesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dtBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtBookPage;
        private System.Windows.Forms.ComboBox cmbBookType;
        private System.Windows.Forms.RadioButton rdNew;
        private System.Windows.Forms.RadioButton rdOld;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
    }
}

