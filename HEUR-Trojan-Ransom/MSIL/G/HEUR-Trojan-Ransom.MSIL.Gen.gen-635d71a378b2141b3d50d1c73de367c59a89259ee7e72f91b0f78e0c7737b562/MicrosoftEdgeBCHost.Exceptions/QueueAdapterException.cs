using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class QueueAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterfaceUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterfaceUtils()
	{
	}
}
