namespace UnicodeGenerator
{
    public partial class ZalgoForm : Form
    {
        public ZalgoForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string text = txtInput.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("請輸入文字", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int up = Convert.ToInt32(numZalgoUp.Value);
            int medium = Convert.ToInt32(numZalgoMedium.Value);
            int down = Convert.ToInt32(numZalgoDown.Value);
            ZalgoString zalgo = new ZalgoString(text)
            {
                upCountMax = up,
                mediumCountMax = medium,
                downCountMax = down
            };
            txtResult.Text = zalgo.convert();
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
    }
}