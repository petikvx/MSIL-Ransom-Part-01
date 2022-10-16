using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AttributeUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeUtils()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceResolver()
	{
	}
}
