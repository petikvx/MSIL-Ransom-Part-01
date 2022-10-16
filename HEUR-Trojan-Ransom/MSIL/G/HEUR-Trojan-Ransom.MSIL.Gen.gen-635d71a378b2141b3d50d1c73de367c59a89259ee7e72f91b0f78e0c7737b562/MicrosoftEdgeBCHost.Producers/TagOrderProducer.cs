using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TagOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceFilter()
	{
	}
}
