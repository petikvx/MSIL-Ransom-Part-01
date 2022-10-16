using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class WorkerRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerRules()
	{
		WriterPropertyProducer.ResolveStub();
		RestartConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartConfiguration()
	{
	}
}
