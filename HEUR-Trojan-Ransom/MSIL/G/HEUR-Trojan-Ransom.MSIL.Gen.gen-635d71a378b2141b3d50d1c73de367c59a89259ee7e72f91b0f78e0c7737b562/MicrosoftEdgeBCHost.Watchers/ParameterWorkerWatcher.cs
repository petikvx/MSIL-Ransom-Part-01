using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParameterWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralDecorator()
	{
	}
}
