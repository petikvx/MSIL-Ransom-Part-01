using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RegWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceClient()
	{
	}
}
