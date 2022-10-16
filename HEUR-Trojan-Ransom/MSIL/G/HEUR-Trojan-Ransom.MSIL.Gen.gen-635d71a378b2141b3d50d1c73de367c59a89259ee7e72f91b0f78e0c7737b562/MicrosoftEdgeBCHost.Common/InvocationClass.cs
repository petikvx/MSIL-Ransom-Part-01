using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InvocationClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationClass()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfacePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfacePolicy()
	{
	}
}
