using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ReponseExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralSetter()
	{
	}
}
