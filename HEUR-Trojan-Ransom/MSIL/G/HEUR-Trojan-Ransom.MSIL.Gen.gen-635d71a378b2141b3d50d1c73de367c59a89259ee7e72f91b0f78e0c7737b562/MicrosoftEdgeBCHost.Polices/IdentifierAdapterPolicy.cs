using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class IdentifierAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralComposer()
	{
	}
}
