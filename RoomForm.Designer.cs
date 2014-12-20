namespace Lab_HotelApp
{
    partial class RoomForm
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
            this.inputRoomName = new System.Windows.Forms.TextBox();
            this.inputPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxEdit = new System.Windows.Forms.CheckBox();
            this.labelEdit = new System.Windows.Forms.Label();
            this.inputPrefs = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.spinnerBedCount = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // inputRoomName
            // 
            this.inputRoomName.Location = new System.Drawing.Point(12, 41);
            this.inputRoomName.Name = "inputRoomName";
            this.inputRoomName.Size = new System.Drawing.Size(120, 20);
            this.inputRoomName.TabIndex = 0;
            // 
            // inputPrice
            // 
            this.inputPrice.Location = new System.Drawing.Point(13, 145);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(119, 20);
            this.inputPrice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // checkBoxEdit
            // 
            this.checkBoxEdit.AutoSize = true;
            this.checkBoxEdit.Location = new System.Drawing.Point(257, 12);
            this.checkBoxEdit.Name = "checkBoxEdit";
            this.checkBoxEdit.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEdit.TabIndex = 5;
            this.checkBoxEdit.UseVisualStyleBackColor = true;
            this.checkBoxEdit.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Location = new System.Drawing.Point(226, 12);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(25, 13);
            this.labelEdit.TabIndex = 6;
            this.labelEdit.Text = "Edit";
            // 
            // inputPrefs
            // 
            this.inputPrefs.Location = new System.Drawing.Point(153, 40);
            this.inputPrefs.Name = "inputPrefs";
            this.inputPrefs.Size = new System.Drawing.Size(119, 125);
            this.inputPrefs.TabIndex = 7;
            this.inputPrefs.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.onSaveClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(196, 225);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.onCloseClick);
            // 
            // spinnerBedCount
            // 
            this.spinnerBedCount.Items.Add("1");
            this.spinnerBedCount.Items.Add("2");
            this.spinnerBedCount.Items.Add("3");
            this.spinnerBedCount.Items.Add("4");
            this.spinnerBedCount.Items.Add("5");
            this.spinnerBedCount.Location = new System.Drawing.Point(12, 94);
            this.spinnerBedCount.Name = "spinnerBedCount";
            this.spinnerBedCount.Size = new System.Drawing.Size(120, 20);
            this.spinnerBedCount.TabIndex = 10;
            this.spinnerBedCount.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bed count";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(153, 182);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(118, 23);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Visible = false;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.spinnerBedCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.inputPrefs);
            this.Controls.Add(this.labelEdit);
            this.Controls.Add(this.checkBoxEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputPrice);
            this.Controls.Add(this.inputRoomName);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputRoomName;
        private System.Windows.Forms.TextBox inputPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxEdit;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.RichTextBox inputPrefs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DomainUpDown spinnerBedCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}