using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DicBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicBridge()
	{
		WriterPropertyProducer.ResolveStub();
		QueryAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryAdapter()
	{
	}
}
