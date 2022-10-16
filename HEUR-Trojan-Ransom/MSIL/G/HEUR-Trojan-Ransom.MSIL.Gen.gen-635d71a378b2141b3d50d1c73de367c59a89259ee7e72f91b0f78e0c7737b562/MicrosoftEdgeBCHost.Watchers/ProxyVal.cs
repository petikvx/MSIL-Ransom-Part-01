using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProxyVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyVal()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterpreter()
	{
	}
}
