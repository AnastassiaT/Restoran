namespace restoranTsausova
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
            this.label1 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtSuurus = new System.Windows.Forms.TextBox();
            this.radioVid = new System.Windows.Forms.RadioButton();
            this.txtVid = new System.Windows.Forms.TextBox();
            this.radioVid2 = new System.Windows.Forms.RadioButton();
            this.radioVid3 = new System.Windows.Forms.RadioButton();
            this.radioVid4 = new System.Windows.Forms.RadioButton();
            this.radioVid5 = new System.Windows.Forms.RadioButton();
            this.radioVid6 = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.restoranDataSet = new restoranTsausova.RestoranDataSet();
            this.menuuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuuTableAdapter = new restoranTsausova.RestoranDataSetTableAdapters.MenuuTableAdapter();
            this.restoranDataSet1 = new restoranTsausova.RestoranDataSet1();
            this.menuuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuuTableAdapter1 = new restoranTsausova.RestoranDataSet1TableAdapters.MenuuTableAdapter();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.numberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(297, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ресторан Анастасия";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.BackColor = System.Drawing.Color.Transparent;
            this.Number.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Number.Location = new System.Drawing.Point(57, 96);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(146, 25);
            this.Number.TabIndex = 2;
            this.Number.Text = "Номер столика";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(57, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 3;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(255, 101);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(269, 20);
            this.txtNumber.TabIndex = 5;
            // 
            // txtSuurus
            // 
            this.txtSuurus.Location = new System.Drawing.Point(255, 191);
            this.txtSuurus.Name = "txtSuurus";
            this.txtSuurus.Size = new System.Drawing.Size(269, 20);
            this.txtSuurus.TabIndex = 7;
            // 
            // radioVid
            // 
            this.radioVid.AutoSize = true;
            this.radioVid.BackColor = System.Drawing.Color.Transparent;
            this.radioVid.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.radioVid.Location = new System.Drawing.Point(62, 175);
            this.radioVid.Name = "radioVid";
            this.radioVid.Size = new System.Drawing.Size(106, 26);
            this.radioVid.TabIndex = 8;
            this.radioVid.TabStop = true;
            this.radioVid.Text = "Пеперони";
            this.radioVid.UseVisualStyleBackColor = false;
            this.radioVid.CheckedChanged += new System.EventHandler(this.RadioVid_CheckedChanged);
            // 
            // txtVid
            // 
            this.txtVid.Location = new System.Drawing.Point(255, 146);
            this.txtVid.Name = "txtVid";
            this.txtVid.Size = new System.Drawing.Size(269, 20);
            this.txtVid.TabIndex = 9;
            // 
            // radioVid2
            // 
            this.radioVid2.AutoSize = true;
            this.radioVid2.BackColor = System.Drawing.Color.Transparent;
            this.radioVid2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radioVid2.Location = new System.Drawing.Point(62, 274);
            this.radioVid2.Name = "radioVid2";
            this.radioVid2.Size = new System.Drawing.Size(146, 26);
            this.radioVid2.TabIndex = 10;
            this.radioVid2.TabStop = true;
            this.radioVid2.Text = "Мясная пицца";
            this.radioVid2.UseVisualStyleBackColor = false;
            this.radioVid2.CheckedChanged += new System.EventHandler(this.RadioVid2_CheckedChanged);
            // 
            // radioVid3
            // 
            this.radioVid3.AutoSize = true;
            this.radioVid3.BackColor = System.Drawing.Color.Transparent;
            this.radioVid3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radioVid3.Location = new System.Drawing.Point(62, 306);
            this.radioVid3.Name = "radioVid3";
            this.radioVid3.Size = new System.Drawing.Size(214, 26);
            this.radioVid3.TabIndex = 11;
            this.radioVid3.TabStop = true;
            this.radioVid3.Text = "Вегетарианская пицца";
            this.radioVid3.UseVisualStyleBackColor = false;
            this.radioVid3.CheckedChanged += new System.EventHandler(this.RadioVid3_CheckedChanged);
            // 
            // radioVid4
            // 
            this.radioVid4.AutoSize = true;
            this.radioVid4.BackColor = System.Drawing.Color.Transparent;
            this.radioVid4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radioVid4.Location = new System.Drawing.Point(62, 209);
            this.radioVid4.Name = "radioVid4";
            this.radioVid4.Size = new System.Drawing.Size(121, 26);
            this.radioVid4.TabIndex = 12;
            this.radioVid4.TabStop = true;
            this.radioVid4.Text = "Маргарита";
            this.radioVid4.UseVisualStyleBackColor = false;
            this.radioVid4.CheckedChanged += new System.EventHandler(this.RadioVid4_CheckedChanged);
            // 
            // radioVid5
            // 
            this.radioVid5.AutoSize = true;
            this.radioVid5.BackColor = System.Drawing.Color.Transparent;
            this.radioVid5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radioVid5.Location = new System.Drawing.Point(62, 242);
            this.radioVid5.Name = "radioVid5";
            this.radioVid5.Size = new System.Drawing.Size(137, 26);
            this.radioVid5.TabIndex = 13;
            this.radioVid5.TabStop = true;
            this.radioVid5.Text = "Четыре сыра";
            this.radioVid5.UseVisualStyleBackColor = false;
            this.radioVid5.CheckedChanged += new System.EventHandler(this.RadioVid5_CheckedChanged);
            // 
            // radioVid6
            // 
            this.radioVid6.AutoSize = true;
            this.radioVid6.BackColor = System.Drawing.Color.Transparent;
            this.radioVid6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radioVid6.Location = new System.Drawing.Point(62, 338);
            this.radioVid6.Name = "radioVid6";
            this.radioVid6.Size = new System.Drawing.Size(238, 26);
            this.radioVid6.TabIndex = 15;
            this.radioVid6.TabStop = true;
            this.radioVid6.Text = "Пицца с морепродуктами";
            this.radioVid6.UseVisualStyleBackColor = false;
            this.radioVid6.CheckedChanged += new System.EventHandler(this.RadioVid6_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Маленькая (25 см) - 6€",
            "Средняя (30см) - 8€",
            "Большая (35см) - 12€",
            "Семейная (40см) - 15€"});
            this.checkedListBox1.Location = new System.Drawing.Point(62, 436);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(220, 100);
            this.checkedListBox1.TabIndex = 16;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(57, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Размер пиццы и её цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(62, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Виды пицц";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkViolet;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSave.Location = new System.Drawing.Point(608, 508);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 39);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkViolet;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDelete.Location = new System.Drawing.Point(728, 508);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 39);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkViolet;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnReset.Location = new System.Drawing.Point(842, 508);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 39);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkViolet;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSearch.Location = new System.Drawing.Point(833, 96);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 39);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(558, 101);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(269, 20);
            this.txtSearch.TabIndex = 23;
            // 
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuuBindingSource
            // 
            this.menuuBindingSource.DataMember = "Menuu";
            this.menuuBindingSource.DataSource = this.restoranDataSet;
            // 
            // menuuTableAdapter
            // 
            this.menuuTableAdapter.ClearBeforeFill = true;
            // 
            // restoranDataSet1
            // 
            this.restoranDataSet1.DataSetName = "RestoranDataSet1";
            this.restoranDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuuBindingSource1
            // 
            this.menuuBindingSource1.DataMember = "Menuu";
            this.menuuBindingSource1.DataSource = this.restoranDataSet1;
            // 
            // menuuTableAdapter1
            // 
            this.menuuTableAdapter1.ClearBeforeFill = true;
            // 
            // DataGrid
            // 
            this.DataGrid.AutoGenerateColumns = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberIDDataGridViewTextBoxColumn,
            this.tableNumberDataGridViewTextBoxColumn,
            this.vidDataGridViewTextBoxColumn,
            this.hindDataGridViewTextBoxColumn});
            this.DataGrid.DataSource = this.menuuBindingSource;
            this.DataGrid.Location = new System.Drawing.Point(607, 306);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(334, 188);
            this.DataGrid.TabIndex = 24;
            // 
            // numberIDDataGridViewTextBoxColumn
            // 
            this.numberIDDataGridViewTextBoxColumn.DataPropertyName = "NumberID";
            this.numberIDDataGridViewTextBoxColumn.HeaderText = "NumberID";
            this.numberIDDataGridViewTextBoxColumn.Name = "numberIDDataGridViewTextBoxColumn";
            // 
            // tableNumberDataGridViewTextBoxColumn
            // 
            this.tableNumberDataGridViewTextBoxColumn.DataPropertyName = "TableNumber";
            this.tableNumberDataGridViewTextBoxColumn.HeaderText = "TableNumber";
            this.tableNumberDataGridViewTextBoxColumn.Name = "tableNumberDataGridViewTextBoxColumn";
            // 
            // vidDataGridViewTextBoxColumn
            // 
            this.vidDataGridViewTextBoxColumn.DataPropertyName = "Vid";
            this.vidDataGridViewTextBoxColumn.HeaderText = "Vid";
            this.vidDataGridViewTextBoxColumn.Name = "vidDataGridViewTextBoxColumn";
            // 
            // hindDataGridViewTextBoxColumn
            // 
            this.hindDataGridViewTextBoxColumn.DataPropertyName = "Hind";
            this.hindDataGridViewTextBoxColumn.HeaderText = "Hind";
            this.hindDataGridViewTextBoxColumn.Name = "hindDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::restoranTsausova.Properties.Resources.marco_completo_fondo_acuarela_textura_purpura_23_2148153334;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 632);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.radioVid6);
            this.Controls.Add(this.radioVid5);
            this.Controls.Add(this.radioVid4);
            this.Controls.Add(this.radioVid3);
            this.Controls.Add(this.radioVid2);
            this.Controls.Add(this.txtVid);
            this.Controls.Add(this.radioVid);
            this.Controls.Add(this.txtSuurus);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtSuurus;
        private System.Windows.Forms.RadioButton radioVid;
        private System.Windows.Forms.TextBox txtVid;
        private System.Windows.Forms.RadioButton radioVid2;
        private System.Windows.Forms.RadioButton radioVid3;
        private System.Windows.Forms.RadioButton radioVid4;
        private System.Windows.Forms.RadioButton radioVid5;
        private System.Windows.Forms.RadioButton radioVid6;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource menuuBindingSource;
        private RestoranDataSetTableAdapters.MenuuTableAdapter menuuTableAdapter;
        private RestoranDataSet1 restoranDataSet1;
        private System.Windows.Forms.BindingSource menuuBindingSource1;
        private RestoranDataSet1TableAdapters.MenuuTableAdapter menuuTableAdapter1;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hindDataGridViewTextBoxColumn;
    }
}

