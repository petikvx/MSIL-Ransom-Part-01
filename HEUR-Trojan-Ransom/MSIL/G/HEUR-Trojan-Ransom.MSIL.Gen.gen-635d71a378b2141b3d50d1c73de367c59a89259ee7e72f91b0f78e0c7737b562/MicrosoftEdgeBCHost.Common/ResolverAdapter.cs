using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ResolverAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceCode()
	{
	}
}
