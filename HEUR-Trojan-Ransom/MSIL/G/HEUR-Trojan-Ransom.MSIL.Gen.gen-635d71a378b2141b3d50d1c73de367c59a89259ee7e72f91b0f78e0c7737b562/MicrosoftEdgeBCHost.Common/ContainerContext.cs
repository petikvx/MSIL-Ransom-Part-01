using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ContainerContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerContext()
	{
		WriterPropertyProducer.ResolveStub();
		CancelInterfaceRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelInterfaceRequest()
	{
	}
}
