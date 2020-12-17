namespace CameraControlTool
{
    partial class FormCameraControlTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCameraControlTool));
            this.buttonMixerOnOff = new System.Windows.Forms.Button();
            this.buttonSnapshotOutputFrame = new System.Windows.Forms.Button();
            this.buttonSnapshotNextSourceFrame = new System.Windows.Forms.Button();
            this.buttonCrossbarSettings = new System.Windows.Forms.Button();
            this.buttonTVMode = new System.Windows.Forms.Button();
            this.tableLayoutPanelForm = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPinOutputSettings = new System.Windows.Forms.Button();
            this.panelCamera = new System.Windows.Forms.Panel();
            this.buttonUnZoom = new System.Windows.Forms.Button();
            this.cameraControl = new Camera_NET.CameraControl();
            this.labelSnapshotTitle = new System.Windows.Forms.Label();
            this.buttonCameraSettings = new System.Windows.Forms.Button();
            this.pictureBoxScreenshot = new System.Windows.Forms.PictureBox();
            this.comboBoxResolutionList = new System.Windows.Forms.ComboBox();
            this.labelResolutionTitle = new System.Windows.Forms.Label();
            this.labelCameraTitle = new System.Windows.Forms.Label();
            this.comboBoxCameraList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonClearSnapshotFrame = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanelForm.SuspendLayout();
            this.panelCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreenshot)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMixerOnOff
            // 
            this.buttonMixerOnOff.Location = new System.Drawing.Point(11, 464);
            this.buttonMixerOnOff.Name = "buttonMixerOnOff";
            this.buttonMixerOnOff.Size = new System.Drawing.Size(194, 28);
            this.buttonMixerOnOff.TabIndex = 1;
            this.buttonMixerOnOff.Text = "Turn mixer overlay ON/OFF";
            this.buttonMixerOnOff.UseVisualStyleBackColor = true;
            this.buttonMixerOnOff.Visible = false;
            this.buttonMixerOnOff.Click += new System.EventHandler(this.buttonMixerOnOff_Click);
            // 
            // buttonSnapshotOutputFrame
            // 
            this.buttonSnapshotOutputFrame.Location = new System.Drawing.Point(11, 227);
            this.buttonSnapshotOutputFrame.Name = "buttonSnapshotOutputFrame";
            this.buttonSnapshotOutputFrame.Size = new System.Drawing.Size(194, 28);
            this.buttonSnapshotOutputFrame.TabIndex = 1;
            this.buttonSnapshotOutputFrame.Text = "Cadastrar";
            this.buttonSnapshotOutputFrame.UseVisualStyleBackColor = true;
            this.buttonSnapshotOutputFrame.Click += new System.EventHandler(this.buttonSnapshotOutputFrame_Click);
            // 
            // buttonSnapshotNextSourceFrame
            // 
            this.buttonSnapshotNextSourceFrame.Location = new System.Drawing.Point(11, 519);
            this.buttonSnapshotNextSourceFrame.Name = "buttonSnapshotNextSourceFrame";
            this.buttonSnapshotNextSourceFrame.Size = new System.Drawing.Size(194, 28);
            this.buttonSnapshotNextSourceFrame.TabIndex = 1;
            this.buttonSnapshotNextSourceFrame.Text = "Snapshot next source frame (fast)";
            this.buttonSnapshotNextSourceFrame.UseVisualStyleBackColor = true;
            this.buttonSnapshotNextSourceFrame.Visible = false;
            this.buttonSnapshotNextSourceFrame.Click += new System.EventHandler(this.buttonSnapshotNextSourceFrame_Click);
            // 
            // buttonCrossbarSettings
            // 
            this.buttonCrossbarSettings.Location = new System.Drawing.Point(11, 430);
            this.buttonCrossbarSettings.Name = "buttonCrossbarSettings";
            this.buttonCrossbarSettings.Size = new System.Drawing.Size(194, 28);
            this.buttonCrossbarSettings.TabIndex = 1;
            this.buttonCrossbarSettings.Text = "Crossbar settings";
            this.buttonCrossbarSettings.UseVisualStyleBackColor = true;
            this.buttonCrossbarSettings.Visible = false;
            this.buttonCrossbarSettings.Click += new System.EventHandler(this.buttonCrossbarSettings_Click);
            // 
            // buttonTVMode
            // 
            this.buttonTVMode.Location = new System.Drawing.Point(11, 396);
            this.buttonTVMode.Name = "buttonTVMode";
            this.buttonTVMode.Size = new System.Drawing.Size(194, 28);
            this.buttonTVMode.TabIndex = 1;
            this.buttonTVMode.Text = "Get current TV Mode";
            this.buttonTVMode.UseVisualStyleBackColor = true;
            this.buttonTVMode.Visible = false;
            this.buttonTVMode.Click += new System.EventHandler(this.buttonTVMode_Click);
            // 
            // tableLayoutPanelForm
            // 
            this.tableLayoutPanelForm.ColumnCount = 2;
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelForm.Controls.Add(this.buttonPinOutputSettings, 0, 9);
            this.tableLayoutPanelForm.Controls.Add(this.panelCamera, 1, 0);
            this.tableLayoutPanelForm.Controls.Add(this.buttonMixerOnOff, 0, 12);
            this.tableLayoutPanelForm.Controls.Add(this.buttonCrossbarSettings, 0, 11);
            this.tableLayoutPanelForm.Controls.Add(this.buttonTVMode, 0, 10);
            this.tableLayoutPanelForm.Controls.Add(this.labelSnapshotTitle, 0, 13);
            this.tableLayoutPanelForm.Controls.Add(this.buttonSnapshotNextSourceFrame, 0, 14);
            this.tableLayoutPanelForm.Controls.Add(this.buttonCameraSettings, 0, 8);
            this.tableLayoutPanelForm.Controls.Add(this.pictureBoxScreenshot, 0, 0);
            this.tableLayoutPanelForm.Controls.Add(this.comboBoxResolutionList, 0, 16);
            this.tableLayoutPanelForm.Controls.Add(this.labelResolutionTitle, 0, 15);
            this.tableLayoutPanelForm.Controls.Add(this.labelCameraTitle, 0, 18);
            this.tableLayoutPanelForm.Controls.Add(this.comboBoxCameraList, 0, 19);
            this.tableLayoutPanelForm.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelForm.Controls.Add(this.textBoxName, 0, 2);
            this.tableLayoutPanelForm.Controls.Add(this.buttonSnapshotOutputFrame, 0, 5);
            this.tableLayoutPanelForm.Controls.Add(this.buttonClearSnapshotFrame, 0, 6);
            this.tableLayoutPanelForm.Controls.Add(this.button1, 0, 21);
            this.tableLayoutPanelForm.Controls.Add(this.button2, 0, 7);
            this.tableLayoutPanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelForm.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelForm.Name = "tableLayoutPanelForm";
            this.tableLayoutPanelForm.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanelForm.RowCount = 23;
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.Size = new System.Drawing.Size(1061, 855);
            this.tableLayoutPanelForm.TabIndex = 0;
            this.tableLayoutPanelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelForm_Paint);
            // 
            // buttonPinOutputSettings
            // 
            this.buttonPinOutputSettings.Location = new System.Drawing.Point(11, 362);
            this.buttonPinOutputSettings.Name = "buttonPinOutputSettings";
            this.buttonPinOutputSettings.Size = new System.Drawing.Size(194, 28);
            this.buttonPinOutputSettings.TabIndex = 9;
            this.buttonPinOutputSettings.Text = "Camera Output settings";
            this.buttonPinOutputSettings.UseVisualStyleBackColor = true;
            this.buttonPinOutputSettings.Visible = false;
            this.buttonPinOutputSettings.Click += new System.EventHandler(this.buttonPinOutputSettings_Click);
            // 
            // panelCamera
            // 
            this.panelCamera.Controls.Add(this.buttonUnZoom);
            this.panelCamera.Controls.Add(this.cameraControl);
            this.panelCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCamera.Location = new System.Drawing.Point(341, 11);
            this.panelCamera.Name = "panelCamera";
            this.tableLayoutPanelForm.SetRowSpan(this.panelCamera, 20);
            this.panelCamera.Size = new System.Drawing.Size(709, 773);
            this.panelCamera.TabIndex = 1;
            // 
            // buttonUnZoom
            // 
            this.buttonUnZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnZoom.Image = ((System.Drawing.Image)(resources.GetObject("buttonUnZoom.Image")));
            this.buttonUnZoom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUnZoom.Location = new System.Drawing.Point(13, 10);
            this.buttonUnZoom.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUnZoom.Name = "buttonUnZoom";
            this.buttonUnZoom.Size = new System.Drawing.Size(113, 26);
            this.buttonUnZoom.TabIndex = 1;
            this.buttonUnZoom.Text = "Reset zoom";
            this.buttonUnZoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUnZoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUnZoom.UseVisualStyleBackColor = true;
            this.buttonUnZoom.Visible = false;
            this.buttonUnZoom.Click += new System.EventHandler(this.buttonUnZoom_Click);
            // 
            // cameraControl
            // 
            this.cameraControl.DirectShowLogFilepath = "";
            this.cameraControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraControl.Location = new System.Drawing.Point(0, 0);
            this.cameraControl.Name = "cameraControl";
            this.cameraControl.Size = new System.Drawing.Size(709, 773);
            this.cameraControl.TabIndex = 2;
            this.cameraControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cameraControl_MouseDoubleClick);
            this.cameraControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cameraControl_MouseDown);
            this.cameraControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cameraControl_MouseMove);
            this.cameraControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cameraControl_MouseUp);
            // 
            // labelSnapshotTitle
            // 
            this.labelSnapshotTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSnapshotTitle.AutoSize = true;
            this.labelSnapshotTitle.Location = new System.Drawing.Point(11, 503);
            this.labelSnapshotTitle.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelSnapshotTitle.Name = "labelSnapshotTitle";
            this.labelSnapshotTitle.Size = new System.Drawing.Size(60, 13);
            this.labelSnapshotTitle.TabIndex = 5;
            this.labelSnapshotTitle.Text = "Snapshots:";
            this.labelSnapshotTitle.Visible = false;
            // 
            // buttonCameraSettings
            // 
            this.buttonCameraSettings.Location = new System.Drawing.Point(11, 328);
            this.buttonCameraSettings.Name = "buttonCameraSettings";
            this.buttonCameraSettings.Size = new System.Drawing.Size(194, 28);
            this.buttonCameraSettings.TabIndex = 1;
            this.buttonCameraSettings.Text = "Camera settings";
            this.buttonCameraSettings.UseVisualStyleBackColor = true;
            this.buttonCameraSettings.Visible = false;
            this.buttonCameraSettings.Click += new System.EventHandler(this.buttonCameraSettings_Click);
            // 
            // pictureBoxScreenshot
            // 
            this.pictureBoxScreenshot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxScreenshot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxScreenshot.Location = new System.Drawing.Point(83, 11);
            this.pictureBoxScreenshot.Name = "pictureBoxScreenshot";
            this.pictureBoxScreenshot.Size = new System.Drawing.Size(180, 120);
            this.pictureBoxScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxScreenshot.TabIndex = 2;
            this.pictureBoxScreenshot.TabStop = false;
            // 
            // comboBoxResolutionList
            // 
            this.comboBoxResolutionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResolutionList.FormattingEnabled = true;
            this.comboBoxResolutionList.Location = new System.Drawing.Point(11, 566);
            this.comboBoxResolutionList.Name = "comboBoxResolutionList";
            this.comboBoxResolutionList.Size = new System.Drawing.Size(194, 21);
            this.comboBoxResolutionList.TabIndex = 6;
            this.comboBoxResolutionList.Visible = false;
            this.comboBoxResolutionList.SelectedIndexChanged += new System.EventHandler(this.comboBoxResolutionList_SelectedIndexChanged);
            // 
            // labelResolutionTitle
            // 
            this.labelResolutionTitle.AutoSize = true;
            this.labelResolutionTitle.Location = new System.Drawing.Point(11, 558);
            this.labelResolutionTitle.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelResolutionTitle.Name = "labelResolutionTitle";
            this.labelResolutionTitle.Size = new System.Drawing.Size(105, 5);
            this.labelResolutionTitle.TabIndex = 7;
            this.labelResolutionTitle.Text = "Resolution selection:";
            this.labelResolutionTitle.Visible = false;
            // 
            // labelCameraTitle
            // 
            this.labelCameraTitle.AutoSize = true;
            this.labelCameraTitle.Location = new System.Drawing.Point(11, 759);
            this.labelCameraTitle.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelCameraTitle.Name = "labelCameraTitle";
            this.labelCameraTitle.Size = new System.Drawing.Size(91, 1);
            this.labelCameraTitle.TabIndex = 4;
            this.labelCameraTitle.Text = "Camera selection:";
            this.labelCameraTitle.Visible = false;
            // 
            // comboBoxCameraList
            // 
            this.comboBoxCameraList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCameraList.FormattingEnabled = true;
            this.comboBoxCameraList.Location = new System.Drawing.Point(11, 763);
            this.comboBoxCameraList.Name = "comboBoxCameraList";
            this.comboBoxCameraList.Size = new System.Drawing.Size(194, 21);
            this.comboBoxCameraList.TabIndex = 3;
            this.comboBoxCameraList.Visible = false;
            this.comboBoxCameraList.SelectedIndexChanged += new System.EventHandler(this.comboBoxCameraList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(11, 150);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(324, 20);
            this.textBoxName.TabIndex = 11;
            // 
            // buttonClearSnapshotFrame
            // 
            this.buttonClearSnapshotFrame.Location = new System.Drawing.Point(11, 261);
            this.buttonClearSnapshotFrame.Name = "buttonClearSnapshotFrame";
            this.buttonClearSnapshotFrame.Size = new System.Drawing.Size(194, 28);
            this.buttonClearSnapshotFrame.TabIndex = 1;
            this.buttonClearSnapshotFrame.Text = "Novo Cadastro";
            this.buttonClearSnapshotFrame.UseVisualStyleBackColor = true;
            this.buttonClearSnapshotFrame.Visible = false;
            this.buttonClearSnapshotFrame.Click += new System.EventHandler(this.buttonClearSnapshotFrame_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 810);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 14);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Ver fotos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormCameraControlTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 855);
            this.Controls.Add(this.tableLayoutPanelForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "FormCameraControlTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUC - IA Projeto Integrado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormCameraControlTool_Load);
            this.tableLayoutPanelForm.ResumeLayout(false);
            this.tableLayoutPanelForm.PerformLayout();
            this.panelCamera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreenshot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMixerOnOff;
        private System.Windows.Forms.Button buttonSnapshotOutputFrame;
        private System.Windows.Forms.PictureBox pictureBoxScreenshot;
        private System.Windows.Forms.Button buttonSnapshotNextSourceFrame;
        private System.Windows.Forms.Button buttonUnZoom;
        private System.Windows.Forms.Button buttonCrossbarSettings;
        private System.Windows.Forms.Button buttonTVMode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelForm;
        private System.Windows.Forms.Panel panelCamera;
        private System.Windows.Forms.Label labelSnapshotTitle;
        private System.Windows.Forms.ComboBox comboBoxResolutionList;
        private System.Windows.Forms.Label labelResolutionTitle;
        private System.Windows.Forms.Button buttonClearSnapshotFrame;
        private System.Windows.Forms.Button buttonCameraSettings;
        private Camera_NET.CameraControl cameraControl;
        private System.Windows.Forms.Button buttonPinOutputSettings;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCameraTitle;
        private System.Windows.Forms.ComboBox comboBoxCameraList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

