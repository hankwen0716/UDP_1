
namespace UDP_1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ActiveReceive = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.textBox_ReceiveText = new System.Windows.Forms.TextBox();
            this.textBox_tragetIP = new System.Windows.Forms.TextBox();
            this.textBox_targetport = new System.Windows.Forms.TextBox();
            this.textBox_sendmsg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ActiveReceive
            // 
            this.btn_ActiveReceive.Location = new System.Drawing.Point(512, 105);
            this.btn_ActiveReceive.Name = "btn_ActiveReceive";
            this.btn_ActiveReceive.Size = new System.Drawing.Size(75, 23);
            this.btn_ActiveReceive.TabIndex = 0;
            this.btn_ActiveReceive.Text = "啟動接收";
            this.btn_ActiveReceive.UseVisualStyleBackColor = true;
            this.btn_ActiveReceive.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "測試port";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(136, 51);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(287, 22);
            this.textBox_port.TabIndex = 2;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(512, 183);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "傳送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // textBox_ReceiveText
            // 
            this.textBox_ReceiveText.Location = new System.Drawing.Point(136, 107);
            this.textBox_ReceiveText.Name = "textBox_ReceiveText";
            this.textBox_ReceiveText.Size = new System.Drawing.Size(287, 22);
            this.textBox_ReceiveText.TabIndex = 4;
            // 
            // textBox_tragetIP
            // 
            this.textBox_tragetIP.Location = new System.Drawing.Point(136, 171);
            this.textBox_tragetIP.Name = "textBox_tragetIP";
            this.textBox_tragetIP.Size = new System.Drawing.Size(287, 22);
            this.textBox_tragetIP.TabIndex = 5;
            // 
            // textBox_targetport
            // 
            this.textBox_targetport.Location = new System.Drawing.Point(136, 229);
            this.textBox_targetport.Name = "textBox_targetport";
            this.textBox_targetport.Size = new System.Drawing.Size(287, 22);
            this.textBox_targetport.TabIndex = 6;
            // 
            // textBox_sendmsg
            // 
            this.textBox_sendmsg.Location = new System.Drawing.Point(136, 293);
            this.textBox_sendmsg.Name = "textBox_sendmsg";
            this.textBox_sendmsg.Size = new System.Drawing.Size(287, 22);
            this.textBox_sendmsg.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "接收訊息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "目標IP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "目標port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "傳送訊息";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_sendmsg);
            this.Controls.Add(this.textBox_targetport);
            this.Controls.Add(this.textBox_tragetIP);
            this.Controls.Add(this.textBox_ReceiveText);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ActiveReceive);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ActiveReceive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox textBox_ReceiveText;
        private System.Windows.Forms.TextBox textBox_tragetIP;
        private System.Windows.Forms.TextBox textBox_targetport;
        private System.Windows.Forms.TextBox textBox_sendmsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

