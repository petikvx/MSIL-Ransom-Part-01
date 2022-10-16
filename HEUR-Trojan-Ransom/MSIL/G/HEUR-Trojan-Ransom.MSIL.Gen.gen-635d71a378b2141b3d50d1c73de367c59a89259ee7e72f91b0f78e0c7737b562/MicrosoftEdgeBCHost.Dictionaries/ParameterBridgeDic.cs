using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParameterBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceAttribute()
	{
	}
}
