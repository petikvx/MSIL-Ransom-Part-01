using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InstanceFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceFacade()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralItem()
	{
	}
}
