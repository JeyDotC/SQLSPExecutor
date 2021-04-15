using SQLSPExecutor.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLSPExecutor
{
    public partial class Form1 : Form
    {
        private string _connectionString;

        private string _databaseName;

        private bool _needsSelectDatabaseName = false;

        private IDbConnection Connection => new SqlConnection(_connectionString);

        public Form1()
        {
            InitializeComponent();
        }

        private void continueToExecution_Click(object sender, EventArgs e)
        {
            connectionWizzard.SelectedIndex = 2;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            _connectionString = connectionStringTextBox.Text;
            _needsSelectDatabaseName = true;
            connectionWizzard.SelectedIndex = 1;
        }

        private void connectionWizzard_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (connectionWizzard.SelectedIndex)
            {
                case 1: UpdateDatabaseSelector();
                    break;
                case 2: UpdateProcedureExecutor();
                    break;
            }
        }

        private void UpdateProcedureExecutor()
        {
            using var connection = Connection;
            var procedures = connection.GetProcedures(_databaseName).ToArray();

            proceduresComboBox.Items.Clear();
            proceduresComboBox.Items.AddRange(procedures);
        }

        private void UpdateDatabaseSelector()
        {
            if (!_needsSelectDatabaseName)
            {
                return;
            }

            _needsSelectDatabaseName = false;
            using var connection = Connection;
            var databases = connection.GetDatabases().ToArray();

            databaseCombobox.Items.Clear();
            databaseCombobox.Items.AddRange(databases);

            if (!string.IsNullOrEmpty(connection.Database))
            {
                databaseCombobox.SelectedItem = connection.Database;
            }
        }

        private void databaseCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _databaseName = databaseCombobox.SelectedItem as string;
        }

        private void executeProcedureButton_Click(object sender, EventArgs e)
        {
            var procedure = proceduresComboBox.SelectedItem as string;
            using var connection = Connection;

            var results = connection.Execute(_databaseName, procedure);
            var datatable = new DataTable();
            datatable.Load(results);

            resultsView.DataSource = datatable;
        }
    }
}
