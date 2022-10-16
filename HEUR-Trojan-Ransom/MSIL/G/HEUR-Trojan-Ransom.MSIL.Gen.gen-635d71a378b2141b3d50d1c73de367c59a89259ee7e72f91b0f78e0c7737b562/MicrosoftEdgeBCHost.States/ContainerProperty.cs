using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ContainerProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerProperty()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceTest()
	{
	}
}
