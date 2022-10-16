using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DicFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicFacade()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralClass()
	{
	}
}
