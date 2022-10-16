using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StructDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructDic()
	{
		WriterPropertyProducer.ResolveStub();
		CheckLiteralReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckLiteralReader()
	{
	}
}
