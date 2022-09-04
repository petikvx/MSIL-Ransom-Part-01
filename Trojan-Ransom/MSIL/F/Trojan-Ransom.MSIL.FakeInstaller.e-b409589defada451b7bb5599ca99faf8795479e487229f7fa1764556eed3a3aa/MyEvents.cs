using System;

internal interface MyEvents
{
	public delegate void CreatedEventHandler(object sender, EventArgs e);

	event CreatedEventHandler Created;
}
