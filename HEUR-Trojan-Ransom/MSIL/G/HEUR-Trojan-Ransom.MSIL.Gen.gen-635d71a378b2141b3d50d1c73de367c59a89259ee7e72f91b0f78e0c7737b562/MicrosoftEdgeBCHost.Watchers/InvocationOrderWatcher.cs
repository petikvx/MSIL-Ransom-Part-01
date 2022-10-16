using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InvocationOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralStrategy()
	{
	}
}
