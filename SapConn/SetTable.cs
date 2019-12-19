using SAP.Middleware.Connector;
using SapConn.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace SapConn
{
    public partial class SetTable : Form
    {
        private readonly IRfcFunction _func;
        private readonly ParameterMetadata _parameter;

        public SetTable()
        {
            InitializeComponent();
        }

        public SetTable(IRfcFunction func, ParameterMetadata parameter) : this()
        {
            _func = func;
            _parameter = parameter;
        }

        private void SetTable_Load(object sender, EventArgs e)
        {
            var table = _func.GetTable(_parameter.Name);

            for (int i = 0; i < table.Metadata.LineType.FieldCount; i++)
            {
                var parameter = table.Metadata.LineType[i];

                parameterMetadataBindingSource.Add(new ParameterMetadata
                {
                    Decimals = parameter.Decimals,
                    Documentation = parameter.Documentation,
                    ExtendedDescription = parameter.ExtendedDescription,
                    Name = parameter.Name,
                    NucLength = parameter.NucLength,
                    UcLength = parameter.UcLength,
                    DataType = parameter.DataType
                });
            }

            var dt = new DataTable();

            for (int i = 0; i < table.Metadata.LineType.FieldCount; i++)
            {
                dt.Columns.Add(new DataColumn(table.Metadata.LineType[i].Name)
                {
                    Caption = table.Metadata.LineType[i].Name + " (" + table.Metadata.LineType[i].Documentation + ")"
                });
            }

            for (int i = 0; i < table.RowCount; i++)
            {
                var row = dt.NewRow();

                foreach (DataColumn column in dt.Columns)
                {
                    row[column.ColumnName] = table[i][column.ColumnName].GetValue();
                }

                dt.Rows.Add(row);
            }

            TableGridView.DataSource = new BindingSource
            {
                DataSource = dt,
            };
        }
    }
}
