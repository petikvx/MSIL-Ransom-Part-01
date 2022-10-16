using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ConsumerFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceStatus()
	{
	}
}
