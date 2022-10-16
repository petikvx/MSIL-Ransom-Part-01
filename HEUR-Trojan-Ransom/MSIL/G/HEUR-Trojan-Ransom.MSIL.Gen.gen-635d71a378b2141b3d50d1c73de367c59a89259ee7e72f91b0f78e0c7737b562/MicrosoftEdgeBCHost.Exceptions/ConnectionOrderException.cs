using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ConnectionOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		CancelInterfaceConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelInterfaceConnection()
	{
	}
}
