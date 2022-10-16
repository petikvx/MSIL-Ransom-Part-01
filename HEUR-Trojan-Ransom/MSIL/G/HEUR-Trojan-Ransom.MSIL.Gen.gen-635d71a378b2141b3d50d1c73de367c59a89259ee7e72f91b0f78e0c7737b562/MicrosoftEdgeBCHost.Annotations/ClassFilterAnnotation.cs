using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ClassFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceError()
	{
	}
}
