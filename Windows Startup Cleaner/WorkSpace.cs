using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace Windows_Startup_Cleaner
{
    public partial class WorkSpace : Form
    {
        private RegistryKey runRegKey;
        private string SelectStringKey = string.Empty;
        public WorkSpace()
        {
            InitializeComponent();
        }

        private void RefreshStartupRegistry()
        {
            try
            {
                lvStartupList.Items.Clear();

                lvStartupList.BeginUpdate();

                var StringKeys = runRegKey.GetValueNames();

                for (int i = 0; i < StringKeys.Length; i++)
                {
                    ListViewItem lvi = new ListViewItem((i + 1).ToString());

                    lvi.SubItems.Add(StringKeys[i].ToString());
                    lvi.SubItems.Add(runRegKey.GetValue(StringKeys[i]).ToString());

                    lvStartupList.Items.Add(lvi);
                }

                lvStartupList.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Exception",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WorkSpace_Load(object sender, EventArgs e)
        {
            cmbRegistry.SelectedIndex = 0;

            lvStartupList.View = View.Details;
            lvStartupList.FullRowSelect = true;

            lvStartupList.Columns.Add("순번", 120);
            lvStartupList.Columns.Add("프로그램명", 120);
            lvStartupList.Columns.Add("실제위치", 300);

            RefreshStartupRegistry();
        }

        private void btnSearchStartup_Click(object sender, EventArgs e)
        {
            RefreshStartupRegistry();
        }

        private void btnRemoveStartup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("시작 프로그램에서 선택한 프로그램이 삭제됩니다.", "시작 프로그램", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (SelectStringKey != string.Empty)
                {
                    try
                    {
                        runRegKey.DeleteValue(SelectStringKey);
                        MessageBox.Show("삭제되었습니다!", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            RefreshStartupRegistry();
        }

        private void btnAddStartup_Click(object sender, EventArgs e)
        {
            string StartupName = textStartupName.Text;
            string StartupPath = textStartupPath.Text;

            if (!(string.IsNullOrEmpty(StartupName) && string.IsNullOrEmpty(StartupPath)))
            {
                try
                {
                    runRegKey.SetValue(StartupName, StartupPath);
                    MessageBox.Show("추가되었습니다!", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            RefreshStartupRegistry();
        }

        private void lvStartupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStartupList.SelectedItems.Count != 0)
            {
                int SelectRow = lvStartupList.SelectedItems[0].Index;
                SelectStringKey = lvStartupList.Items[SelectRow].SubItems[1].Text;
            }
        }

        private void btnGetProgramPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textStartupPath.Text = openFileDialog.FileName;
                textStartupName.Text = openFileDialog.FileName.Split('\\')[openFileDialog.FileName.Split('\\').Length - 1];
            }
        }

        private void cmbRegistry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cmbRegistry.SelectedItem.ToString())
                {
                    case "Current User 1":
                        runRegKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                        RefreshStartupRegistry();
                        break;

                    case "Current User 2":
                        runRegKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce", true);
                        RefreshStartupRegistry();
                        break;

                    case "Local Machine(32Bit) 1":
                        runRegKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                        RefreshStartupRegistry();
                        break;

                    case "Local Machine(32Bit) 2":
                        runRegKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", true);
                        RefreshStartupRegistry();
                        break;

                    case "Local Machine(64Bit) 1":
                        runRegKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                        RefreshStartupRegistry();
                        break;

                    case "Local Machine(64Bit) 2":
                        runRegKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce", true);
                        RefreshStartupRegistry();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
