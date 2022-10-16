using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DicAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralModel()
	{
	}
}
