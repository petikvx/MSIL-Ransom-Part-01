using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ResolverProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverProperty()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceTest()
	{
	}
}
