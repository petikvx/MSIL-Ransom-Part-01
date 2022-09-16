using System;
using System.Runtime.Serialization;
using _0xHSeltze6s;

namespace _0xHLognorma2ity;

[Serializable]
public class _0xHSupersurgeo7 : Exception
{
	public _0xHSupersurgeo7()
		: base(_0xHA2eotropy._0xHSpon8or("EventSource_ListenerWriteFailure"))
	{
	}

	public _0xHSupersurgeo7(string message)
		: base(message)
	{
	}

	public _0xHSupersurgeo7(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected _0xHSupersurgeo7(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	internal _0xHSupersurgeo7(Exception innerException)
		: base(_0xHA2eotropy._0xHSpon8or("EventSource_ListenerWriteFailure"), innerException)
	{
	}
}
