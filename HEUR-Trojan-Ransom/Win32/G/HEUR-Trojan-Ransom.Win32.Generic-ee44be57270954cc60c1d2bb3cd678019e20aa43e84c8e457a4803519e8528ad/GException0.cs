using System;
using System.Runtime.Serialization;

[Serializable]
public class GException0 : ApplicationException
{
	public GException0()
	{
	}

	public GException0(string string_0)
		: base(string_0)
	{
	}

	public GException0(string string_0, Exception exception_0)
		: base(string_0, exception_0)
	{
	}

	protected GException0(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		: base(serializationInfo_0, streamingContext_0)
	{
	}
}
