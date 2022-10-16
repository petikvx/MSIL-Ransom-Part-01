using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IteratorVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorVal()
	{
		WriterPropertyProducer.ResolveStub();
		PostRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostRequest()
	{
	}
}
