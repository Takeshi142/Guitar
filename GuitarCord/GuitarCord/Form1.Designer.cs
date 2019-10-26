namespace GuitarCord
{
    partial class Cord
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCord = new System.Windows.Forms.ComboBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbCord
            // 
            this.cmbCord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCord.FormattingEnabled = true;
            this.cmbCord.Items.AddRange(new object[] {
            "C",
            "D",
            "Db_C＃",
            "E",
            "Eb_D＃",
            "F",
            "G",
            "Gb_F＃",
            "A",
            "Ab_G",
            "B",
            "Bb_A＃"});
            this.cmbCord.Location = new System.Drawing.Point(12, 11);
            this.cmbCord.Name = "cmbCord";
            this.cmbCord.Size = new System.Drawing.Size(85, 20);
            this.cmbCord.TabIndex = 0;
            this.cmbCord.SelectedIndexChanged += new System.EventHandler(this.CmbCord_SelectedIndexChanged);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(103, 11);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(44, 176);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "表示";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(12, 39);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(85, 148);
            this.listBox.TabIndex = 2;
            // 
            // Cord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(155, 194);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.cmbCord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cord";
            this.Text = "Cord";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button displayButton;
        public System.Windows.Forms.ComboBox cmbCord;
        public System.Windows.Forms.ListBox listBox;
    }
}

