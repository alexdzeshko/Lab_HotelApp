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
    public partial class CreateHotelForm : Form
    {

        MainForm.Callback callback;

        public CreateHotelForm(MainForm.Callback callback)
        {
            this.callback = callback;
            InitializeComponent();
        }

        private void onBtnOkClick(object sender, EventArgs e)
        {
            DataManager.Instance.AddHotel(new Hotel(inputHotelNmae.Text, inputAdress.Text));
            //todo return result
            callback(true);
            Close();
        }

        private void onBtnCancelClick(object sender, EventArgs e)
        {
            callback(false);
            Close();
        }
    }
}
