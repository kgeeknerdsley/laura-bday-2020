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
		//starting point, gates of the park 6
		Location gatesLoc = new Location("Gates", "This is where the gates are wahoo",
			Properties.Resources.gates, false);

		Location entrancePlaza = new Location("Entrance Plaza", "Take your first photo of the day here! Don't stand here if you want Rise passes.",
			Properties.Resources.entranceplaza, false);

		Location cityHall = new Location("City Hall", "Get a button, maybe leave a compliment? If you're really lucky they'll give you a $120 gift card.",
			Properties.Resources.cityhall, false);

		Location operaHouse = new Location("Opera House", "",
			Properties.Resources.operahouse, false);

		Location mainStreet = new Location("Main Street", "",
			Properties.Resources.mainstreet, false);

		Location circle = new Location("Walt Statue Hub", "",
			Properties.Resources.waltstatue, false);

		//TOMORROWLAND 6
		Location tomorrowFront = new Location("Tomorrowland Entrance", "",
			Properties.Resources.tomorrowlandenter, false);

		Location tomorrowMid = new Location("Tomorrowland Mid", "",
			Properties.Resources.tomorrowlandmid, false);

		Location innoventions = new Location("Launch Bay", "",
			Properties.Resources.launchbay, false);

		Location spaceMountain = new Location("Space Mountain", "",
			Properties.Resources.spacemountain, false);

		Location autopia = new Location("Autopia", "",
			Properties.Resources.autopia, false);

		Location subLagoon = new Location("Submarine Lagoon", "",
			Properties.Resources.sublagoon, false);

		//FANTASYLAND/TOONTOWN 8 
		Location castle = new Location("Castle", "",
			Properties.Resources.castle, false);

		Location matterhornWay = new Location("Matterhorn Alleyway", "",
			Properties.Resources.noimage, false);

		Location matterhorn = new Location("Matterhorn", "",
			Properties.Resources.matterhorn, false);

		Location smallWorld = new Location("Small World", "",
			Properties.Resources.smallworld, false);

		Location fantasyland = new Location("Fantasyland", "",
			Properties.Resources.fantasyland, false);

		Location caseyJr = new Location("Casey Jr.", "",
			Properties.Resources.caseyjr, false);

		Location rogerRabbit = new Location("Roger Rabbit's Car Toon Spin", "",
			Properties.Resources.rogerrabbit, false);

		Location mickeyHouse = new Location("Mickey's House", "",
			Properties.Resources.mickeyhouse, false);

		//FRONTIER/ADVENTURE 10
		Location afSplit = new Location("Adventure/Frontier Split", "",
			Properties.Resources.afsplit, false);

		Location tikiRoom = new Location("Tiki Room", "",
			Properties.Resources.tikiroom, false);

		Location adventurelandMid = new Location("Adventureland Mid", "",
			Properties.Resources.adventureland, false);

		Location indy = new Location("Indiana Jones", "",
			Properties.Resources.indy, false);

		Location frontierland = new Location("Frontierland and Rancho Del Zocalo", "",
			Properties.Resources.frontierland, false);

		Location bigThunder = new Location("Big Thunder Mountain Railroad", "",
			Properties.Resources.bigthunder, false);

		Location riverJunction = new Location("Rivers of America Approach", "",
			Properties.Resources.riversjunction, false);

		Location newOrleans = new Location("New Orleans Shops", "",
			Properties.Resources.neworleans, false);

		Location hauntedMansion = new Location("Haunted Mansion", "",
			Properties.Resources.hauntedmansion, false);

		Location splashMountain = new Location("Splash Mountain", "",
			Properties.Resources.splashmountain, false);

		Location hungryBear = new Location("Hungry Bear Junction", "",
			Properties.Resources.hungrybear, false);

		//galaxys edge 6
		Location geFirstOrderEnter = new Location("Galaxy's Edge, First Order Entrance", "",
			Properties.Resources.firstorder, false);

		Location geBazaarEnter = new Location("Galaxy's Edge, Bazaar Entrance", "",
			Properties.Resources.gebazaar, false);

		Location geRiseEntry = new Location("Galaxy's Edge, Rise Entrance", "",
			Properties.Resources.hungrybearentrance, false);

		Location falcon = new Location("Smuggler's Run", "",
			Properties.Resources.smugglersrun, false);

		Location bazaar = new Location("Batuu Bazaar", "",
			Properties.Resources.bazaar, false);

		Location rise = new Location("Rise of the Resistance", "",
			Properties.Resources.rise, false);

		private Location currentLocation;
		public Stack<Location> locationHistory = new Stack<Location>();

		public mainWindow()
		{
			InitializeComponent();
			changeCurrentLocation(gatesLoc); //set the initial location
			linkLocations(); //link all the locations together
			locationHistory.Push(gatesLoc); //this location should always be the bottom of stack. no empty!!
			updateGUI(getCurrentLocation()); //update window to be the first location
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
				buttonBack.Image = Properties.Resources.downarrow;
			} else
			{
				buttonBack.Image = Properties.Resources.sym_no;
			}


		}

		public void linkLocations()
		{
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

			//fantasyland links
			castle.linkForward(fantasyland);
			castle.linkRight(matterhornWay);

			fantasyland.linkLeft(geFirstOrderEnter);
			fantasyland.linkForward(caseyJr);
			fantasyland.linkRight(smallWorld);

			matterhornWay.linkForward(smallWorld);
			matterhornWay.linkRight(matterhorn);

			matterhorn.linkLeft(subLagoon);
			matterhorn.linkRight(matterhornWay);

			subLagoon.linkForward(matterhorn);
			subLagoon.linkRight(innoventions);
			
			smallWorld.linkForward(rogerRabbit);
			smallWorld.linkLeft(fantasyland);

			rogerRabbit.linkLeft(mickeyHouse);

			//adventureland/frontierland links
			afSplit.linkLeft(tikiRoom);
			afSplit.linkRight(frontierland);

			tikiRoom.linkRight(adventurelandMid);

			adventurelandMid.linkLeft(indy);
			adventurelandMid.linkForward(riverJunction);

			riverJunction.linkLeft(newOrleans);
			riverJunction.linkForward(hauntedMansion);
			riverJunction.linkRight(bigThunder);

			frontierland.linkLeft(bigThunder);

			bigThunder.linkLeft(geBazaarEnter);
			bigThunder.linkRight(frontierland);

			newOrleans.linkForward(hauntedMansion);

			hauntedMansion.linkRight(hungryBear);

			hungryBear.linkLeft(splashMountain);
			hungryBear.linkRight(geRiseEntry);

			//galaxy's edge links
			geRiseEntry.linkForward(rise);
			geRiseEntry.linkLeft(hungryBear);
			rise.linkRight(bazaar);

			bazaar.linkLeft(rise);
			bazaar.linkRight(falcon);

			geFirstOrderEnter.linkForward(falcon);
			geFirstOrderEnter.linkLeft(geBazaarEnter);
			geFirstOrderEnter.linkRight(fantasyland);
			falcon.linkLeft(bazaar);

			
			geBazaarEnter.linkForward(bazaar);
			geBazaarEnter.linkRight(geFirstOrderEnter);
			geBazaarEnter.linkLeft(bigThunder);



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

		private void tutorialLabel_Click(object sender, EventArgs e)
		{

		}
	}
}