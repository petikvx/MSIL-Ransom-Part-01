using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ConsumerObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerObject()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralPage()
	{
	}
}
