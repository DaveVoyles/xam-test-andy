using System;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace _1to1Core
{
	public class LandingPageViewModel
	{
		public ObservableCollection<DeviceData> Objects { get; set; }


		public LandingPageViewModel()
		{
			
			this.Objects = new ObservableCollection<DeviceData>();

		}

	}
}
