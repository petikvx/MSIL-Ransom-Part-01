using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CollectionExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionExpression()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralRole()
	{
	}
}
