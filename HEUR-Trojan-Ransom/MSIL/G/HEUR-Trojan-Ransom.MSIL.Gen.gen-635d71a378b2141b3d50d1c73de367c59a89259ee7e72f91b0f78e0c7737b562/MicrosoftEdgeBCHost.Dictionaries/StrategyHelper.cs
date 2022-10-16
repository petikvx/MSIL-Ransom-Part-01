using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StrategyHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyHelper()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralPool()
	{
	}
}
