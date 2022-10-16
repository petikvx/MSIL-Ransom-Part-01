using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class QueueServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueServer()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralIterator()
	{
	}
}
