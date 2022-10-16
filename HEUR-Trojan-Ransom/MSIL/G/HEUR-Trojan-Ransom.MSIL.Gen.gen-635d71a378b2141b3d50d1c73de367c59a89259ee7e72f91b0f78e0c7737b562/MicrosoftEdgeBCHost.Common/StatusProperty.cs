using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StatusProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusProperty()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceBridge()
	{
	}
}
