using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ItemObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemObject()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralExpression()
	{
	}
}
