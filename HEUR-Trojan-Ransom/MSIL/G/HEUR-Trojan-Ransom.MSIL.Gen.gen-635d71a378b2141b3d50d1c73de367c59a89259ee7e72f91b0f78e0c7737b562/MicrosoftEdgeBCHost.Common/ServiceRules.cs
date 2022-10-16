using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ServiceRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceRules()
	{
		WriterPropertyProducer.ResolveStub();
		ManageOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageOrder()
	{
	}
}
