using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConfigurationAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralContext()
	{
	}
}
