using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PoolReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolReponse()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralIdentifier()
	{
	}
}
