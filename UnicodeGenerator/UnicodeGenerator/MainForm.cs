using System.Collections.ObjectModel;
using System.Text;

namespace UnicodeGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            initializeUnicodeBlockCheckBoxList();
        }

        private void initializeUnicodeBlockCheckBoxList()
        {
            ReadOnlyCollection<UnicodeBlockData> collection = UnicodeBlock.unicodeBlockDataList;
            lvUnicodeBlock.BeginUpdate();
            foreach (UnicodeBlockData data in collection)
            {
                lvUnicodeBlock.Items.Add(new ListViewItem([data.readableBlockRange, data.blockName])
                {
                    Checked = data.defaultCheck,
                    Tag = data
                });
            }
            lvUnicodeBlock.EndUpdate();
        }

        private void checkAll(bool check)
        {
            ListView.ListViewItemCollection collection = lvUnicodeBlock.Items;
            foreach (ListViewItem item in collection)
            {
                item.Checked = check;
            }
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            checkAll(true);
        }

        private void btnCancelAll_Click(object sender, EventArgs e)
        {
            checkAll(false);
        }

        private void btnReverseCheck_Click(object sender, EventArgs e)
        {
            ListView.ListViewItemCollection collection = lvUnicodeBlock.Items;
            foreach (ListViewItem item in collection)
            {
                item.Checked = !item.Checked;
            }
        }

        private void enableControl(bool enable)
        {
            lvUnicodeBlock.Enabled = btnCheckAll.Enabled = btnCancelAll.Enabled
                = btnReverseCheck.Enabled = numLength.Enabled = btnGenerate.Enabled
                = enable;
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            enableControl(false);
            ListView.CheckedListViewItemCollection collection = lvUnicodeBlock.CheckedItems;
            int count = collection.Count;
            if (count <= 0)
            {
                MessageBox.Show("請選擇項目", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                enableControl(true);
                return;
            }

            IList<UnicodeBlockData> checkUnicodeBlockDataList = new List<UnicodeBlockData>();
            foreach (ListViewItem item in collection)
            {
                object tag = item.Tag ?? throw new NullReferenceException("找不到物件");
                checkUnicodeBlockDataList.Add((UnicodeBlockData)tag);
            }

            StringBuilder sb = new StringBuilder();
            int length = Convert.ToInt32(numLength.Value);
            await Task.Run(() =>
            {
                Random random = Random.Shared;
                for (int i = 0; i < length; ++i)
                {
                    UnicodeBlockData data = checkUnicodeBlockDataList[random.Next(count)];
                    sb.Append(Util.getUnicodeString((uint)random.Next((int)data.lower, (int)data.upper + 1)));
                }
            });
            txtResult.Text = sb.ToString();
            enableControl(true);
        }

        private void tsmiUnicodeBlockViewer_Click(object sender, EventArgs e)
        {
            Util.openForm(typeof(UnicodeBlockViewerForm));
        }

        private void btnCopyResult_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtResult.Text);
            }
            catch
            {
            }
        }

        private void tsmiZalgoTool_Click(object sender, EventArgs e)
        {
            Util.openForm(typeof(ZalgoForm));
        }
    }
}