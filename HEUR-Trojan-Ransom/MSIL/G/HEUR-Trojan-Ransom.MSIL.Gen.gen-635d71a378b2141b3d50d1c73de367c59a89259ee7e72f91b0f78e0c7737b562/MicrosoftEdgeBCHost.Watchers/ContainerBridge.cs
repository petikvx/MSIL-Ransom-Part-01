using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ContainerBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerBridge()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveRecord()
	{
	}
}
