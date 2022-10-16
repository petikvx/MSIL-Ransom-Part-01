using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RequestServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestServer()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralRules()
	{
	}
}
