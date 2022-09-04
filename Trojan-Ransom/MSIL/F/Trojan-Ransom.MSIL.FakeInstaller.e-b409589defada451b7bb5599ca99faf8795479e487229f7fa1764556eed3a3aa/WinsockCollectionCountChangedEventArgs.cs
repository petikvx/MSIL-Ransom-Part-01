using System;

public class WinsockCollectionCountChangedEventArgs : EventArgs
{
	private int _oldCount;

	private int _newCount;

	public int OldCount => _oldCount;

	public int NewCount => _newCount;

	public WinsockCollectionCountChangedEventArgs(int old_count, int new_count)
	{
		_oldCount = old_count;
		_newCount = new_count;
	}
}
