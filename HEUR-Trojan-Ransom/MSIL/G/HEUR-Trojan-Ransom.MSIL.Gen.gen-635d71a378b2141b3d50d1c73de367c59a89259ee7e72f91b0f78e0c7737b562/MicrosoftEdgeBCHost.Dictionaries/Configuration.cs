using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class Configuration
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Configuration()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveCode()
	{
	}
}
