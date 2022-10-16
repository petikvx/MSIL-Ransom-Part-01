using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ServiceProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceProperty()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceService()
	{
	}
}
