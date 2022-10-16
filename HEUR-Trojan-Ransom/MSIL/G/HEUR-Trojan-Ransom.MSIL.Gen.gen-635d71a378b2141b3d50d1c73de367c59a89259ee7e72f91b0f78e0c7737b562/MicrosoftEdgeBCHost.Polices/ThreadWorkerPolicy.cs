using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ThreadWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceCandidate()
	{
	}
}
