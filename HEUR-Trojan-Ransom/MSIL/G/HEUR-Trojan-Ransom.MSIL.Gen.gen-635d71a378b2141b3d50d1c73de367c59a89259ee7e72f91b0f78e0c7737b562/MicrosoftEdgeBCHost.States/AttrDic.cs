using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AttrDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrDic()
	{
		WriterPropertyProducer.ResolveStub();
		GetLiteralToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetLiteralToken()
	{
	}
}
