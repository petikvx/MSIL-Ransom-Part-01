using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TaskState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskState()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceTag()
	{
	}
}
