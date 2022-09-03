using System;
using System.Runtime.Serialization;

namespace _003CCrtImplementationDetails_003E;

[Serializable]
internal class Exception : System.Exception
{
	protected Exception(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public Exception(string message, System.Exception innerException)
		: base(message, innerException)
	{
	}

	public Exception(string message)
		: base(message)
	{
	}
}
