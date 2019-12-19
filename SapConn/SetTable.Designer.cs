namespace SapConn
{
    partial class SetTable
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.TableGridView = new System.Windows.Forms.DataGridView();
            this.parameterMetadataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extendedDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nucLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decimalsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parameterMetadataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.documentationDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.dataTypeDataGridViewTextBoxColumn,
            this.extendedDescriptionDataGridViewTextBoxColumn,
            this.nucLengthDataGridViewTextBoxColumn,
            this.ucLengthDataGridViewTextBoxColumn,
            this.decimalsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parameterMetadataBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(947, 180);
            this.dataGridView1.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 180);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(947, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // TableGridView
            // 
            this.TableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableGridView.Location = new System.Drawing.Point(0, 183);
            this.TableGridView.Name = "TableGridView";
            this.TableGridView.Size = new System.Drawing.Size(947, 305);
            this.TableGridView.TabIndex = 2;
            // 
            // parameterMetadataBindingSource
            // 
            this.parameterMetadataBindingSource.DataSource = typeof(SapConn.Models.ParameterMetadata);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // documentationDataGridViewTextBoxColumn
            // 
            this.documentationDataGridViewTextBoxColumn.DataPropertyName = "Documentation";
            this.documentationDataGridViewTextBoxColumn.HeaderText = "Documentation";
            this.documentationDataGridViewTextBoxColumn.Name = "documentationDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // dataTypeDataGridViewTextBoxColumn
            // 
            this.dataTypeDataGridViewTextBoxColumn.DataPropertyName = "DataType";
            this.dataTypeDataGridViewTextBoxColumn.HeaderText = "DataType";
            this.dataTypeDataGridViewTextBoxColumn.Name = "dataTypeDataGridViewTextBoxColumn";
            // 
            // extendedDescriptionDataGridViewTextBoxColumn
            // 
            this.extendedDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ExtendedDescription";
            this.extendedDescriptionDataGridViewTextBoxColumn.HeaderText = "ExtendedDescription";
            this.extendedDescriptionDataGridViewTextBoxColumn.Name = "extendedDescriptionDataGridViewTextBoxColumn";
            // 
            // nucLengthDataGridViewTextBoxColumn
            // 
            this.nucLengthDataGridViewTextBoxColumn.DataPropertyName = "NucLength";
            this.nucLengthDataGridViewTextBoxColumn.HeaderText = "NucLength";
            this.nucLengthDataGridViewTextBoxColumn.Name = "nucLengthDataGridViewTextBoxColumn";
            // 
            // ucLengthDataGridViewTextBoxColumn
            // 
            this.ucLengthDataGridViewTextBoxColumn.DataPropertyName = "UcLength";
            this.ucLengthDataGridViewTextBoxColumn.HeaderText = "UcLength";
            this.ucLengthDataGridViewTextBoxColumn.Name = "ucLengthDataGridViewTextBoxColumn";
            // 
            // decimalsDataGridViewTextBoxColumn
            // 
            this.decimalsDataGridViewTextBoxColumn.DataPropertyName = "Decimals";
            this.decimalsDataGridViewTextBoxColumn.HeaderText = "Decimals";
            this.decimalsDataGridViewTextBoxColumn.Name = "decimalsDataGridViewTextBoxColumn";
            // 
            // SetTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 488);
            this.Controls.Add(this.TableGridView);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SetTable";
            this.Text = "SetTable";
            this.Load += new System.EventHandler(this.SetTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parameterMetadataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView TableGridView;
        private System.Windows.Forms.BindingSource parameterMetadataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extendedDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nucLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decimalsDataGridViewTextBoxColumn;
    }
}