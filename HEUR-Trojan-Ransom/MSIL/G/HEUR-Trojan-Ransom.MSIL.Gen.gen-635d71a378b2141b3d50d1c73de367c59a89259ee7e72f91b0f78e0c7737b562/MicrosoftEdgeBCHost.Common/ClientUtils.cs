using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ClientUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientUtils()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceQueue()
	{
	}
}
