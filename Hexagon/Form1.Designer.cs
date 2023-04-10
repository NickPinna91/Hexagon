
namespace Hexagon
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.homePanel = new System.Windows.Forms.Panel();
            this.labelHome = new System.Windows.Forms.Label();
            this.gBoxTiminigs = new System.Windows.Forms.GroupBox();
            this.gBoxTyres = new System.Windows.Forms.GroupBox();
            this.gBoxSpeed = new System.Windows.Forms.GroupBox();
            this.gBoxRPM = new System.Windows.Forms.GroupBox();
            this.gBoxGear = new System.Windows.Forms.GroupBox();
            this.lblGear = new System.Windows.Forms.Label();
            this.lblMaxRPM = new System.Windows.Forms.Label();
            this.lblRPM = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.gBoxFrontTyres = new System.Windows.Forms.GroupBox();
            this.gBoxRearTyres = new System.Windows.Forms.GroupBox();
            this.gBoxFrontLeftTyre = new System.Windows.Forms.GroupBox();
            this.gBoxFrontRightTyre = new System.Windows.Forms.GroupBox();
            this.gBoxRearLeftTyre = new System.Windows.Forms.GroupBox();
            this.gBoxRearRightTyre = new System.Windows.Forms.GroupBox();
            this.lblFrontLeftPressure = new System.Windows.Forms.Label();
            this.lblFrontLeftTemp = new System.Windows.Forms.Label();
            this.lblFrontRightPressure = new System.Windows.Forms.Label();
            this.lblFrontRightTemp = new System.Windows.Forms.Label();
            this.lblRearLeftPressure = new System.Windows.Forms.Label();
            this.lblRearLeftTemp = new System.Windows.Forms.Label();
            this.lblRearRightPressure = new System.Windows.Forms.Label();
            this.lblRearRightTemp = new System.Windows.Forms.Label();
            this.gBoxLastLap = new System.Windows.Forms.GroupBox();
            this.gBoxBestLap = new System.Windows.Forms.GroupBox();
            this.lblLastLap = new System.Windows.Forms.Label();
            this.lblBestLap = new System.Windows.Forms.Label();
            this.btnReadGameData = new System.Windows.Forms.Button();
            this.gBoxDevice = new System.Windows.Forms.GroupBox();
            this.lblDevConnStatus = new System.Windows.Forms.Label();
            this.btnCheckDevConn = new System.Windows.Forms.Button();
            this.lblPID = new System.Windows.Forms.Label();
            this.lblVID = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnSendData = new System.Windows.Forms.Button();
            this.panelMainMenu.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.gBoxTiminigs.SuspendLayout();
            this.gBoxTyres.SuspendLayout();
            this.gBoxSpeed.SuspendLayout();
            this.gBoxRPM.SuspendLayout();
            this.gBoxGear.SuspendLayout();
            this.gBoxFrontTyres.SuspendLayout();
            this.gBoxRearTyres.SuspendLayout();
            this.gBoxFrontLeftTyre.SuspendLayout();
            this.gBoxFrontRightTyre.SuspendLayout();
            this.gBoxRearLeftTyre.SuspendLayout();
            this.gBoxRearRightTyre.SuspendLayout();
            this.gBoxLastLap.SuspendLayout();
            this.gBoxBestLap.SuspendLayout();
            this.gBoxDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMainMenu.Controls.Add(this.panelMenu);
            this.panelMainMenu.Controls.Add(this.panelLogo);
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(300, 660);
            this.panelMainMenu.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnSetting);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Location = new System.Drawing.Point(3, 118);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(292, 537);
            this.panelMenu.TabIndex = 1;
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(0, 50);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(292, 50);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(292, 50);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(292, 109);
            this.panelLogo.TabIndex = 0;
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.gBoxDevice);
            this.homePanel.Controls.Add(this.btnReadGameData);
            this.homePanel.Controls.Add(this.gBoxGear);
            this.homePanel.Controls.Add(this.gBoxRPM);
            this.homePanel.Controls.Add(this.gBoxSpeed);
            this.homePanel.Controls.Add(this.gBoxTyres);
            this.homePanel.Controls.Add(this.gBoxTiminigs);
            this.homePanel.Controls.Add(this.labelHome);
            this.homePanel.Location = new System.Drawing.Point(306, 4);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(773, 652);
            this.homePanel.TabIndex = 1;
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Location = new System.Drawing.Point(25, 17);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(35, 13);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "Home";
            // 
            // gBoxTiminigs
            // 
            this.gBoxTiminigs.Controls.Add(this.gBoxBestLap);
            this.gBoxTiminigs.Controls.Add(this.gBoxLastLap);
            this.gBoxTiminigs.Location = new System.Drawing.Point(28, 44);
            this.gBoxTiminigs.Name = "gBoxTiminigs";
            this.gBoxTiminigs.Size = new System.Drawing.Size(230, 121);
            this.gBoxTiminigs.TabIndex = 1;
            this.gBoxTiminigs.TabStop = false;
            this.gBoxTiminigs.Text = "Timinigs";
            // 
            // gBoxTyres
            // 
            this.gBoxTyres.Controls.Add(this.gBoxRearTyres);
            this.gBoxTyres.Controls.Add(this.gBoxFrontTyres);
            this.gBoxTyres.Location = new System.Drawing.Point(28, 175);
            this.gBoxTyres.Name = "gBoxTyres";
            this.gBoxTyres.Size = new System.Drawing.Size(230, 205);
            this.gBoxTyres.TabIndex = 2;
            this.gBoxTyres.TabStop = false;
            this.gBoxTyres.Text = "Tyres";
            // 
            // gBoxSpeed
            // 
            this.gBoxSpeed.Controls.Add(this.lblSpeed);
            this.gBoxSpeed.Location = new System.Drawing.Point(302, 44);
            this.gBoxSpeed.Name = "gBoxSpeed";
            this.gBoxSpeed.Size = new System.Drawing.Size(213, 54);
            this.gBoxSpeed.TabIndex = 3;
            this.gBoxSpeed.TabStop = false;
            this.gBoxSpeed.Text = "Speed";
            // 
            // gBoxRPM
            // 
            this.gBoxRPM.Controls.Add(this.lblRPM);
            this.gBoxRPM.Controls.Add(this.lblMaxRPM);
            this.gBoxRPM.Location = new System.Drawing.Point(302, 104);
            this.gBoxRPM.Name = "gBoxRPM";
            this.gBoxRPM.Size = new System.Drawing.Size(213, 111);
            this.gBoxRPM.TabIndex = 4;
            this.gBoxRPM.TabStop = false;
            this.gBoxRPM.Text = "RPM";
            // 
            // gBoxGear
            // 
            this.gBoxGear.Controls.Add(this.lblGear);
            this.gBoxGear.Location = new System.Drawing.Point(302, 221);
            this.gBoxGear.Name = "gBoxGear";
            this.gBoxGear.Size = new System.Drawing.Size(213, 66);
            this.gBoxGear.TabIndex = 5;
            this.gBoxGear.TabStop = false;
            this.gBoxGear.Text = "Gear";
            // 
            // lblGear
            // 
            this.lblGear.AutoSize = true;
            this.lblGear.Location = new System.Drawing.Point(23, 27);
            this.lblGear.Name = "lblGear";
            this.lblGear.Size = new System.Drawing.Size(15, 13);
            this.lblGear.TabIndex = 0;
            this.lblGear.Text = "N";
            // 
            // lblMaxRPM
            // 
            this.lblMaxRPM.AutoSize = true;
            this.lblMaxRPM.Location = new System.Drawing.Point(23, 30);
            this.lblMaxRPM.Name = "lblMaxRPM";
            this.lblMaxRPM.Size = new System.Drawing.Size(25, 13);
            this.lblMaxRPM.TabIndex = 0;
            this.lblMaxRPM.Text = "------";
            // 
            // lblRPM
            // 
            this.lblRPM.AutoSize = true;
            this.lblRPM.Location = new System.Drawing.Point(23, 67);
            this.lblRPM.Name = "lblRPM";
            this.lblRPM.Size = new System.Drawing.Size(25, 13);
            this.lblRPM.TabIndex = 1;
            this.lblRPM.Text = "------";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(23, 20);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(19, 13);
            this.lblSpeed.TabIndex = 0;
            this.lblSpeed.Text = "----";
            // 
            // gBoxFrontTyres
            // 
            this.gBoxFrontTyres.Controls.Add(this.gBoxFrontRightTyre);
            this.gBoxFrontTyres.Controls.Add(this.gBoxFrontLeftTyre);
            this.gBoxFrontTyres.Location = new System.Drawing.Point(5, 20);
            this.gBoxFrontTyres.Name = "gBoxFrontTyres";
            this.gBoxFrontTyres.Size = new System.Drawing.Size(219, 85);
            this.gBoxFrontTyres.TabIndex = 0;
            this.gBoxFrontTyres.TabStop = false;
            this.gBoxFrontTyres.Text = "Front";
            // 
            // gBoxRearTyres
            // 
            this.gBoxRearTyres.Controls.Add(this.gBoxRearRightTyre);
            this.gBoxRearTyres.Controls.Add(this.gBoxRearLeftTyre);
            this.gBoxRearTyres.Location = new System.Drawing.Point(6, 107);
            this.gBoxRearTyres.Name = "gBoxRearTyres";
            this.gBoxRearTyres.Size = new System.Drawing.Size(219, 85);
            this.gBoxRearTyres.TabIndex = 1;
            this.gBoxRearTyres.TabStop = false;
            this.gBoxRearTyres.Text = "Rear";
            // 
            // gBoxFrontLeftTyre
            // 
            this.gBoxFrontLeftTyre.Controls.Add(this.lblFrontLeftTemp);
            this.gBoxFrontLeftTyre.Controls.Add(this.lblFrontLeftPressure);
            this.gBoxFrontLeftTyre.Location = new System.Drawing.Point(6, 18);
            this.gBoxFrontLeftTyre.Name = "gBoxFrontLeftTyre";
            this.gBoxFrontLeftTyre.Size = new System.Drawing.Size(97, 61);
            this.gBoxFrontLeftTyre.TabIndex = 0;
            this.gBoxFrontLeftTyre.TabStop = false;
            this.gBoxFrontLeftTyre.Text = "Left";
            // 
            // gBoxFrontRightTyre
            // 
            this.gBoxFrontRightTyre.Controls.Add(this.lblFrontRightTemp);
            this.gBoxFrontRightTyre.Controls.Add(this.lblFrontRightPressure);
            this.gBoxFrontRightTyre.Location = new System.Drawing.Point(114, 18);
            this.gBoxFrontRightTyre.Name = "gBoxFrontRightTyre";
            this.gBoxFrontRightTyre.Size = new System.Drawing.Size(99, 61);
            this.gBoxFrontRightTyre.TabIndex = 1;
            this.gBoxFrontRightTyre.TabStop = false;
            this.gBoxFrontRightTyre.Text = "Right";
            // 
            // gBoxRearLeftTyre
            // 
            this.gBoxRearLeftTyre.Controls.Add(this.lblRearLeftTemp);
            this.gBoxRearLeftTyre.Controls.Add(this.lblRearLeftPressure);
            this.gBoxRearLeftTyre.Location = new System.Drawing.Point(6, 21);
            this.gBoxRearLeftTyre.Name = "gBoxRearLeftTyre";
            this.gBoxRearLeftTyre.Size = new System.Drawing.Size(96, 55);
            this.gBoxRearLeftTyre.TabIndex = 0;
            this.gBoxRearLeftTyre.TabStop = false;
            this.gBoxRearLeftTyre.Text = "Left";
            // 
            // gBoxRearRightTyre
            // 
            this.gBoxRearRightTyre.Controls.Add(this.lblRearRightTemp);
            this.gBoxRearRightTyre.Controls.Add(this.lblRearRightPressure);
            this.gBoxRearRightTyre.Location = new System.Drawing.Point(113, 23);
            this.gBoxRearRightTyre.Name = "gBoxRearRightTyre";
            this.gBoxRearRightTyre.Size = new System.Drawing.Size(94, 56);
            this.gBoxRearRightTyre.TabIndex = 1;
            this.gBoxRearRightTyre.TabStop = false;
            this.gBoxRearRightTyre.Text = "Right";
            // 
            // lblFrontLeftPressure
            // 
            this.lblFrontLeftPressure.AutoSize = true;
            this.lblFrontLeftPressure.Location = new System.Drawing.Point(6, 16);
            this.lblFrontLeftPressure.Name = "lblFrontLeftPressure";
            this.lblFrontLeftPressure.Size = new System.Drawing.Size(30, 13);
            this.lblFrontLeftPressure.TabIndex = 0;
            this.lblFrontLeftPressure.Text = "- PSI";
            // 
            // lblFrontLeftTemp
            // 
            this.lblFrontLeftTemp.AutoSize = true;
            this.lblFrontLeftTemp.Location = new System.Drawing.Point(6, 35);
            this.lblFrontLeftTemp.Name = "lblFrontLeftTemp";
            this.lblFrontLeftTemp.Size = new System.Drawing.Size(23, 13);
            this.lblFrontLeftTemp.TabIndex = 1;
            this.lblFrontLeftTemp.Text = "- °c";
            // 
            // lblFrontRightPressure
            // 
            this.lblFrontRightPressure.AutoSize = true;
            this.lblFrontRightPressure.Location = new System.Drawing.Point(7, 16);
            this.lblFrontRightPressure.Name = "lblFrontRightPressure";
            this.lblFrontRightPressure.Size = new System.Drawing.Size(30, 13);
            this.lblFrontRightPressure.TabIndex = 0;
            this.lblFrontRightPressure.Text = "- PSI";
            // 
            // lblFrontRightTemp
            // 
            this.lblFrontRightTemp.AutoSize = true;
            this.lblFrontRightTemp.Location = new System.Drawing.Point(7, 33);
            this.lblFrontRightTemp.Name = "lblFrontRightTemp";
            this.lblFrontRightTemp.Size = new System.Drawing.Size(23, 13);
            this.lblFrontRightTemp.TabIndex = 1;
            this.lblFrontRightTemp.Text = "- °c";
            // 
            // lblRearLeftPressure
            // 
            this.lblRearLeftPressure.AutoSize = true;
            this.lblRearLeftPressure.Location = new System.Drawing.Point(6, 16);
            this.lblRearLeftPressure.Name = "lblRearLeftPressure";
            this.lblRearLeftPressure.Size = new System.Drawing.Size(30, 13);
            this.lblRearLeftPressure.TabIndex = 0;
            this.lblRearLeftPressure.Text = "- PSI";
            // 
            // lblRearLeftTemp
            // 
            this.lblRearLeftTemp.AutoSize = true;
            this.lblRearLeftTemp.Location = new System.Drawing.Point(10, 36);
            this.lblRearLeftTemp.Name = "lblRearLeftTemp";
            this.lblRearLeftTemp.Size = new System.Drawing.Size(23, 13);
            this.lblRearLeftTemp.TabIndex = 1;
            this.lblRearLeftTemp.Text = "- °c";
            // 
            // lblRearRightPressure
            // 
            this.lblRearRightPressure.AutoSize = true;
            this.lblRearRightPressure.Location = new System.Drawing.Point(7, 17);
            this.lblRearRightPressure.Name = "lblRearRightPressure";
            this.lblRearRightPressure.Size = new System.Drawing.Size(30, 13);
            this.lblRearRightPressure.TabIndex = 0;
            this.lblRearRightPressure.Text = "- PSI";
            // 
            // lblRearRightTemp
            // 
            this.lblRearRightTemp.AutoSize = true;
            this.lblRearRightTemp.Location = new System.Drawing.Point(10, 37);
            this.lblRearRightTemp.Name = "lblRearRightTemp";
            this.lblRearRightTemp.Size = new System.Drawing.Size(23, 13);
            this.lblRearRightTemp.TabIndex = 1;
            this.lblRearRightTemp.Text = "- °c";
            // 
            // gBoxLastLap
            // 
            this.gBoxLastLap.Controls.Add(this.lblLastLap);
            this.gBoxLastLap.Location = new System.Drawing.Point(6, 20);
            this.gBoxLastLap.Name = "gBoxLastLap";
            this.gBoxLastLap.Size = new System.Drawing.Size(212, 45);
            this.gBoxLastLap.TabIndex = 0;
            this.gBoxLastLap.TabStop = false;
            this.gBoxLastLap.Text = "Last Lap";
            // 
            // gBoxBestLap
            // 
            this.gBoxBestLap.Controls.Add(this.lblBestLap);
            this.gBoxBestLap.Location = new System.Drawing.Point(6, 70);
            this.gBoxBestLap.Name = "gBoxBestLap";
            this.gBoxBestLap.Size = new System.Drawing.Size(212, 45);
            this.gBoxBestLap.TabIndex = 1;
            this.gBoxBestLap.TabStop = false;
            this.gBoxBestLap.Text = "Best Lap";
            // 
            // lblLastLap
            // 
            this.lblLastLap.AutoSize = true;
            this.lblLastLap.Location = new System.Drawing.Point(6, 21);
            this.lblLastLap.Name = "lblLastLap";
            this.lblLastLap.Size = new System.Drawing.Size(34, 13);
            this.lblLastLap.TabIndex = 0;
            this.lblLastLap.Text = "--:--.---";
            // 
            // lblBestLap
            // 
            this.lblBestLap.AutoSize = true;
            this.lblBestLap.Location = new System.Drawing.Point(7, 19);
            this.lblBestLap.Name = "lblBestLap";
            this.lblBestLap.Size = new System.Drawing.Size(34, 13);
            this.lblBestLap.TabIndex = 0;
            this.lblBestLap.Text = "--:--.---";
            // 
            // btnReadGameData
            // 
            this.btnReadGameData.Location = new System.Drawing.Point(302, 307);
            this.btnReadGameData.Name = "btnReadGameData";
            this.btnReadGameData.Size = new System.Drawing.Size(213, 60);
            this.btnReadGameData.TabIndex = 1;
            this.btnReadGameData.Text = "Start Reading";
            this.btnReadGameData.UseVisualStyleBackColor = true;
            this.btnReadGameData.Click += new System.EventHandler(this.btnReadGameData_Click);
            // 
            // gBoxDevice
            // 
            this.gBoxDevice.Controls.Add(this.btnSendData);
            this.gBoxDevice.Controls.Add(this.lblVID);
            this.gBoxDevice.Controls.Add(this.lblPID);
            this.gBoxDevice.Controls.Add(this.btnCheckDevConn);
            this.gBoxDevice.Controls.Add(this.lblDevConnStatus);
            this.gBoxDevice.Location = new System.Drawing.Point(28, 386);
            this.gBoxDevice.Name = "gBoxDevice";
            this.gBoxDevice.Size = new System.Drawing.Size(496, 175);
            this.gBoxDevice.TabIndex = 6;
            this.gBoxDevice.TabStop = false;
            this.gBoxDevice.Text = "Device";
            // 
            // lblDevConnStatus
            // 
            this.lblDevConnStatus.AutoSize = true;
            this.lblDevConnStatus.Location = new System.Drawing.Point(19, 34);
            this.lblDevConnStatus.Name = "lblDevConnStatus";
            this.lblDevConnStatus.Size = new System.Drawing.Size(132, 13);
            this.lblDevConnStatus.TabIndex = 0;
            this.lblDevConnStatus.Text = "Check Device Connection";
            // 
            // btnCheckDevConn
            // 
            this.btnCheckDevConn.Location = new System.Drawing.Point(20, 133);
            this.btnCheckDevConn.Name = "btnCheckDevConn";
            this.btnCheckDevConn.Size = new System.Drawing.Size(110, 23);
            this.btnCheckDevConn.TabIndex = 1;
            this.btnCheckDevConn.Text = "Check Connection";
            this.btnCheckDevConn.UseVisualStyleBackColor = true;
            this.btnCheckDevConn.Click += new System.EventHandler(this.btnCheckDevConn_Click);
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(22, 64);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(28, 13);
            this.lblPID.TabIndex = 2;
            this.lblPID.Text = "PID:";
            // 
            // lblVID
            // 
            this.lblVID.AutoSize = true;
            this.lblVID.Location = new System.Drawing.Point(25, 98);
            this.lblVID.Name = "lblVID";
            this.lblVID.Size = new System.Drawing.Size(28, 13);
            this.lblVID.TabIndex = 3;
            this.lblVID.Text = "VID:";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(93, 27);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(99, 50);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "HEX";
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(366, 133);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(110, 23);
            this.btnSendData.TabIndex = 4;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.panelMainMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.gBoxTiminigs.ResumeLayout(false);
            this.gBoxTyres.ResumeLayout(false);
            this.gBoxSpeed.ResumeLayout(false);
            this.gBoxSpeed.PerformLayout();
            this.gBoxRPM.ResumeLayout(false);
            this.gBoxRPM.PerformLayout();
            this.gBoxGear.ResumeLayout(false);
            this.gBoxGear.PerformLayout();
            this.gBoxFrontTyres.ResumeLayout(false);
            this.gBoxRearTyres.ResumeLayout(false);
            this.gBoxFrontLeftTyre.ResumeLayout(false);
            this.gBoxFrontLeftTyre.PerformLayout();
            this.gBoxFrontRightTyre.ResumeLayout(false);
            this.gBoxFrontRightTyre.PerformLayout();
            this.gBoxRearLeftTyre.ResumeLayout(false);
            this.gBoxRearLeftTyre.PerformLayout();
            this.gBoxRearRightTyre.ResumeLayout(false);
            this.gBoxRearRightTyre.PerformLayout();
            this.gBoxLastLap.ResumeLayout(false);
            this.gBoxLastLap.PerformLayout();
            this.gBoxBestLap.ResumeLayout(false);
            this.gBoxBestLap.PerformLayout();
            this.gBoxDevice.ResumeLayout(false);
            this.gBoxDevice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.GroupBox gBoxGear;
        private System.Windows.Forms.Label lblGear;
        private System.Windows.Forms.GroupBox gBoxRPM;
        private System.Windows.Forms.Label lblRPM;
        private System.Windows.Forms.Label lblMaxRPM;
        private System.Windows.Forms.GroupBox gBoxSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.GroupBox gBoxTyres;
        private System.Windows.Forms.GroupBox gBoxRearTyres;
        private System.Windows.Forms.GroupBox gBoxRearRightTyre;
        private System.Windows.Forms.Label lblRearRightTemp;
        private System.Windows.Forms.Label lblRearRightPressure;
        private System.Windows.Forms.GroupBox gBoxRearLeftTyre;
        private System.Windows.Forms.Label lblRearLeftTemp;
        private System.Windows.Forms.Label lblRearLeftPressure;
        private System.Windows.Forms.GroupBox gBoxFrontTyres;
        private System.Windows.Forms.GroupBox gBoxFrontRightTyre;
        private System.Windows.Forms.Label lblFrontRightTemp;
        private System.Windows.Forms.Label lblFrontRightPressure;
        private System.Windows.Forms.GroupBox gBoxFrontLeftTyre;
        private System.Windows.Forms.Label lblFrontLeftTemp;
        private System.Windows.Forms.Label lblFrontLeftPressure;
        private System.Windows.Forms.GroupBox gBoxTiminigs;
        private System.Windows.Forms.GroupBox gBoxBestLap;
        private System.Windows.Forms.Label lblBestLap;
        private System.Windows.Forms.GroupBox gBoxLastLap;
        private System.Windows.Forms.Label lblLastLap;
        private System.Windows.Forms.Button btnReadGameData;
        private System.Windows.Forms.GroupBox gBoxDevice;
        private System.Windows.Forms.Label lblVID;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.Button btnCheckDevConn;
        private System.Windows.Forms.Label lblDevConnStatus;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnSendData;
    }
}

