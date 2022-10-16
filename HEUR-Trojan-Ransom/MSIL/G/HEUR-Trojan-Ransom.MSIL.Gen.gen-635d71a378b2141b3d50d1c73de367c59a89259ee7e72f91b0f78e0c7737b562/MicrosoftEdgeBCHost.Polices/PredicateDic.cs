using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PredicateDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateDic()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralField()
	{
	}
}
