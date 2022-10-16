using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ContainerFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ListInterfaceParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInterfaceParam()
	{
	}
}
