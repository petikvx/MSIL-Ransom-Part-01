using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class QueueUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueUtils()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceExporter()
	{
	}
}
