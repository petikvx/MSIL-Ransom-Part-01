using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AlgoAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralResolver()
	{
	}
}
