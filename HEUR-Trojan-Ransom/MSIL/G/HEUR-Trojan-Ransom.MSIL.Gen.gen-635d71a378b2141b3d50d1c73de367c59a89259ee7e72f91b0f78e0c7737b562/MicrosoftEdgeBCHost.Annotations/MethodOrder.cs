using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MethodOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodOrder()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutConsumer()
	{
	}
}
