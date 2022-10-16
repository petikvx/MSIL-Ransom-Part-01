using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WrapperFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperFacade()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralReg()
	{
	}
}
