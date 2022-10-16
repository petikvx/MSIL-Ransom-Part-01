using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StateValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateValDic()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralParameter()
	{
	}
}
