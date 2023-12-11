namespace FinalProject
{
    partial class frmPathfinderCharacterViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPathfinderCharacterViewer));
            this.btnExit = new System.Windows.Forms.Button();
            this.bxCharacterViewer = new System.Windows.Forms.GroupBox();
            this.txtBoxBackstory = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numLevel = new System.Windows.Forms.NumericUpDown();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numChar = new System.Windows.Forms.NumericUpDown();
            this.numWis = new System.Windows.Forms.NumericUpDown();
            this.numIntel = new System.Windows.Forms.NumericUpDown();
            this.numCon = new System.Windows.Forms.NumericUpDown();
            this.numDex = new System.Windows.Forms.NumericUpDown();
            this.numStr = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblCharactersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.charactersDataSet = new FinalProject.CharactersDataSet();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tableAdapterManager = new FinalProject.CharactersDataSetTableAdapters.TableAdapterManager();
            this.tblCharactersTableAdapter = new FinalProject.CharactersDataSetTableAdapters.tblCharactersTableAdapter();
            this.tblCharactersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bxCharacterViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCharactersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCharactersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(954, 567);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 38);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bxCharacterViewer
            // 
            this.bxCharacterViewer.Controls.Add(this.txtBoxBackstory);
            this.bxCharacterViewer.Controls.Add(this.label11);
            this.bxCharacterViewer.Controls.Add(this.numLevel);
            this.bxCharacterViewer.Controls.Add(this.txtClass);
            this.bxCharacterViewer.Controls.Add(this.label10);
            this.bxCharacterViewer.Controls.Add(this.label9);
            this.bxCharacterViewer.Controls.Add(this.txtLast);
            this.bxCharacterViewer.Controls.Add(this.label8);
            this.bxCharacterViewer.Controls.Add(this.txtFirst);
            this.bxCharacterViewer.Controls.Add(this.label7);
            this.bxCharacterViewer.Controls.Add(this.numChar);
            this.bxCharacterViewer.Controls.Add(this.numWis);
            this.bxCharacterViewer.Controls.Add(this.numIntel);
            this.bxCharacterViewer.Controls.Add(this.numCon);
            this.bxCharacterViewer.Controls.Add(this.numDex);
            this.bxCharacterViewer.Controls.Add(this.numStr);
            this.bxCharacterViewer.Controls.Add(this.label6);
            this.bxCharacterViewer.Controls.Add(this.label5);
            this.bxCharacterViewer.Controls.Add(this.label4);
            this.bxCharacterViewer.Controls.Add(this.label3);
            this.bxCharacterViewer.Controls.Add(this.label2);
            this.bxCharacterViewer.Controls.Add(this.label1);
            this.bxCharacterViewer.Controls.Add(this.btnDelete);
            this.bxCharacterViewer.Controls.Add(this.btnCancel);
            this.bxCharacterViewer.Controls.Add(this.btnSave);
            this.bxCharacterViewer.Location = new System.Drawing.Point(493, 12);
            this.bxCharacterViewer.Name = "bxCharacterViewer";
            this.bxCharacterViewer.Size = new System.Drawing.Size(547, 549);
            this.bxCharacterViewer.TabIndex = 1;
            this.bxCharacterViewer.TabStop = false;
            this.bxCharacterViewer.Text = "Character Viewer";
            this.bxCharacterViewer.Enter += new System.EventHandler(this.bxCharacterViewer_Enter);
            // 
            // txtBoxBackstory
            // 
            this.txtBoxBackstory.Location = new System.Drawing.Point(93, 223);
            this.txtBoxBackstory.Name = "txtBoxBackstory";
            this.txtBoxBackstory.Size = new System.Drawing.Size(448, 282);
            this.txtBoxBackstory.TabIndex = 44;
            this.txtBoxBackstory.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Backstory";
            // 
            // numLevel
            // 
            this.numLevel.Location = new System.Drawing.Point(373, 148);
            this.numLevel.Name = "numLevel";
            this.numLevel.Size = new System.Drawing.Size(35, 20);
            this.numLevel.TabIndex = 42;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(131, 148);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 20);
            this.txtClass.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(336, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Level";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Class";
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(354, 37);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(129, 20);
            this.txtLast.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Last Name";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(131, 37);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "First Name";
            // 
            // numChar
            // 
            this.numChar.Location = new System.Drawing.Point(434, 106);
            this.numChar.Name = "numChar";
            this.numChar.Size = new System.Drawing.Size(32, 20);
            this.numChar.TabIndex = 35;
            // 
            // numWis
            // 
            this.numWis.Location = new System.Drawing.Point(376, 106);
            this.numWis.Name = "numWis";
            this.numWis.Size = new System.Drawing.Size(32, 20);
            this.numWis.TabIndex = 34;
            // 
            // numIntel
            // 
            this.numIntel.Location = new System.Drawing.Point(305, 105);
            this.numIntel.Name = "numIntel";
            this.numIntel.Size = new System.Drawing.Size(32, 20);
            this.numIntel.TabIndex = 33;
            // 
            // numCon
            // 
            this.numCon.Location = new System.Drawing.Point(232, 106);
            this.numCon.Name = "numCon";
            this.numCon.Size = new System.Drawing.Size(32, 20);
            this.numCon.TabIndex = 32;
            // 
            // numDex
            // 
            this.numDex.Location = new System.Drawing.Point(159, 106);
            this.numDex.Name = "numDex";
            this.numDex.Size = new System.Drawing.Size(32, 20);
            this.numDex.TabIndex = 31;
            // 
            // numStr
            // 
            this.numStr.Location = new System.Drawing.Point(93, 106);
            this.numStr.Name = "numStr";
            this.numStr.Size = new System.Drawing.Size(32, 20);
            this.numStr.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Charisma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Wisdom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Intellegence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Constitution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dexterity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Strength";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 511);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(180, 511);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 32);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 511);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tblCharactersBindingSource
            // 
            this.tblCharactersBindingSource.DataMember = "tblCharacters";
            this.tblCharactersBindingSource.DataSource = this.charactersDataSet;
            // 
            // charactersDataSet
            // 
            this.charactersDataSet.DataSetName = "CharactersDataSet";
            this.charactersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(396, 567);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(89, 38);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create New";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCharactersTableAdapter = this.tblCharactersTableAdapter;
            this.tableAdapterManager.UpdateOrder = FinalProject.CharactersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblCharactersTableAdapter
            // 
            this.tblCharactersTableAdapter.ClearBeforeFill = true;
            // 
            // tblCharactersDataGridView
            // 
            this.tblCharactersDataGridView.AllowUserToAddRows = false;
            this.tblCharactersDataGridView.AllowUserToDeleteRows = false;
            this.tblCharactersDataGridView.AutoGenerateColumns = false;
            this.tblCharactersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCharactersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7});
            this.tblCharactersDataGridView.DataSource = this.tblCharactersBindingSource;
            this.tblCharactersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.tblCharactersDataGridView.Name = "tblCharactersDataGridView";
            this.tblCharactersDataGridView.ReadOnly = true;
            this.tblCharactersDataGridView.Size = new System.Drawing.Size(473, 549);
            this.tblCharactersDataGridView.TabIndex = 3;
            this.tblCharactersDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblCharactersDataGridView_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Level";
            this.dataGridViewTextBoxColumn4.HeaderText = "Level";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Class";
            this.dataGridViewTextBoxColumn6.HeaderText = "Class";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FristName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FristName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Backstory";
            this.dataGridViewTextBoxColumn5.HeaderText = "Backstory";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Stats";
            this.dataGridViewTextBoxColumn7.HeaderText = "Stats";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmPathfinderCharacterViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 625);
            this.Controls.Add(this.tblCharactersDataGridView);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.bxCharacterViewer);
            this.Controls.Add(this.btnExit);
            this.DoubleBuffered = true;
            this.Name = "frmPathfinderCharacterViewer";
            this.Text = "Pathfinder Character Creater";
            this.Load += new System.EventHandler(this.frmPathfinderCharacterViewer_Load);
            this.bxCharacterViewer.ResumeLayout(false);
            this.bxCharacterViewer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCharactersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCharactersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox bxCharacterViewer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private CharactersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CharactersDataSetTableAdapters.tblCharactersTableAdapter tblCharactersTableAdapter;
        private System.Windows.Forms.BindingSource tblCharactersBindingSource;
        private CharactersDataSet charactersDataSet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tblCharactersDataGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown numChar;
        private System.Windows.Forms.NumericUpDown numWis;
        private System.Windows.Forms.NumericUpDown numIntel;
        private System.Windows.Forms.NumericUpDown numCon;
        private System.Windows.Forms.NumericUpDown numDex;
        private System.Windows.Forms.NumericUpDown numStr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.NumericUpDown numLevel;
        private System.Windows.Forms.RichTextBox txtBoxBackstory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

