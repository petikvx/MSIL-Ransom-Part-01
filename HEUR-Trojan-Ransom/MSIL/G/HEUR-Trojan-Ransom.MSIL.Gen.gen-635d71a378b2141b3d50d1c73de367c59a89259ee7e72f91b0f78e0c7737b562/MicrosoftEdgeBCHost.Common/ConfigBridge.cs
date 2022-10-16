using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConfigBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigBridge()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareTests()
	{
	}
}
