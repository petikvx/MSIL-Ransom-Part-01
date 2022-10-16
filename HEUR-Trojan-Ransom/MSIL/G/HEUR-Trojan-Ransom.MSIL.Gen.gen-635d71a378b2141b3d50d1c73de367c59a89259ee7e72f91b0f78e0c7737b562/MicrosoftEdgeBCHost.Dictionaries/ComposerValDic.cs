using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ComposerValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerValDic()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralSystem()
	{
	}
}
