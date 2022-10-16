using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ContainerFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SearchComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchComposer()
	{
	}
}
