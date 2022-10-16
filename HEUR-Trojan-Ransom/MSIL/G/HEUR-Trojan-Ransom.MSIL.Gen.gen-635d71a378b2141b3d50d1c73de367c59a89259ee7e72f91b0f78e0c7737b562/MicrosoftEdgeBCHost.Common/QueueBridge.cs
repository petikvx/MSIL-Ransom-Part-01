using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class QueueBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueBridge()
	{
		WriterPropertyProducer.ResolveStub();
		NewMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewMapper()
	{
	}
}
