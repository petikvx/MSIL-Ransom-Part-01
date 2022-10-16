using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ClassValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassValDic()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralTemplate()
	{
	}
}
