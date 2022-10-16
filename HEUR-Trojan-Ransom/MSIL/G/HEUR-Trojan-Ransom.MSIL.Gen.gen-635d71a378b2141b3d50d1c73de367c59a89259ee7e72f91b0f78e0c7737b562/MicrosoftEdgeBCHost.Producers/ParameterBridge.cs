using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParameterBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterBridge()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutIndexer()
	{
	}
}
