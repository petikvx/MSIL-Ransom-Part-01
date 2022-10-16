using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RegFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceConfiguration()
	{
	}
}
