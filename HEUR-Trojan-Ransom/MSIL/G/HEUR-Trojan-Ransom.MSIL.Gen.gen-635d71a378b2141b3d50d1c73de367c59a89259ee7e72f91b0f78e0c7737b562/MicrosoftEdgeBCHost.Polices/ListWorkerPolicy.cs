using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ListWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfacePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfacePredicate()
	{
	}
}
