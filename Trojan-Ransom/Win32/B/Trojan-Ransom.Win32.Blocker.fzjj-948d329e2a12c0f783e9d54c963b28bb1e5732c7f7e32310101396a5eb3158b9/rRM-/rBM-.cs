using System;
using System.Runtime.CompilerServices;

namespace rRM_003D;

public class rBM_003D : Attribute
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public rBM_003D()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static rBM_003D()
	{
		_003CAgileDotNetRT_003E.Initialize();
		_003CAgileDotNetRT_003E.PostInitialize();
	}
}
