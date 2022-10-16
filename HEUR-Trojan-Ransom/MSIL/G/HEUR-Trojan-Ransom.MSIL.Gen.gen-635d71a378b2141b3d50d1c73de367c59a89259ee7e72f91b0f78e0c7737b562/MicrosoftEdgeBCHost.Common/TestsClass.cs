using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TestsClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsClass()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceInterceptor()
	{
	}
}
