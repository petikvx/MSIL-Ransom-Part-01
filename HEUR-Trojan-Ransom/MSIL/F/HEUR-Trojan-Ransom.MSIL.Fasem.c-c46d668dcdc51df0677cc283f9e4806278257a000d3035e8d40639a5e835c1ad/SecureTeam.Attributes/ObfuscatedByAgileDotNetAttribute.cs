using System;
using System.Runtime.CompilerServices;

namespace SecureTeam.Attributes;

public class ObfuscatedByAgileDotNetAttribute : Attribute
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ObfuscatedByAgileDotNetAttribute()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObfuscatedByAgileDotNetAttribute()
	{
		_003CAgileDotNetRT_003E.Initialize();
		_003CAgileDotNetRT_003E.PostInitialize();
	}
}
