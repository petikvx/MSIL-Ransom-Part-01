using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InterpreterRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeDefinition()
	{
	}
}
