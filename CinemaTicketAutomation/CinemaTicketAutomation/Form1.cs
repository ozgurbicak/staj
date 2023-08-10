﻿using CinemaTicketAutomation.Helpers;
using CinemaTicketAutomation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTicketAutomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Movie> movies;
        private void Form1_Load(object sender, EventArgs e)
        {
            movies = Helper.CreateMovies();
            ListControls();
        }
        private void ListControls()
        {
            Size pictureSize = new Size(300,180);
            Size buttonSize = new Size(90, 40);
            int x = 50;
            int y = 100;
            int xIncrement = 400;
            int yIncrement = 300;
            for(int i = 0;i < movies.Count; i++)
            {
                PictureBox picture = new PictureBox();
                picture.Location = new Point(x, y);
                picture.Size = pictureSize;
                picture.Image = Image.FromFile(movies[i].picturePath);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(picture);
                int buttonX = x;
                int buttonY = picture.Bottom + 10;

                for(int index=0; index<3; index++)
                {
                    
                    Button button = new Button();
                    button.Text = movies[i].sessions[index].time;
                    button.Location = new Point(buttonX, buttonY);
                    button.Size = buttonSize;
                    button.Tag = i;
                    button.Click += new EventHandler(button_Click);
                    this.Controls.Add(button);
                    buttonX += 100;
                }
                if(1200> x + xIncrement + picture.Width)
                {
                    x = xIncrement + x;
                }
               else
                {
                    x = 50;
                    y = yIncrement + y;
                }
                
                
                
            }
        }
        
        private void button_Click(object sender, EventArgs e)
        {

        }
    }
}