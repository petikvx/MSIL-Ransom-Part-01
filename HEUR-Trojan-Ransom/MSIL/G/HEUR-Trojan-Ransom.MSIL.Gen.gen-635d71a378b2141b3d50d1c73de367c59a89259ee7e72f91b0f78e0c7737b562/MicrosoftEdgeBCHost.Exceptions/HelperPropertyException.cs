using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class HelperPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralResolver()
	{
	}
}
