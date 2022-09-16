using System;
using System.Threading;
using _0xHCibo7;

namespace _0xHRolf3rs;

internal struct _0xHDoss1ers<KeyType, ItemType> where ItemType : _0xHCibo7._0xHRefr8in<KeyType, ItemType>
{
	private ItemType[] _0xHFr6tter;

	public ItemType _0xHInfusi0ility(KeyType _0xHVenialne11e1)
	{
		ItemType[] items = this.items;
		if (items == null)
		{
			goto IL_004d;
		}
		int num = 0;
		int num2 = items.Length;
		ItemType result;
		while (true)
		{
			int num3 = checked(num + num2) / 2;
			result = items[num3];
			int num4 = ((_0xHCibo7._0xHRefr8in<KeyType, ItemType>)result).Compare(_0xHVenialne11e1);
			if (num4 == 0)
			{
				break;
			}
			if (num4 < 0)
			{
				num = checked(num3 + 1);
			}
			else
			{
				num2 = num3;
			}
			if (num != num2)
			{
				continue;
			}
			goto IL_004d;
		}
		goto IL_0055;
		IL_0055:
		return result;
		IL_004d:
		result = null;
		goto IL_0055;
	}

	public ItemType _0xHNe5s5ritings(ItemType _0xHPish5r)
	{
		ItemType[] array = this.items;
		ItemType result;
		while (true)
		{
			int num;
			if (array != null)
			{
				num = 0;
				int num2 = array.Length;
				while (true)
				{
					int num3 = checked(num + num2) / 2;
					result = array[num3];
					int num4 = ((_0xHCibo7._0xHRefr8in<KeyType, ItemType>)result).Compare(_0xHPish5r);
					if (num4 == 0)
					{
						break;
					}
					if (num4 < 0)
					{
						num = checked(num3 + 1);
					}
					else
					{
						num2 = num3;
					}
					if (num != num2)
					{
						continue;
					}
					goto IL_0053;
				}
				break;
			}
			ItemType[] array2 = new ItemType[1] { _0xHPish5r };
			goto IL_0083;
			IL_0083:
			array2 = Interlocked.CompareExchange(ref this.items, array2, array);
			if (array != array2)
			{
				array = array2;
				continue;
			}
			result = _0xHPish5r;
			break;
			IL_0053:
			int num5 = array.Length;
			checked
			{
				array2 = new ItemType[num5 + 1];
				Array.Copy(array, 0, array2, 0, num);
				array2[num] = _0xHPish5r;
				Array.Copy(array, num, array2, num + 1, num5 - num);
				goto IL_0083;
			}
		}
		return result;
	}
}
