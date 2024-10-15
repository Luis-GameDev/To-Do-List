using System;
using System.Drawing; 
using System.Windows.Forms;

namespace MyFirstWindow
{
    public class Program : Form
    {
        private DataGridView dataGridView1;
        private Label todoheader;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
        }

        public Program()
        {
            InitializeComponent(); 
            this.Text = "To Do List";
            this.Width = 800;
            this.Height = 600;
            InitializeDataGridView();
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            todoheader = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Menu;
            dataGridView1.Location = new Point(85, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.Silver;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowTemplate.ErrorText = "Error 404: Not found";
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(979, 402);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // todoheader
            // 
            todoheader.AccessibleName = "todoheader";
            todoheader.AccessibleRole = AccessibleRole.None;
            todoheader.Anchor = AnchorStyles.Top;
            todoheader.AutoSize = true;
            todoheader.Font = new Font("Segoe UI Black", 16F);
            todoheader.Location = new Point(500, 47);
            todoheader.MinimumSize = new Size(100, 1);
            todoheader.Name = "todoheader";
            todoheader.Size = new Size(160, 37);
            todoheader.TabIndex = 1;
            todoheader.Text = "To Do List:";
            // 
            // Program
            // 
            ClientSize = new Size(1156, 558);
            Controls.Add(todoheader);
            Controls.Add(dataGridView1);
            Name = "Program";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("Priority", "Priority");
            dataGridView1.Columns.Add("Task", "Task");
            DataGridViewCheckBoxColumn statusColumn = new DataGridViewCheckBoxColumn();
            dataGridView1.Columns.Add(statusColumn);
            statusColumn.HeaderText = "Status";

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridView1.Columns[0].FillWeight = 15; // 15% for Priority
            dataGridView1.Columns[1].FillWeight = 70; // 70% for Task
            dataGridView1.Columns[2].FillWeight = 15; // 15% for Status
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
