using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PolicyFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatParams()
	{
	}
}
