using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TaskPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceCallback()
	{
	}
}
