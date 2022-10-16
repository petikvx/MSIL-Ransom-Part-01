using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TaskFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		OrderResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderResolver()
	{
	}
}
