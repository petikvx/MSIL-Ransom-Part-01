using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CustomerProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerProperty()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceTest()
	{
	}
}
