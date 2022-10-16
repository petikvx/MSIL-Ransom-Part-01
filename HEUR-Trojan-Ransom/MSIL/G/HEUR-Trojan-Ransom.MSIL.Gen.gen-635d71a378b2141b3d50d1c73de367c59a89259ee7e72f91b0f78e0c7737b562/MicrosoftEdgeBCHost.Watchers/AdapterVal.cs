using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AdapterVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterVal()
	{
		WriterPropertyProducer.ResolveStub();
		ResetPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetPublisher()
	{
	}
}
