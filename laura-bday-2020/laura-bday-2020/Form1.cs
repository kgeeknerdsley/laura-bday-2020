using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace laura_bday_2020
{
	public partial class mainWindow : Form
	{
		//starting point, gates of the park 6
		Location gatesLoc = new Location("Gates", "You made it! Hopefully parking was pretty easy (it's very quick in a digital version, isn't it?). Let's get started!",
			Properties.Resources.gates, false);

		Location entrancePlaza = new Location("Entrance Plaza", "Take your first photo of the day here! Don't stand here if you want Rise passes.",
			Properties.Resources.entranceplaza, false);

		Location cityHall = new Location("City Hall", "Get a button, maybe leave a compliment? If you're really lucky they'll give you a $120 gift card.",
			Properties.Resources.cityhall, false);

		Location operaHouse = new Location("Opera House", "Watch some Mr. Lincoln...and get really bored. Nice and air conditioned on a hot day, though.",
			Properties.Resources.operahouse, false);

		Location mainStreet = new Location("Main Street", "Can you see the castle from here? The new colors were a really good idea. Maybe grab a bag of gluten-free cookies while you're here.",
			Properties.Resources.mainstreet, false);

		Location circle = new Location("Walt Statue Hub", "Look out! You might be in someone's photo if you stand here too long. Anyways, which land do you want to go to first?",
			Properties.Resources.waltstatue, false);

		//TOMORROWLAND 6
		Location tomorrowFront = new Location("Tomorrowland Entrance", "Say goodbye to the french fry rocks! Make sure you don't bump into the Star Tours fastpass entrance.",
			Properties.Resources.tomorrowlandenter, false);

		Location tomorrowMid = new Location("Tomorrowland Mid", "Stay to the right! Unless you want some Toy Story merch. Then you're going to have to get creative on a busy day...",
			Properties.Resources.tomorrowlandmid, false);

		Location innoventions = new Location("Launch Bay", "Go get a Chewie hug! Or look at it and miss the House of the Future. Those touchscreens were so cool...",
			Properties.Resources.launchbay, false);

		Location spaceMountain = new Location("Space Mountain", "Hope you got your fastpass ready! Time for the best coaster in the park (objective opinion).",
			Properties.Resources.spacemountain, false);

		Location autopia = new Location("Autopia", "Ahh, the smell of gasoline on a summer's day. Yo soy Berd- no bumping.",
			Properties.Resources.autopia, false);

		Location subLagoon = new Location("Submarine Lagoon", "Mine! Mine! Mine! The ride might not be all that great, but the submarines are pretty.",
			Properties.Resources.sublagoon, false);

		//FANTASYLAND/TOONTOWN 8 
		Location castle = new Location("Castle", "Dodge the Photopass employees! It's a pretty view but you can't be camera shy here.",
			Properties.Resources.castle, false);

		Location matterhornWay = new Location("Matterhorn Alleyway", "If you walk down here at just the right time it feels like YOU'RE the parade!",
			Properties.Resources.matterhornalley, false);

		Location matterhorn = new Location("Matterhorn", "Buckle up and get ready for your spine to rearrange! Cover your ears when the yeti shows up. He's just too loud...",
			Properties.Resources.matterhorn, false);

		Location smallWorld = new Location("Small World", "Time to sit down in an air conditioned boat for fifteen minutes. How many Disney characters can you spot?",
			Properties.Resources.smallworld, false);

		Location fantasyland = new Location("Fantasyland", "Surprisingly good variety of rides, but I think my favorite is Pinnochio...for obvious reasons...",
			Properties.Resources.fantasyland, false);

		Location caseyJr = new Location("Casey Jr.", "I'm still shocked adults can fit in this ride. The back is a lot of fun though.",
			Properties.Resources.caseyjr, false);

		Location rogerRabbit = new Location("Roger Rabbit's Car Toon Spin", "Probably the best themed line in the whole park. The ride is a bit terrifying, though.",
			Properties.Resources.rogerrabbit, false);

		Location mickeyHouse = new Location("Mickey's House", "How deep does his underground movie barn go?? Mickey has some explaining to do.",
			Properties.Resources.mickeyhouse, false);

		//FRONTIER/ADVENTURE 10
		Location afSplit = new Location("Adventure/Frontier Split", "Which way to go? Depends: do you want a Dole Whip or Mexican food?",
			Properties.Resources.afsplit, false);

		Location tikiRoom = new Location("Tiki Room", "The best place to kick back and snuggle for a while. Remember to take your enchanted trash with you on the way out.",
			Properties.Resources.tikiroom, false);

		Location adventurelandMid = new Location("Adventureland Mid", "Remember when this used to be full of strollers? What a time that was.",
			Properties.Resources.adventureland, false);

		Location indy = new Location("Indiana Jones", "Such a cool ride, and somehow even more fun if it breaks down!",
			Properties.Resources.indy, false);

		Location frontierland = new Location("Rancho Del Zocalo", "Best gluten free dinner in the park! And I'm not just saying that so I can get a huge burrito.",
			Properties.Resources.frontierland, false);

		Location bigThunder = new Location("Big Thunder Mountain Railroad", "It's almost criminal to ride this without a Fastpass. Watch the goat on your way down for maximum excitement!",
			Properties.Resources.bigthunder, false);

		Location riverJunction = new Location("Rivers of America Approach", "Good luck getting through here on a busy day. Watch out for the Pirates line.",
			Properties.Resources.riversjunction, false);

		Location newOrleans = new Location("New Orleans Shops", "Who buys all the expensive gem statues and perfume? I've never understood that, but hey, it's fun to look at.",
			Properties.Resources.neworleans, false);

		Location hauntedMansion = new Location("Haunted Mansion", "999 haunts...if you stick around long enough you might become the 1000th.",
			Properties.Resources.hauntedmansion, false);

		Location splashMountain = new Location("Splash Mountain", "Bring an extra pair of socks! And don't trust your girlfriend when she says row 4 will be safe. It's not.",
			Properties.Resources.splashmountain, false);

		Location hungryBear = new Location("Hungry Bear Junction", "How's the line looking for Pooh? It's either that or Star Wars Land from here.",
			Properties.Resources.hungrybear, false);

		//galaxys edge 6
		Location geFirstOrderEnter = new Location("Galaxy's Edge, First Order Entrance", "If it's hot, why not grab a blue milk right here? It's definitely a choice you won't regret after a few minutes.",
			Properties.Resources.firstorder, false);

		Location geBazaarEnter = new Location("Galaxy's Edge, Bazaar Entrance", "Careful of rogue droids! Watch your step around the Droid Depot.",
			Properties.Resources.gebazaar, false);

		Location geRiseEntry = new Location("Galaxy's Edge, Rise Entrance", "Get walkin', there's a long way to go before the bazaar. You'll probably see Chewie this way, though.",
			Properties.Resources.hungrybearentrance, false);

		Location falcon = new Location("Smuggler's Run", "Best enjoyed with a party of 6. Remember to ask for pilot!",
			Properties.Resources.smugglersrun, false);

		Location bazaar = new Location("Batuu Bazaar", "Quick! Check and see if any new merchandise appeared since last time...or is that just me?",
			Properties.Resources.bazaar, false);

		Location rise = new Location("Rise of the Resistance", "Got your boarding pass ready? Or are you here for the surprisingly good cheese doodles?",
			Properties.Resources.rise, false);

		private Location currentLocation;
		public Stack<Location> locationHistory = new Stack<Location>();

		bool splash_obj1 = false;
		bool smuggler_obj2 = false;
		bool tiki_obj3 = false;
		bool roger_obj4 = false;

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

				checkObjectives(currentLoc); //check current location against list of objectives
				updateGUI(nextLoc); //change gui to the new location
				changeCurrentLocation(nextLoc); //current location is now the new location
			}
		}

		public void updateGUI(Location location)
		{
			//update photo and text
			nameLabel.Text = location.getName();
			flavorLabel.Text = location.getFlavorText();
			parkImageBox.Image = location.getImage();

			//update button images
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

			if(splash_obj1)
			{
				obj1Image.Image = Properties.Resources.sym_check;
			}

			if(smuggler_obj2)
			{
				obj2Image.Image = Properties.Resources.sym_check;
			}

			if(tiki_obj3)
			{
				obj3Image.Image = Properties.Resources.sym_check;
			}

			if(roger_obj4)
			{
				obj4Image.Image = Properties.Resources.sym_check;
			}


		}

		//sets the booleans to true if visited once
		public void checkObjectives(Location currentLocation)
		{
			if(currentLocation == splashMountain)
			{
				splash_obj1 = true;
			} else if(currentLocation == falcon)
			{
				smuggler_obj2 = true;
			} else if(currentLocation == tikiRoom)
			{
				tiki_obj3 = true;
			} else if(currentLocation == rogerRabbit)
			{
				roger_obj4 = true;
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
			tikiRoom.linkLeft(afSplit);

			adventurelandMid.linkLeft(indy);
			adventurelandMid.linkForward(riverJunction);

			riverJunction.linkLeft(newOrleans);
			riverJunction.linkForward(hauntedMansion);
			riverJunction.linkRight(bigThunder);

			frontierland.linkLeft(bigThunder);
			frontierland.linkRight(afSplit);

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
			//how do i kill this
		}

		private void secretButton_Click(object sender, EventArgs e)
		{
			String pdfpath = Directory.GetCurrentDirectory() + "\\bin\\reward.pdf";

			if(splash_obj1 && smuggler_obj2 && tiki_obj3 && roger_obj4)
			{
				MessageBox.Show("You found all four places! Hit OK to open secret...");
				//use System.Diagnostics.Process.Start(path of pdf) to open a pdf viewer from machine
				System.Diagnostics.Process.Start(pdfpath);
				
			} else
			{
				MessageBox.Show("Keep looking! You haven't found everything yet...");
				//MessageBox.Show(pdfpath);
				//System.Diagnostics.Process.Start(pdfpath);
			}
		}
	}
}