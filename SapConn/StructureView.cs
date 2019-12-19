using SAP.Middleware.Connector;
using SapConn.Models;
using System;
using System.Windows.Forms;

namespace SapConn
{
    public partial class StructureView : Form
    {
        private readonly IRfcFunction _func;
        private readonly ParameterMetadata _parameter;

        protected StructureView()
        {
            InitializeComponent();
        }

        public StructureView(IRfcFunction func, ParameterMetadata parameter) : this()
        {
            _func = func;
            _parameter = parameter;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            var structure = _func.GetStructure(_parameter.Name);

            foreach (ParameterMetadata parameter in parameterMetadataBindingSource.List)
            {
                structure.SetValue(parameter.Name, parameter.Value);
            }

            //_parameter.Value = 
        }

        private void StructureView_Load(object sender, EventArgs e)
        {
            if (_parameter.Value == null)
            {
                foreach (var parameter in _func.GetStructure(_parameter.Name))
                {
                    parameterMetadataBindingSource.Add(new ParameterMetadata
                    {
                        Value = parameter.GetObject(),
                        //DefaultValue = parameter.DefaultValue,
                        //Optional = parameter.Metadata.Optional,
                        //Active = parameter.Active,
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
            else
            {

            }

            ///var structure = (ParameterMetadata)_parameter.Value ?? _func.GetStructure(_parameter.Name);
        }
    }
}
