using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AccountObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountObject()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralComposer()
	{
	}
}
