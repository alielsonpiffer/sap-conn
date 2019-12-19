namespace SapConn
{
    partial class StructureView
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
            this.ParameterGridView = new System.Windows.Forms.DataGridView();
            this.BtnOK = new System.Windows.Forms.Button();
            this.parameterMetadataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.optionalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.extendedDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nucLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decimalsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ParameterGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parameterMetadataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ParameterGridView
            // 
            this.ParameterGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParameterGridView.AutoGenerateColumns = false;
            this.ParameterGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParameterGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.defaultValueDataGridViewTextBoxColumn,
            this.dataTypeDataGridViewTextBoxColumn,
            this.documentationDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.optionalDataGridViewCheckBoxColumn,
            this.extendedDescriptionDataGridViewTextBoxColumn,
            this.nucLengthDataGridViewTextBoxColumn,
            this.ucLengthDataGridViewTextBoxColumn,
            this.decimalsDataGridViewTextBoxColumn});
            this.ParameterGridView.DataSource = this.parameterMetadataBindingSource;
            this.ParameterGridView.Location = new System.Drawing.Point(15, 12);
            this.ParameterGridView.Name = "ParameterGridView";
            this.ParameterGridView.Size = new System.Drawing.Size(711, 394);
            this.ParameterGridView.TabIndex = 0;
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOK.Location = new System.Drawing.Point(651, 412);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // parameterMetadataBindingSource
            // 
            this.parameterMetadataBindingSource.DataSource = typeof(SapConn.Models.ParameterMetadata);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 30F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.FillWeight = 70F;
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // defaultValueDataGridViewTextBoxColumn
            // 
            this.defaultValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.defaultValueDataGridViewTextBoxColumn.DataPropertyName = "DefaultValue";
            this.defaultValueDataGridViewTextBoxColumn.HeaderText = "DefaultValue";
            this.defaultValueDataGridViewTextBoxColumn.Name = "defaultValueDataGridViewTextBoxColumn";
            this.defaultValueDataGridViewTextBoxColumn.Width = 93;
            // 
            // dataTypeDataGridViewTextBoxColumn
            // 
            this.dataTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataTypeDataGridViewTextBoxColumn.DataPropertyName = "DataType";
            this.dataTypeDataGridViewTextBoxColumn.HeaderText = "DataType";
            this.dataTypeDataGridViewTextBoxColumn.Name = "dataTypeDataGridViewTextBoxColumn";
            this.dataTypeDataGridViewTextBoxColumn.Width = 79;
            // 
            // documentationDataGridViewTextBoxColumn
            // 
            this.documentationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.documentationDataGridViewTextBoxColumn.DataPropertyName = "Documentation";
            this.documentationDataGridViewTextBoxColumn.HeaderText = "Documentation";
            this.documentationDataGridViewTextBoxColumn.Name = "documentationDataGridViewTextBoxColumn";
            this.documentationDataGridViewTextBoxColumn.Width = 104;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.Width = 21;
            // 
            // optionalDataGridViewCheckBoxColumn
            // 
            this.optionalDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.optionalDataGridViewCheckBoxColumn.DataPropertyName = "Optional";
            this.optionalDataGridViewCheckBoxColumn.HeaderText = "Optional";
            this.optionalDataGridViewCheckBoxColumn.Name = "optionalDataGridViewCheckBoxColumn";
            this.optionalDataGridViewCheckBoxColumn.Width = 21;
            // 
            // extendedDescriptionDataGridViewTextBoxColumn
            // 
            this.extendedDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.extendedDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ExtendedDescription";
            this.extendedDescriptionDataGridViewTextBoxColumn.HeaderText = "ExtendedDescription";
            this.extendedDescriptionDataGridViewTextBoxColumn.Name = "extendedDescriptionDataGridViewTextBoxColumn";
            this.extendedDescriptionDataGridViewTextBoxColumn.Width = 130;
            // 
            // nucLengthDataGridViewTextBoxColumn
            // 
            this.nucLengthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.nucLengthDataGridViewTextBoxColumn.DataPropertyName = "NucLength";
            this.nucLengthDataGridViewTextBoxColumn.HeaderText = "NucLength";
            this.nucLengthDataGridViewTextBoxColumn.Name = "nucLengthDataGridViewTextBoxColumn";
            this.nucLengthDataGridViewTextBoxColumn.Width = 21;
            // 
            // ucLengthDataGridViewTextBoxColumn
            // 
            this.ucLengthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ucLengthDataGridViewTextBoxColumn.DataPropertyName = "UcLength";
            this.ucLengthDataGridViewTextBoxColumn.HeaderText = "UcLength";
            this.ucLengthDataGridViewTextBoxColumn.Name = "ucLengthDataGridViewTextBoxColumn";
            this.ucLengthDataGridViewTextBoxColumn.Width = 21;
            // 
            // decimalsDataGridViewTextBoxColumn
            // 
            this.decimalsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.decimalsDataGridViewTextBoxColumn.DataPropertyName = "Decimals";
            this.decimalsDataGridViewTextBoxColumn.HeaderText = "Decimals";
            this.decimalsDataGridViewTextBoxColumn.Name = "decimalsDataGridViewTextBoxColumn";
            this.decimalsDataGridViewTextBoxColumn.Width = 21;
            // 
            // StructureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 447);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.ParameterGridView);
            this.Name = "StructureView";
            this.Text = "ParameterView";
            this.Load += new System.EventHandler(this.StructureView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ParameterGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parameterMetadataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ParameterGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defaultValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn optionalDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extendedDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nucLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decimalsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource parameterMetadataBindingSource;
        private System.Windows.Forms.Button BtnOK;
    }
}