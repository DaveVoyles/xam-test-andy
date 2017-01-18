using System;
namespace _1to1Core
{
	/// <summary>
	/// Maps data from JSON to C# type
	/// </summary>
	public class DeviceData
	{
		public int Id{
			get;
			set;
		}

		public string DeviceId
		{
			get;
			set;
		}

		public string SensorType
		{
			get;
			set;
		}

		public string SensorValue
		{
			get;
			set;
		}

		public DateTime OutputTime
		{
			get;
			set;
		}

	}
}
