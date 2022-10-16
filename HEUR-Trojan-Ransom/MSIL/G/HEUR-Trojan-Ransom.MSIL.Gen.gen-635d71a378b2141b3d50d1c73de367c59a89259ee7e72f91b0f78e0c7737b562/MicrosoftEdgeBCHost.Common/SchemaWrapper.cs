using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SchemaWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		TestService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestService()
	{
	}
}
