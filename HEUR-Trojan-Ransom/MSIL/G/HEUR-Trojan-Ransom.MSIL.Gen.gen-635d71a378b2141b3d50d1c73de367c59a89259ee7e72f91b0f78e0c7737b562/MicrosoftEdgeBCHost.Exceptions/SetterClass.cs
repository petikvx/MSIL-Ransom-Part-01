using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SetterClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterClass()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInterfaceReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInterfaceReg()
	{
	}
}
