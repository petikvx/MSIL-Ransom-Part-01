using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TestReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestReponse()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralMethod()
	{
	}
}
