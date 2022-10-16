using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RegValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegValDic()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralReader()
	{
	}
}
