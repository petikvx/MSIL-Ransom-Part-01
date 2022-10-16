using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ConfigurationSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		GetLiteralImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetLiteralImporter()
	{
	}
}
