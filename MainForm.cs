using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_HotelApp.model;

namespace Lab_HotelApp
{
    public partial class MainForm : Form
    {
        static List<Hotel> hotels = new List<Hotel>();

        public MainForm()
        {
            InitializeComponent();
            FillHotels();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            FillListView();
        }

        
        private void btnOpen_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in hotelsListView.SelectedItems)
            {
                hotelsListView.Items.Remove(eachItem);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in hotelsListView.SelectedItems)
            {
                hotelsListView.Items.Remove(eachItem);
            }
        }

        private void FillHotels()
        {
            List<Room> rooms = new List<Room>();
            List<Preference> preferences = new List<Preference>();

            for (int i = 0; i <= 10; i++)
            {
                Room r = new Room();
                rooms.Add(r);
            }

            preferences.Add(new Preference("Wi-fi"));
            preferences.Add(new Preference("TV"));
            preferences.Add(new Preference("Private pool"));

            for (int i = 0; i <= 10; i++)
            {
                Hotel h = new Hotel(i, "Hotel #" + i, "address #" + i, rooms, preferences);
                hotels.Add(h);
            }
        }

        private void FillListView()
        {
            hotelsListView.Items.Clear();

            hotels.ForEach(delegate(Hotel h)
            {
                ListViewItem lvi = new ListViewItem(h.Name);
                lvi.Tag = h.ID;
                hotelsListView.Items.Add(lvi);
            });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Hotel h = new Hotel();
        }
    }
}
