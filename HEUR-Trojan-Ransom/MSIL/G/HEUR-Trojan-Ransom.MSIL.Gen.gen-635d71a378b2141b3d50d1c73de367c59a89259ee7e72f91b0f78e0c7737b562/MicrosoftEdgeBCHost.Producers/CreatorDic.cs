using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CreatorDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorDic()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralSpecification()
	{
	}
}
