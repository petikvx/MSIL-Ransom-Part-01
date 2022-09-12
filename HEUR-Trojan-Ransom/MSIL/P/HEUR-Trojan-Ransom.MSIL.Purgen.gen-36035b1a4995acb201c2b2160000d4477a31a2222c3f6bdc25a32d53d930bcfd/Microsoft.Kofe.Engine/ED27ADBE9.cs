using System;

namespace Microsoft.Kofe.Engine;

internal class ED27ADBE9 : Exception
{
	public readonly int F4391992B;

	public ED27ADBE9(string message, int position)
		: base(message)
	{
		F4391992B = position;
	}

	public ED27ADBE9(string message, Exception inner, int position)
		: base(message, inner)
	{
		F4391992B = position;
	}
}
