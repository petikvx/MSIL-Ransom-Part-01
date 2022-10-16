using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TestWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		TestImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestImporter()
	{
	}
}
