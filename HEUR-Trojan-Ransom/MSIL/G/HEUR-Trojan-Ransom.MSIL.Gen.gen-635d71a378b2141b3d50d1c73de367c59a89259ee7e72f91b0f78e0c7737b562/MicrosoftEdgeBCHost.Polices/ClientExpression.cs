using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ClientExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralCollection()
	{
	}
}
