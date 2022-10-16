using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ConnectionContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionContext()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfacePublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfacePublisher()
	{
	}
}
