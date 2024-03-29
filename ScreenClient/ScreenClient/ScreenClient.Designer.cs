﻿namespace ScreenClient
{
    partial class ScreenClient
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCMsg = new System.Windows.Forms.TextBox();
            this.btnCSend = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnConnectToServer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMouse1 = new System.Windows.Forms.TextBox();
            this.txtKeyboard1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartGesture = new System.Windows.Forms.Button();
            this.btnCloseGesture = new System.Windows.Forms.Button();
            this.txtMouse2 = new System.Windows.Forms.TextBox();
            this.txtMouse3 = new System.Windows.Forms.TextBox();
            this.txtMouse4 = new System.Windows.Forms.TextBox();
            this.txtKeyboard2 = new System.Windows.Forms.TextBox();
            this.txtKeyboard3 = new System.Windows.Forms.TextBox();
            this.txtKeyboard4 = new System.Windows.Forms.TextBox();
            this.labelCondition1 = new System.Windows.Forms.Label();
            this.btnModelStop = new System.Windows.Forms.Button();
            this.btnModelStart = new System.Windows.Forms.Button();
            this.labelCondition2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(718, 410);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 45;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(718, 372);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(438, 21);
            this.txtFileName.TabIndex = 44;
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(1081, 410);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(75, 23);
            this.btnSendFile.TabIndex = 43;
            this.btnSendFile.Text = "发送文件";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 42;
            this.label4.Text = " 信息发送栏 :";
            // 
            // txtCMsg
            // 
            this.txtCMsg.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCMsg.Location = new System.Drawing.Point(162, 391);
            this.txtCMsg.Name = "txtCMsg";
            this.txtCMsg.Size = new System.Drawing.Size(420, 24);
            this.txtCMsg.TabIndex = 40;
            this.txtCMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCMsg_KeyDown);
            // 
            // btnCSend
            // 
            this.btnCSend.Location = new System.Drawing.Point(588, 391);
            this.btnCSend.Name = "btnCSend";
            this.btnCSend.Size = new System.Drawing.Size(89, 24);
            this.btnCSend.TabIndex = 38;
            this.btnCSend.Text = "发送信息";
            this.btnCSend.UseVisualStyleBackColor = true;
            this.btnCSend.Click += new System.EventHandler(this.btnCSend_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(162, 30);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.Size = new System.Drawing.Size(492, 344);
            this.txtMsg.TabIndex = 37;
            // 
            // btnConnectToServer
            // 
            this.btnConnectToServer.Location = new System.Drawing.Point(40, 120);
            this.btnConnectToServer.Name = "btnConnectToServer";
            this.btnConnectToServer.Size = new System.Drawing.Size(75, 23);
            this.btnConnectToServer.TabIndex = 36;
            this.btnConnectToServer.Text = "连接服务端";
            this.btnConnectToServer.UseVisualStyleBackColor = true;
            this.btnConnectToServer.Click += new System.EventHandler(this.btnConnectToServer_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(41, 158);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 21);
            this.btnExit.TabIndex = 48;
            this.btnExit.Text = "关闭客户端";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPort);
            this.groupBox2.Controls.Add(this.txtIP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 90);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "控制端:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(48, 55);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(90, 21);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "8888";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(48, 15);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(90, 21);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "10.71.44.6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "Port: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "IP: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 50;
            this.label1.Text = "信息内容:";
            // 
            // txtMouse1
            // 
            this.txtMouse1.Location = new System.Drawing.Point(660, 30);
            this.txtMouse1.Multiline = true;
            this.txtMouse1.Name = "txtMouse1";
            this.txtMouse1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMouse1.Size = new System.Drawing.Size(240, 50);
            this.txtMouse1.TabIndex = 51;
            // 
            // txtKeyboard1
            // 
            this.txtKeyboard1.Location = new System.Drawing.Point(931, 30);
            this.txtKeyboard1.Multiline = true;
            this.txtKeyboard1.Name = "txtKeyboard1";
            this.txtKeyboard1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKeyboard1.Size = new System.Drawing.Size(240, 50);
            this.txtKeyboard1.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 53;
            this.label2.Text = "接收的坐标信息:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(929, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 54;
            this.label3.Text = "接收的控制信息:";
            // 
            // btnStartGesture
            // 
            this.btnStartGesture.Location = new System.Drawing.Point(20, 198);
            this.btnStartGesture.Name = "btnStartGesture";
            this.btnStartGesture.Size = new System.Drawing.Size(123, 23);
            this.btnStartGesture.TabIndex = 55;
            this.btnStartGesture.Text = "开启控制信息接收";
            this.btnStartGesture.UseVisualStyleBackColor = true;
            this.btnStartGesture.Click += new System.EventHandler(this.btnStartGesture_Click);
            // 
            // btnCloseGesture
            // 
            this.btnCloseGesture.Location = new System.Drawing.Point(20, 227);
            this.btnCloseGesture.Name = "btnCloseGesture";
            this.btnCloseGesture.Size = new System.Drawing.Size(123, 23);
            this.btnCloseGesture.TabIndex = 56;
            this.btnCloseGesture.Text = "关闭控制信息接收";
            this.btnCloseGesture.UseVisualStyleBackColor = true;
            this.btnCloseGesture.Click += new System.EventHandler(this.btnCloseGesture_Click);
            // 
            // txtMouse2
            // 
            this.txtMouse2.Location = new System.Drawing.Point(660, 93);
            this.txtMouse2.Multiline = true;
            this.txtMouse2.Name = "txtMouse2";
            this.txtMouse2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMouse2.Size = new System.Drawing.Size(240, 50);
            this.txtMouse2.TabIndex = 57;
            // 
            // txtMouse3
            // 
            this.txtMouse3.Location = new System.Drawing.Point(660, 159);
            this.txtMouse3.Multiline = true;
            this.txtMouse3.Name = "txtMouse3";
            this.txtMouse3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMouse3.Size = new System.Drawing.Size(240, 50);
            this.txtMouse3.TabIndex = 58;
            // 
            // txtMouse4
            // 
            this.txtMouse4.Location = new System.Drawing.Point(660, 224);
            this.txtMouse4.Multiline = true;
            this.txtMouse4.Name = "txtMouse4";
            this.txtMouse4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMouse4.Size = new System.Drawing.Size(240, 50);
            this.txtMouse4.TabIndex = 59;
            // 
            // txtKeyboard2
            // 
            this.txtKeyboard2.Location = new System.Drawing.Point(931, 93);
            this.txtKeyboard2.Multiline = true;
            this.txtKeyboard2.Name = "txtKeyboard2";
            this.txtKeyboard2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKeyboard2.Size = new System.Drawing.Size(240, 50);
            this.txtKeyboard2.TabIndex = 60;
            // 
            // txtKeyboard3
            // 
            this.txtKeyboard3.Location = new System.Drawing.Point(931, 159);
            this.txtKeyboard3.Multiline = true;
            this.txtKeyboard3.Name = "txtKeyboard3";
            this.txtKeyboard3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKeyboard3.Size = new System.Drawing.Size(240, 50);
            this.txtKeyboard3.TabIndex = 61;
            // 
            // txtKeyboard4
            // 
            this.txtKeyboard4.Location = new System.Drawing.Point(928, 224);
            this.txtKeyboard4.Multiline = true;
            this.txtKeyboard4.Name = "txtKeyboard4";
            this.txtKeyboard4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKeyboard4.Size = new System.Drawing.Size(240, 50);
            this.txtKeyboard4.TabIndex = 62;
            // 
            // labelCondition1
            // 
            this.labelCondition1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCondition1.Location = new System.Drawing.Point(793, 288);
            this.labelCondition1.Name = "labelCondition1";
            this.labelCondition1.Size = new System.Drawing.Size(247, 41);
            this.labelCondition1.TabIndex = 63;
            this.labelCondition1.Text = "尚未接收控制信息";
            // 
            // btnModelStop
            // 
            this.btnModelStop.Location = new System.Drawing.Point(20, 317);
            this.btnModelStop.Name = "btnModelStop";
            this.btnModelStop.Size = new System.Drawing.Size(123, 23);
            this.btnModelStop.TabIndex = 65;
            this.btnModelStop.Text = "控制模型行为关闭";
            this.btnModelStop.UseVisualStyleBackColor = true;
            this.btnModelStop.Click += new System.EventHandler(this.btnModelStop_Click);
            // 
            // btnModelStart
            // 
            this.btnModelStart.Location = new System.Drawing.Point(20, 288);
            this.btnModelStart.Name = "btnModelStart";
            this.btnModelStart.Size = new System.Drawing.Size(123, 23);
            this.btnModelStart.TabIndex = 64;
            this.btnModelStart.Text = "控制模型行为开启";
            this.btnModelStart.UseVisualStyleBackColor = true;
            this.btnModelStart.Click += new System.EventHandler(this.btnModelStart_Click);
            // 
            // labelCondition2
            // 
            this.labelCondition2.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCondition2.Location = new System.Drawing.Point(793, 328);
            this.labelCondition2.Name = "labelCondition2";
            this.labelCondition2.Size = new System.Drawing.Size(247, 41);
            this.labelCondition2.TabIndex = 66;
            this.labelCondition2.Text = "尚未控制模型运作";
            // 
            // ScreenClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 438);
            this.Controls.Add(this.labelCondition2);
            this.Controls.Add(this.btnModelStop);
            this.Controls.Add(this.btnModelStart);
            this.Controls.Add(this.labelCondition1);
            this.Controls.Add(this.txtKeyboard4);
            this.Controls.Add(this.txtKeyboard3);
            this.Controls.Add(this.txtKeyboard2);
            this.Controls.Add(this.txtMouse4);
            this.Controls.Add(this.txtMouse3);
            this.Controls.Add(this.txtMouse2);
            this.Controls.Add(this.btnCloseGesture);
            this.Controls.Add(this.btnStartGesture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKeyboard1);
            this.Controls.Add(this.txtMouse1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCMsg);
            this.Controls.Add(this.btnCSend);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnConnectToServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ScreenClient";
            this.Text = "模型展示端";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCMsg;
        private System.Windows.Forms.Button btnCSend;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnConnectToServer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMouse1;
        private System.Windows.Forms.TextBox txtKeyboard1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStartGesture;
        private System.Windows.Forms.Button btnCloseGesture;
        private System.Windows.Forms.TextBox txtMouse2;
        private System.Windows.Forms.TextBox txtMouse3;
        private System.Windows.Forms.TextBox txtMouse4;
        private System.Windows.Forms.TextBox txtKeyboard2;
        private System.Windows.Forms.TextBox txtKeyboard3;
        private System.Windows.Forms.TextBox txtKeyboard4;
        private System.Windows.Forms.Label labelCondition1;
        private System.Windows.Forms.Button btnModelStop;
        private System.Windows.Forms.Button btnModelStart;
        private System.Windows.Forms.Label labelCondition2;
    }
}

