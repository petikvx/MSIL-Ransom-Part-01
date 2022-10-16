using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StructProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructProperty()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterfaceBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterfaceBroadcaster()
	{
	}
}
