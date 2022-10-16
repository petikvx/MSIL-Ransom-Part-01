using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProcReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcReponse()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralIdentifier()
	{
	}
}
