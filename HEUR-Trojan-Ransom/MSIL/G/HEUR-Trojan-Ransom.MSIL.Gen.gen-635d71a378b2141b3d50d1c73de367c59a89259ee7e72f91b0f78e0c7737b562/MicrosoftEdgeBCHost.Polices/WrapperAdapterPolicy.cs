using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WrapperAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralMessage()
	{
	}
}
