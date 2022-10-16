using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class IdentifierOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceItem()
	{
	}
}
