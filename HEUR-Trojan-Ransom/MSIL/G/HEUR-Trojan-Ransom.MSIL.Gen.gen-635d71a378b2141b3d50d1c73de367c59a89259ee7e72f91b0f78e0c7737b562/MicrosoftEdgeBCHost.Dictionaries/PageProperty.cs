using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PageProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageProperty()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceTest()
	{
	}
}
