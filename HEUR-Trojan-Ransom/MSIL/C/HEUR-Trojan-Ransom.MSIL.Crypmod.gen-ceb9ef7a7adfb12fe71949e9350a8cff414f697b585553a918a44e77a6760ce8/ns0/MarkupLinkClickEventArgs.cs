using System;

namespace ns0;

public class MarkupLinkClickEventArgs : EventArgs
{
	public readonly string string_0 = "";

	public readonly string string_1 = "";

	public MarkupLinkClickEventArgs(string string_2, string string_3)
	{
		string_0 = string_3;
		string_1 = string_2;
	}
}
