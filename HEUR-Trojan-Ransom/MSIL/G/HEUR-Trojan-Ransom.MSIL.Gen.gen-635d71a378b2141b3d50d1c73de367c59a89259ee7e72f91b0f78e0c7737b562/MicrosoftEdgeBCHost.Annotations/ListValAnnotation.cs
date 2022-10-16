using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ListValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		GetInterfaceReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInterfaceReg()
	{
	}
}
