using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CallbackValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackValDic()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralReader()
	{
	}
}
