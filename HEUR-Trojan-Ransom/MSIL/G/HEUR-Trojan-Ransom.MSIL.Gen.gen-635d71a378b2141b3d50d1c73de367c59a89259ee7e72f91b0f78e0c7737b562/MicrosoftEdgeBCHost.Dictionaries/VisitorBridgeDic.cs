using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class VisitorBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		DisableThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableThread()
	{
	}
}
