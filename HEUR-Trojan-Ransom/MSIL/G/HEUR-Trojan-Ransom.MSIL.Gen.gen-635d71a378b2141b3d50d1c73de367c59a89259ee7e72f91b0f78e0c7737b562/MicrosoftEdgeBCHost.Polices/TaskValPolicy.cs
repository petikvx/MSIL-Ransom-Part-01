using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TaskValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeRegistry()
	{
	}
}
