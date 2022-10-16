using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class FacadeValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceWrapper()
	{
	}
}
