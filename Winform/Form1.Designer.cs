namespace Winform
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.btnLoadDevices = new System.Windows.Forms.Button();
            this.dgvDevices = new System.Windows.Forms.DataGridView();
            this.btnStartPoll = new System.Windows.Forms.Button();
            this.btnStopPoll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Location = new System.Drawing.Point(48, 95);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(101, 50);
            this.btnAddDevice.TabIndex = 0;
            this.btnAddDevice.Text = "插入设备";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.BtnAddDevice_Click);
            // 
            // btnLoadDevices
            // 
            this.btnLoadDevices.Location = new System.Drawing.Point(168, 95);
            this.btnLoadDevices.Name = "btnLoadDevices";
            this.btnLoadDevices.Size = new System.Drawing.Size(141, 50);
            this.btnLoadDevices.TabIndex = 1;
            this.btnLoadDevices.Text = "加载设备列表";
            this.btnLoadDevices.UseVisualStyleBackColor = true;
            this.btnLoadDevices.Click += new System.EventHandler(this.BtnLoadDevices_Click);
            // 
            // dgvDevices
            // 
            this.dgvDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevices.Location = new System.Drawing.Point(26, 161);
            this.dgvDevices.Name = "dgvDevices";
            this.dgvDevices.RowHeadersWidth = 62;
            this.dgvDevices.RowTemplate.Height = 30;
            this.dgvDevices.Size = new System.Drawing.Size(746, 277);
            this.dgvDevices.TabIndex = 2;
            // 
            // btnStartPoll
            // 
            this.btnStartPoll.Location = new System.Drawing.Point(391, 95);
            this.btnStartPoll.Name = "btnStartPoll";
            this.btnStartPoll.Size = new System.Drawing.Size(101, 50);
            this.btnStartPoll.TabIndex = 3;
            this.btnStartPoll.Text = "开始采集";
            this.btnStartPoll.UseVisualStyleBackColor = true;
            this.btnStartPoll.Click += new System.EventHandler(this.btnStartPoll_Click);
            // 
            // btnStopPoll
            // 
            this.btnStopPoll.Location = new System.Drawing.Point(582, 103);
            this.btnStopPoll.Name = "btnStopPoll";
            this.btnStopPoll.Size = new System.Drawing.Size(106, 41);
            this.btnStopPoll.TabIndex = 4;
            this.btnStopPoll.Text = "停止采集";
            this.btnStopPoll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStopPoll);
            this.Controls.Add(this.btnStartPoll);
            this.Controls.Add(this.dgvDevices);
            this.Controls.Add(this.btnLoadDevices);
            this.Controls.Add(this.btnAddDevice);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.Button btnLoadDevices;
        private System.Windows.Forms.DataGridView dgvDevices;
        private System.Windows.Forms.Button btnStartPoll;
        private System.Windows.Forms.Button btnStopPoll;
    }
}

