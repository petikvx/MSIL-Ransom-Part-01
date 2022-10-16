using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DefinitionAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralFacade()
	{
	}
}
