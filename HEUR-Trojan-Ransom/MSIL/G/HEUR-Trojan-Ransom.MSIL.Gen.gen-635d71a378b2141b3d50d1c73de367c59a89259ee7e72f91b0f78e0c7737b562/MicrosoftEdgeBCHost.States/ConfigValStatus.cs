using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConfigValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralGlobal()
	{
	}
}
