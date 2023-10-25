using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SQLtoCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadComboBox();
            cboTables.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void grpFilepath_Enter(object sender, EventArgs e)
        {
        }

        private void btnFilepath_Click(object sender, EventArgs e)
        {
            if(cboTables.SelectedIndex != -1)
            {
                SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV File|*.csv" };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    txtFilepath.Text = sfd.FileName;
                }
            }
            else
            {
                MessageBox.Show("You must select a table!");
            }
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(cboTables.SelectedIndex == -1 && txtFilepath.Text.Equals(string.Empty))
            {
                MessageBox.Show("You must select a table and put a filepath!");
            }
            else
            {
                try
                {
                    DataTable table = DBHelper.GetNewDBHelper().Select(cboTables.Text);
                    List<string> lines = new List<string>();
                    List<string> columns = new List<string>();

                    foreach (DataColumn col in table.Columns)
                    {
                        columns.Add(col.ColumnName);
                    }
                    lines.Add(string.Join(";", columns));

                    foreach (DataRow row in table.Rows)
                    {
                        List<string> cells = new List<string>();
                        foreach (object cell in row.ItemArray)
                        {
                            cells.Add(cell.ToString());
                        }
                        lines.Add(string.Join(";", cells));
                    }

                    File.WriteAllLines(txtFilepath.Text, lines);
                    MessageBox.Show("File Saved!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.ToString());
                }
            }
        }

        public void LoadComboBox()
        {
            DataTable table = DBHelper.GetNewDBHelper().CboFiller();
            cboTables.DataSource = table;
            cboTables.DisplayMember = table.Columns[0].ColumnName;
            cboTables.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Close();
            }
        }

        private void cboTables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if(txtFilepath.Text.Equals(string.Empty))
            {
                MessageBox.Show("No filepath written!");
            }
            else
            {
                System.Diagnostics.Process.Start(txtFilepath.Text);
            }
        }
    }
}
