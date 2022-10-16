using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TemplateClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateClass()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceInterceptor()
	{
	}
}
