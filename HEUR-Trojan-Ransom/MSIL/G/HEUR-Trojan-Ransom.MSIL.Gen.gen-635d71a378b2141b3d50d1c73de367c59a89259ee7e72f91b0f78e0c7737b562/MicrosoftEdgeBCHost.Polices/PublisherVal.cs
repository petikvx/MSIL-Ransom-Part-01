using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PublisherVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherVal()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectUtils()
	{
	}
}
