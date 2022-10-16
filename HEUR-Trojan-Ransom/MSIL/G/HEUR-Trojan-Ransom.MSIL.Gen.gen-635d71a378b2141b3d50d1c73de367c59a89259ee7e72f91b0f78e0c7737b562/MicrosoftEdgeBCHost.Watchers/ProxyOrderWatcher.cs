using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProxyOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralException()
	{
	}
}
