using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IssuerState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerState()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceInitializer()
	{
	}
}
