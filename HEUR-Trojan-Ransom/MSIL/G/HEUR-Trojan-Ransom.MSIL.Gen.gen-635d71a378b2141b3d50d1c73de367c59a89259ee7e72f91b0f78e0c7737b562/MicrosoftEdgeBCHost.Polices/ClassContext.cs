using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ClassContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassContext()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceRules()
	{
	}
}
