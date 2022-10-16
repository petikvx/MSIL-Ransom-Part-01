using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProducerVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerVal()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutSpecification()
	{
	}
}
