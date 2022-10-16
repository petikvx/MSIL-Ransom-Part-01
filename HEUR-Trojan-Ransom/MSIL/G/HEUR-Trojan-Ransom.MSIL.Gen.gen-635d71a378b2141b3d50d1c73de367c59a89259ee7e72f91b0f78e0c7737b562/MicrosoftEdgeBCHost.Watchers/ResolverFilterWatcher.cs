using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ResolverFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InsertClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertClass()
	{
	}
}
