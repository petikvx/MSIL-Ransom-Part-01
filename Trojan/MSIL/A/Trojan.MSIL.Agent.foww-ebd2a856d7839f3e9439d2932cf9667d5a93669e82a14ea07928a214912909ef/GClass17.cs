using System;
using System.Runtime.CompilerServices;

public class GClass17
{
	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private Uri uri_0;

	public string Username
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public string Password
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public Uri Host
	{
		[CompilerGenerated]
		get
		{
			return uri_0;
		}
		[CompilerGenerated]
		set
		{
			uri_0 = value;
		}
	}

	public override string ToString()
	{
		return string.Format("User: {0}{3}Pass: {1}{3}Host: {2}", Username, Password, Host.Host, Environment.NewLine);
	}
}
