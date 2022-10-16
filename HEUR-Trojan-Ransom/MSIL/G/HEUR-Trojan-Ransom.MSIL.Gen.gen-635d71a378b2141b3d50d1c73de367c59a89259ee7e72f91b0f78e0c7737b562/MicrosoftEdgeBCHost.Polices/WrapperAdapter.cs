using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WrapperAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareProc()
	{
	}
}
