using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ComposerWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfacePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfacePredicate()
	{
	}
}
