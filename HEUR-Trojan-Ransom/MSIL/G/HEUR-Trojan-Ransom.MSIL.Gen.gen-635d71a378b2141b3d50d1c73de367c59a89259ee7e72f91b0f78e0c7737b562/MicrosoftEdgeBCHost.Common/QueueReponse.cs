using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class QueueReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueReponse()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceMerchant()
	{
	}
}
