using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AccountOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceAdvisor()
	{
	}
}
