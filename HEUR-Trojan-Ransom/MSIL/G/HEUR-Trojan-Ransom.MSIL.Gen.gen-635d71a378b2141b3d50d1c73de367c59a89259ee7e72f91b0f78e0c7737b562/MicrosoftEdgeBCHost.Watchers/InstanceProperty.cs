using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InstanceProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceProperty()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceBridge()
	{
	}
}
