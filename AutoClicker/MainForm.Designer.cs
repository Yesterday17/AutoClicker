namespace AutoClicker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.grpClickType = new System.Windows.Forms.GroupBox();
            this.rdbClickDoubleRight = new System.Windows.Forms.RadioButton();
            this.rdbClickDoubleMiddle = new System.Windows.Forms.RadioButton();
            this.rdbClickDoubleLeft = new System.Windows.Forms.RadioButton();
            this.rdbClickSingleRight = new System.Windows.Forms.RadioButton();
            this.rdbClickSingleMiddle = new System.Windows.Forms.RadioButton();
            this.rdbClickSingleLeft = new System.Windows.Forms.RadioButton();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnHotkeyRemove = new System.Windows.Forms.Button();
            this.txtHotkey = new System.Windows.Forms.TextBox();
            this.grpCount = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.rdbCount = new System.Windows.Forms.RadioButton();
            this.rdbUntilStopped = new System.Windows.Forms.RadioButton();
            this.grpDelay = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numDelayFixed = new System.Windows.Forms.NumericUpDown();
            this.rdbDelayFixed = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpMain.SuspendLayout();
            this.grpClickType.SuspendLayout();
            this.grpControls.SuspendLayout();
            this.grpCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.grpDelay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayFixed)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.grpClickType);
            this.grpMain.Controls.Add(this.btnToggle);
            this.grpMain.Controls.Add(this.grpControls);
            this.grpMain.Controls.Add(this.grpCount);
            this.grpMain.Controls.Add(this.grpDelay);
            this.grpMain.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpMain.Location = new System.Drawing.Point(13, 13);
            this.grpMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMain.Name = "grpMain";
            this.grpMain.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMain.Size = new System.Drawing.Size(305, 450);
            this.grpMain.TabIndex = 0;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "点击设置";
            // 
            // grpClickType
            // 
            this.grpClickType.Controls.Add(this.rdbClickDoubleRight);
            this.grpClickType.Controls.Add(this.rdbClickDoubleMiddle);
            this.grpClickType.Controls.Add(this.rdbClickDoubleLeft);
            this.grpClickType.Controls.Add(this.rdbClickSingleRight);
            this.grpClickType.Controls.Add(this.rdbClickSingleMiddle);
            this.grpClickType.Controls.Add(this.rdbClickSingleLeft);
            this.grpClickType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpClickType.Location = new System.Drawing.Point(8, 65);
            this.grpClickType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpClickType.Name = "grpClickType";
            this.grpClickType.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpClickType.Size = new System.Drawing.Size(288, 120);
            this.grpClickType.TabIndex = 2;
            this.grpClickType.TabStop = false;
            this.grpClickType.Text = "点击方式";
            // 
            // rdbClickDoubleRight
            // 
            this.rdbClickDoubleRight.AutoSize = true;
            this.rdbClickDoubleRight.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbClickDoubleRight.Location = new System.Drawing.Point(137, 84);
            this.rdbClickDoubleRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbClickDoubleRight.Name = "rdbClickDoubleRight";
            this.rdbClickDoubleRight.Size = new System.Drawing.Size(120, 24);
            this.rdbClickDoubleRight.TabIndex = 5;
            this.rdbClickDoubleRight.Text = "双击鼠标右键";
            this.rdbClickDoubleRight.UseVisualStyleBackColor = true;
            this.rdbClickDoubleRight.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // rdbClickDoubleMiddle
            // 
            this.rdbClickDoubleMiddle.AutoSize = true;
            this.rdbClickDoubleMiddle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbClickDoubleMiddle.Location = new System.Drawing.Point(137, 56);
            this.rdbClickDoubleMiddle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbClickDoubleMiddle.Name = "rdbClickDoubleMiddle";
            this.rdbClickDoubleMiddle.Size = new System.Drawing.Size(120, 24);
            this.rdbClickDoubleMiddle.TabIndex = 4;
            this.rdbClickDoubleMiddle.Text = "双击鼠标中键";
            this.rdbClickDoubleMiddle.UseVisualStyleBackColor = true;
            this.rdbClickDoubleMiddle.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // rdbClickDoubleLeft
            // 
            this.rdbClickDoubleLeft.AutoSize = true;
            this.rdbClickDoubleLeft.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbClickDoubleLeft.Location = new System.Drawing.Point(137, 28);
            this.rdbClickDoubleLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbClickDoubleLeft.Name = "rdbClickDoubleLeft";
            this.rdbClickDoubleLeft.Size = new System.Drawing.Size(120, 24);
            this.rdbClickDoubleLeft.TabIndex = 3;
            this.rdbClickDoubleLeft.Text = "双击鼠标左键";
            this.rdbClickDoubleLeft.UseVisualStyleBackColor = true;
            this.rdbClickDoubleLeft.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // rdbClickSingleRight
            // 
            this.rdbClickSingleRight.AutoSize = true;
            this.rdbClickSingleRight.Checked = true;
            this.rdbClickSingleRight.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbClickSingleRight.Location = new System.Drawing.Point(12, 84);
            this.rdbClickSingleRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbClickSingleRight.Name = "rdbClickSingleRight";
            this.rdbClickSingleRight.Size = new System.Drawing.Size(90, 24);
            this.rdbClickSingleRight.TabIndex = 2;
            this.rdbClickSingleRight.TabStop = true;
            this.rdbClickSingleRight.Text = "鼠标右键";
            this.rdbClickSingleRight.UseVisualStyleBackColor = true;
            this.rdbClickSingleRight.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // rdbClickSingleMiddle
            // 
            this.rdbClickSingleMiddle.AutoSize = true;
            this.rdbClickSingleMiddle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbClickSingleMiddle.Location = new System.Drawing.Point(12, 56);
            this.rdbClickSingleMiddle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbClickSingleMiddle.Name = "rdbClickSingleMiddle";
            this.rdbClickSingleMiddle.Size = new System.Drawing.Size(90, 24);
            this.rdbClickSingleMiddle.TabIndex = 1;
            this.rdbClickSingleMiddle.Text = "鼠标中键";
            this.rdbClickSingleMiddle.UseVisualStyleBackColor = true;
            this.rdbClickSingleMiddle.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // rdbClickSingleLeft
            // 
            this.rdbClickSingleLeft.AutoSize = true;
            this.rdbClickSingleLeft.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbClickSingleLeft.Location = new System.Drawing.Point(12, 28);
            this.rdbClickSingleLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbClickSingleLeft.Name = "rdbClickSingleLeft";
            this.rdbClickSingleLeft.Size = new System.Drawing.Size(90, 24);
            this.rdbClickSingleLeft.TabIndex = 0;
            this.rdbClickSingleLeft.Text = "鼠标左键";
            this.rdbClickSingleLeft.UseVisualStyleBackColor = true;
            this.rdbClickSingleLeft.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.label11);
            this.grpControls.Controls.Add(this.btnHotkeyRemove);
            this.grpControls.Controls.Add(this.txtHotkey);
            this.grpControls.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpControls.Location = new System.Drawing.Point(8, 193);
            this.grpControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpControls.Name = "grpControls";
            this.grpControls.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpControls.Size = new System.Drawing.Size(288, 91);
            this.grpControls.TabIndex = 1;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "控制";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(8, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "快捷键";
            // 
            // btnToggle
            // 
            this.btnToggle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnToggle.Location = new System.Drawing.Point(8, 28);
            this.btnToggle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(288, 29);
            this.btnToggle.TabIndex = 3;
            this.btnToggle.Text = "开始连点";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // btnHotkeyRemove
            // 
            this.btnHotkeyRemove.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHotkeyRemove.Location = new System.Drawing.Point(12, 54);
            this.btnHotkeyRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHotkeyRemove.Name = "btnHotkeyRemove";
            this.btnHotkeyRemove.Size = new System.Drawing.Size(265, 29);
            this.btnHotkeyRemove.TabIndex = 2;
            this.btnHotkeyRemove.Text = "清除快捷键";
            this.btnHotkeyRemove.UseVisualStyleBackColor = true;
            this.btnHotkeyRemove.Click += new System.EventHandler(this.btnHotkeyRemove_Click);
            // 
            // txtHotkey
            // 
            this.txtHotkey.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHotkey.Location = new System.Drawing.Point(70, 23);
            this.txtHotkey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHotkey.Name = "txtHotkey";
            this.txtHotkey.Size = new System.Drawing.Size(207, 27);
            this.txtHotkey.TabIndex = 0;
            this.txtHotkey.Text = "无";
            this.txtHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHotkey_KeyDown);
            // 
            // grpCount
            // 
            this.grpCount.Controls.Add(this.label1);
            this.grpCount.Controls.Add(this.numCount);
            this.grpCount.Controls.Add(this.rdbCount);
            this.grpCount.Controls.Add(this.rdbUntilStopped);
            this.grpCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpCount.Location = new System.Drawing.Point(8, 292);
            this.grpCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCount.Name = "grpCount";
            this.grpCount.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCount.Size = new System.Drawing.Size(288, 86);
            this.grpCount.TabIndex = 1;
            this.grpCount.TabStop = false;
            this.grpCount.Text = "点击计数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(253, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "次";
            // 
            // numCount
            // 
            this.numCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numCount.Location = new System.Drawing.Point(106, 51);
            this.numCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(139, 27);
            this.numCount.TabIndex = 2;
            this.numCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numCount.ValueChanged += new System.EventHandler(this.CountHandler);
            // 
            // rdbCount
            // 
            this.rdbCount.AutoSize = true;
            this.rdbCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbCount.Location = new System.Drawing.Point(8, 51);
            this.rdbCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbCount.Name = "rdbCount";
            this.rdbCount.Size = new System.Drawing.Size(90, 24);
            this.rdbCount.TabIndex = 1;
            this.rdbCount.Text = "固定次数";
            this.rdbCount.UseVisualStyleBackColor = true;
            this.rdbCount.CheckedChanged += new System.EventHandler(this.CountHandler);
            // 
            // rdbUntilStopped
            // 
            this.rdbUntilStopped.AutoSize = true;
            this.rdbUntilStopped.Checked = true;
            this.rdbUntilStopped.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbUntilStopped.Location = new System.Drawing.Point(8, 24);
            this.rdbUntilStopped.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbUntilStopped.Name = "rdbUntilStopped";
            this.rdbUntilStopped.Size = new System.Drawing.Size(120, 24);
            this.rdbUntilStopped.TabIndex = 0;
            this.rdbUntilStopped.TabStop = true;
            this.rdbUntilStopped.Text = "直到手动停止";
            this.rdbUntilStopped.UseVisualStyleBackColor = true;
            this.rdbUntilStopped.CheckedChanged += new System.EventHandler(this.CountHandler);
            // 
            // grpDelay
            // 
            this.grpDelay.Controls.Add(this.label9);
            this.grpDelay.Controls.Add(this.numDelayFixed);
            this.grpDelay.Controls.Add(this.rdbDelayFixed);
            this.grpDelay.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpDelay.Location = new System.Drawing.Point(8, 386);
            this.grpDelay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDelay.Name = "grpDelay";
            this.grpDelay.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDelay.Size = new System.Drawing.Size(288, 57);
            this.grpDelay.TabIndex = 1;
            this.grpDelay.TabStop = false;
            this.grpDelay.Text = "延迟";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(247, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "ms";
            // 
            // numDelayFixed
            // 
            this.numDelayFixed.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numDelayFixed.Location = new System.Drawing.Point(106, 24);
            this.numDelayFixed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numDelayFixed.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDelayFixed.Name = "numDelayFixed";
            this.numDelayFixed.Size = new System.Drawing.Size(139, 27);
            this.numDelayFixed.TabIndex = 11;
            this.numDelayFixed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numDelayFixed.ValueChanged += new System.EventHandler(this.DelayHandler);
            // 
            // rdbDelayFixed
            // 
            this.rdbDelayFixed.AutoSize = true;
            this.rdbDelayFixed.Checked = true;
            this.rdbDelayFixed.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbDelayFixed.Location = new System.Drawing.Point(12, 24);
            this.rdbDelayFixed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbDelayFixed.Name = "rdbDelayFixed";
            this.rdbDelayFixed.Size = new System.Drawing.Size(90, 24);
            this.rdbDelayFixed.TabIndex = 0;
            this.rdbDelayFixed.TabStop = true;
            this.rdbDelayFixed.Text = "固定延迟";
            this.rdbDelayFixed.UseVisualStyleBackColor = true;
            this.rdbDelayFixed.CheckedChanged += new System.EventHandler(this.DelayHandler);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 468);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(330, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(219, 20);
            this.tslStatus.Text = "随手改了改，空岛筛矿用的（（";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 493);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "鼠标连点器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMain.ResumeLayout(false);
            this.grpClickType.ResumeLayout(false);
            this.grpClickType.PerformLayout();
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            this.grpCount.ResumeLayout(false);
            this.grpCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.grpDelay.ResumeLayout(false);
            this.grpDelay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayFixed)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.GroupBox grpClickType;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Button btnHotkeyRemove;
        private System.Windows.Forms.TextBox txtHotkey;
        private System.Windows.Forms.GroupBox grpCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.RadioButton rdbCount;
        private System.Windows.Forms.RadioButton rdbUntilStopped;
        private System.Windows.Forms.GroupBox grpDelay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numDelayFixed;
        private System.Windows.Forms.RadioButton rdbDelayFixed;
        private System.Windows.Forms.RadioButton rdbClickDoubleRight;
        private System.Windows.Forms.RadioButton rdbClickDoubleMiddle;
        private System.Windows.Forms.RadioButton rdbClickDoubleLeft;
        private System.Windows.Forms.RadioButton rdbClickSingleRight;
        private System.Windows.Forms.RadioButton rdbClickSingleMiddle;
        private System.Windows.Forms.RadioButton rdbClickSingleLeft;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
    }
}

