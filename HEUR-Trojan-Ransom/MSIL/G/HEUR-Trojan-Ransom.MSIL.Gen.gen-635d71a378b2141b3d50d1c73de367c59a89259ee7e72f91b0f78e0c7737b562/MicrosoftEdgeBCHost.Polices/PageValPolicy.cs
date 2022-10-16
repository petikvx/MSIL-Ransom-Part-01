using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PageValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceProccesor()
	{
	}
}
