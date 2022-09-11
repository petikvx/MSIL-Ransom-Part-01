using System;
using System.Runtime.CompilerServices;

namespace PreEmptive.SoS.Client.Messages;

public class BinaryInformation
{
	[CompilerGenerated]
	private Guid guid_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private DateTime dateTime_0;

	public Guid Id
	{
		[CompilerGenerated]
		get
		{
			int num = 3812;
			int num2 = num;
			num = 3812;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return guid_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = -11347;
			int num2 = num;
			num = -11347;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			guid_0 = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			int num = -17413;
			int num2 = num;
			num = -17413;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return string_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 15439;
			int num2 = num;
			num = 15439;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			string_0 = value;
		}
	}

	public string Version
	{
		[CompilerGenerated]
		get
		{
			int num = 12167;
			int num2 = num;
			num = 12167;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return string_1;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 22000;
			int num2 = num;
			num = 22000;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			string_1 = value;
		}
	}

	public DateTime ModifiedDate
	{
		[CompilerGenerated]
		get
		{
			int num = -24553;
			int num2 = num;
			num = -24553;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return dateTime_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = -13569;
			int num2 = num;
			num = -13569;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			dateTime_0 = value;
		}
	}

	public BinaryInformation(Guid guid_1, string name, string version, string modifiedDate)
	{
		Id = guid_1;
		Name = name;
		Version = version;
		try
		{
			ModifiedDate = DateTime.Parse(modifiedDate);
		}
		catch
		{
			ModifiedDate = DateTime.Today;
		}
	}
}
