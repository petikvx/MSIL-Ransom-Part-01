using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TokenSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralAlgo()
	{
	}
}
