using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TagClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagClass()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceStruct()
	{
	}
}
