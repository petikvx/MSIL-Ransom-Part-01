using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StrategyReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyReponse()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralError()
	{
	}
}
