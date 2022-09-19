using System;

public class GEventArgs5 : EventArgs
{
	private string string_0;

	public string Description => string_0;

	public GEventArgs5(string description)
	{
		string_0 = description;
	}
}
