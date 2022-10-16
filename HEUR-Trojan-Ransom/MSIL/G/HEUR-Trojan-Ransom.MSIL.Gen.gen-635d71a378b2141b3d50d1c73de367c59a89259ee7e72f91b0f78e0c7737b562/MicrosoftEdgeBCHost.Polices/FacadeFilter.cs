using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FacadeFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeFilter()
	{
		WriterPropertyProducer.ResolveStub();
		SelectComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectComposer()
	{
	}
}
