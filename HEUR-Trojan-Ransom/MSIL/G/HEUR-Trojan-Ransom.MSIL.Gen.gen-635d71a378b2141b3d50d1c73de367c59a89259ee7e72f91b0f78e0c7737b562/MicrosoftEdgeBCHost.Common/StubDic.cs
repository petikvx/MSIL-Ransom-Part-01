using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StubDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubDic()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralProducer()
	{
	}
}
