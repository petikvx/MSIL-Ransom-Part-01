using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class QueueOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfacePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfacePolicy()
	{
	}
}
