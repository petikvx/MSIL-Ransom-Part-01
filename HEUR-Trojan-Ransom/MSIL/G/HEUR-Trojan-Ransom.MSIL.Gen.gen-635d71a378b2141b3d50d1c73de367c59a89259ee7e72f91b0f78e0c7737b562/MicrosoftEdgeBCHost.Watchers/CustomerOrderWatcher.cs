using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CustomerOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralAnnotation()
	{
	}
}
