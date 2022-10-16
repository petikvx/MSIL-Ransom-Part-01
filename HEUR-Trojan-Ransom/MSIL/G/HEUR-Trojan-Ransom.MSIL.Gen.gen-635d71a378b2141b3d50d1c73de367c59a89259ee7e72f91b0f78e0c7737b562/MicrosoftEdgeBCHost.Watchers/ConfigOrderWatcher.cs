using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ConfigOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralParams()
	{
	}
}
