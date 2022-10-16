using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RegistryAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralFacade()
	{
	}
}
