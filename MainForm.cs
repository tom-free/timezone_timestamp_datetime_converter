using System.Text.RegularExpressions;

namespace TimezoneConverter
{
    public partial class MainForm : Form
    {
        // ʱ���б�
        private readonly string[] timezones =
        {
            "-12:00", "-11:00", "-10:00", "-09:30",
            "-09:00", "-08:00", "-07:00", "-06:00",
            "-05:00", "-04:00", "-03:30", "-03:00",
            "-02:00", "-01:00",
            "00:00", "01:00", "02:00", "03:00",
            "03:30", "04:00", "04:30", "05:00",
            "05:30", "05:45", "06:00", "06:30",
            "07:00", "08:00", "08:45", "09:00",
            "09:30", "10:00", "10:30", "11:00",
            "12:00", "13:00", "13:45", "14:00",
        };

        /// <summary>
        /// ���췽��
        /// </summary>
        public MainForm()
        {
            // ��ʼ��UI���
            InitializeComponent();
            // ������ʾ
            StartPosition = FormStartPosition.CenterScreen;
            // ��ֹ����
            MaximumSize = MinimumSize = Size;
            // ����Ҫ��󻯰���
            MaximizeBox = false;
        }

        /// <summary>
        /// ���ڼ����¼�����
        /// </summary>
        /// <param name="sender">���ڿؼ�</param>
        /// <param name="e">�¼�����</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // ������ʱ��
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Enabled = true;
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();

            // ����Ĭ��ʱ���
            // ���㵱ǰUTCʱ���1970��1��1��0ʱ0��0��Ĳ�ֵ
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            // �õ�������
            long stamp = Convert.ToInt64(ts.TotalSeconds);
            txbTimestamp.Text = stamp.ToString();

            // ����ʱ������ѡ���
            cmbTimezoneSelect.Items.Clear();
            for (int i = 0; i < timezones.Length; i++)
            {
                if (timezones[i][0] == '-')
                {
                    cmbTimezoneSelect.Items.Add("UTC" + timezones[i].ToString());
                }
                else
                {
                    cmbTimezoneSelect.Items.Add("UTC+" + timezones[i].ToString());
                }
            }
            cmbTimezoneSelect.SelectedIndex = 27;

            // ���ص�ǰʱ��
            dateInputTime.Value = DateTime.Now;
        }

        /// <summary>
        /// ��ʱ����ʱ�¼�����
        /// </summary>
        /// <param name="sender">���ڿؼ�</param>
        /// <param name="e">�¼�����</param>
        private void Timer_Tick(object? sender, EventArgs e)
        {
            // ���㵱ǰUTCʱ���1970��1��1��0ʱ0��0��Ĳ�ֵ
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            // �õ�������
            long stamp = Convert.ToInt64(ts.TotalSeconds);
            // ��ʾ
            txbTimestampDec.Text = stamp.ToString("D");
            txbTimestampHex.Text = stamp.ToString("X");
        }

