using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WrapperServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperServer()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralExpression()
	{
	}
}
