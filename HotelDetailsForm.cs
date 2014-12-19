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
            rooms = DataManager.GetRooms(hotel);
            InitializeComponent();
            InitUi();

        }

        private void InitUi()
        {
            if (hotel != null)
            {
                inputAdress.Text = hotel.Adress;
                inputName.Text = hotel.Name;
                textViewAbout.Text = hotel.About;


            }
        }

        private void onEditCheckChanged(object sender, EventArgs e)
        {
            bool c = checkBoxEdit.Checked;
            btnSave.Visible = c;
            inputAdress.ReadOnly = !c;
            inputName.ReadOnly = !c;
            textViewAbout.ReadOnly = !c;
        }

        private void onSaveClick(object sender, EventArgs e)
        {
            hotel.Name = inputName.Text;
            hotel.Adress = inputAdress.Text;
            DataManager.UpdateHotel(hotel);
            callback(true);
            Dispose();
        }

        private void onCloseClick(object sender, EventArgs e)
        {
            Dispose();
        }

        private void listViewRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            //todo open room view
        }
    }
}
