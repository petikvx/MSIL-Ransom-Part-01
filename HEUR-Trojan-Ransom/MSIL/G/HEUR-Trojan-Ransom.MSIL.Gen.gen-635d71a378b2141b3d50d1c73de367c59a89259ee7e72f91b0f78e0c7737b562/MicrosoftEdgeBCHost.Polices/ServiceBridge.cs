using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ServiceBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceBridge()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteStatus()
	{
	}
}
