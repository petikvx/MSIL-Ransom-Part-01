using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

[StructLayout(LayoutKind.Explicit, Size = 16)]
internal struct GlobalId
{
	public const int StructSize = 16;

	public static readonly GlobalId Empty = Guid.Empty;

	private static readonly byte[] HASHPREFIX = new byte[16]
	{
		126, 85, 219, 17, 52, 221, 70, 150, 168, 123,
		15, 254, 196, 77, 155, 168
	};

	public GlobalId(byte[] guidBytes)
		: this(new Guid(guidBytes))
	{
	}

	public unsafe GlobalId(Guid guid)
	{
		fixed (GlobalId* ptr = &this)
		{
			*ptr = guid;
		}
	}

	public byte[] ToByteArray()
	{
		return ((Guid)this).ToByteArray();
	}

	public override int GetHashCode()
	{
		return ((Guid)this).GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (!(obj is GlobalId) && !(obj is Guid))
		{
			return false;
		}
		return (GlobalId)obj == this;
	}

	public override string ToString()
	{
		return ((Guid)this).ToString("D");
	}

	public static bool operator !=(GlobalId a, GlobalId b)
	{
		return !(a == b);
	}

	public unsafe static bool operator ==(GlobalId a, GlobalId b)
	{
		byte* ptr = (byte*)(&a);
		byte* ptr2 = (byte*)(&b);
		int num = 0;
		while (true)
		{
			if (num < sizeof(GlobalId))
			{
				if (ptr[num] != ptr2[num])
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public unsafe static implicit operator Guid(GlobalId id)
	{
		return *(Guid*)(&id);
	}

	public unsafe static implicit operator GlobalId(Guid guid)
	{
		return *(GlobalId*)(&guid);
	}

	public static GlobalId DeriveFrom(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("value");
		}
		value = value.Trim();
		value = value.ToLower(CultureInfo.InvariantCulture);
		using SHA256Managed sHA256Managed = new SHA256Managed();
		int num = Encoding.Unicode.GetByteCount(value) + HASHPREFIX.Length;
		byte[] array = new byte[num];
		Array.Copy(HASHPREFIX, 0, array, 0, HASHPREFIX.Length);
		Encoding.Unicode.GetBytes(value, 0, value.Length, array, HASHPREFIX.Length);
		byte[] array2 = sHA256Managed.ComputeHash(array);
		return new GlobalId(new byte[16]
		{
			array2[3],
			array2[2],
			array2[1],
			array2[0],
			array2[5],
			array2[4],
			array2[7],
			(byte)((array2[6] & 0xFu) | 0x30u),
			(byte)((array2[8] & 0x3Fu) | 0x80u),
			array2[9],
			array2[10],
			array2[11],
			array2[12],
			array2[13],
			array2[14],
			array2[15]
		});
	}
}
