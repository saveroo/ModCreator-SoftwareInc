using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SoftwareIncModMaker
{
    public partial class DiagnosticForm : Form
    {
        private Button button1;
        private Button button2;
        private DataGrid myDataGrid;
        public DataSet pDataSet;
        public DataTable tProcessTable;

        public DiagnosticForm()
        {
            InitializeComponent();
            Process p = Process.GetCurrentProcess();
            long pageMemSize = p.PagedMemorySize64;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createDataSet();
            this.myDataGrid = new DataGrid();

            this.Text = "DataGrid Control Sample";
            this.ClientSize = new System.Drawing.Size(450, 330);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            button1.Location = new Point(24, 16);
            button1.Size = new System.Drawing.Size(120, 24);
            button1.Text = "Change Appearance";
            button1.Click += new System.EventHandler(button1_Click);

            button2.Location = new Point(150, 16);
            button2.Size = new System.Drawing.Size(120, 24);
            button2.Text = "Get Binding Manager";
            button2.Click += new System.EventHandler(button2_Click);

            myDataGrid.Location = new Point(24, 50);
            myDataGrid.Size = new Size(300, 200);
            myDataGrid.CaptionText = "Microsoft DataGrid Control";
            myDataGrid.MouseUp += new MouseEventHandler(Grid_MouseUp);

            myDataGrid.SetDataBinding(pDataSet, "processDataTable");

            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(myDataGrid);
        }

        private void Grid_MouseUp(object sender, MouseEventArgs e)
        {
            DataGrid myGrid = (DataGrid)sender;
            DataGrid.HitTestInfo myHitInfo = myGrid.HitTest(e.X, e.Y);
            Console.WriteLine(myHitInfo);
            Console.WriteLine(myHitInfo.Type);
            Console.WriteLine(myHitInfo.Row);
            Console.WriteLine(myHitInfo.Column);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingManagerBase bmGrid;
            bmGrid = BindingContext[pDataSet, "processDataTable"];
            MessageBox.Show("Current BindingManager Position: " + bmGrid.Position);
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void createDataSet()
        {
            pDataSet = new DataSet("processDataSet");

            tProcessTable = new DataTable("processDataTable");

            DataColumn cProcessID = new DataColumn("PID", typeof(int));
            DataColumn cProcessName = new DataColumn("PName");
            DataColumn cProcessThreadID = new DataColumn("PThreadID", typeof(int));
            DataColumn cProcessThreadLevel = new DataColumn("PThreadLevel", typeof(int));
            tProcessTable.Columns.Add(cProcessID);
            tProcessTable.Columns.Add(cProcessName);
            tProcessTable.Columns.Add(cProcessThreadID);
            tProcessTable.Columns.Add(cProcessThreadLevel);

            pDataSet.Tables.Add(tProcessTable);

            DataRow newRow1;
            DataRow newRow2;

            Process p = Process.GetCurrentProcess();
            long pageMemSize = p.PagedMemorySize64;
            for (int i = 1; i < 5; i++)
            {
                newRow1 = tProcessTable.NewRow();
                newRow1["PID"] = pageMemSize;
                // Add the row to the Customers table.
                tProcessTable.Rows.Add(newRow1);
            }
            tProcessTable.Rows[0]["PID"] = 123;
            tProcessTable.Rows[1]["PName"] = "Customer2";
            tProcessTable.Rows[2]["PThreadID"] = 123;
            tProcessTable.Rows[3]["PThreadLevel"] = 123;

        }
    }

}
