using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class OrderValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceStrategy()
	{
	}
}
