using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StructFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectReader()
	{
	}
}
