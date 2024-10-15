namespace TestApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Priority = new DataGridViewTextBoxColumn();
            Task = new DataGridViewComboBoxColumn();
            Done = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Priority, Task, Done });
            dataGridView1.Location = new Point(78, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(642, 326);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Priority
            // 
            Priority.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.Aquamarine;
            Priority.DefaultCellStyle = dataGridViewCellStyle1;
            Priority.FillWeight = 15F;
            Priority.HeaderText = "Priority";
            Priority.MinimumWidth = 6;
            Priority.Name = "Priority";
            // 
            // Task
            // 
            Task.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Task.FillWeight = 70F;
            Task.HeaderText = "Task";
            Task.MinimumWidth = 6;
            Task.Name = "Task";
            Task.Resizable = DataGridViewTriState.True;
            Task.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Done
            // 
            Done.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Done.FillWeight = 15F;
            Done.HeaderText = "Done";
            Done.MinimumWidth = 6;
            Done.Name = "Done";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewComboBoxColumn Task;
        private DataGridViewCheckBoxColumn Done;
    }
}
