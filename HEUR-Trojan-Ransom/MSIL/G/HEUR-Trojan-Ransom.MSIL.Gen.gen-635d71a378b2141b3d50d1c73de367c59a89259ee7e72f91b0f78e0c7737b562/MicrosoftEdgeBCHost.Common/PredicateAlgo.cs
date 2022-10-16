using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PredicateAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralParam()
	{
	}
}
