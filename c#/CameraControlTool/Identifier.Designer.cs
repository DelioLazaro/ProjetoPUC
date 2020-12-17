namespace CameraControlTool
{
    partial class Identifier
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLoading = new System.Windows.Forms.Label();
            this.cameraControl = new Camera_NET.CameraControl();
            this.comboBoxCameraList = new System.Windows.Forms.ComboBox();
            this.comboBoxResolutionList = new System.Windows.Forms.ComboBox();
            this.buttonCrossbarSettings = new System.Windows.Forms.Button();
            this.buttonUnZoom = new System.Windows.Forms.Button();
            this.buttonMixerOnOff = new System.Windows.Forms.Button();
            this.buttonSnapshotOutputFrame = new System.Windows.Forms.Button();
            this.buttonClearSnapshotFrame = new System.Windows.Forms.Button();
            this.buttonSnapshotNextSourceFrame = new System.Windows.Forms.Button();
            this.buttonTVMode = new System.Windows.Forms.Button();
            this.buttonCameraSettings = new System.Windows.Forms.Button();
            this.buttonPinOutputSettings = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBoxScreenshot = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewFile = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreenshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fotos para reconhecimento";
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.Location = new System.Drawing.Point(235, 279);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(224, 25);
            this.labelLoading.TabIndex = 6;
            this.labelLoading.Text = "Aguarde, autenticando...";
            this.labelLoading.Visible = false;
            // 
            // cameraControl
            // 
            this.cameraControl.DirectShowLogFilepath = "";
            this.cameraControl.Location = new System.Drawing.Point(559, 166);
            this.cameraControl.Name = "cameraControl";
            this.cameraControl.Size = new System.Drawing.Size(562, 415);
            this.cameraControl.TabIndex = 10;
            this.cameraControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cameraControl_MouseDoubleClick);
            this.cameraControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cameraControl_MouseDown);
            this.cameraControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cameraControl_MouseMove);
            this.cameraControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cameraControl_MouseUp);
            // 
            // comboBoxCameraList
            // 
            this.comboBoxCameraList.FormattingEnabled = true;
            this.comboBoxCameraList.Location = new System.Drawing.Point(22, 399);
            this.comboBoxCameraList.Name = "comboBoxCameraList";
            this.comboBoxCameraList.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCameraList.TabIndex = 11;
            this.comboBoxCameraList.Visible = false;
            this.comboBoxCameraList.SelectedIndexChanged += new System.EventHandler(this.comboBoxCameraList_SelectedIndexChanged);
            // 
            // comboBoxResolutionList
            // 
            this.comboBoxResolutionList.FormattingEnabled = true;
            this.comboBoxResolutionList.Location = new System.Drawing.Point(22, 438);
            this.comboBoxResolutionList.Name = "comboBoxResolutionList";
            this.comboBoxResolutionList.Size = new System.Drawing.Size(121, 21);
            this.comboBoxResolutionList.TabIndex = 12;
            this.comboBoxResolutionList.Visible = false;
            this.comboBoxResolutionList.SelectedIndexChanged += new System.EventHandler(this.comboBoxResolutionList_SelectedIndexChanged);
            // 
            // buttonCrossbarSettings
            // 
            this.buttonCrossbarSettings.Location = new System.Drawing.Point(22, 479);
            this.buttonCrossbarSettings.Name = "buttonCrossbarSettings";
            this.buttonCrossbarSettings.Size = new System.Drawing.Size(121, 23);
            this.buttonCrossbarSettings.TabIndex = 13;
            this.buttonCrossbarSettings.Text = "buttonCrossbarSettings";
            this.buttonCrossbarSettings.UseVisualStyleBackColor = true;
            this.buttonCrossbarSettings.Visible = false;
            this.buttonCrossbarSettings.Click += new System.EventHandler(this.buttonCrossbarSettings_Click);
            // 
            // buttonUnZoom
            // 
            this.buttonUnZoom.Location = new System.Drawing.Point(22, 509);
            this.buttonUnZoom.Name = "buttonUnZoom";
            this.buttonUnZoom.Size = new System.Drawing.Size(121, 23);
            this.buttonUnZoom.TabIndex = 14;
            this.buttonUnZoom.Text = "buttonUnZoom";
            this.buttonUnZoom.UseVisualStyleBackColor = true;
            this.buttonUnZoom.Visible = false;
            this.buttonUnZoom.Click += new System.EventHandler(this.buttonUnZoom_Click);
            // 
            // buttonMixerOnOff
            // 
            this.buttonMixerOnOff.Location = new System.Drawing.Point(22, 537);
            this.buttonMixerOnOff.Name = "buttonMixerOnOff";
            this.buttonMixerOnOff.Size = new System.Drawing.Size(121, 23);
            this.buttonMixerOnOff.TabIndex = 15;
            this.buttonMixerOnOff.Text = "buttonMixerOnOff";
            this.buttonMixerOnOff.UseVisualStyleBackColor = true;
            this.buttonMixerOnOff.Visible = false;
            this.buttonMixerOnOff.Click += new System.EventHandler(this.buttonMixerOnOff_Click);
            // 
            // buttonSnapshotOutputFrame
            // 
            this.buttonSnapshotOutputFrame.Location = new System.Drawing.Point(288, 197);
            this.buttonSnapshotOutputFrame.Name = "buttonSnapshotOutputFrame";
            this.buttonSnapshotOutputFrame.Size = new System.Drawing.Size(121, 23);
            this.buttonSnapshotOutputFrame.TabIndex = 16;
            this.buttonSnapshotOutputFrame.Text = "Autenticar";
            this.buttonSnapshotOutputFrame.UseVisualStyleBackColor = true;
            this.buttonSnapshotOutputFrame.Click += new System.EventHandler(this.buttonSnapshotOutputFrame_Click);
            // 
            // buttonClearSnapshotFrame
            // 
            this.buttonClearSnapshotFrame.Location = new System.Drawing.Point(288, 226);
            this.buttonClearSnapshotFrame.Name = "buttonClearSnapshotFrame";
            this.buttonClearSnapshotFrame.Size = new System.Drawing.Size(121, 23);
            this.buttonClearSnapshotFrame.TabIndex = 18;
            this.buttonClearSnapshotFrame.Text = "Novo reconhecimento";
            this.buttonClearSnapshotFrame.UseVisualStyleBackColor = true;
            this.buttonClearSnapshotFrame.Visible = false;
            this.buttonClearSnapshotFrame.Click += new System.EventHandler(this.buttonClearSnapshotFrame_Click);
            // 
            // buttonSnapshotNextSourceFrame
            // 
            this.buttonSnapshotNextSourceFrame.Location = new System.Drawing.Point(22, 596);
            this.buttonSnapshotNextSourceFrame.Name = "buttonSnapshotNextSourceFrame";
            this.buttonSnapshotNextSourceFrame.Size = new System.Drawing.Size(121, 23);
            this.buttonSnapshotNextSourceFrame.TabIndex = 19;
            this.buttonSnapshotNextSourceFrame.Text = "buttonSnapshotNextSourceFrame";
            this.buttonSnapshotNextSourceFrame.UseVisualStyleBackColor = true;
            this.buttonSnapshotNextSourceFrame.Visible = false;
            this.buttonSnapshotNextSourceFrame.Click += new System.EventHandler(this.buttonSnapshotNextSourceFrame_Click);
            // 
            // buttonTVMode
            // 
            this.buttonTVMode.Location = new System.Drawing.Point(22, 625);
            this.buttonTVMode.Name = "buttonTVMode";
            this.buttonTVMode.Size = new System.Drawing.Size(121, 23);
            this.buttonTVMode.TabIndex = 20;
            this.buttonTVMode.Text = "buttonTVMode";
            this.buttonTVMode.UseVisualStyleBackColor = true;
            this.buttonTVMode.Visible = false;
            this.buttonTVMode.Click += new System.EventHandler(this.buttonTVMode_Click);
            // 
            // buttonCameraSettings
            // 
            this.buttonCameraSettings.Location = new System.Drawing.Point(22, 655);
            this.buttonCameraSettings.Name = "buttonCameraSettings";
            this.buttonCameraSettings.Size = new System.Drawing.Size(133, 23);
            this.buttonCameraSettings.TabIndex = 21;
            this.buttonCameraSettings.Text = "buttonCameraSettings";
            this.buttonCameraSettings.UseVisualStyleBackColor = true;
            this.buttonCameraSettings.Visible = false;
            this.buttonCameraSettings.Click += new System.EventHandler(this.buttonCameraSettings_Click);
            // 
            // buttonPinOutputSettings
            // 
            this.buttonPinOutputSettings.Location = new System.Drawing.Point(31, 684);
            this.buttonPinOutputSettings.Name = "buttonPinOutputSettings";
            this.buttonPinOutputSettings.Size = new System.Drawing.Size(124, 23);
            this.buttonPinOutputSettings.TabIndex = 22;
            this.buttonPinOutputSettings.Text = "buttonPinOutputSettings";
            this.buttonPinOutputSettings.UseVisualStyleBackColor = true;
            this.buttonPinOutputSettings.Visible = false;
            this.buttonPinOutputSettings.Click += new System.EventHandler(this.buttonPinOutputSettings_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(83, 988);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(326, 23);
            this.progressBar1.TabIndex = 23;
            this.progressBar1.Visible = false;
            // 
            // pictureBoxScreenshot
            // 
            this.pictureBoxScreenshot.Location = new System.Drawing.Point(263, 48);
            this.pictureBoxScreenshot.Name = "pictureBoxScreenshot";
            this.pictureBoxScreenshot.Size = new System.Drawing.Size(196, 134);
            this.pictureBoxScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxScreenshot.TabIndex = 17;
            this.pictureBoxScreenshot.TabStop = false;
            this.pictureBoxScreenshot.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CameraControlTool.Properties.Resources.checked__1_;
            this.pictureBox4.Location = new System.Drawing.Point(83, 851);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 102);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CameraControlTool.Properties.Resources._checked;
            this.pictureBox3.Location = new System.Drawing.Point(189, 851);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 102);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CameraControlTool.Properties.Resources.spinner_icon_gif_24;
            this.pictureBox2.Location = new System.Drawing.Point(265, 321);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CameraControlTool.Properties.Resources.face_scan;
            this.pictureBox1.Location = new System.Drawing.Point(465, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(748, 808);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Ver fotos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listViewFile
            // 
            this.listViewFile.HideSelection = false;
            this.listViewFile.Location = new System.Drawing.Point(1290, 124);
            this.listViewFile.Name = "listViewFile";
            this.listViewFile.Size = new System.Drawing.Size(384, 319);
            this.listViewFile.TabIndex = 25;
            this.listViewFile.UseCompatibleStateImageBehavior = false;
            this.listViewFile.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1290, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Identifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1790, 1061);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listViewFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonPinOutputSettings);
            this.Controls.Add(this.buttonCameraSettings);
            this.Controls.Add(this.buttonTVMode);
            this.Controls.Add(this.buttonSnapshotNextSourceFrame);
            this.Controls.Add(this.buttonClearSnapshotFrame);
            this.Controls.Add(this.pictureBoxScreenshot);
            this.Controls.Add(this.buttonSnapshotOutputFrame);
            this.Controls.Add(this.buttonMixerOnOff);
            this.Controls.Add(this.buttonUnZoom);
            this.Controls.Add(this.buttonCrossbarSettings);
            this.Controls.Add(this.comboBoxResolutionList);
            this.Controls.Add(this.comboBoxCameraList);
            this.Controls.Add(this.cameraControl);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Identifier";
            this.Text = "Identifier";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Identifier_FormClosed);
            this.Load += new System.EventHandler(this.Identifier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreenshot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Camera_NET.CameraControl cameraControl;
        private System.Windows.Forms.ComboBox comboBoxCameraList;
        private System.Windows.Forms.ComboBox comboBoxResolutionList;
        private System.Windows.Forms.Button buttonCrossbarSettings;
        private System.Windows.Forms.Button buttonUnZoom;
        private System.Windows.Forms.Button buttonMixerOnOff;
        private System.Windows.Forms.Button buttonSnapshotOutputFrame;
        private System.Windows.Forms.PictureBox pictureBoxScreenshot;
        private System.Windows.Forms.Button buttonClearSnapshotFrame;
        private System.Windows.Forms.Button buttonSnapshotNextSourceFrame;
        private System.Windows.Forms.Button buttonTVMode;
        private System.Windows.Forms.Button buttonCameraSettings;
        private System.Windows.Forms.Button buttonPinOutputSettings;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewFile;
        private System.Windows.Forms.Button button2;
    }
}