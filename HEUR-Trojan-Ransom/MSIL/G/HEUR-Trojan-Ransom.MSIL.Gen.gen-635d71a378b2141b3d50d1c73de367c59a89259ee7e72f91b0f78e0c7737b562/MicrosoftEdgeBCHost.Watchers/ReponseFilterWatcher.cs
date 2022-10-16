using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ReponseFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterParams()
	{
	}
}
