using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ContextValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextValDic()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralParameter()
	{
	}
}
