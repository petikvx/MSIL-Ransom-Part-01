using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RepositoryFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectSerializer()
	{
	}
}
