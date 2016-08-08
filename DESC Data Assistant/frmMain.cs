using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESC_Data_Assistant
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DescSqlParserForCrm parser = new DescSqlParserForCrm();
            string strErrorMsg = "";
            Dictionary<string, Object> dictParsedFields = new Dictionary<string, object>();

            if (!parser.ParseSQL(txtSQL.Text, dictParsedFields, strErrorMsg))
            {
                // Display error message
            }
        }
    }
}
