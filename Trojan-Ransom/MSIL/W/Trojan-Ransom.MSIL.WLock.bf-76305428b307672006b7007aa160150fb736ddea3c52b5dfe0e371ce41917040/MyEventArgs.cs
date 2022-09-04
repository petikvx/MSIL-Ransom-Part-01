using System;

public class MyEventArgs : EventArgs
{
	private string _data;

	public object Data => _data;

	public MyEventArgs(string dat)
	{
		_data = dat;
	}
}
