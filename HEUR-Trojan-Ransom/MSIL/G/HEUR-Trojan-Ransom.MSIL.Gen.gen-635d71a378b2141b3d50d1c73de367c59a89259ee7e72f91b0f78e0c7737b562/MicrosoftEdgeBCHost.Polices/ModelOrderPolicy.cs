using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ModelOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralDic()
	{
	}
}
