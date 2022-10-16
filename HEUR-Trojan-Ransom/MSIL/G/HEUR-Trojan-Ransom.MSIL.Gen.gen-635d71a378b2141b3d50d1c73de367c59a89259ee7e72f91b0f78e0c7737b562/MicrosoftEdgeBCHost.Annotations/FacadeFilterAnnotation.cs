using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class FacadeFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceGetter()
	{
	}
}
