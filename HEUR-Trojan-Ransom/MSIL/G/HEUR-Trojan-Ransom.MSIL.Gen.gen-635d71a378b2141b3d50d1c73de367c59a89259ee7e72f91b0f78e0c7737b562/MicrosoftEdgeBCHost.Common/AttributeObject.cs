using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AttributeObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeObject()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralExpression()
	{
	}
}
