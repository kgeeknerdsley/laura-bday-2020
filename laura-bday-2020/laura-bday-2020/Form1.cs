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

		Location entrancePlaza = new Location("Entrance Plaza", "Take your first photo of the day here! Don't stand here if you want Rise passes.",
			Properties.Resources.control_background, false);

		Location cityHall = new Location("City Hall", "Get a button, maybe leave a compliment? If you're really lucky they'll give you a $120 gift card.",
			Properties.Resources.noimage, false);

		Location operaHouse = new Location("Opera House", "",
			Properties.Resources.noimage, false);

		Location mainStreet = new Location("Main Street", "",
			Properties.Resources.noimage, false);

		Location circle = new Location("Walt Statue Hub", "",
			Properties.Resources.noimage, false);

		//TOMORROWLAND
		Location tomorrowFront = new Location("Tomorrowland Entrance", "",
			Properties.Resources.noimage, false);

		Location tomorrowMid = new Location("Tomorrowland Mid", "",
			Properties.Resources.noimage, false);

		Location innoventions = new Location("Launch Bay", "",
			Properties.Resources.noimage, false);

		Location spaceMountain = new Location("Space Mountain", "",
			Properties.Resources.noimage, false);

		Location autopia = new Location("Autopia", "",
			Properties.Resources.noimage, false);

		Location subLagoon = new Location("Submarine Lagoon", "",
			Properties.Resources.noimage, false);

		//FANTASYLAND/TOONTOWN
		Location castle = new Location("Castle", "",
			Properties.Resources.noimage, false);

		Location matterhornWay = new Location("Matterhorn Alleyway", "",
			Properties.Resources.noimage, false);

		Location smallWorld = new Location("Small World", "",
			Properties.Resources.noimage, false);

		Location rogerRabbit = new Location("Roger Rabbit's Car Toon Spin", "",
			Properties.Resources.noimage, false);

		Location mickeyHouse = new Location("Mickey's House", "",
			Properties.Resources.noimage, false);

		//FRONTIER/ADVENTURE
		Location afSplit = new Location("Adventure/Frontier Split", "",
			Properties.Resources.noimage, false);

		Location tikiRoom = new Location("Tiki Room", "",
			Properties.Resources.noimage, false);

		Location indy = new Location("Indiana Jones", "",
			Properties.Resources.noimage, false);

		Location frontierland = new Location("Frontierland and Rancho Del Zocalo", "",
			Properties.Resources.noimage, false);

		Location bigThunder = new Location("Big Thunder Mountain Railroad", "",
			Properties.Resources.noimage, false);

		Location riverJunction = new Location("Rivers of America Approach", "",
			Properties.Resources.noimage, false);

		Location newOrleans = new Location("New Orleans Shops", "",
			Properties.Resources.noimage, false);

		Location hauntedMansion = new Location("Haunted Mansion", "",
			Properties.Resources.noimage, false);

		Location splashMountain = new Location("Splash Mountain", "",
			Properties.Resources.noimage, false);

		//galaxys edge
		Location geFirstOrderEnter = new Location("Galaxy's Edge, First Order Entrance", "",
			Properties.Resources.noimage, false);

		Location geBazaarEnter = new Location("Galaxy's Edge, Bazaar Entrance", "",
			Properties.Resources.noimage, false);

		Location geRiseEntry = new Location("Galaxy's Edge, Rise Entrance", "",
			Properties.Resources.noimage, false);

		Location falcon = new Location("Smuggler's Run", "",
			Properties.Resources.noimage, false);

		Location bazaar = new Location("Batuu Bazaar", "",
			Properties.Resources.noimage, false);

		Location rise = new Location("Rise of the Resistance", "",
			Properties.Resources.noimage, false);

		private Location currentLocation;
		public Stack<Location> locationHistory = new Stack<Location>();

		public mainWindow()
		{
			InitializeComponent();
			changeCurrentLocation(gatesLoc); //set the initial location

			//main street and entrance links
			gatesLoc.linkForward(entrancePlaza);

			entrancePlaza.linkLeft(cityHall);
			entrancePlaza.linkRight(operaHouse);

			cityHall.linkRight(mainStreet);
			operaHouse.linkLeft(mainStreet);

			mainStreet.linkForward(circle);

			circle.linkLeft(afSplit);
			circle.linkForward(castle);
			circle.linkRight(tomorrowFront);

			//tomorrowland links
			tomorrowFront.linkForward(tomorrowMid);
			tomorrowMid.linkForward(innoventions);

			innoventions.linkLeft(subLagoon);
			innoventions.linkForward(autopia);
			innoventions.linkRight(spaceMountain);

			locationHistory.Push(gatesLoc); //this location should always be the bottom of stack. no empty!!
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

			if(location.getLeftLocation() == null)
			{
				buttonLeft.Image = Properties.Resources.sym_no;
			} else
			{
				buttonLeft.Image = Properties.Resources.leftarrow;
			}

			if (location.getForwardLocation() == null)
			{
				buttonForward.Image = Properties.Resources.sym_no;
			}
			else
			{
				buttonForward.Image = Properties.Resources.uparrow;
			}

			if (location.getRightLocation() == null)
			{
				buttonRight.Image = Properties.Resources.sym_no;
			}
			else
			{
				buttonRight.Image = Properties.Resources.rightarrow;
			}

			//note: will crash if stack empties. don't let it?
			if(locationHistory.Peek() != gatesLoc) //if not the gates to go back to say no? not sure if good
			{
				buttonBack.Image = Properties.Resources.sym_no;
			} else
			{
				buttonBack.Image = Properties.Resources.downarrow;
			}


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