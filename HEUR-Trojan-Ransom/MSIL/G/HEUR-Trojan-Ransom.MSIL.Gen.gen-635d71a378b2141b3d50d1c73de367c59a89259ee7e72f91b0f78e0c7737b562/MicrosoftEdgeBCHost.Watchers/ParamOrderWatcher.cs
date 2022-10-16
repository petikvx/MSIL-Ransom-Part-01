using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParamOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralDispatcher()
	{
	}
}
