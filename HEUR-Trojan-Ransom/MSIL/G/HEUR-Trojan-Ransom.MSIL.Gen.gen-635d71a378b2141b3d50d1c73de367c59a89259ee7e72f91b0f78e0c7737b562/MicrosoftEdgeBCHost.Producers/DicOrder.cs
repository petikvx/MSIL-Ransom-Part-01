using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DicOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicOrder()
	{
		WriterPropertyProducer.ResolveStub();
		PrintPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintPool()
	{
	}
}
