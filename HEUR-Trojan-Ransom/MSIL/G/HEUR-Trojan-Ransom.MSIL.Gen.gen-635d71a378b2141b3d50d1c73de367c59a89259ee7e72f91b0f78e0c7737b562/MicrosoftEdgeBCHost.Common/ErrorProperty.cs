using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ErrorProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorProperty()
	{
		WriterPropertyProducer.ResolveStub();
		InitInterfaceDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInterfaceDecorator()
	{
	}
}
