using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParameterValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterValDic()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralObserver()
	{
	}
}
