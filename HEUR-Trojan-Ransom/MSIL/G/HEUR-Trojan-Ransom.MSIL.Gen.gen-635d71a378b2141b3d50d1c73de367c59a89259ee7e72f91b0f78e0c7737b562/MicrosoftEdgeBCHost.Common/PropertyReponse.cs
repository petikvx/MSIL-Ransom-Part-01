using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PropertyReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyReponse()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceBase()
	{
	}
}
