using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConfigurationHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationHelper()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralFilter()
	{
	}
}