        /// <summary>
        /// ����10����ʵʱʱ�����������
        /// </summary>
        /// <param name="sender">���ڿؼ�</param>
        /// <param name="e">�¼�����</param>
        private void btnCopyTimestampDec_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txbTimestampDec.Text);
        }

        /// <summary>
        /// ����16����ʵʱʱ�����������
        /// </summary>
        /// <param name="sender">���ڿؼ�</param>
        /// <param name="e">�¼�����</param>
        private void btnCopyTimestampHex_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txbTimestampHex.Text);
        }

        /// <summary>
        /// ʱ���ת��Ϊʱ�䰴������
        /// </summary>
        /// <param name="sender">���ڿؼ�</param>
        /// <param name="e">�¼�����</param>
        private void btnTimestampToDatetime_Click(object sender, EventArgs e)
        {
            // ����������֤
            long timestamp;
            if (!chkTimestampHex.Checked && Regex.IsMatch(txbTimestamp.Text, @"^\d+$"))
            {
                timestamp = Convert.ToInt64(txbTimestamp.Text, 10);
                txbTimestampEx.Text = timestamp.ToString("X");
            }
            else if (chkTimestampHex.Checked && Regex.IsMatch(txbTimestamp.Text, @"^[A-Fa-f0-9]+$"))
            {
                timestamp = Convert.ToInt64(txbTimestamp.Text, 16);
                txbTimestampEx.Text = timestamp.ToString("D");
            }
            else
            {
                MessageBox.Show("ʱ����������", "�������", MessageBoxButtons.OK);
                return;
            }

            DateTime dt_utc = new DateTime(1970, 1, 1, 0, 0, 0) +
                              new TimeSpan(timestamp * TimeSpan.TicksPerSecond);
            listTime.BeginUpdate();
            listTime.Items.Clear();
            for (int i = 0; i < timezones.Length; i++)
            {
                TimeSpan span = TimeSpan.Parse(timezones[i].ToString());
                DateTime dt_local = dt_utc.Add(span);
                ListViewItem lvi = new ListViewItem();
                if (timezones[i][0] == '-')
                {
                    lvi.Text = "UTC" + timezones[i].ToString();
                }
                else
                {
                    lvi.Text = "UTC+" + timezones[i].ToString();
                }
                lvi.SubItems.Add(dt_local.ToString("yyyy-MM-dd HH:mm:ss"));
                listTime.Items.Add(lvi);
            }
            listTime.EndUpdate();
        }

        /// <summary>
        /// ʱ�������ѡ�����ѡ�����¼�����
        /// </summary>
        /// <param name="sender">���ڿؼ�</param>
        /// <param name="e">�¼�����</param>
        private void chkTimestampHex_CheckedChanged(object sender, EventArgs e)
        {
            long timestamp;

            if (chkTimestampHex.Checked)
            {
                txbTimestamp.MaxLength = 10;
                lblTimestampFormat.Text = "ʮ���ƣ�";
                if (Regex.IsMatch(txbTimestamp.Text, @"^\d+$"))
                {
                    timestamp = Convert.ToInt64(txbTimestamp.Text, 10);
                }
                else
                {
                    timestamp = 0;
                }
                txbTimestamp.Text = timestamp.ToString("X");
                txbTimestampEx.Text = timestamp.ToString("D");
            }
            else
            {
                txbTimestamp.MaxLength = 16;
                lblTimestampFormat.Text = "ʮ�����ƣ�";
                if (Regex.IsMatch(txbTimestamp.Text, @"^[A-Fa-f0-9]+$"))
                {
                    timestamp = Convert.ToInt64(txbTimestamp.Text, 16);
                }
                else
                {
                    timestamp = 0;
                }
                txbTimestamp.Text = timestamp.ToString("D");
                txbTimestampEx.Text = timestamp.ToString("X");
            }
        }

        /// <summary>
        /// ʱ��ת��Ϊʱ�����������
        /// </summary>
        /// <param name="sender">���ڿؼ�</param>
        /// <param name="e">�¼�����</param>
        private void btnDatetimeToTimestamp_Click(object sender, EventArgs e)
        {
            TimeSpan span = TimeSpan.Parse(timezones[cmbTimezoneSelect.SelectedIndex].ToString());
            // ����ʱ���1970��1��1��0ʱ0��0��Ĳ�ֵ
            DateTime dt = dateInputTime.Value;
            TimeSpan ts = dt - new DateTime(1970, 1, 1, 0, 0, 0, dt.Millisecond);
            // �õ�����������ȥʱ����
            ts -= span;
            long stamp = Convert.ToInt64(ts.TotalSeconds);
            // ��ʾ
            txbTimestampDecResult.Text = stamp.ToString("D");
            txbTimestampHexResult.Text = stamp.ToString("X");
        }
    }
}
