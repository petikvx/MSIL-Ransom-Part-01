using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StrategyVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyVal()
	{
		WriterPropertyProducer.ResolveStub();
		ManageAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageAnnotation()
	{
	}
}
