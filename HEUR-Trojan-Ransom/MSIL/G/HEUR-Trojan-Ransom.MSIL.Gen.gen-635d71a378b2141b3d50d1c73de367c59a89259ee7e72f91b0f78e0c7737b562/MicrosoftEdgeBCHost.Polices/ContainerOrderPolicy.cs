using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ContainerOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralAdapter()
	{
	}
}
