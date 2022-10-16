using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ObjectClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectClass()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceSerializer()
	{
	}
}
