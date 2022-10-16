using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StrategyAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralFactory()
	{
	}
}
