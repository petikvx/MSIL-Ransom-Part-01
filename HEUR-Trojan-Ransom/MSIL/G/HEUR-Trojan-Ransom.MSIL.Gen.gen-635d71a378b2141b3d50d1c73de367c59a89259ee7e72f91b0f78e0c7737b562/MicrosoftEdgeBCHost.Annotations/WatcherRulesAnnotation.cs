using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WatcherRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ResetToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetToken()
	{
	}
}
