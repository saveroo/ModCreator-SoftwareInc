namespace SoftwareIncModMaker
{
    using System;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class DiagnosticForm : Form
    {
        public DataSet pDataSet;

        public DataTable tProcessTable;

        private Button button1;

        private Button button2;

        private DataGrid myDataGrid;

        public DiagnosticForm()
        {
            this.InitializeComponent();
            var p = Process.GetCurrentProcess();
            var pageMemSize = p.PagedMemorySize64;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingManagerBase bmGrid;
            bmGrid = this.BindingContext[this.pDataSet, "processDataTable"];
            MessageBox.Show("Current BindingManager Position: " + bmGrid.Position);
        }

        private void createDataSet()
        {
            this.pDataSet = new DataSet("processDataSet");

            this.tProcessTable = new DataTable("processDataTable");

            var cProcessID = new DataColumn("PID", typeof(int));
            var cProcessName = new DataColumn("PName");
            var cProcessThreadID = new DataColumn("PThreadID", typeof(int));
            var cProcessThreadLevel = new DataColumn("PThreadLevel", typeof(int));
            this.tProcessTable.Columns.Add(cProcessID);
            this.tProcessTable.Columns.Add(cProcessName);
            this.tProcessTable.Columns.Add(cProcessThreadID);
            this.tProcessTable.Columns.Add(cProcessThreadLevel);

            this.pDataSet.Tables.Add(this.tProcessTable);

            DataRow newRow1;

            var p = Process.GetCurrentProcess();
            var pageMemSize = p.PagedMemorySize64;
            for (var i = 1; i < 5; i++)
            {
                newRow1 = this.tProcessTable.NewRow();
                newRow1["PID"] = pageMemSize;

                // Add the row to the Customers table.
                this.tProcessTable.Rows.Add(newRow1);
            }

            this.tProcessTable.Rows[0]["PID"] = 123;
            this.tProcessTable.Rows[1]["PName"] = "Customer2";
            this.tProcessTable.Rows[2]["PThreadID"] = 123;
            this.tProcessTable.Rows[3]["PThreadLevel"] = 123;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.createDataSet();
            this.myDataGrid = new DataGrid();

            this.Text = "DataGrid Control Sample";
            this.ClientSize = new Size(450, 330);
            this.button1 = new Button();
            this.button2 = new Button();
            this.button1.Location = new Point(24, 16);
            this.button1.Size = new Size(120, 24);
            this.button1.Text = "Change Appearance";
            this.button1.Click += this.button1_Click;

            this.button2.Location = new Point(150, 16);
            this.button2.Size = new Size(120, 24);
            this.button2.Text = "Get Binding Manager";
            this.button2.Click += this.button2_Click;

            this.myDataGrid.Location = new Point(24, 50);
            this.myDataGrid.Size = new Size(300, 200);
            this.myDataGrid.CaptionText = "Microsoft DataGrid Control";
            this.myDataGrid.MouseUp += this.Grid_MouseUp;

            this.myDataGrid.SetDataBinding(this.pDataSet, "processDataTable");

            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.myDataGrid);
        }

        private void Grid_MouseUp(object sender, MouseEventArgs e)
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