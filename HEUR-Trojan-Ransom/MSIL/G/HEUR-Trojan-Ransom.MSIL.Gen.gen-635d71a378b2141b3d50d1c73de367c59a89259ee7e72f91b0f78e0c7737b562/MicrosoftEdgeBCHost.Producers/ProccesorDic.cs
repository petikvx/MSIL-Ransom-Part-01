using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProccesorDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorDic()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralCallback()
	{
	}
}
