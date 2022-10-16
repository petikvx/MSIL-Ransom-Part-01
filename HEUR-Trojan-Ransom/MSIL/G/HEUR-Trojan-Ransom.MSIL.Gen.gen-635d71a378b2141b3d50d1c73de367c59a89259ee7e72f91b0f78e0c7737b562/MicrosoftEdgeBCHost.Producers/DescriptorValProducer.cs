using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DescriptorValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectClient()
	{
	}
}
