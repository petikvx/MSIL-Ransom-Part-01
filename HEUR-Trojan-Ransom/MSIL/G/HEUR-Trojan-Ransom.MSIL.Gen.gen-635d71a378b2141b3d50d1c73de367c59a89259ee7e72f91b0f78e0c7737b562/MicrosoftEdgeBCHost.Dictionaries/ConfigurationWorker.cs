using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ConfigurationWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationWorker()
	{
		WriterPropertyProducer.ResolveStub();
		GetHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetHelper()
	{
	}
}
