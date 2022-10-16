using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PolicyWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyWorker()
	{
		WriterPropertyProducer.ResolveStub();
		PopProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopProcess()
	{
	}
}
