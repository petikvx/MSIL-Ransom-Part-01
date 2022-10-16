using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProcessFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceListener()
	{
	}
}
