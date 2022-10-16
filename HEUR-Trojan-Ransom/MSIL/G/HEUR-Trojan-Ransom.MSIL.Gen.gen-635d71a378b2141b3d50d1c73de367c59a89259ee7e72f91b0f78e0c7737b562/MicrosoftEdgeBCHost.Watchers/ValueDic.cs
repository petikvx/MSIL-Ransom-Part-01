using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ValueDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueDic()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralRepository()
	{
	}
}
