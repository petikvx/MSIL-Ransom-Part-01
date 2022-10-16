using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AttributeClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeClass()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceRule()
	{
	}
}
