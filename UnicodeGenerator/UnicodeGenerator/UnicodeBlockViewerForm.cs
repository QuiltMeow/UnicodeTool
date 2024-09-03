using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace UnicodeGenerator
{
    public partial class UnicodeBlockViewerForm : Form
    {
        private static readonly ReadOnlyCollection<UnicodeBlockData> unicodeBlockDataList = UnicodeBlock.unicodeBlockDataList;

        public UnicodeBlockViewerForm()
        {
            InitializeComponent();
            initializeUnicodeBlockComboBoxList();
        }

        private void initializeUnicodeBlockComboBoxList()
        {
            foreach (UnicodeBlockData data in unicodeBlockDataList)
            {
                cbUnicodeBlock.Items.Add($"[{data.plane}] {data.blockName} ({data.readableBlockRange})");
            }
        }

        private void clearResult()
        {
            lvResult.Items.Clear();
            lvDetail.Items.Clear();
        }

        private void cbUnicodeBlock_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearResult();
            lvResult.BeginUpdate();
            UnicodeBlockData data = unicodeBlockDataList[cbUnicodeBlock.SelectedIndex];
            for (uint i = data.lower; i <= data.upper; ++i)
            {
                string value = Util.getUnicodeString(i);
                lvResult.Items.Add(new ListViewItem(value)
                {
                    Tag = new CharacterCode(value)
                });
            }
            lvResult.EndUpdate();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            if (chkRemoveCharacterWithoutDisplayWidth.Checked)
            {
                text = text.removeCharacterWithoutDisplayWidth();
            }
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("請輸入查詢文字", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clearResult();
            ISet<string> characterSet = new HashSet<string>();
            foreach (string data in text.textElement())
            {
                if (characterSet.Contains(data))
                {
                    continue;
                }

                lvResult.Items.Add(new ListViewItem(data)
                {
                    Tag = new CharacterCode(data)
                });
                characterSet.Add(data);
            }
        }

        private void rbSearch_CheckedChanged(object sender, EventArgs e)
        {
            enableUIControl(true);
        }

        private void rbBlockView_CheckedChanged(object sender, EventArgs e)
        {
            enableUIControl(false);
        }

        private void enableUIControl(bool search)
        {
            txtSearch.Enabled = btnSearch.Enabled = chkRemoveCharacterWithoutDisplayWidth.Enabled
                = search;
            cbUnicodeBlock.Enabled = !search;
        }

        private void lvResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = lvResult.HitTest(e.X, e.Y);
            ListViewItem? item = info.Item;
            if (item != null)
            {
                try
                {
                    Clipboard.SetText(item.Text);
                }
                catch
                {
                }
            }
        }

        private void lvResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectCollection = lvResult.SelectedItems;
            if (selectCollection.Count <= 0)
            {
                return;
            }

            object tag = selectCollection[0].Tag ?? throw new NullReferenceException("找不到物件");
            CharacterCode code = (CharacterCode)tag;
            ListView.ListViewItemCollection collection = lvDetail.Items;
            collection.Clear();
            lvDetail.BeginUpdate();

            OrderedDictionary item = new OrderedDictionary();
            item["Unicode Hexadecimal"] = null;
            item["Unicode 數值"] = null;
            item["Hexadecimal HTML 表達式"] = null;
            item["HTML 表達式"] = null;
            item["UTF－8 Hexadecimal"] = $"0x{Convert.ToHexString(code.characterUTF8Byte)}";
            item["UTF－16 Hexadecimal"] = null;
            item["UTF－32 Hexadecimal"] = $"0x{Convert.ToHexString(code.characterUTF32Byte)}";

            uint? unicodeIntegerValue = code.characterUnicodeIntegerValue;
            if (unicodeIntegerValue != null)
            {
                string unicodeValue = code.characterUnicodeValue!;
                item["Unicode Hexadecimal"] = unicodeValue;
                item["Unicode 數值"] = unicodeIntegerValue;

                string htmlHex = unicodeValue.Replace("U+", string.Empty).TrimStart('0');
                if (string.IsNullOrWhiteSpace(htmlHex))
                {
                    htmlHex = "0";
                }
                item["Hexadecimal HTML 表達式"] = $"&#x{htmlHex};";

                item["HTML 表達式"] = $"&#{unicodeIntegerValue};";
                item["UTF－16 Hexadecimal"] = $"0x{Convert.ToHexString(code.characterUTF16Byte!)}";
            }
            else
            {
                item["⚠ 注意事項"] = "複合字元";
            }

            foreach (DictionaryEntry pair in item)
            {
                object? value = pair.Value;
                if (value != null)
                {
                    collection.Add(new ListViewItem([pair.Key.ToString()!, value.ToString()!]));
                }
            }
            lvDetail.EndUpdate();
        }
    }
}