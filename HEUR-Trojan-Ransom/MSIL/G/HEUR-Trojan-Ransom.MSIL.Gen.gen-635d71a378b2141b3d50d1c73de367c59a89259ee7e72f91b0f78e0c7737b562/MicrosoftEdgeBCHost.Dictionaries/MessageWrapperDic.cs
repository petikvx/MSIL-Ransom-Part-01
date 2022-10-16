using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MessageWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		TestTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestTest()
	{
	}
}
