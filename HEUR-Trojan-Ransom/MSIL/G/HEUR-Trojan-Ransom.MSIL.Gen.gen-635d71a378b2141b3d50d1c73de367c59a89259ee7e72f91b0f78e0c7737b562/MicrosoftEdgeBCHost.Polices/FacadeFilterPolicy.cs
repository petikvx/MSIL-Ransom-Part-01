using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FacadeFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		OrderDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderDecorator()
	{
	}
}
