using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProducerHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerHelper()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralSerializer()
	{
	}
}
