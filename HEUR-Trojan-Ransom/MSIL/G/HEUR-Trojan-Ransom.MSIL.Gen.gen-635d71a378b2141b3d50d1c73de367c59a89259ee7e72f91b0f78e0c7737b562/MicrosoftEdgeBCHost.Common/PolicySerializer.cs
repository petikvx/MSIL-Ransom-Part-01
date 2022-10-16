using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PolicySerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicySerializer()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralCode()
	{
	}
}
