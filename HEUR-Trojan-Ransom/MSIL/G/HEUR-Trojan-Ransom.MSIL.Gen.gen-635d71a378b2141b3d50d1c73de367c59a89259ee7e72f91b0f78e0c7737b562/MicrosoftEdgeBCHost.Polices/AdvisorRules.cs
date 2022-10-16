using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AdvisorRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorRules()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectOrder()
	{
	}
}
