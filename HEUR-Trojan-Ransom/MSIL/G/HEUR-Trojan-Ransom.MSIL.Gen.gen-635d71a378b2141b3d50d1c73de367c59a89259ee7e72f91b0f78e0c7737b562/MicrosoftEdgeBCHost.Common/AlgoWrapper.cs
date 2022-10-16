using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AlgoWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		CalcDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcDecorator()
	{
	}
}
