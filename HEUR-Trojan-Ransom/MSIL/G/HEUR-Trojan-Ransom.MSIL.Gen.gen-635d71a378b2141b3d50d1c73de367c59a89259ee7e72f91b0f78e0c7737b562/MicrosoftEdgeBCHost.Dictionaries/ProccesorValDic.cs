using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProccesorValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorValDic()
	{
		WriterPropertyProducer.ResolveStub();
		CheckLiteralThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckLiteralThread()
	{
	}
}
