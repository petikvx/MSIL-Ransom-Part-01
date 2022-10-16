using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CollectionOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceClass()
	{
	}
}
