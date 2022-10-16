using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ValHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValHelper()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralField()
	{
	}
}
