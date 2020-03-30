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
		int placeholdingForImage;
		Location left;
		Location forward;
		Location right;
		Location back;
		bool action;

		public Location(String inputName, String inputFlavor, int placeholder, 
			Location inputLeft, Location inputForward, Location inputRight, Location inputBack, bool inputAction)
		{
			this.name = inputName;
			this.flavorText = inputFlavor;
			this.placeholdingForImage = placeholder;
			this.left = inputLeft;
			this.forward = inputForward;
			this.right = inputRight;
			this.back = inputBack;
			this.action = inputAction;
		}
	}
}
