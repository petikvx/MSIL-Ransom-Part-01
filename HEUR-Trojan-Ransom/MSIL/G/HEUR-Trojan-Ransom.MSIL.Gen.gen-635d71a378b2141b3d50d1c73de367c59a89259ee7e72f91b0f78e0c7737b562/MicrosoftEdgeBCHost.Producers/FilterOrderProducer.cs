using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FilterOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceConfiguration()
	{
	}
}
