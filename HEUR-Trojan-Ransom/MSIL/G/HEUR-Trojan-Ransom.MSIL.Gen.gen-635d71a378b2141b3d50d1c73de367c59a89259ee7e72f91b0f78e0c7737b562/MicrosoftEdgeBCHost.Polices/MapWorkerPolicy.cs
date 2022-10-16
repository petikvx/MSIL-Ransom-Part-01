using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MapWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceProxy()
	{
	}
}
