using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ServerPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralAdvisor()
	{
	}
}
