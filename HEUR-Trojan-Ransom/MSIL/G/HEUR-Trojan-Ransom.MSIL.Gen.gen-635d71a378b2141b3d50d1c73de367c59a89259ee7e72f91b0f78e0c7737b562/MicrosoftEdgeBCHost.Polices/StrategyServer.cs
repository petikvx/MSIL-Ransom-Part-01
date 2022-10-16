using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StrategyServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyServer()
	{
		WriterPropertyProducer.ResolveStub();
		CheckLiteralUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckLiteralUtils()
	{
	}
}
