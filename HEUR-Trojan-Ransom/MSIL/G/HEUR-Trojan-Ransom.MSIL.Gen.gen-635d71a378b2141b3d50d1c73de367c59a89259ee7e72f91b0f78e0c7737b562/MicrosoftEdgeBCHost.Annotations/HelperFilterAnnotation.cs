using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class HelperFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceGetter()
	{
	}
}
