using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConfigAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralMapper()
	{
	}
}
