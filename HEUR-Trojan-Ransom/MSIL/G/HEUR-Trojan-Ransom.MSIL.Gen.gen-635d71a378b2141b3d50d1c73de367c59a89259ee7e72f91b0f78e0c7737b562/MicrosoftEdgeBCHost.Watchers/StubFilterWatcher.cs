using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StubFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		LoginProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginProperty()
	{
	}
}
