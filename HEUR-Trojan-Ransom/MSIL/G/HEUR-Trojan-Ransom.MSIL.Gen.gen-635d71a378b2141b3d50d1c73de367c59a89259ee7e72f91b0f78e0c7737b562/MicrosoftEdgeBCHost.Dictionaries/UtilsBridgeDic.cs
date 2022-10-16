using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class UtilsBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		DisableToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableToken()
	{
	}
}
