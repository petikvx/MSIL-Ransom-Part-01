using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConfigRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigRules()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInitializer()
	{
	}
}
