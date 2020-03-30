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
		}

		public void changeCurrentLocation(Location newLoc)
		{
			currentLocation = newLoc;
		}

		public Location getCurrentLocation()
		{
			return currentLocation;
		}

		public void move(Location toMove)
		{
			Location temp_loc = getCurrentLocation();
			temp_loc.getFlavorText();
		}

		private void buttonForward_Click(object sender, EventArgs e)
		{

		}

		private void buttonLeft_Click(object sender, EventArgs e)
		{

		}

		private void buttonRight_Click(object sender, EventArgs e)
		{

		}

		private void buttonBack_Click(object sender, EventArgs e)
		{

		}
	}
}
