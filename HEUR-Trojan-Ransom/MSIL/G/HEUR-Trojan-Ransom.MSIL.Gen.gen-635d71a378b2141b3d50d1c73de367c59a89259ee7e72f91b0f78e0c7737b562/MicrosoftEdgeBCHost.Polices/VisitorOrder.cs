using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class VisitorOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorOrder()
	{
		WriterPropertyProducer.ResolveStub();
		AssetReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetReg()
	{
	}
}
