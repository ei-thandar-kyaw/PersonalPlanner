using System;
using System.Drawing;
using System.Windows.Forms;

namespace PersonalPlanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lvTasks.View = View.Details;
            lvTasks.FullRowSelect = true;
            lvTasks.GridLines = true;
            lvTasks.Columns.Add("Task", 150);
            lvTasks.Columns.Add("Status", 100);
            lvTasks.Columns.Add("Due Date", 100);
            lvTasks.DoubleClick += lvTasks_DoubleClick;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            {
                string taskName = tbTask.Text.Trim();
                string category = cmbCateogry.Text;
                string dueDate = dtpDate.Value.ToShortDateString();
                string details = rtbTaskDetails.Text.Trim();

                if (string.IsNullOrWhiteSpace(taskName))
                {
                    MessageBox.Show("Please enter a task name.");
                    return;
                }

                ListViewItem item = new ListViewItem(taskName);
                item.SubItems.Add("Pending");
                item.SubItems.Add(dueDate);

                lvTasks.Items.Add(item);
                tbTask.Clear();
                cmbCateogry.SelectedIndex = -1;
                dtpDate.Value = DateTime.Now;
                rtbTaskDetails.Clear();
            }
        }

        private void lvTasks_DoubleClick(object sender, EventArgs e)
        {
            if (lvTasks.SelectedItems.Count > 0)
            {
                var item = lvTasks.SelectedItems[0];
                string currentStatus = item.SubItems[1].Text;
                if (currentStatus == "Pending")
                    item.SubItems[1].Text = "In Progress";
                else if (currentStatus == "In Progress")
                    item.SubItems[1].Text = "Done";
                else
                    item.SubItems[1].Text = "Pending";
            }
        }

        private void lvTasks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lvTasks.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Delete selected task?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lvTasks.Items.Remove(lvTasks.SelectedItems[0]);
                }
            }
        }

        private void lvTasks_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item == null) return;
            lvTasks.ItemChecked -= lvTasks_ItemChecked;

            if (e.Item.Checked)
            {
                e.Item.SubItems[1].Text = "Done";
                e.Item.Font = new Font(e.Item.Font, FontStyle.Strikeout);

                lvTasks.Items.Remove(e.Item);
                lvTasks.Items.Add(e.Item);
            }
            else
            {
                e.Item.SubItems[1].Text = "In Progress";
                e.Item.Font = new Font(e.Item.Font, FontStyle.Regular);
                lvTasks.Items.Remove(e.Item);
                lvTasks.Items.Insert(0, e.Item);
            }

            lvTasks.ItemChecked += lvTasks_ItemChecked;
        }

    }
}

      
