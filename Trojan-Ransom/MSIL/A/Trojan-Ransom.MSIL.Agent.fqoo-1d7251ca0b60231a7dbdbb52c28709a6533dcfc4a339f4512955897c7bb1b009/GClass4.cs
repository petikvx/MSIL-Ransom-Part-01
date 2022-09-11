using System;
using System.IO;
using System.Runtime.CompilerServices;

public class GClass4
{
	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private readonly GEnum0 genum0_0;

	[CompilerGenerated]
	private readonly string string_3;

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	public string String_1
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
	}

	public string String_2
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
	}

	public GEnum0 GEnum0_0
	{
		[CompilerGenerated]
		get
		{
			return genum0_0;
		}
	}

	public string String_3
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
	}

	public bool Boolean_0
	{
		get
		{
			if ((GEnum0_0 & GEnum0.Device) != 0)
			{
				return false;
			}
			if ((GEnum0_0 & GEnum0.Ipc) != 0)
			{
				return false;
			}
			if ((GEnum0_0 & GEnum0.Printer) == 0)
			{
				if ((GEnum0_0 & GEnum0.Special) == 0)
				{
					return true;
				}
				if (GEnum0.Special != GEnum0_0 || string.IsNullOrEmpty(String_1))
				{
					return false;
				}
				return true;
			}
			return false;
		}
	}

	public DirectoryInfo DirectoryInfo_0
	{
		get
		{
			if (!Boolean_0)
			{
				return null;
			}
			if (string.IsNullOrEmpty(String_0))
			{
				if (!string.IsNullOrEmpty(String_2))
				{
					return new DirectoryInfo(String_2);
				}
				return new DirectoryInfo(ToString());
			}
			return new DirectoryInfo(ToString());
		}
	}

	public GClass4(string string_4, string string_5, string string_6, GEnum0 genum0_1, string string_7)
	{
		if (GEnum0.Special == genum0_1 && "IPC$" == string_5)
		{
			genum0_1 |= GEnum0.Ipc;
		}
		string_0 = string_4;
		string_1 = string_5;
		string_2 = string_6;
		genum0_0 = genum0_1;
		string_3 = string_7;
	}

	string object.ToString()
	{
		if (string.IsNullOrEmpty(String_0))
		{
			return $"\\\\{Environment.MachineName}\\{String_1}";
		}
		return $"\\\\{String_0}\\{String_1}";
	}

	public bool method_0(string string_4)
	{
		if (!Boolean_0)
		{
			return false;
		}
		if (!string.IsNullOrEmpty(string_4))
		{
			return string_4.ToLower().StartsWith(String_2.ToLower());
		}
		return true;
	}
}
