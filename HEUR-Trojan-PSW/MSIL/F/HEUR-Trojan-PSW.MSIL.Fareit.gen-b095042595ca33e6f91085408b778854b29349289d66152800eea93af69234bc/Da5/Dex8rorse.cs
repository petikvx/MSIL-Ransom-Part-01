using System;
using Etcete1a;

namespace Da5;

public class Dex8rorse : Exception
{
	public readonly Organ0s0l Ov5rstability;

	public Dex8rorse(Organ0s0l errorCode, string message)
		: base(message)
	{
		Ov5rstability = errorCode;
	}

	public Dex8rorse(Organ0s0l errorCode, string message, Exception innerException)
		: base(message, innerException)
	{
		Ov5rstability = errorCode;
	}
}
