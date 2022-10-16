using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ClassOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceParam()
	{
	}
}
