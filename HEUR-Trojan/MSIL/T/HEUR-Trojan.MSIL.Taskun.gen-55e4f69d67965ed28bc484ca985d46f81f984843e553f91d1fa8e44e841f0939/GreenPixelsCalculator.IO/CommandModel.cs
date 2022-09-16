using System;
using System.Collections;
using System.Collections.Generic;

namespace GreenPixelsCalculator.IO;

public readonly struct CommandModel : IEnumerable<ParamType>, IReadOnlyList<ParamType>, IEquatable<CommandModel>, IEnumerable
{
	public readonly ushort Type;

	private readonly ParamType[] Params;

	public readonly Type enumType;

	public int Count => Params.Length;

	public ParamType this[int i] => Params[i];

	public CommandModel(in ushort type, params ParamType[] @params)
	{
		enumType = null;
		Type = type;
		Params = @params;
	}

	public CommandModel(Enum type, params ParamType[] @params)
	{
		enumType = type.GetType();
		Type = Convert.ToUInt16(type);
		Params = @params;
	}

	public int GetNextNonSpecialParam(int paramIndex)
	{
		bool flag = false;
		bool flag2 = false;
		int num = paramIndex;
		while (true)
		{
			if (num < Params.Length)
			{
				if ((flag = !Params[num].HasFlag(ParamType._SPECIAL)) && flag2)
				{
					break;
				}
				flag2 = flag;
				num++;
				continue;
			}
			return Params.Length;
		}
		return num;
	}

	public IEnumerator<ParamType> GetEnumerator()
	{
		return ((IEnumerable<ParamType>)Params).GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<ParamType>)Params).GetEnumerator();
	}

	public override string ToString()
	{
		object obj;
		if (!(enumType != null))
		{
			obj = Type;
			if (obj == null)
			{
				goto IL_0037;
			}
		}
		else
		{
			obj = Enum.GetName(enumType, Type);
			if (obj == null)
			{
				goto IL_0037;
			}
		}
		object obj2 = obj.ToString();
		goto IL_0040;
		IL_0037:
		obj2 = null;
		goto IL_0040;
		IL_0040:
		return (string?)obj2 + ": " + string.Join(",", Params);
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		return obj is CommandModel && Equals((CommandModel)obj);
	}

	public bool Equals(CommandModel other)
	{
		return Type == other.Type && Count == other.Count && EqualityComparer<ParamType[]>.Default.Equals(Params, other.Params);
	}

	public static bool operator ==(CommandModel a, CommandModel b)
	{
		return a.Type == b.Type;
	}

	public static bool operator !=(CommandModel a, CommandModel b)
	{
		return a.Type == b.Type;
	}

	public static bool operator ==(CommandModel a, ushort b)
	{
		return a.Type == b;
	}

	public static bool operator !=(CommandModel a, ushort b)
	{
		return a.Type == b;
	}

	public static bool operator ==(CommandModel a, Enum b)
	{
		return a.Type == Convert.ToInt16(b);
	}

	public static bool operator !=(CommandModel a, Enum b)
	{
		return a.Type == Convert.ToInt16(b);
	}

	public static implicit operator ushort(in CommandModel c)
	{
		return c.Type;
	}
}
