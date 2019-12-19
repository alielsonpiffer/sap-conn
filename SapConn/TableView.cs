using SAP.Middleware.Connector;
using System;
using System.Data;
using System.Windows.Forms;

namespace SapConn
{
    public partial class TableView : Form
    {
        private readonly IRfcFunction _func;
        private readonly string _resultName;

        protected TableView()
        {
            InitializeComponent();
        }

        public TableView(IRfcFunction func, string resultName) : this()
        {
            _func = func;
            _resultName = resultName;
        }

        private void TableView_Load(object sender, EventArgs e)
        {
            var type = _func[_resultName].Metadata.DataType;

            if (type == RfcDataType.TABLE)
            {
                var result = _func.GetTable(_resultName);
                var table = new DataTable();

                for (int i = 0; i < result.Metadata.LineType.FieldCount; i++)
                {
                    table.Columns.Add(new DataColumn(result.Metadata.LineType[i].Name)
                    {
                        Caption = result.Metadata.LineType[i].Name + " (" + result.Metadata.LineType[i].Documentation + ")"
                    });
                }

                var r = table.NewRow();
                foreach (DataColumn column in table.Columns)
                {
                    r[column.ColumnName] = result.Metadata.LineType[column.ColumnName].Documentation;
                }
                table.Rows.Add(r);

                for (int i = 0; i < result.RowCount; i++)
                {
                    var row = table.NewRow();

                    foreach (DataColumn column in table.Columns)
                    {
                        row[column.ColumnName] = result[i][column.ColumnName].GetValue();
                    }

                    table.Rows.Add(row);
                }

                ResultGridView.DataSource = new BindingSource
                {
                    DataSource = table,
                };
            }
            else if (type == RfcDataType.STRUCTURE)
            {
                var result = _func.GetStructure(_resultName);
                var table = new DataTable();

                table.Columns.Add("Property");
                table.Columns.Add("Value");
                table.Columns.Add("DataType");
                table.Columns.Add("Length");
                table.Columns.Add("Documentation");

                foreach (var item in result)
                {
                    var row = table.NewRow();

                    row["Property"] = item.Metadata.Name;
                    row["Value"] = item.GetValue();
                    row["DataType"] = item.Metadata.DataType;
                    row["Length"] = item.Metadata.NucLength;
                    row["Documentation"] = item.Metadata.Documentation;

                    table.Rows.Add(row);
                }

                ResultGridView.DataSource = new BindingSource
                {
                    DataSource = table,
                };

                ResultGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                ResultGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                ResultGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                ResultGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                ResultGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                MessageBox.Show(_resultName + ": " + _func.GetValue(_resultName));
                Close();
            }
        }
    }
}
