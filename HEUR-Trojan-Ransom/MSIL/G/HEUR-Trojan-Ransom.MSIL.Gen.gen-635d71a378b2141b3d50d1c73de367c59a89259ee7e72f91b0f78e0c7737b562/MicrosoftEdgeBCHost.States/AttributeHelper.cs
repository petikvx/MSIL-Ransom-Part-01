using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AttributeHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeHelper()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralReg()
	{
	}
}
