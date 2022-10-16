using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TagDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagDic()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralStub()
	{
	}
}
