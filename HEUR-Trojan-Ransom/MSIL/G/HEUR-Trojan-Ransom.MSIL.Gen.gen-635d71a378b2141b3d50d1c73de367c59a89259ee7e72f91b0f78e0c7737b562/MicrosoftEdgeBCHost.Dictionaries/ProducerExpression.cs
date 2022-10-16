using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProducerExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerExpression()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralMapper()
	{
	}
}
