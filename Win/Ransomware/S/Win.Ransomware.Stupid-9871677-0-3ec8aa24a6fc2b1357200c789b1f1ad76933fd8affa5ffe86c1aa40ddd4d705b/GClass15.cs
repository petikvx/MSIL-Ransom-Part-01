using System.Runtime.CompilerServices;

public class GClass15
{
	public class GClass16 : GInterface0
	{
		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		public string Source
		{
			[CompilerGenerated]
			get
			{
				return string_0;
			}
			[CompilerGenerated]
			private set
			{
				string_0 = value;
			}
		}

		public string Target
		{
			[CompilerGenerated]
			get
			{
				return string_1;
			}
			[CompilerGenerated]
			private set
			{
				string_1 = value;
			}
		}

		public GClass16(string source, string target)
		{
			Source = source;
			Target = target;
		}
	}
}
