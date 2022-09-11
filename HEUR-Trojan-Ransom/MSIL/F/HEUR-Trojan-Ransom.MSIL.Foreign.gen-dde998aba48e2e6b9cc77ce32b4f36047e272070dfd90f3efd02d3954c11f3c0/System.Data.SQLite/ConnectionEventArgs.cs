using System.Runtime.InteropServices;

namespace System.Data.SQLite;

public sealed class ConnectionEventArgs : EventArgs
{
	public readonly SQLiteConnectionEventType EventType;

	public readonly StateChangeEventArgs EventArgs;

	public readonly IDbTransaction Transaction;

	public readonly IDbCommand Command;

	public readonly IDataReader DataReader;

	public readonly CriticalHandle CriticalHandle;

	public readonly string Text;

	public readonly object Data;

	internal ConnectionEventArgs(SQLiteConnectionEventType eventType, StateChangeEventArgs eventArgs, IDbTransaction transaction, IDbCommand command, IDataReader dataReader, CriticalHandle criticalHandle, string text, object data)
	{
		EventType = eventType;
		EventArgs = eventArgs;
		Transaction = transaction;
		Command = command;
		DataReader = dataReader;
		CriticalHandle = criticalHandle;
		Text = text;
		Data = data;
	}
}
