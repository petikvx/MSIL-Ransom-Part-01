using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns3;

namespace ns8;

internal sealed class Class55
{
	private readonly ulong[] ulong_0;

	private readonly Dictionary<string, ulong> dictionary_0;

	public Class55(ulong[] ulong_1, Dictionary<string, ulong> dictionary_1)
	{
		try
		{
			ulong_0 = ulong_1;
			dictionary_0 = dictionary_1;
		}
		catch (Exception exception_)
		{
			Class38.smethod_3(exception_, this, ulong_1, dictionary_1);
			throw;
		}
	}

	[SpecialName]
	public Dictionary<string, ulong> method_0()
	{
		try
		{
			return dictionary_0;
		}
		catch (Exception exception_)
		{
			Class38.smethod_1(exception_, this);
			throw;
		}
	}

	[SpecialName]
	public ulong[] method_1()
	{
		try
		{
			return ulong_0;
		}
		catch (Exception exception_)
		{
			Class38.smethod_1(exception_, this);
			throw;
		}
	}

	[SpecialName]
	public bool method_2()
	{
		try
		{
			if (ulong_0.Length == 0)
			{
				return dictionary_0.Count == 0;
			}
			return false;
		}
		catch (Exception exception_)
		{
			Class38.smethod_1(exception_, this);
			throw;
		}
	}
}
