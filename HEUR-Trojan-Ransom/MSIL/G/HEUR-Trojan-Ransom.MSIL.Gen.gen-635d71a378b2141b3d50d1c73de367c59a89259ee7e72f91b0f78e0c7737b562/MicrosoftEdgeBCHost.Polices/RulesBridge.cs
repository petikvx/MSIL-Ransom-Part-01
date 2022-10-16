using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RulesBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesBridge()
	{
		WriterPropertyProducer.ResolveStub();
		PrintParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintParser()
	{
	}
}
