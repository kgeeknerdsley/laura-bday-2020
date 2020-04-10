using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laura_bday_2020
{
	public class Location
	{
		String name;
		String flavorText;
		System.Drawing.Bitmap image;
		Location left;
		Location forward;
		Location right;
		Location back;
		bool action;

		public Location(String inputName, String inputFlavor, System.Drawing.Bitmap inputImage, 
			Location inputLeft, Location inputForward, Location inputRight, Location inputBack, bool inputAction)
		{
			this.name = inputName;
			this.flavorText = inputFlavor;
			this.image = inputImage;
			this.left = inputLeft;
			this.forward = inputForward;
			this.right = inputRight;
			this.back = inputBack;
			this.action = inputAction;
		}

		//if we have trouble instantiating in order, use this version
		public Location(String inputName, String inputFlavor, System.Drawing.Bitmap inputImage, bool inputAction)
		{
			this.name = inputName;
			this.flavorText = inputFlavor;
			this.image = inputImage;
			this.left = null;
			this.forward = null;
			this.right = null;
			this.back = null;
			this.action = inputAction;
		}

		//link locations together
		public void linkLeft(Location leftLoc)
		{
			this.left = leftLoc;
		}

		public void linkRight(Location rightLoc)
		{
			this.right = rightLoc;
		}

		public void linkForward(Location forwardLoc)
		{
			this.forward = forwardLoc;
		}

		public void linkBack(Location backLoc)
		{
			this.back = backLoc;
		}

		public Location getForwardLocation()
		{
			return this.forward;
		}

		public Location getLeftLocation()
		{
			return this.left;
		}

		public Location getBackLocation()
		{
			return this.back;
		}

		public Location getRightLocation()
		{
			return this.right;
		}

		public String getName()
		{
			return this.name;
		}

		public String getFlavorText()
		{
			return flavorText;
		}

		public System.Drawing.Bitmap getImage()
		{
			return image;
		}
	}
}