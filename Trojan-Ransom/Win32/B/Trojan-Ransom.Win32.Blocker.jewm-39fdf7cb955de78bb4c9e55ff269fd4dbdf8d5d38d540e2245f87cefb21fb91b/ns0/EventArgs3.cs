using System;
using System.Collections.Generic;

namespace ns0;

internal class EventArgs3 : EventArgs
{
	internal Dictionary<string, string> dictionary_0;

	internal Exception exception_0;

	public Dictionary<string, string> Dictionary_0 => dictionary_0;

	public Exception Exception_0 => exception_0;

	internal EventArgs3(Dictionary<string, string> dictionary_1, Exception exception_1)
	{
		dictionary_0 = dictionary_1;
		exception_0 = exception_1;
	}
}
