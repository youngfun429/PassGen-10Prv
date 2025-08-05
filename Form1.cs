using System.Security.Cryptography.X509Certificates;

namespace PassGen_10Prv
{
    public partial class FrmPassGen_10Prv : Form
    {
        bool bolUpper = true, bolLower = true, bolNum = true, bolOth = true;
        int radioButtonSel = 1, nDelimiter = 0;
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
                gBxDelimiter.Enabled = true;
                bolOth = true;
                TxtOthers_10Prv.Enabled = true;
                BtnGen_10Prv.Enabled = true;
                BtnGen_10Prv.Text = "重新生成随机密码(&G)";
                EnableChkBoxes();
            }
            else
            {
                gBxDelimiter.Enabled = false; //如果取消选择其他字符，则不允许选择分隔符
                rBtNoDeli.Checked = true; //如果取消选择其他字符，则默认选择无分隔符
                bolOth = false;
                TxtOthers_10Prv.Enabled = false;
                BtnResetOth_10Prv.Enabled = false;
                DisableChkBoxes(bolUpper, bolLower, bolNum, bolOth);
            }
        }

        private void BtnGen_10Prv_Click(object sender, EventArgs e)
        {
            bool bolInclNonOthers = false;

            switch (radioButtonSel)
            {
                case 1: //无分隔符
                    nDelimiter = 0;
                    break;
                case 2: //尽量均匀分隔符
                    if (Decimal.ToInt32(NumLen_10Prv.Value) % 7 == 0)
                        nDelimiter = 7;
                    else if (Decimal.ToInt32(NumLen_10Prv.Value) % 6 == 0)
                        nDelimiter = 6;
                    else if (Decimal.ToInt32(NumLen_10Prv.Value) % 5 == 0)
                        nDelimiter = 5;
                    else
                        nDelimiter = 6;
                    break;
                case 3: //不均匀分隔符，每6个字符分隔一次，并且最后一个字符不是分隔符，即最后一个分隔符之后的密码长度最大为6，其余分隔符之间的密码长度为5
                    nDelimiter = 6;
                    break;
            }

            char[] chars =
                [
                    'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                    'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                    '1','2','3','4','5','6','7','8','9','0',' '
                ];
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
                int nUpper, nLower, nNum, nOthers;//随机生成的整数
                string subStrStringUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ", //大写
                    subStrStringLower = "abcdefghijklmnopqrstuvwxyz", //小写
                    subStrStringNum = "0123456789", //数字
                    subStrStringOthers = TxtOthers_10Prv.Text;//其他字符
                string subCharUpper, subCharLower, subCharNum, subCharOthers;

                //nUpper = randUpper.Next(1, subStrStringUpper.Length);
                nUpper = Random.Shared.Next(1, subStrStringUpper.Length);//将Random.Next方法替换为Random.Shared.Next方法
                subCharUpper = subStrStringUpper.Substring(nUpper, 1);
                //nLower = randLower.Next(1, subStrStringLower.Length);
                nLower = Random.Shared.Next(1, subStrStringLower.Length);
                subCharLower = subStrStringLower.Substring(nLower, 1);
                //nNum = randNum.Next(1, subStrStringNum.Length);
                nNum = Random.Shared.Next(1, subStrStringNum.Length);
                subCharNum = subStrStringNum.Substring(nNum, 1);
                //nOthers = randOthers.Next(1, subStrStringOthers.Length);
                nOthers = Random.Shared.Next(1, subStrStringOthers.Length);
                subCharOthers = subStrStringOthers.Substring(nOthers, 1);//分别从大写、小写、数字、其他字符中随机取出的一个字符

                nUpper = Random.Shared.Next(1, Decimal.ToInt32(NumLen_10Prv.Value));
                nLower = Random.Shared.Next(1, Decimal.ToInt32(NumLen_10Prv.Value));
                nNum = Random.Shared.Next(1, Decimal.ToInt32(NumLen_10Prv.Value));
                nOthers = Random.Shared.Next(1, Decimal.ToInt32(NumLen_10Prv.Value));//随机生成的不大于密码长度整数

                if (nDelimiter == 0)
                {
                    if (ChkUpper_10Prv.Checked)
                    {
                        strString += subStrStringUpper;
                        while ((nUpper == nLower) | (nUpper == nNum) | (nUpper == nOthers))
                            nUpper = Random.Shared.Next(1, Decimal.ToInt32(NumLen_10Prv.Value));
                    }
                    else
                        nUpper = 0;
                    if (ChkLower_10Prv.Checked)
                    {
                        strString += subStrStringLower;
                        while ((nLower == nUpper) | (nLower == nNum) | (nLower == nOthers))
                            nLower = Random.Shared.Next(1, Decimal.ToInt32(NumLen_10Prv.Value));
                    }
                    else
                        nLower = 0;
                    if (ChkNum_10Prv.Checked)
                    {
                        strString += subStrStringNum;
                        while ((nNum == nUpper) | (nNum == nLower) | (nNum == nOthers))
                            nNum = Random.Shared.Next(1, Decimal.ToInt32(NumLen_10Prv.Value));
                    }
                    else
                        nNum = 0;
                    if (ChkOthers_10Prv.Checked)
                    {
                        strString += subStrStringOthers;
                        while ((nOthers == nUpper) | (nOthers == nLower) | (nOthers == nNum))
                            nOthers = Random.Shared.Next(1, Decimal.ToInt32(NumLen_10Prv.Value));
                    }
                    else
                        nOthers = 0;
                }
                else
                {
                    if (ChkUpper_10Prv.Checked)
                    {
                        strString += subStrStringUpper;
                        while ((nUpper == nLower) | (nUpper == nNum) | (nUpper == nOthers) | (nUpper % nDelimiter == 0))
                            nUpper = Random.Shared.Next(1, Decimal.ToInt32(NumLen_10Prv.Value));
                    }
                    else
                        nUpper = 0;
                    if (ChkLower_10Prv.Checked)
                    {
                        strString += subStrStringLower;
                        while ((nLower == nUpper) | (nLower == nNum) | (nLower == nOthers) | (nLower % nDelimiter == 0))
                            nLower = Random.Shared.Next(1, Decimal.ToInt32(NumLen_10Prv.Value));
                    }
                    else
                        nLower = 0;
                    if (ChkNum_10Prv.Checked)
                    {
                        strString += subStrStringNum;
                        while ((nNum == nUpper) | (nNum == nLower) | (nNum == nOthers) | (nNum % nDelimiter == 0))
                            nNum = Random.Shared.Next(1, Decimal.ToInt32(NumLen_10Prv.Value));
                    }
                    else
                        nNum = 0;
                    if (ChkOthers_10Prv.Checked)
                    {
                        strString += subStrStringOthers;
                        while ((nOthers == nUpper) | (nOthers == nLower) | (nOthers == nNum) | (nOthers % nDelimiter == 0))
                            nOthers = Random.Shared.Next(1, Decimal.ToInt32(NumLen_10Prv.Value));
                    }
                    else
                        nOthers = 0;
                }
                //生成包括随机密码可用的所有字符串strString，并确保随机生成的整数nUpper、nLower、nNum、nOthers除0外互不相等，而且不是分隔符的位置
                //nUpper意思为此位置的字符为大写，nLower为此位置的字符是小写，nNum、nOthers类同
                //即保证随机密码中至少包含一个所需要的字符
                //nUpper、nLower、nNum、nOthers若为0，则表示不包含对应的字符类型

                for (int i = 1; i <= Decimal.ToInt32(NumLen_10Prv.Value); i++)//按照用户选择的密码长度生成随机密码循环
                {
                    if (nDelimiter != 0 && i % nDelimiter == 0 && i != Decimal.ToInt32(NumLen_10Prv.Value))
                        strPassword += "-";
                    else
                    {
                        if (i == nUpper)
                            strPassword += subCharUpper;
                        else if (i == nLower)
                            strPassword += subCharLower;
                        else if (i == nNum)
                            strPassword += subCharNum;
                        else if (i == nOthers)
                            strPassword += subCharOthers;
                        else
                        {
                            n = Random.Shared.Next(1, strString.Length);//随机生成不大于strString长度的一个整数
                            strPassword += strString.Substring(n, 1);//从strString中随机取出一个字符
                        }
                    }
                }


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

        private void NumLen_10Prv_ValueChanged(object sender, EventArgs e)
        {
            if (NumLen_10Prv.Value <= 10)
            {
                gBxDelimiter.Enabled = false;
                rBtNoDeli.Checked = true;
            }
            else
                gBxDelimiter.Enabled = true;
            //如果密码长度大于10，则允许选择有分隔符

            if (NumLen_10Prv.Value <= 15)
                TxtPassword_10Prv.Font = new Font("Courier New", 40);
            else if (NumLen_10Prv.Value > 15 && NumLen_10Prv.Value <= 25)
                TxtPassword_10Prv.Font = new Font("Courier New", 30);
            else
                TxtPassword_10Prv.Font = new Font("Courier New", 10);
            //根据密码长度设置密码框字体大小 

            TxtPassword_10Prv.Text = "PassWord";

        }

        private void rBtNoDeli_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonSel = 1;//无分隔符 45 '-'
            //if (rBtNoDeli.Checked)
            //{
            //}
        }

        private void rBtEvenDisDeli_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonSel = 2;//均匀分隔符
            //if (rBtEvenDisDeli.Checked)
            //{
            //}
        }

        private void rBtUNEvenDisDeli_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonSel = 3;//不均匀分隔符
            //if (rBtUNEvenDisDeli.Checked)
            //{
            //}
        }

    }
}
