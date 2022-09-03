using System;
using System.Runtime.Serialization;

namespace _003CCrtImplementationDetails_003E;

[Serializable]
internal class OpenMPWithMultipleAppdomainsException : System.Exception
{
	protected OpenMPWithMultipleAppdomainsException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public OpenMPWithMultipleAppdomainsException()
	{
	}
}
