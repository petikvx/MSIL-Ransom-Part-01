using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConfigurationOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfaceTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfaceTokenizer()
	{
	}
}
