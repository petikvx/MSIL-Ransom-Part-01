using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ListenerAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceIssuer()
	{
	}
}
