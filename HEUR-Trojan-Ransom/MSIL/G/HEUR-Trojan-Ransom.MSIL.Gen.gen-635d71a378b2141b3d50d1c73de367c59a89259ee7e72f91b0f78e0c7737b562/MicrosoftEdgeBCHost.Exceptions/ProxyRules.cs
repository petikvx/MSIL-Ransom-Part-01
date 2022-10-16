using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProxyRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyRules()
	{
		WriterPropertyProducer.ResolveStub();
		StopDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopDispatcher()
	{
	}
}
