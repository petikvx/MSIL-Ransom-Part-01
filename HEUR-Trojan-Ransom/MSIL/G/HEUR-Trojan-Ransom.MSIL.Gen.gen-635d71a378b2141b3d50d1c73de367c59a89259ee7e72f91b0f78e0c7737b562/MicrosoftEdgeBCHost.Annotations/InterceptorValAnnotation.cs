using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InterceptorValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceHelper()
	{
	}
}
