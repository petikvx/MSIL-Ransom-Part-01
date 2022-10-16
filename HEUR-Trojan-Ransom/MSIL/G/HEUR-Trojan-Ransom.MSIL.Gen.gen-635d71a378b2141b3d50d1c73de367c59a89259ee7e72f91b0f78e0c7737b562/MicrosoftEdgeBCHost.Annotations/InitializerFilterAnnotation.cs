using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InitializerFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CancelInterfaceRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelInterfaceRecord()
	{
	}
}
