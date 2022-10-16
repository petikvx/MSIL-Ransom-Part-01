using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StateExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralTest()
	{
	}
}
