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
    public partial class HotelDetailsForm : Form
    {
        private Hotel hotel;
        private List<Room> rooms;
        MainForm.Callback callback;

        public HotelDetailsForm(Hotel hotel, MainForm.Callback callback)
        {
            this.hotel = hotel;
            this.callback = callback;
            LoadRooms(hotel);
            InitializeComponent();
            InitUi();

        }

        private void LoadRooms(Hotel hotel)
        {
            rooms = DataManager.Instance.GetRooms(hotel);
        }

        private void InitUi()
        {
            if (hotel != null)
            {
                inputAdress.Text = hotel.Adress;
                inputName.Text = hotel.Name;
                textViewAbout.Text = hotel.About;

                listViewRooms.Items.Clear();
                rooms.ForEach(delegate(Room r)
                {
                    listViewRooms.Items.Add(r.Type + " - $"+r.Price.ToString());
                });
            }
        }

        private void onEditCheckChanged(object sender, EventArgs e)
        {
            bool c = checkBoxEdit.Checked;
            btnSave.Visible = c;
            btnAddRoom.Visible = c;
            inputAdress.ReadOnly = !c;
            inputName.ReadOnly = !c;
            textViewAbout.ReadOnly = !c;
        }

        private async void onSaveClick(object sender, EventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Marquee;
            hotel.Name = inputName.Text;
            hotel.Adress = inputAdress.Text;
            hotel.About = textViewAbout.Text;
            await DataManager.Instance.UpdateHotelAsync(hotel);
            callback(true);
            Dispose();
        }

        private void onCloseClick(object sender, EventArgs e)
        {
            Dispose();
        }

        private void listViewRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRooms.SelectedIndex > 0)
            {
                Room room = rooms.ElementAt(listViewRooms.SelectedIndex);
                new RoomForm(hotel, room, new MainForm.Callback(Update)).Show();
            }
            
        }

        private void onAddRoom(object sender, EventArgs e)
        {
            
            new RoomForm(hotel, new MainForm.Callback(Update)).Show();
        }

        public void Update(bool update)
        {
            if (update)
            {
                LoadRooms(hotel);
                InitUi();
            }
        }
    }
}
