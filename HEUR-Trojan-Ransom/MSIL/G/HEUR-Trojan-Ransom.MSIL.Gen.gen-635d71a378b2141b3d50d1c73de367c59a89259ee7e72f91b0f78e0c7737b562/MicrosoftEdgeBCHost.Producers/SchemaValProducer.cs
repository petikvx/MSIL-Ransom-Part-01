using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SchemaValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutMock()
	{
	}
}
