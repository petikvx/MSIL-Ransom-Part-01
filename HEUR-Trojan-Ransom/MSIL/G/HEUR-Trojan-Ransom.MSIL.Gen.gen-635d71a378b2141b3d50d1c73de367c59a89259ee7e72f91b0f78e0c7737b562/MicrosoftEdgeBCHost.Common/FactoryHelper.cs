using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class FactoryHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryHelper()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralHelper()
	{
	}
}
