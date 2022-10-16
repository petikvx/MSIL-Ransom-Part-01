using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IteratorDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorDic()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralDatabase()
	{
	}
}
