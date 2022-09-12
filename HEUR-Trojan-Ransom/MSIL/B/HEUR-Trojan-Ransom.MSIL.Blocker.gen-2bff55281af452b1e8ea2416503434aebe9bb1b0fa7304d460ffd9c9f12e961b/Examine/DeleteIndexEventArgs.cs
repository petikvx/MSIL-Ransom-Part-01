using System;
using System.Collections.Generic;

namespace Examine;

public class DeleteIndexEventArgs : EventArgs
{
	public KeyValuePair<string, string> DeletedTerm { get; private set; }

	public DeleteIndexEventArgs(KeyValuePair<string, string> term)
	{
		DeletedTerm = term;
	}
}
