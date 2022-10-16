using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TaskValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		GetInterfaceRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInterfaceRecord()
	{
	}
}
