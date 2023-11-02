namespace launcher
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_mstart = new System.Windows.Forms.Button();
            this.Btn_vstart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_mstart
            // 
            this.Btn_mstart.BackColor = System.Drawing.Color.Cyan;
            this.Btn_mstart.FlatAppearance.BorderSize = 0;
            this.Btn_mstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_mstart.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_mstart.Image = ((System.Drawing.Image)(resources.GetObject("Btn_mstart.Image")));
            this.Btn_mstart.Location = new System.Drawing.Point(423, 27);
            this.Btn_mstart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_mstart.Name = "Btn_mstart";
            this.Btn_mstart.Size = new System.Drawing.Size(60, 60);
            this.Btn_mstart.TabIndex = 1;
            this.Btn_mstart.UseVisualStyleBackColor = false;
            this.Btn_mstart.Click += new System.EventHandler(this.Btn_mstart_Click);
            // 
            // Btn_vstart
            // 
            this.Btn_vstart.BackColor = System.Drawing.Color.Cyan;
            this.Btn_vstart.FlatAppearance.BorderSize = 0;
            this.Btn_vstart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_vstart.Image = ((System.Drawing.Image)(resources.GetObject("Btn_vstart.Image")));
            this.Btn_vstart.Location = new System.Drawing.Point(346, 27);
            this.Btn_vstart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_vstart.Name = "Btn_vstart";
            this.Btn_vstart.Size = new System.Drawing.Size(60, 60);
            this.Btn_vstart.TabIndex = 2;
            this.Btn_vstart.UseVisualStyleBackColor = false;
            this.Btn_vstart.Click += new System.EventHandler(this.Btn_vstart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 449);
            this.Controls.Add(this.Btn_vstart);
            this.Controls.Add(this.Btn_mstart);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "MapleStory";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_mstart;
        private System.Windows.Forms.Button Btn_vstart;
    }
}

