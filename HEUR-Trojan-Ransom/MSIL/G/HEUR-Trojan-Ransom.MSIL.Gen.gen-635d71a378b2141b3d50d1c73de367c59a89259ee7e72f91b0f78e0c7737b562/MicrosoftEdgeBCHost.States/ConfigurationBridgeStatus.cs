using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConfigurationBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterpreter()
	{
	}
}
