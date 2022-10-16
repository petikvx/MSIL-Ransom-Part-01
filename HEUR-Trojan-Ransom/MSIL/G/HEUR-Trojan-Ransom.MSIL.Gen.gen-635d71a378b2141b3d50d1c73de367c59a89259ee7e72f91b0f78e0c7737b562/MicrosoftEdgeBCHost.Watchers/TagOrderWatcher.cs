using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TagOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralWrapper()
	{
	}
}
