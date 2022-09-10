using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class ServiceBusyException : InfoCardBaseException
{
	private const int HRESULT = -1073413875;

	public ServiceBusyException()
		: base(-1073413875)
	{
	}

	public ServiceBusyException(string message)
		: base(-1073413875, message)
	{
	}

	public ServiceBusyException(string message, Exception inner)
		: base(-1073413875, message, inner)
	{
	}

	protected ServiceBusyException(SerializationInfo si, StreamingContext sc)
		: base(-1073413875, si, sc)
	{
	}
}
