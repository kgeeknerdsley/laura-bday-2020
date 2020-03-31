using System;
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

		private Location currentLocation;

		public mainWindow()
		{
			InitializeComponent();
			changeCurrentLocation(gatesLoc); //set the initial location

			gatesLoc.linkForward(testLoc);

			testLoc.linkBack(gatesLoc);

			updateGUI(getCurrentLocation());
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

			switch (direction)
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
					nextLoc = currentLoc.getBackLocation();
					break;
			}

			if(nextLoc == null)
			{
				MessageBox.Show("Can't go that way!");
			} else
			{
				updateGUI(nextLoc);
				changeCurrentLocation(nextLoc);
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
		}
	}
}
