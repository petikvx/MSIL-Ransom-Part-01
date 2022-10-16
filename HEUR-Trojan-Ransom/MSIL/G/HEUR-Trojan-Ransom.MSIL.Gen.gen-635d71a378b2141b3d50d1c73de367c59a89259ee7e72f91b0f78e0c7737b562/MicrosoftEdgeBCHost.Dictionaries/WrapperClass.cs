using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WrapperClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperClass()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceList()
	{
	}
}
