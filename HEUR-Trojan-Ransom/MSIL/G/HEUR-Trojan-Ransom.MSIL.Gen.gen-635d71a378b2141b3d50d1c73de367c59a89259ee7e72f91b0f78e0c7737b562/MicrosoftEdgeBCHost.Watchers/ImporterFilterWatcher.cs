using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ImporterFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotCallback()
	{
	}
}
