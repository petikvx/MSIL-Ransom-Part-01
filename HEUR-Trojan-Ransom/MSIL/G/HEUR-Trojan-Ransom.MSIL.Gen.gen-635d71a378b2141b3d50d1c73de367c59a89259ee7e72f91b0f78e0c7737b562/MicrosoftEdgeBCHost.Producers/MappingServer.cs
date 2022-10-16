using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MappingServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingServer()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralUtils()
	{
	}
}
