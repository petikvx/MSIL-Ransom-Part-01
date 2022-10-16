using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CustomerFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfaceListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfaceListener()
	{
	}
}
