using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TaskContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskContext()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceWrapper()
	{
	}
}
