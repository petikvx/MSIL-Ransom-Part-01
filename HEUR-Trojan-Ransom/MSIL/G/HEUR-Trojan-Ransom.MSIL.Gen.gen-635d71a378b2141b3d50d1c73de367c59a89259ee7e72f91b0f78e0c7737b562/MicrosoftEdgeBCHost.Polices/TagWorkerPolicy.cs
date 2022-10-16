using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TagWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfacePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfacePredicate()
	{
	}
}
