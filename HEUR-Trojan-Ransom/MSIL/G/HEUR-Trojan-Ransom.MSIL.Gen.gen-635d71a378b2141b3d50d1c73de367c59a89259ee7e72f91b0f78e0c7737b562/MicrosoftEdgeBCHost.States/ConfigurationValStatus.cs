using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConfigurationValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralInitializer()
	{
	}
}
