using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParamProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamProperty()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceDecorator()
	{
	}
}
