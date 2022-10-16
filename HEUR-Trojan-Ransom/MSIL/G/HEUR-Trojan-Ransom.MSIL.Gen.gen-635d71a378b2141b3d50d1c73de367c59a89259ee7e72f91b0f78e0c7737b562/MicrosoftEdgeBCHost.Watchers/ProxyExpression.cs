using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProxyExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyExpression()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralRole()
	{
	}
}
