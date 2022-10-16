using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CollectionWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		SetBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetBridge()
	{
	}
}
