using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParameterClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterClass()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterfaceItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterfaceItem()
	{
	}
}
