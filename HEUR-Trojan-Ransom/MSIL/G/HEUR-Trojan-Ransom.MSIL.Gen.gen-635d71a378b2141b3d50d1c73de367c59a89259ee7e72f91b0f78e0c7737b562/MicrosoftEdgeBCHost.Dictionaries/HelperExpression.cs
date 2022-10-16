using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class HelperExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperExpression()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralSetter()
	{
	}
}
