namespace SoftwareIncModMaker
{
    using System;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class DiagnosticForm : Form
    {
        public DataSet PDataSet;

        public DataTable TProcessTable;

        private Button button1;

        private Button button2;

        private DataGrid myDataGrid;

        public DiagnosticForm()
        {
            this.InitializeComponent();
            var p = Process.GetCurrentProcess();
            var pageMemSize = p.PagedMemorySize64;
        }

        private void Button1Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button2Click(object sender, EventArgs e)
        {
            BindingManagerBase bmGrid;
            bmGrid = this.BindingContext[this.PDataSet, "processDataTable"];
            MessageBox.Show("Current BindingManager Position: " + bmGrid.Position);
        }

        private void CreateDataSet()
        {
            this.PDataSet = new DataSet("processDataSet");

            this.TProcessTable = new DataTable("processDataTable");

            var cProcessId = new DataColumn("PID", typeof(int));
            var cProcessName = new DataColumn("PName");
            var cProcessThreadId = new DataColumn("PThreadID", typeof(int));
            var cProcessThreadLevel = new DataColumn("PThreadLevel", typeof(int));
            this.TProcessTable.Columns.Add(cProcessId);
            this.TProcessTable.Columns.Add(cProcessName);
            this.TProcessTable.Columns.Add(cProcessThreadId);
            this.TProcessTable.Columns.Add(cProcessThreadLevel);

            this.PDataSet.Tables.Add(this.TProcessTable);

            DataRow newRow1;

            var p = Process.GetCurrentProcess();
            var pageMemSize = p.PagedMemorySize64;
            for (var i = 1; i < 5; i++)
            {
                newRow1 = this.TProcessTable.NewRow();
                newRow1["PID"] = pageMemSize;

                // Add the row to the Customers table.
                this.TProcessTable.Rows.Add(newRow1);
            }

            this.TProcessTable.Rows[0]["PID"] = 123;
            this.TProcessTable.Rows[1]["PName"] = "Customer2";
            this.TProcessTable.Rows[2]["PThreadID"] = 123;
            this.TProcessTable.Rows[3]["PThreadLevel"] = 123;
        }

        private void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1Load(object sender, EventArgs e)
        {
            this.CreateDataSet();
            this.myDataGrid = new DataGrid();

            this.Text = "DataGrid Control Sample";
            this.ClientSize = new Size(450, 330);
            this.button1 = new Button();
            this.button2 = new Button();
            this.button1.Location = new Point(24, 16);
            this.button1.Size = new Size(120, 24);
            this.button1.Text = "Change Appearance";
            this.button1.Click += this.Button1Click;

            this.button2.Location = new Point(150, 16);
            this.button2.Size = new Size(120, 24);
            this.button2.Text = "Get Binding Manager";
            this.button2.Click += this.Button2Click;

            this.myDataGrid.Location = new Point(24, 50);
            this.myDataGrid.Size = new Size(300, 200);
            this.myDataGrid.CaptionText = "Microsoft DataGrid Control";
            this.myDataGrid.MouseUp += this.GridMouseUp;

            this.myDataGrid.SetDataBinding(this.PDataSet, "processDataTable");

            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.myDataGrid);
        }

        private void GridMouseUp(object sender, MouseEventArgs e)
        {
            var myGrid = (DataGrid)sender;
            var myHitInfo = myGrid.HitTest(e.X, e.Y);
            Console.WriteLine(myHitInfo);
            Console.WriteLine(myHitInfo.Type);
            Console.WriteLine(myHitInfo.Row);
            Console.WriteLine(myHitInfo.Column);
        }
    }
}