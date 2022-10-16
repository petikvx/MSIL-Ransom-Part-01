using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InstanceOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceConsumer()
	{
	}
}
