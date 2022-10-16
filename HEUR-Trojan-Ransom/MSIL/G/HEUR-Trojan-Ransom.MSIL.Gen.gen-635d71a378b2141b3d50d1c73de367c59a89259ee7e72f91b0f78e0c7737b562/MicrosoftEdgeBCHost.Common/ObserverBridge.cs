using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ObserverBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverBridge()
	{
		WriterPropertyProducer.ResolveStub();
		EnableResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableResolver()
	{
	}
}
