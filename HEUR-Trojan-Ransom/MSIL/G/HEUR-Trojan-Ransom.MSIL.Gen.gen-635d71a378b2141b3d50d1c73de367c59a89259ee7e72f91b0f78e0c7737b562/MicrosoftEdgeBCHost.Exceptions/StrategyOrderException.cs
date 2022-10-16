using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StrategyOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		PopInterfaceDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopInterfaceDefinition()
	{
	}
}
