using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RuleAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralTag()
	{
	}
}
