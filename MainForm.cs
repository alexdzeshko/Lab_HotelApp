﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_HotelApp.model;
using Lab_HotelApp.data_;

namespace Lab_HotelApp
{
    public partial class MainForm : Form
    {
        private List<Hotel> hotels = new List<Hotel>();

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            FillHotels();
        }

        
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (hotelsListView.SelectedItems.Count == 1)
            {
                Hotel hotel = (Hotel)hotelsListView.SelectedItems[0].Tag;
                new HotelDetailsForm(hotel, new Callback(Update)).Show();
            }
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (hotelsListView.SelectedItems.Count == 1)
            {
                Hotel hotel = (Hotel)hotelsListView.SelectedItems[0].Tag;
                DataManager.Instance.DeleteHotel(hotel);
                Update(true);
            }
        }

        private async void FillHotels()
        {
            progressBar1.Style = ProgressBarStyle.Marquee;

            hotels = await DataManager.Instance.GetHotelsAsync();

            progressBar1.Style = ProgressBarStyle.Continuous;
            FillListView();
        }

        private void FillListView()
        {
            hotelsListView.Items.Clear();

            hotels.ForEach(delegate(Hotel h)
            {
                ListViewItem lvi = new ListViewItem(h.Name);
                lvi.Tag = h;
                hotelsListView.Items.Add(lvi);
            });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateHotelForm Form = new CreateHotelForm(new Callback(Update));
            Form.Show();
        }

        public void Update(bool update)
        {
            if (update)
            {
                FillHotels();
                
            }
        }

        public delegate void Callback(bool action);

        private void onHotelSelected(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }
    }
}
