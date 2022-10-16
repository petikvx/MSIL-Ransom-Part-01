using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TagValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralAccount()
	{
	}
}
