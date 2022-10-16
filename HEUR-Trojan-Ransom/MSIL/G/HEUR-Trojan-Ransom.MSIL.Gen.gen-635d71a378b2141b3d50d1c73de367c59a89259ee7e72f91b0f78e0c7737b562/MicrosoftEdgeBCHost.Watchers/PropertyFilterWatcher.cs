using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PropertyFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateModel()
	{
	}
}
