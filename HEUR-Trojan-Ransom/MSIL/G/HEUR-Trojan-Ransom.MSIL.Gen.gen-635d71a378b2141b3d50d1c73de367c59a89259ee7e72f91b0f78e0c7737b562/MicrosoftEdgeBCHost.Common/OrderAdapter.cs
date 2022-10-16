using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class OrderAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceMethod()
	{
	}
}
