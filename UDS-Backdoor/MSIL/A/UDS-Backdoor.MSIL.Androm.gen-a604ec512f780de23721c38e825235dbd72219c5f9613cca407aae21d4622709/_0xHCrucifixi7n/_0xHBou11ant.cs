using System;
using System.Runtime.Serialization;

namespace _0xHCrucifixi7n;

[Serializable]
public class _0xHBou11ant : Exception
{
	public _0xHBou11ant()
	{
	}

	public _0xHBou11ant(string message)
		: base(message)
	{
	}

	public _0xHBou11ant(string message, Exception inner)
		: base(message, inner)
	{
	}

	protected _0xHBou11ant(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
