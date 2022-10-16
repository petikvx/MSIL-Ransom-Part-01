using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ModelOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceSerializer()
	{
	}
}
