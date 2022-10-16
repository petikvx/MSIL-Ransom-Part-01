using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ObserverValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceManager()
	{
	}
}
