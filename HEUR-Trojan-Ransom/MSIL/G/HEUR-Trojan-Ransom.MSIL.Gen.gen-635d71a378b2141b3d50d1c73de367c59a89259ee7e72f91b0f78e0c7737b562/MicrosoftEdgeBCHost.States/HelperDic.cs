using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class HelperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperDic()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralSpecification()
	{
	}
}
