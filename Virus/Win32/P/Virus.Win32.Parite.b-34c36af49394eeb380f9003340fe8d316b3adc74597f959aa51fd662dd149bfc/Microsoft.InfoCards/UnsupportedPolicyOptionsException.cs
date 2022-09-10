using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class UnsupportedPolicyOptionsException : InfoCardBaseException
{
	private const int HRESULT = -1073413866;

	public UnsupportedPolicyOptionsException()
		: base(-1073413866)
	{
	}

	public UnsupportedPolicyOptionsException(string message)
		: base(-1073413866, message)
	{
	}

	public UnsupportedPolicyOptionsException(string message, Exception inner)
		: base(-1073413866, message, inner)
	{
	}

	protected UnsupportedPolicyOptionsException(SerializationInfo si, StreamingContext sc)
		: base(-1073413866, si, sc)
	{
	}
}
