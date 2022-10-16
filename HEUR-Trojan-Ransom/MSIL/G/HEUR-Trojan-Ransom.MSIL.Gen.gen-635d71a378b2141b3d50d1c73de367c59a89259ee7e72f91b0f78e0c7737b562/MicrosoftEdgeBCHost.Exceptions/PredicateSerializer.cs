using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PredicateSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralDic()
	{
	}
}
