using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SingletonExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonExpression()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralMapper()
	{
	}
}
