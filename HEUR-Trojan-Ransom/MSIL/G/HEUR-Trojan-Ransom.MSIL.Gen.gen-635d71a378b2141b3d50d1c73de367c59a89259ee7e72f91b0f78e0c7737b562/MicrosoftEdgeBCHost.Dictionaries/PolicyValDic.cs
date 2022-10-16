using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PolicyValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyValDic()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralParameter()
	{
	}
}
