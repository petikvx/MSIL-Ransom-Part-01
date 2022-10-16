using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RuleWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleWorker()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateCreator()
	{
	}
}
