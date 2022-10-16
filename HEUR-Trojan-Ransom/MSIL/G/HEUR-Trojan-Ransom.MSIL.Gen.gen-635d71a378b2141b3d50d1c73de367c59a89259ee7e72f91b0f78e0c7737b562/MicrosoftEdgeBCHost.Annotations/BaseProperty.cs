using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BaseProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseProperty()
	{
		WriterPropertyProducer.ResolveStub();
		CloneInterfaceBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneInterfaceBroadcaster()
	{
	}
}
