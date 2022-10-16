using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FacadeExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeExpression()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralSetter()
	{
	}
}
