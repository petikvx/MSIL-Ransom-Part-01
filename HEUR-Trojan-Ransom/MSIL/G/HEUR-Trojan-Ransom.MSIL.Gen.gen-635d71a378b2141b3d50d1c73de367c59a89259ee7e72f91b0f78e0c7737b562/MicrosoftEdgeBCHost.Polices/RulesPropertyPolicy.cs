using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RulesPropertyPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesPropertyPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralRegistry()
	{
	}
}
