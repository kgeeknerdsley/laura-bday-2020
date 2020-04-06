﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laura_bday_2020
{
	public partial class mainWindow : Form
	{
		//starting point, gates of the park
		Location gatesLoc = new Location("Gates", "This is where the gates are wahoo",
			Properties.Resources.gates, false);

		Location testLoc = new Location("Test zone", "This is just for testing",
			Properties.Resources.control_background, false);

		Location entrancePlaza = new Location("Entrance Plaza", "Take your first photo of the day here! Don't stand here if you want Rise passes.",
			Properties.Resources.control_background, false);

		Location cityHall = new Location("City Hall", "Get a button, maybe leave a compliment? If you're really lucky they'll give you a $120 gift card.",
			Properties.Resources.control_background, false);

		private Location currentLocation;
		public Stack<Location> locationHistory = new Stack<Location>();

		public mainWindow()
		{
			InitializeComponent();
			changeCurrentLocation(gatesLoc); //set the initial location

			gatesLoc.linkForward(entrancePlaza);

			entrancePlaza.linkLeft(cityHall);

			updateGUI(getCurrentLocation());
			locationHistory.Push(gatesLoc); //this location should always be the bottom of stack. no empty!!
			//MessageBox.Show(locationHistory.Peek().ToString());
		}

		public void changeCurrentLocation(Location newLoc)
		{
			currentLocation = newLoc;
		}

		public Location getCurrentLocation()
		{
			return currentLocation;
		}

		//0 = forward, 1 = left, 2 = right, 3 = backward
		public void move(int direction)
		{
			Location currentLoc = getCurrentLocation();
			Location nextLoc = null;

			switch (direction) //get where you're going next in nextLoc
			{
				case 0:
					nextLoc = currentLoc.getForwardLocation();
					break;
				case 1:
					nextLoc = currentLoc.getLeftLocation();
					break;
				case 2:
					nextLoc = currentLoc.getRightLocation();
					break;
				case 3:
					nextLoc = locationHistory.Pop(); //pop off the top of the stack for the most recent move

					break;
			}

			if(nextLoc == null) //if it's null, there's no path so go nowhere
			{
				MessageBox.Show("Can't go that way!");
			} else //valid path
			{
				if(direction != 3)
				{
					locationHistory.Push(getCurrentLocation()); //save where we just were
				}

				updateGUI(nextLoc); //change gui to the new location
				changeCurrentLocation(nextLoc); //current location is now the new location

				foreach (Location i in locationHistory)
				{
					Console.WriteLine("---------");
					Console.WriteLine(i.getName());
					Console.WriteLine("---------");
					Console.WriteLine();
				}
			}
		}

		public void updateGUI(Location location)
		{
			nameLabel.Text = location.getName();
			flavorLabel.Text = location.getFlavorText();
			parkImageBox.Image = location.getImage();

		}

		private void buttonForward_Click(object sender, EventArgs e)
		{
			move(0);
		}

		private void buttonLeft_Click(object sender, EventArgs e)
		{
			move(1);
		}

		private void buttonRight_Click(object sender, EventArgs e)
		{
			move(2);
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			move(3);

			if (locationHistory.Count() == 0) //if we popped off the start location, put it back
			{
				locationHistory.Push(gatesLoc);
				MessageBox.Show("Can't go that way!");
			}
		}
	}
}