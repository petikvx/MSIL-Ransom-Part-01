using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StateValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RevertSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertSpecification()
	{
	}
}
