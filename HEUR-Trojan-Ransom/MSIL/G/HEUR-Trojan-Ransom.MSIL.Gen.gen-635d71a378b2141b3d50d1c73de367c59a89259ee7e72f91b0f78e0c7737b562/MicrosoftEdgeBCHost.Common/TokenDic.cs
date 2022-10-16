using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TokenDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenDic()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralRepository()
	{
	}
}
