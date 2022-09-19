using System;

public sealed class GEventArgs3 : EventArgs
{
	private readonly DateTime dateTime_0;

	public DateTime Time => dateTime_0;

	public GEventArgs3(DateTime triggeredAt)
	{
		dateTime_0 = triggeredAt;
	}
}
