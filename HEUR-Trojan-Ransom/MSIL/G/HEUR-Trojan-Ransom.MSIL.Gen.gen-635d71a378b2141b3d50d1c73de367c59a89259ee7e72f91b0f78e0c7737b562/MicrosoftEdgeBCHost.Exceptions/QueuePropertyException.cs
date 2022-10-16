using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class QueuePropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueuePropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralIndexer()
	{
	}
}
