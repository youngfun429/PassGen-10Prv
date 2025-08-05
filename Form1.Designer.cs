namespace PassGen_10Prv
{
    partial class FrmPassGen_10Prv
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
            TxtPassword_10Prv = new TextBox();
            BtnCopy_10Prv = new Button();
            NumLen_10Prv = new NumericUpDown();
            LblLen_10Prv = new Label();
            ChkUpper_10Prv = new CheckBox();
            ChkLower_10Prv = new CheckBox();
            ChkNum_10Prv = new CheckBox();
            ChkOthers_10Prv = new CheckBox();
            TxtOthers_10Prv = new TextBox();
            BtnGen_10Prv = new Button();
            BtnResetOth_10Prv = new Button();
            rBtNoDeli = new RadioButton();
            gBxDelimiter = new GroupBox();
            rBtUNEvenDisDeli = new RadioButton();
            rBtEvenDisDeli = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)NumLen_10Prv).BeginInit();
            gBxDelimiter.SuspendLayout();
            SuspendLayout();
            // 
            // TxtPassword_10Prv
            // 
            TxtPassword_10Prv.BorderStyle = BorderStyle.FixedSingle;
            TxtPassword_10Prv.Enabled = false;
            TxtPassword_10Prv.Font = new Font("Courier New", 40F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPassword_10Prv.Location = new Point(39, 22);
            TxtPassword_10Prv.Name = "TxtPassword_10Prv";
            TxtPassword_10Prv.Size = new Size(722, 68);
            TxtPassword_10Prv.TabIndex = 0;
            TxtPassword_10Prv.TabStop = false;
            TxtPassword_10Prv.Text = "PassWord";
            TxtPassword_10Prv.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnCopy_10Prv
            // 
            BtnCopy_10Prv.Enabled = false;
            BtnCopy_10Prv.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BtnCopy_10Prv.Location = new Point(226, 121);
            BtnCopy_10Prv.Name = "BtnCopy_10Prv";
            BtnCopy_10Prv.Size = new Size(349, 59);
            BtnCopy_10Prv.TabIndex = 1;
            BtnCopy_10Prv.Text = "复制生成的密码(&P)";
            BtnCopy_10Prv.UseVisualStyleBackColor = true;
            BtnCopy_10Prv.Click += BtnCopy_10Prv_Click;
            // 
            // NumLen_10Prv
            // 
            NumLen_10Prv.Location = new Point(171, 201);
            NumLen_10Prv.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumLen_10Prv.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            NumLen_10Prv.Name = "NumLen_10Prv";
            NumLen_10Prv.Size = new Size(120, 23);
            NumLen_10Prv.TabIndex = 3;
            NumLen_10Prv.TextAlign = HorizontalAlignment.Right;
            NumLen_10Prv.Value = new decimal(new int[] { 15, 0, 0, 0 });
            NumLen_10Prv.ValueChanged += NumLen_10Prv_ValueChanged;
            // 
            // LblLen_10Prv
            // 
            LblLen_10Prv.AutoSize = true;
            LblLen_10Prv.Location = new Point(93, 204);
            LblLen_10Prv.Name = "LblLen_10Prv";
            LblLen_10Prv.Size = new Size(71, 17);
            LblLen_10Prv.TabIndex = 2;
            LblLen_10Prv.Text = "密码长度(&E)";
            // 
            // ChkUpper_10Prv
            // 
            ChkUpper_10Prv.AutoSize = true;
            ChkUpper_10Prv.Checked = true;
            ChkUpper_10Prv.CheckState = CheckState.Checked;
            ChkUpper_10Prv.Location = new Point(141, 237);
            ChkUpper_10Prv.Name = "ChkUpper_10Prv";
            ChkUpper_10Prv.Size = new Size(120, 21);
            ChkUpper_10Prv.TabIndex = 4;
            ChkUpper_10Prv.Text = "大写字母(A-Z)(&U)";
            ChkUpper_10Prv.UseVisualStyleBackColor = true;
            ChkUpper_10Prv.CheckedChanged += ChkUpper_10Prv_CheckedChanged;
            // 
            // ChkLower_10Prv
            // 
            ChkLower_10Prv.AutoSize = true;
            ChkLower_10Prv.Checked = true;
            ChkLower_10Prv.CheckState = CheckState.Checked;
            ChkLower_10Prv.Location = new Point(142, 271);
            ChkLower_10Prv.Name = "ChkLower_10Prv";
            ChkLower_10Prv.Size = new Size(115, 21);
            ChkLower_10Prv.TabIndex = 5;
            ChkLower_10Prv.Text = "小写字母(a-z)(&L)";
            ChkLower_10Prv.UseVisualStyleBackColor = true;
            ChkLower_10Prv.CheckedChanged += ChkLower_10Prv_CheckedChanged;
            // 
            // ChkNum_10Prv
            // 
            ChkNum_10Prv.AutoSize = true;
            ChkNum_10Prv.Checked = true;
            ChkNum_10Prv.CheckState = CheckState.Checked;
            ChkNum_10Prv.Location = new Point(153, 305);
            ChkNum_10Prv.Name = "ChkNum_10Prv";
            ChkNum_10Prv.Size = new Size(96, 21);
            ChkNum_10Prv.TabIndex = 6;
            ChkNum_10Prv.Text = "数字(0-9)(&N)";
            ChkNum_10Prv.UseVisualStyleBackColor = true;
            ChkNum_10Prv.CheckedChanged += ChkNum_10Prv_CheckedChanged;
            // 
            // ChkOthers_10Prv
            // 
            ChkOthers_10Prv.AutoSize = true;
            ChkOthers_10Prv.Checked = true;
            ChkOthers_10Prv.CheckState = CheckState.Checked;
            ChkOthers_10Prv.Location = new Point(102, 354);
            ChkOthers_10Prv.Name = "ChkOthers_10Prv";
            ChkOthers_10Prv.Size = new Size(93, 21);
            ChkOthers_10Prv.TabIndex = 7;
            ChkOthers_10Prv.Text = "特殊字符(&O)";
            ChkOthers_10Prv.UseVisualStyleBackColor = true;
            ChkOthers_10Prv.CheckedChanged += ChkOthers_10Prv_CheckedChanged;
            // 
            // TxtOthers_10Prv
            // 
            TxtOthers_10Prv.BorderStyle = BorderStyle.FixedSingle;
            TxtOthers_10Prv.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            TxtOthers_10Prv.Location = new Point(212, 350);
            TxtOthers_10Prv.Name = "TxtOthers_10Prv";
            TxtOthers_10Prv.Size = new Size(310, 28);
            TxtOthers_10Prv.TabIndex = 0;
            TxtOthers_10Prv.TabStop = false;
            TxtOthers_10Prv.Text = "~!@#$%^&*+-/.,\\{}[]();:";
            TxtOthers_10Prv.TextChanged += TxtOthers_10Prv_TextChanged;
            // 
            // BtnGen_10Prv
            // 
            BtnGen_10Prv.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BtnGen_10Prv.Location = new Point(213, 415);
            BtnGen_10Prv.Name = "BtnGen_10Prv";
            BtnGen_10Prv.Size = new Size(374, 59);
            BtnGen_10Prv.TabIndex = 9;
            BtnGen_10Prv.Text = "生成随机密码(&G)";
            BtnGen_10Prv.UseVisualStyleBackColor = true;
            BtnGen_10Prv.Click += BtnGen_10Prv_Click;
            // 
            // BtnResetOth_10Prv
            // 
            BtnResetOth_10Prv.Location = new Point(539, 353);
            BtnResetOth_10Prv.Name = "BtnResetOth_10Prv";
            BtnResetOth_10Prv.Size = new Size(160, 23);
            BtnResetOth_10Prv.TabIndex = 10;
            BtnResetOth_10Prv.Text = "重置特殊字符(&R)";
            BtnResetOth_10Prv.UseVisualStyleBackColor = true;
            BtnResetOth_10Prv.Click += BtnResetOth_10Prv_Click;
            // 
            // rBtNoDeli
            // 
            rBtNoDeli.AutoSize = true;
            rBtNoDeli.Checked = true;
            rBtNoDeli.Location = new Point(13, 22);
            rBtNoDeli.Name = "rBtNoDeli";
            rBtNoDeli.Size = new Size(134, 21);
            rBtNoDeli.TabIndex = 11;
            rBtNoDeli.TabStop = true;
            rBtNoDeli.Text = "无分隔符，完全随机";
            rBtNoDeli.UseVisualStyleBackColor = true;
            rBtNoDeli.CheckedChanged += rBtNoDeli_CheckedChanged;
            // 
            // gBxDelimiter
            // 
            gBxDelimiter.Controls.Add(rBtUNEvenDisDeli);
            gBxDelimiter.Controls.Add(rBtEvenDisDeli);
            gBxDelimiter.Controls.Add(rBtNoDeli);
            gBxDelimiter.Location = new Point(345, 211);
            gBxDelimiter.Name = "gBxDelimiter";
            gBxDelimiter.Size = new Size(362, 109);
            gBxDelimiter.TabIndex = 12;
            gBxDelimiter.TabStop = false;
            gBxDelimiter.Text = "分隔符(\"-\")设置(密码长度大于10时有分隔符)";
            // 
            // rBtUNEvenDisDeli
            // 
            rBtUNEvenDisDeli.AutoSize = true;
            rBtUNEvenDisDeli.Location = new Point(13, 78);
            rBtUNEvenDisDeli.Name = "rBtUNEvenDisDeli";
            rBtUNEvenDisDeli.Size = new Size(237, 21);
            rBtUNEvenDisDeli.TabIndex = 13;
            rBtUNEvenDisDeli.Text = "每6个字符插入一个分隔符，不平均分布";
            rBtUNEvenDisDeli.UseVisualStyleBackColor = true;
            rBtUNEvenDisDeli.CheckedChanged += rBtUNEvenDisDeli_CheckedChanged;
            // 
            // rBtEvenDisDeli
            // 
            rBtEvenDisDeli.AutoSize = true;
            rBtEvenDisDeli.Location = new Point(13, 50);
            rBtEvenDisDeli.Name = "rBtEvenDisDeli";
            rBtEvenDisDeli.Size = new Size(285, 21);
            rBtEvenDisDeli.TabIndex = 12;
            rBtEvenDisDeli.Text = "每6个字符左右插入一个分隔符，并尽量平均分布";
            rBtEvenDisDeli.UseVisualStyleBackColor = true;
            rBtEvenDisDeli.CheckedChanged += rBtEvenDisDeli_CheckedChanged;
            // 
            // FrmPassGen_10Prv
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 538);
            Controls.Add(gBxDelimiter);
            Controls.Add(BtnResetOth_10Prv);
            Controls.Add(BtnGen_10Prv);
            Controls.Add(TxtOthers_10Prv);
            Controls.Add(ChkOthers_10Prv);
            Controls.Add(ChkNum_10Prv);
            Controls.Add(ChkLower_10Prv);
            Controls.Add(ChkUpper_10Prv);
            Controls.Add(LblLen_10Prv);
            Controls.Add(NumLen_10Prv);
            Controls.Add(BtnCopy_10Prv);
            Controls.Add(TxtPassword_10Prv);
            MaximizeBox = false;
            Name = "FrmPassGen_10Prv";
            Text = "随机密码生成器_10Prv";
            ((System.ComponentModel.ISupportInitialize)NumLen_10Prv).EndInit();
            gBxDelimiter.ResumeLayout(false);
            gBxDelimiter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtPassword_10Prv;
        private Button BtnCopy_10Prv;
        private NumericUpDown NumLen_10Prv;
        private Label LblLen_10Prv;
        private CheckBox ChkUpper_10Prv;
        private CheckBox ChkLower_10Prv;
        private CheckBox ChkNum_10Prv;
        private CheckBox ChkOthers_10Prv;
        private TextBox TxtOthers_10Prv;
        private Button BtnGen_10Prv;
        private Button BtnResetOth_10Prv;
        private RadioButton rBtNoDeli;
        private GroupBox gBxDelimiter;
        private RadioButton rBtUNEvenDisDeli;
        private RadioButton rBtEvenDisDeli;
    }
}
