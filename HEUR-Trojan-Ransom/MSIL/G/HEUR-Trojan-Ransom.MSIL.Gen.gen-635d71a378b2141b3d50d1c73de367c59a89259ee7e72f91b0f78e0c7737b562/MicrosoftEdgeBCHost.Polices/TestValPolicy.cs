using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TestValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		TestWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestWriter()
	{
	}
}
