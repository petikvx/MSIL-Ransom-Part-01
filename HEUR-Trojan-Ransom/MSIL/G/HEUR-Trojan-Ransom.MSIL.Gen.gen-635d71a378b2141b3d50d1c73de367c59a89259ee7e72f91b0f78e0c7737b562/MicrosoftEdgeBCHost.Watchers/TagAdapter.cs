using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TagAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceIdentifier()
	{
	}
}
