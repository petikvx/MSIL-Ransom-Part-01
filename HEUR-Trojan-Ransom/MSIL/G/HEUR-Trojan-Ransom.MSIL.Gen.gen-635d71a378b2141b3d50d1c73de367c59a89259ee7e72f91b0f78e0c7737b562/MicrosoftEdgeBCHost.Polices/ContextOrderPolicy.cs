using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ContextOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceSerializer()
	{
	}
}
