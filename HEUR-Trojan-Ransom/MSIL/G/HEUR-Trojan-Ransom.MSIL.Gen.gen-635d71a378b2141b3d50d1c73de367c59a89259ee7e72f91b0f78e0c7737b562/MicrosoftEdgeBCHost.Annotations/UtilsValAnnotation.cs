using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class UtilsValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceFacade()
	{
	}
}
