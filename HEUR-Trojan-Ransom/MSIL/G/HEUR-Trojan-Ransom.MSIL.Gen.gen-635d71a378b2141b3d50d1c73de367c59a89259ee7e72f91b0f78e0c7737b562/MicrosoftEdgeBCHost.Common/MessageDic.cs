using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MessageDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageDic()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralToken()
	{
	}
}
