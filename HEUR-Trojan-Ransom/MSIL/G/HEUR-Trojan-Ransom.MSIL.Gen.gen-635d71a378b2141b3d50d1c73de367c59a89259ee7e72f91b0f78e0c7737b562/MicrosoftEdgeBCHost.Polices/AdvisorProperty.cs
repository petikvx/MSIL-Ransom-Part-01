using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AdvisorProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorProperty()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceService()
	{
	}
}
