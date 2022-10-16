using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InstanceRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceRules()
	{
		WriterPropertyProducer.ResolveStub();
		StopProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopProperty()
	{
	}
}
