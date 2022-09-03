using System;

namespace ns0;

internal class EventArgs2 : EventArgs
{
	private int int_0;

	public int Int32_0 => int_0;

	public EventArgs2(int sent)
	{
		int_0 = sent;
	}
}
