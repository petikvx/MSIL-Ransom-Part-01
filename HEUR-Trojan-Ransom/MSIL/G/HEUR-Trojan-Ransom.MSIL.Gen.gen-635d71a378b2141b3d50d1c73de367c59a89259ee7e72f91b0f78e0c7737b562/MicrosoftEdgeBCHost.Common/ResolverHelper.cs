using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ResolverHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverHelper()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralPool()
	{
	}
}
