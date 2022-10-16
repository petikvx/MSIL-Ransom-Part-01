using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class BaseValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		VisitMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitMerchant()
	{
	}
}
