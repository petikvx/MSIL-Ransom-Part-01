using System;
using Ionic.Zip;

public class GEventArgs0 : EventArgs
{
	private int int_0;

	private bool bool_0;

	private GClass8 gclass8_0;

	private ZipProgressEventType zipProgressEventType_0;

	private string string_0;

	private long long_0;

	private long long_1;

	public int Int32_0
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	public GClass8 GClass8_0
	{
		get
		{
			return gclass8_0;
		}
		set
		{
			gclass8_0 = value;
		}
	}

	public bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 |= value;
		}
	}

	public ZipProgressEventType ZipProgressEventType_0
	{
		get
		{
			return zipProgressEventType_0;
		}
		set
		{
			zipProgressEventType_0 = value;
		}
	}

	public string String_0
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public long Int64_0
	{
		get
		{
			return long_0;
		}
		set
		{
			long_0 = value;
		}
	}

	public long Int64_1
	{
		get
		{
			return long_1;
		}
		set
		{
			long_1 = value;
		}
	}

	internal GEventArgs0()
	{
	}

	internal GEventArgs0(string archiveName, ZipProgressEventType flavor)
	{
		string_0 = archiveName;
		zipProgressEventType_0 = flavor;
	}
}
