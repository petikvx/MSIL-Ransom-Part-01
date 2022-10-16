using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RegRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegRules()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyContext()
	{
	}
}
