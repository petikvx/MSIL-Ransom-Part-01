using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProccesorFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralPrototype()
	{
	}
}
