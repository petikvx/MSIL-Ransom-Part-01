using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DispatcherValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InitInterfaceInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInterfaceInvocation()
	{
	}
}
