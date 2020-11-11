namespace Bluetooth_App
{
    partial class Form1
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
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ButtonChoose = new System.Windows.Forms.Button();
            this.ButtonInfo = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonDeviceInfo = new System.Windows.Forms.Button();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonChooseFile = new System.Windows.Forms.Button();
            this.ListBoxAdapters = new System.Windows.Forms.ListBox();
            this.ListBoxDevices = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(25, 13);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(157, 48);
            this.ButtonRefresh.TabIndex = 0;
            this.ButtonRefresh.Text = "Wyszukaj adapter";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // ButtonChoose
            // 
            this.ButtonChoose.Location = new System.Drawing.Point(25, 67);
            this.ButtonChoose.Name = "ButtonChoose";
            this.ButtonChoose.Size = new System.Drawing.Size(157, 48);
            this.ButtonChoose.TabIndex = 1;
            this.ButtonChoose.Text = "Wybierz";
            this.ButtonChoose.UseVisualStyleBackColor = true;
            this.ButtonChoose.Click += new System.EventHandler(this.ButtonChoose_Click);
            // 
            // ButtonInfo
            // 
            this.ButtonInfo.Location = new System.Drawing.Point(25, 121);
            this.ButtonInfo.Name = "ButtonInfo";
            this.ButtonInfo.Size = new System.Drawing.Size(157, 48);
            this.ButtonInfo.TabIndex = 2;
            this.ButtonInfo.Text = "Informacja o adapterze";
            this.ButtonInfo.UseVisualStyleBackColor = true;
            this.ButtonInfo.Click += new System.EventHandler(this.ButtonInfo_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(505, 13);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(157, 48);
            this.ButtonSearch.TabIndex = 3;
            this.ButtonSearch.Text = "Wyszukaj urządzenia";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonDeviceInfo
            // 
            this.ButtonDeviceInfo.Location = new System.Drawing.Point(505, 67);
            this.ButtonDeviceInfo.Name = "ButtonDeviceInfo";
            this.ButtonDeviceInfo.Size = new System.Drawing.Size(157, 48);
            this.ButtonDeviceInfo.TabIndex = 4;
            this.ButtonDeviceInfo.Text = "Informacja o urządzeniu";
            this.ButtonDeviceInfo.UseVisualStyleBackColor = true;
            this.ButtonDeviceInfo.Click += new System.EventHandler(this.ButtonDeviceInfo_Click);
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(505, 121);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(157, 48);
            this.ButtonConnect.TabIndex = 5;
            this.ButtonConnect.Text = "Połącz";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButtonChooseFile
            // 
            this.ButtonChooseFile.Location = new System.Drawing.Point(505, 175);
            this.ButtonChooseFile.Name = "ButtonChooseFile";
            this.ButtonChooseFile.Size = new System.Drawing.Size(157, 48);
            this.ButtonChooseFile.TabIndex = 6;
            this.ButtonChooseFile.Text = "Wybierz plik";
            this.ButtonChooseFile.UseVisualStyleBackColor = true;
            this.ButtonChooseFile.Click += new System.EventHandler(this.ButtonChooseFile_Click);
            // 
            // ListBoxAdapters
            // 
            this.ListBoxAdapters.FormattingEnabled = true;
            this.ListBoxAdapters.ItemHeight = 16;
            this.ListBoxAdapters.Location = new System.Drawing.Point(207, 13);
            this.ListBoxAdapters.Name = "ListBoxAdapters";
            this.ListBoxAdapters.Size = new System.Drawing.Size(206, 164);
            this.ListBoxAdapters.TabIndex = 7;
            // 
            // ListBoxDevices
            // 
            this.ListBoxDevices.FormattingEnabled = true;
            this.ListBoxDevices.ItemHeight = 16;
            this.ListBoxDevices.Location = new System.Drawing.Point(701, 13);
            this.ListBoxDevices.Name = "ListBoxDevices";
            this.ListBoxDevices.Size = new System.Drawing.Size(206, 164);
            this.ListBoxDevices.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 276);
            this.Controls.Add(this.ListBoxDevices);
            this.Controls.Add(this.ListBoxAdapters);
            this.Controls.Add(this.ButtonChooseFile);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.ButtonDeviceInfo);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonInfo);
            this.Controls.Add(this.ButtonChoose);
            this.Controls.Add(this.ButtonRefresh);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "BluetoothApplication";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.Button ButtonChoose;
        private System.Windows.Forms.Button ButtonInfo;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonDeviceInfo;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Button ButtonChooseFile;
        private System.Windows.Forms.ListBox ListBoxAdapters;
        private System.Windows.Forms.ListBox ListBoxDevices;
    }
}

