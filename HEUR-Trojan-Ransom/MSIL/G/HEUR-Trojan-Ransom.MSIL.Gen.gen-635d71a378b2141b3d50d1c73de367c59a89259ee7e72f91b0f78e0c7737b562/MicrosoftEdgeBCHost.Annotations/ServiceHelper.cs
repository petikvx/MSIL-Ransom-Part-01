using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ServiceHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceHelper()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralFilter()
	{
	}
}
