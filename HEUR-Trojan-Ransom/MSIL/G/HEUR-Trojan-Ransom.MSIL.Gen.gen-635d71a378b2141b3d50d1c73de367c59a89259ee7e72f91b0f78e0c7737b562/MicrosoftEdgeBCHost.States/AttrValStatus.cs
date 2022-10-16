using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AttrValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralDic()
	{
	}
}
