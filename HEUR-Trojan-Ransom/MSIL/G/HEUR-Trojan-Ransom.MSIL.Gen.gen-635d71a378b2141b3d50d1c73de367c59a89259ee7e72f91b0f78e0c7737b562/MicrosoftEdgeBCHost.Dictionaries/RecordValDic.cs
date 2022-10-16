using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RecordValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordValDic()
	{
		WriterPropertyProducer.ResolveStub();
		SetLiteralStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetLiteralStrategy()
	{
	}
}
