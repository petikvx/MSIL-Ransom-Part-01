using System;

namespace Orcus.Utilities.KeyLogger;

internal class SendLogEventArgs : EventArgs
{
	public bool IsHandled { get; set; }

	public byte[] LogData { get; }

	public SendLogEventArgs(byte[] logData)
	{
		LogData = logData;
	}
}
