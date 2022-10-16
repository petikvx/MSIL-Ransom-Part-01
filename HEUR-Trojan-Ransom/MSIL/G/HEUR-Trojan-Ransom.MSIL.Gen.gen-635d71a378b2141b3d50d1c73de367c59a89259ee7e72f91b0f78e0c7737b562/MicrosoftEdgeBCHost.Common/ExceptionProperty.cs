using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExceptionProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionProperty()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfaceDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfaceDecorator()
	{
	}
}
