using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ParserRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		MoveThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveThread()
	{
	}
}
