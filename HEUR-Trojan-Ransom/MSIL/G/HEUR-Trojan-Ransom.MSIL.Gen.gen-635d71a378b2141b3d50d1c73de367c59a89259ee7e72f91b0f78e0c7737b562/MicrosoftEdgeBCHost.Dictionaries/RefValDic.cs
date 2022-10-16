using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RefValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralPolicy()
	{
	}
}
