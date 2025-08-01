namespace PassGen_10Prv
{
    public partial class FrmPassGen_10Prv : Form
    {
        bool bolUpper = true, bolLower = true, bolNum = true, bolOth = true;
        public FrmPassGen_10Prv()
        {
            InitializeComponent();
        }

        private void BtnCopy_10Prv_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TxtPassword_10Prv.Text);
        }

        private void ChkUpper_10Prv_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkUpper_10Prv.Checked)
            {
                bolUpper = true;
                BtnGen_10Prv.Enabled = true;
                BtnGen_10Prv.Text = "重新生成随机密码(&G)";
                EnableChkBoxes();
            }
            else
            {
                bolUpper = false;
                DisableChkBoxes(bolUpper, bolLower, bolNum, bolOth);
            }
        }

        private void ChkLower_10Prv_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkLower_10Prv.Checked)
            {
                bolLower = true;
                BtnGen_10Prv.Enabled = true;
                BtnGen_10Prv.Text = "重新生成随机密码(&G)";
                EnableChkBoxes();
            }
            else
            {
                bolLower = false;
                DisableChkBoxes(bolUpper, bolLower, bolNum, bolOth);
            }
        }

        private void ChkNum_10Prv_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkNum_10Prv.Checked)
            {
                bolNum = true;
                BtnGen_10Prv.Enabled = true;
                BtnGen_10Prv.Text = "重新生成随机密码(&G)";
                EnableChkBoxes();
            }
            else
            {
                bolNum = false;
                DisableChkBoxes(bolUpper, bolLower, bolNum, bolOth);
            }
        }

        private void ChkOthers_10Prv_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkOthers_10Prv.Checked)
            {
                bolOth = true;
                TxtOthers_10Prv.Enabled = true;
                BtnGen_10Prv.Enabled = true;
                BtnGen_10Prv.Text = "重新生成随机密码(&G)";
                EnableChkBoxes();
            }
            else
            {
                bolOth = false;
                TxtOthers_10Prv.Enabled = false;
                BtnResetOth_10Prv.Enabled = false;
                DisableChkBoxes(bolUpper, bolLower, bolNum, bolOth);
            }
        }

        private void BtnGen_10Prv_Click(object sender, EventArgs e)
        {
            bool bolInclNonOthers = false;
            char[] chars =
                {
                    'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                    'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                    '1','2','3','4','5','6','7','8','9','0',' '
                };
            for (int j = 0; j < TxtOthers_10Prv.Text.Length; j++)
            {
                if (((int)TxtOthers_10Prv.Text[j] > 127) | (TxtOthers_10Prv.Text.IndexOfAny(chars) >= 0))
                {
                    MessageBox.Show("特殊字符框中不能包含 大小写、数字、空格、汉字、全角 字符");
                    bolInclNonOthers = true;
                    break;
                }
            }
            if (!bolInclNonOthers)
            {
                BtnCopy_10Prv.Enabled = true;
                string strString = "", strPassword = "";
                int n;
                Random randUpper = new();
                Random randLower = new();
                Random randNum = new();
                Random randOthers = new();
                Random randString = new();
                int nUpper, nLower, nNum, nOthers;//随机生成的整数
                string subStrStringUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ", //大写
                    subStrStringLower = "abcdefghijklmnopqrstuvwxyz", //小写
                    subStrStringNum = "0123456789", //数字
                    subStrStringOthers = TxtOthers_10Prv.Text;//其他字符
                string subCharUpper, subCharLower, subCharNum, subCharOthers;

                nUpper = randUpper.Next(1, subStrStringUpper.Length);
                subCharUpper = subStrStringUpper.Substring(nUpper, 1);
                nLower = randLower.Next(1, subStrStringLower.Length);
                subCharLower = subStrStringLower.Substring(nLower, 1);
                nNum = randNum.Next(1, subStrStringNum.Length);
                subCharNum = subStrStringNum.Substring(nNum, 1);
                nOthers = randOthers.Next(1, subStrStringOthers.Length);
                subCharOthers = subStrStringOthers.Substring(nOthers, 1);//分别从大写、小写、数字、其他字符中随机取出的一个字符

                nUpper = randUpper.Next(1, Decimal.ToInt32(NumLen_10Prv.Value));
                nLower = randLower.Next(1, Decimal.ToInt32(NumLen_10Prv.Value));
                nNum = randNum.Next(1, Decimal.ToInt32(NumLen_10Prv.Value));
                nOthers = randOthers.Next(1, Decimal.ToInt32(NumLen_10Prv.Value));//随机生成的不大于密码长度整数

                if (ChkUpper_10Prv.Checked)
                {
                    strString += subStrStringUpper;
                    while ((nUpper == nLower) | (nUpper == nNum) | (nUpper == nOthers))
                        nUpper = randUpper.Next(1, Decimal.ToInt32(NumLen_10Prv.Value));
                }
                else
                    nUpper = 0;
                if (ChkLower_10Prv.Checked)
                {
                    strString += subStrStringLower;
                    while ((nLower == nUpper) | (nLower == nNum) | (nLower == nOthers))
                        nLower = randLower.Next(1, Decimal.ToInt32(NumLen_10Prv.Value));
                }
                else
                    nLower = 0;
                if (ChkNum_10Prv.Checked)
                {
                    strString += subStrStringNum;
                    while ((nNum == nUpper) | (nNum == nLower) | (nNum == nOthers))
                        nNum = randNum.Next(1, Decimal.ToInt32(NumLen_10Prv.Value));
                }
                else
                    nNum = 0;
                if (ChkOthers_10Prv.Checked)
                {
                    strString += subStrStringOthers;
                    while ((nOthers == nUpper) | (nOthers == nLower) | (nOthers == nNum))
                        nOthers = randOthers.Next(1, Decimal.ToInt32(NumLen_10Prv.Value));
                }
                else
                    nOthers = 0;
                //生成包括随机密码可用的所有字符串strString，并确保随机生成的整数不相等
                //nUpper意思为此位置的字符为大写，nLower为此位置的字符是小写，nNum、nOthers类同

                for (int i = 1; i <= Decimal.ToInt32(NumLen_10Prv.Value); i++)//按照用户选择的密码长度生成随机密码循环
                {
                    n = randString.Next(1, strString.Length);//随机生成不大于strString长度的一个整数
                    if (i == nUpper)
                        strPassword += subCharUpper; //在第nUpper位时从大写字符库中随机抽一个，下同
                    else if (i == nLower)
                        strPassword += subCharLower;
                    else if (i == nNum)
                        strPassword += subCharNum;
                    else if (i == nOthers)
                        strPassword += subCharOthers;
                    else
                        strPassword += strString.Substring(n, 1);//从strString中随机取出一个字符
                }

                //     Random rand2 = new();
                /*  if (ChkUpper_10Prv.Checked)
                  {
                      subStrString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                      StrString += subStrString;
                      n = rand.Next(1,1, subStrString.Length);
                      //               subStrString = StrString.Substring(n2, 1);
                      strPassword = genPass(NumLen_10Prv.Value, n, StrString, subStrString);
                  }
                  if (ChkLower_10Prv.Checked)
                  {
                      subStrString = "abcdefghijklmnopqrstuvwxyz";
                      StrString += subStrString;
                      n2 = rand.Next(1,1, subStrString.Length);
                      subStrString = StrString.Substring(n2, 1);
                  }
                  if (ChkNum_10Prv.Checked)
                  {
                      subStrString = "0123456789";
                      StrString += subStrString;
                      n2 = rand.Next(1,1, subStrString.Length);
                      subStrString = StrString.Substring(n2, 1);
                  }
                  if (ChkOthers_10Prv.Checked)
                  {
                      StrString += TxtOthers_10Prv.Text;
                      n2 = rand.Next(1,1, StrString.Length);
                      subStrString = StrString.Substring(n2, 1);
                  }
                */
                TxtPassword_10Prv.Text = strPassword;
                BtnGen_10Prv.Text = "重新生成随机密码(&G)";
            }
        }

        private void DisableChkBoxes(bool bolUpper, bool bolLower, bool bolNum, bool bolOth)
        {
            if (!bolOth & !bolLower & !bolNum)
                ChkUpper_10Prv.Enabled = false;
            if (!bolUpper & !bolOth & !bolNum)
                ChkLower_10Prv.Enabled = false;
            if (!bolUpper & !bolLower & !bolOth)
                ChkNum_10Prv.Enabled = false;
            if (!bolUpper & !bolLower & !bolNum)
                ChkOthers_10Prv.Enabled = false;
        }

        private void EnableChkBoxes()
        {
            ChkUpper_10Prv.Enabled = true;
            ChkLower_10Prv.Enabled = true;
            ChkNum_10Prv.Enabled = true;
            ChkOthers_10Prv.Enabled = true;
        }

        private void TxtOthers_10Prv_TextChanged(object sender, EventArgs e)
        {
            BtnResetOth_10Prv.Enabled = true;
        }

        private void BtnResetOth_10Prv_Click(object sender, EventArgs e)
        {
            TxtOthers_10Prv.Text = "~!@#$%^&*+-/.,\\{}[]();:";
            BtnResetOth_10Prv.Enabled = false;
        }

        /*
        /// <summary>
        /// 生成随机密码函数
        /// </summary>
        /// <param name="value">密码长度，由NumericUpDown控件被用户选择</param>
        /// <param name="n2">随机生成不大于subStrString长度的一个整数</param>
        /// <param name="StrString">密码可用的所有字符</param>
        /// <param name="subStrString">密码必用的所有字符</param>
        /// <returns></returns>
        private string genPass(decimal value, int n2, string StrString, string subStrString)
        {
            string strPassword = "";
            int n1 = 0;
            Random rand = new();
            for (int i = 1; i <= Decimal.ToInt32(value); i++)
            {
                if (i != n2)
                {
                    n1 = rand.Next(1,1, StrString.Length);
                    strPassword = StrString.Substring(n1, 1);
                }
                else
                    strPassword = subStrString.Substring(n2, 1);
            }
            return strPassword;
        }
        */
    }
}
