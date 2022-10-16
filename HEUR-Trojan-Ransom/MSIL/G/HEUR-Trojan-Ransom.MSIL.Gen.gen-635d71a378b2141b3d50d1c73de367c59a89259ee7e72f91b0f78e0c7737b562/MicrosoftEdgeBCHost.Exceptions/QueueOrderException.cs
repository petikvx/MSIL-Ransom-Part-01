using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class QueueOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceServer()
	{
	}
}
