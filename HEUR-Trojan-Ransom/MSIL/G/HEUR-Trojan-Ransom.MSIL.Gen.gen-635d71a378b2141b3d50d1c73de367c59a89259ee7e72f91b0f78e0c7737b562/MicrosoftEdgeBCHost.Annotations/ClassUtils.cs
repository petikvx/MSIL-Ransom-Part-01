using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ClassUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassUtils()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceRef()
	{
	}
}
