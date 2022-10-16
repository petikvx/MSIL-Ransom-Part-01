using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AttributeFilterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CloneDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneDescriptor()
	{
	}
}
