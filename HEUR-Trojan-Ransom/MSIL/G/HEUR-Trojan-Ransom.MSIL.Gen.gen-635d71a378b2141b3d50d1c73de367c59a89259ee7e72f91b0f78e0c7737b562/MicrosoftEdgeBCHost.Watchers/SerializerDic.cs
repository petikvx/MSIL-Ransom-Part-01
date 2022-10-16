using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SerializerDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerDic()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralRequest()
	{
	}
}
