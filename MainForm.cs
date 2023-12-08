using System.Text.RegularExpressions;

namespace TimezoneConverter
{
    public partial class MainForm : Form
    {
        // 时区列表
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
        /// 构造方法
        /// </summary>
        public MainForm()
        {
            // 初始化UI组件
            InitializeComponent();
            // 居中显示
            StartPosition = FormStartPosition.CenterScreen;
            // 禁止放缩
            MaximumSize = MinimumSize = Size;
            // 不需要最大化按键
            MaximizeBox = false;
        }

        /// <summary>
        /// 窗口加载事件处理
        /// </summary>
        /// <param name="sender">窗口控件</param>
        /// <param name="e">事件参数</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // 创建定时器
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Enabled = true;
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();

            // 加载默认时间戳
            // 计算当前UTC时间和1970年1月1日0时0分0秒的差值
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 得到总秒数
            long stamp = Convert.ToInt64(ts.TotalSeconds);
            txbTimestamp.Text = stamp.ToString();

            // 加载时区下拉选择框
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

            // 加载当前时间
            dateInputTime.Value = DateTime.Now;
        }

        /// <summary>
        /// 定时器超时事件处理
        /// </summary>
        /// <param name="sender">窗口控件</param>
        /// <param name="e">事件参数</param>
        private void Timer_Tick(object? sender, EventArgs e)
        {
            // 计算当前UTC时间和1970年1月1日0时0分0秒的差值
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 得到总秒数
            long stamp = Convert.ToInt64(ts.TotalSeconds);
            // 显示
            txbTimestampDec.Text = stamp.ToString("D");
            txbTimestampHex.Text = stamp.ToString("X");
        }

        /// <summary>
        /// 复制10进制实时时间戳按键处理
        /// </summary>
        /// <param name="sender">窗口控件</param>
        /// <param name="e">事件参数</param>
        private void btnCopyTimestampDec_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txbTimestampDec.Text);
        }

        /// <summary>
        /// 复制16进制实时时间戳按键处理
        /// </summary>
        /// <param name="sender">窗口控件</param>
        /// <param name="e">事件参数</param>
        private void btnCopyTimestampHex_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txbTimestampHex.Text);
        }

        /// <summary>
        /// 时间戳转换为时间按键处理
        /// </summary>
        /// <param name="sender">窗口控件</param>
        /// <param name="e">事件参数</param>
        private void btnTimestampToDatetime_Click(object sender, EventArgs e)
        {
            // 输入数据验证
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
                MessageBox.Show("时间戳输入错误", "输入错误", MessageBoxButtons.OK);
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
        /// 时间戳进制选择框发生选择动作事件处理
        /// </summary>
        /// <param name="sender">窗口控件</param>
        /// <param name="e">事件参数</param>
        private void chkTimestampHex_CheckedChanged(object sender, EventArgs e)
        {
            long timestamp;

            if (chkTimestampHex.Checked)
            {
                txbTimestamp.MaxLength = 10;
                lblTimestampFormat.Text = "十进制：";
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
                lblTimestampFormat.Text = "十六进制：";
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
        /// 时间转换为时间戳按键处理
        /// </summary>
        /// <param name="sender">窗口控件</param>
        /// <param name="e">事件参数</param>
        private void btnDatetimeToTimestamp_Click(object sender, EventArgs e)
        {
            TimeSpan span = TimeSpan.Parse(timezones[cmbTimezoneSelect.SelectedIndex].ToString());
            // 计算时间和1970年1月1日0时0分0秒的差值
            DateTime dt = dateInputTime.Value;
            TimeSpan ts = dt - new DateTime(1970, 1, 1, 0, 0, 0, dt.Millisecond);
            // 得到总秒数，减去时区差
            ts -= span;
            long stamp = Convert.ToInt64(ts.TotalSeconds);
            // 显示
            txbTimestampDecResult.Text = stamp.ToString("D");
            txbTimestampHexResult.Text = stamp.ToString("X");
        }
    }
}
