using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TagVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagVal()
	{
		WriterPropertyProducer.ResolveStub();
		DisableSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableSpecification()
	{
	}
}
