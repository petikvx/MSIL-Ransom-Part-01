using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ModelOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralWrapper()
	{
	}
}
