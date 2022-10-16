using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PolicyOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceSerializer()
	{
	}
}
