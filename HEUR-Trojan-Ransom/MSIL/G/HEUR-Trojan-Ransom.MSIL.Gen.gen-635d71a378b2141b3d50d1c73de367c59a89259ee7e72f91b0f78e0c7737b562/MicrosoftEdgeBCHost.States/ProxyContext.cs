using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProxyContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyContext()
	{
		WriterPropertyProducer.ResolveStub();
		GetInterfacePublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInterfacePublisher()
	{
	}
}
