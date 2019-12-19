using SAP.Middleware.Connector;
using SapConn.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SapConn
{
    public partial class Principal : Form
    {
        private RfcDestination _dest;
        private string _funcName;
        private bool _invoked;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshDestination();
                RefreshFunctions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro: " + ex.Message);
            }
        }

        private void BAPIGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var parameter = (FunctionMetadata)functionMetadataBindingSource[e.RowIndex];
            RefreshMetadata(parameter.Name);
        }

        private void RefreshMetadata(string funcName)
        {
            _funcName = funcName;

            exportParameterMetadataBindingSource.Clear();
            importParameterMetadataBindingSource.Clear();
            _invoked = false;

            var func = _dest.Repository.CreateFunction(_funcName);

            foreach (var parameter in func.Where(x => x.Metadata.Direction != RfcDirection.IMPORT))
            {
                exportParameterMetadataBindingSource.Add(new ParameterMetadata
                {
                    DefaultValue = parameter.Metadata.DefaultValue,
                    Direction = parameter.Metadata.Direction,
                    Optional = parameter.Metadata.Optional,
                    Active = parameter.Active,
                    Decimals = parameter.Metadata.Decimals,
                    Documentation = parameter.Metadata.Documentation,
                    ExtendedDescription = parameter.Metadata.ExtendedDescription,
                    Name = parameter.Metadata.Name,
                    NucLength = parameter.Metadata.NucLength,
                    UcLength = parameter.Metadata.UcLength,
                    DataType = parameter.Metadata.DataType
                });
            }

            foreach (var parameter in func.Where(x => x.Metadata.Direction == RfcDirection.IMPORT))
            {
                importParameterMetadataBindingSource.Add(new ParameterMetadata
                {
                    Value = null,
                    DefaultValue = parameter.DefaultValue,
                    Direction = parameter.Metadata.Direction,
                    Optional = parameter.Metadata.Optional,
                    Active = parameter.Active,
                    Decimals = parameter.Metadata.Decimals,
                    Documentation = parameter.Metadata.Documentation,
                    ExtendedDescription = parameter.Metadata.ExtendedDescription,
                    Name = parameter.Metadata.Name,
                    NucLength = parameter.Metadata.NucLength,
                    UcLength = parameter.Metadata.UcLength,
                    DataType = parameter.Metadata.DataType
                });
            }
        }

        private void RefreshDestination()
        {
            if (string.IsNullOrWhiteSpace(ConnectionString.Text))
                return;

            string[] vtConn = ConnectionString.Text.Split(' ');

            string ASHOST = vtConn[0].Substring(vtConn[0].IndexOf("=") + 1);
            string SYSNR = vtConn[1].Substring(vtConn[1].IndexOf("=") + 1);
            string CLIENT = vtConn[2].Substring(vtConn[2].IndexOf("=") + 1);
            string USER = vtConn[3].Substring(vtConn[3].IndexOf("=") + 1);
            string PASSWD = vtConn[4].Substring(vtConn[4].IndexOf("=") + 1);

            RfcConfigParameters config = new RfcConfigParameters
            {
                [RfcConfigParameters.Name] = "moss",
                [RfcConfigParameters.AppServerHost] = ASHOST,
                [RfcConfigParameters.SystemNumber] = SYSNR,
                [RfcConfigParameters.Client] = CLIENT,
                [RfcConfigParameters.User] = USER,
                [RfcConfigParameters.Password] = PASSWD,
                [RfcConfigParameters.Language] = "pt",
            };

            _dest = RfcDestinationManager.GetDestination(config);

            try
            {
                _dest.Ping();
            }
            catch (RfcInvalidParameterException ex)
            {
                MessageBox.Show($"{ex.GetType().Name} : {ex.Message}");
            }
            catch (RfcBaseException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RefreshFunctions()
        {
            // RFC_FUNCTION_SEARCH
            // RFC_FUNCTION_SEARCH_WITHGROUP
            // BAPI_MONITOR_GETLIST

            functionMetadataBindingSource.Clear();

            var func = _dest.Repository.CreateFunction("BAPI_MONITOR_GETLIST");

            func.Invoke(_dest);

            IRfcTable result = func.GetTable("BAPILIST");

            foreach (var item in result)
            {
                functionMetadataBindingSource.Add(new FunctionMetadata
                {
                    Name = item["ABAPNAME"].GetString(),
                    Description = item["BAPI_TEXT"].GetString(),
                    ObjectDescription = item["BO_TEXT"].GetString(),
                    ObjectName = item["OBJECTNAME"].GetString(),
                    Verb = item["VERB"].GetString(),
                });
            }

            //functionMetadataBindingSource.Add(new FunctionMetadata { Name = "BAPI_MONITOR_GETLIST" });
            //functionMetadataBindingSource.Add(new FunctionMetadata { Name = "BAPI_MONITOR_GETLIST_2" });
        }

        private void ConnectionString_TextChanged(object sender, EventArgs e)
        {
            RefreshDestination();
            RefreshFunctions();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource
            {
                DataSource = functionMetadataBindingSource
                    .Cast<FunctionMetadata>()
                    .Where(x =>
                        x.Name.ToLower().Contains(SearchBox.Text.ToLower()) ||
                        x.Description.ToLower().Contains(SearchBox.Text.ToLower()))
            };

            FunctionMetadataGridView.DataSource = bs;
        }

        private void ExportParameterMetadataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var exportParameter = (ParameterMetadata)exportParameterMetadataBindingSource[e.RowIndex];

            if ((RfcDirection)exportParameter.Direction == RfcDirection.IMPORT)
            {
                MessageBox.Show("nop: direction=" + exportParameter.Direction);
                return;
            }

            var func = _dest.Repository.CreateFunction(_funcName);

            foreach (ParameterMetadata importParameter in importParameterMetadataBindingSource.List)
            {
                if (importParameter.Value == null)
                    continue;

                if ((RfcDataType)importParameter.DataType == RfcDataType.STRUCTURE)
                {
                    SetStructureValue(func, importParameter);
                }

                func.SetValue(importParameter.Name, importParameter.Value);
            }

            if (!_invoked)
            {
                try
                {
                    func.Invoke(_dest);
                }
                catch (RfcInvalidParameterException ex)
                {
                    MessageBox.Show($"{ex.GetType().Name} : {ex.Message}");
                    return;
                }
                catch (RfcBaseException ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }

            new TableView(func, exportParameter.Name).Show();
        }

        private void SetStructureValue(IRfcFunction func, ParameterMetadata importParameter)
        {
            var structureMetadata = importParameter.Value as StructureMetadata;

            var structure = func.GetStructure(structureMetadata.Name);

            //foreach (var item in structure.Values)
            //{

            //    structure
            //    var x = item.
            //}
        }

        private void ImportParameterMetadataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _invoked = false;
        }

        private void ImportParameterMetadataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var parameter = (ParameterMetadata)importParameterMetadataBindingSource[e.RowIndex];

            //messa

            //var columnIndex = grid.Columns.Cast<DataGridViewColumn>().First(x => x.DataPropertyName == "DataType").Index;
            //var direction = Convert.ToString(grid[columnIndex, e.RowIndex].Value);
            //if (direction == "IMPORT")
            //{
            //    MessageBox.Show("nop: direction=" + direction);
            //    return;
            //}
        }

        private void BtnRFC_Click(object sender, EventArgs e)
        {
            RefreshMetadata(RFCBox.Text);
        }
    }
}
