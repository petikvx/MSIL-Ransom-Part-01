using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PublisherDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherDic()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralAnnotation()
	{
	}
}
