using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParamsFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralInstance()
	{
	}
}
