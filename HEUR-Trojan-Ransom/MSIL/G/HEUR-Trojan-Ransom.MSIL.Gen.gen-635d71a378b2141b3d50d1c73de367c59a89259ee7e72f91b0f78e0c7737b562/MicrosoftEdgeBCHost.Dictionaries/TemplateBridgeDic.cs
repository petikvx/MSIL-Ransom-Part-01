using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TemplateBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceBroadcaster()
	{
	}
}
