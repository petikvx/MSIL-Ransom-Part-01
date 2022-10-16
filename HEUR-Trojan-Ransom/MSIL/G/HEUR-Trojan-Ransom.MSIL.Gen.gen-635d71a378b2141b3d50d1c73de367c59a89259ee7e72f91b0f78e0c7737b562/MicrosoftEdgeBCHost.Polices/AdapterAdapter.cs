using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AdapterAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		CancelInterfaceMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelInterfaceMethod()
	{
	}
}
