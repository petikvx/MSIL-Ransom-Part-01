using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RegOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceAdvisor()
	{
	}
}
