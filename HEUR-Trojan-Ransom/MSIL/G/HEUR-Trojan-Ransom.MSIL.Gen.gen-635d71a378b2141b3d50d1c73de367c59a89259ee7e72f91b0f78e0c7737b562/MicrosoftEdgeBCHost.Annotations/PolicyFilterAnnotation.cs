using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PolicyFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InitInterfaceObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInterfaceObject()
	{
	}
}
