using System;
using ATI.ACE.LOG.Foundation.Implementation.Private;

namespace ATI.ACE.LOG.EXE;

public sealed class LogEventArgs : EventArgs
{
	private SLog msg;

	public SLog Message => msg;

	public LogEventArgs(SLog message)
	{
		msg = message;
	}
}
