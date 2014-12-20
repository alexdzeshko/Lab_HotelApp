using Lab_HotelApp.data_;
using Lab_HotelApp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_HotelApp
{
    public partial class RoomForm : Form
    {
        Hotel hotel;
        Room room;
        MainForm.Callback callback;

            //is create room mode
        public RoomForm(Hotel hotel, MainForm.Callback callback)
        {
            this.hotel = hotel;
            this.callback = callback;
            InitializeComponent();
            checkBoxEdit.Checked = true;
            checkBoxEdit.Visible = false;
            labelEdit.Visible = false;
            
        }

            //open\edit mode
        public RoomForm(Hotel hotel, Room room, MainForm.Callback callback)
        {
            this.hotel = hotel;
            this.callback = callback;
            this.room = room;
            InitializeComponent();
            InitUi();
        }

        private void InitUi()
        {
            if (room != null)
            {
                inputRoomName.Text = room.Type;
                inputPrice.Text = room.Price.ToString();
                inputPrefs.Text = Preference.GetWrittableString(room.Preferences);
                spinnerBedCount.Text = room.BedCount.ToString();
            }
        }

        private async void onSaveClick(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;

            if (room == null)
            {
                room = new Room();
                room.ID = DataManager.Instance.GetNewRoomId();
                hotel.Rooms.Add(room.ID);
            }
            room.Type = inputRoomName.Text;
            room.Price = Int32.Parse(inputPrice.Text);
            room.Preferences = Preference.FromString(inputPrefs.Text);
            room.BedCount = Int32.Parse(spinnerBedCount.Text);

            DataManager.Instance.UpdateHotel(hotel);
            await DataManager.Instance.UpdateRoomAsync(room);

            callback(true);
            Dispose();

        }

        private void onCloseClick(object sender, EventArgs e)
        {
            Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool c = checkBoxEdit.Checked;
            btnSave.Visible = c;
            inputPrefs.ReadOnly = !c;
            inputRoomName.ReadOnly = !c;
            inputPrice.ReadOnly = !c;
        }

    }
}
