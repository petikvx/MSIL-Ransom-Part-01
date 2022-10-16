using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProductWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectDescriptor()
	{
	}
}
