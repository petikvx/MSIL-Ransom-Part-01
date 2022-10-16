using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ErrorExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorExpression()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralRole()
	{
	}
}
