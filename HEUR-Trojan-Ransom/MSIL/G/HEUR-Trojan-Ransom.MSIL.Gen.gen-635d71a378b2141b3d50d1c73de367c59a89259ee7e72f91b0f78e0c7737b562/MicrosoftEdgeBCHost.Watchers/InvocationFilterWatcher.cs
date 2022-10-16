using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InvocationFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeDatabase()
	{
	}
}
