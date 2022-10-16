using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FactoryOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceRule()
	{
	}
}
