using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MappingFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceOrder()
	{
	}
}
