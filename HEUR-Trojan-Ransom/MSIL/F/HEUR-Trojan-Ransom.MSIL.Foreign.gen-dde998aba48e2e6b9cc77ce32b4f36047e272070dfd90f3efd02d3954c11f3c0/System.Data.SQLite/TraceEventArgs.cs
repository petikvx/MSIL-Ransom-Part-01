namespace System.Data.SQLite;

public sealed class TraceEventArgs : EventArgs
{
	public readonly string Statement;

	internal TraceEventArgs(string statement)
	{
		Statement = statement;
	}
}
