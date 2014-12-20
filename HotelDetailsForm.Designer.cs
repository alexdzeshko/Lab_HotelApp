namespace Lab_HotelApp
{
    partial class HotelDetailsForm
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
            this.checkBoxEdit = new System.Windows.Forms.CheckBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.listViewRooms = new System.Windows.Forms.ListBox();
            this.textViewAbout = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxEdit
            // 
            this.checkBoxEdit.AutoSize = true;
            this.checkBoxEdit.Location = new System.Drawing.Point(12, 12);
            this.checkBoxEdit.Name = "checkBoxEdit";
            this.checkBoxEdit.Size = new System.Drawing.Size(44, 17);
            this.checkBoxEdit.TabIndex = 0;
            this.checkBoxEdit.Text = "Edit";
            this.checkBoxEdit.UseVisualStyleBackColor = true;
            this.checkBoxEdit.CheckedChanged += new System.EventHandler(this.onEditCheckChanged);
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(12, 36);
            this.inputName.Name = "inputName";
            this.inputName.ReadOnly = true;
            this.inputName.Size = new System.Drawing.Size(206, 20);
            this.inputName.TabIndex = 1;
            // 
            // inputAdress
            // 
            this.inputAdress.Location = new System.Drawing.Point(13, 63);
            this.inputAdress.Name = "inputAdress";
            this.inputAdress.ReadOnly = true;
            this.inputAdress.Size = new System.Drawing.Size(205, 20);
            this.inputAdress.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hotel name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adress";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.onSaveClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(210, 307);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.onCloseClick);
            // 
            // listViewRooms
            // 
            this.listViewRooms.FormattingEnabled = true;
            this.listViewRooms.Location = new System.Drawing.Point(13, 155);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(272, 121);
            this.listViewRooms.TabIndex = 7;
            this.listViewRooms.SelectedIndexChanged += new System.EventHandler(this.listViewRooms_SelectedIndexChanged);
            // 
            // textViewAbout
            // 
            this.textViewAbout.Location = new System.Drawing.Point(13, 90);
            this.textViewAbout.Name = "textViewAbout";
            this.textViewAbout.ReadOnly = true;
            this.textViewAbout.Size = new System.Drawing.Size(272, 53);
            this.textViewAbout.TabIndex = 8;
            this.textViewAbout.Text = "";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 349);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(273, 23);
            this.progressBar.TabIndex = 9;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(94, 307);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoom.TabIndex = 10;
            this.btnAddRoom.Text = "Add room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Visible = false;
            this.btnAddRoom.Click += new System.EventHandler(this.onAddRoom);
            // 
            // HotelDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 384);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textViewAbout);
            this.Controls.Add(this.listViewRooms);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputAdress);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.checkBoxEdit);
            this.Name = "HotelDetailsForm";
            this.Text = "HotelDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEdit;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox listViewRooms;
        private System.Windows.Forms.RichTextBox textViewAbout;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnAddRoom;
    }
}