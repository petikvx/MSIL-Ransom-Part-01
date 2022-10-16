using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CodeValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralTask()
	{
	}
}
