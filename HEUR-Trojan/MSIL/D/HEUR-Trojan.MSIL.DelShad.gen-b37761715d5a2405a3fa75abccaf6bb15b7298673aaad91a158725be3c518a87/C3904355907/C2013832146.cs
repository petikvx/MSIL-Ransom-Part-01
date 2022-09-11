#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using C3554254475;

namespace C3904355907;

public class C2013832146 : ICloneable
{
	private enum C3554254475 : byte
	{
		C3554254475 = 0,
		C3904355907 = 4,
		C1255198513 = 5,
		C1908338681 = 8,
		C1037565863 = 12,
		C112844655 = 13,
		C2746444292 = 24,
		C2564639436 = 66
	}

	private const ushort m_C3554254475 = 256;

	private const ushort m_C3904355907 = 65280;

	private const ushort m_C1255198513 = 255;

	private Dictionary<string, object> m_C3554254475 = new Dictionary<string, object>();

	[SpecialName]
	public int C3554254475()
	{
		return this.m_C3554254475.Count;
	}

	public C2013832146()
	{
		Debug.Assert(condition: true);
		Debug.Assert(condition: true);
	}

	private bool C3554254475<C3554254475>(string string_0, out C3554254475 gparam_0)
	{
		gparam_0 = default(C3554254475);
		if (string.IsNullOrEmpty(string_0))
		{
			Debug.Assert(condition: false);
			return false;
		}
		if (!this.m_C3554254475.TryGetValue(string_0, out var value))
		{
			return false;
		}
		if (value == null)
		{
			Debug.Assert(condition: false);
			return false;
		}
		if (value.GetType() != typeof(C3554254475))
		{
			Debug.Assert(condition: false);
			return false;
		}
		gparam_0 = (C3554254475)value;
		return true;
	}

	private void C3554254475<C3554254475>(string string_0, C3554254475 gparam_0) where C3554254475 : struct
	{
		if (string.IsNullOrEmpty(string_0))
		{
			Debug.Assert(condition: false);
			return;
		}
		this.C3554254475(string_0, out C3554254475 _);
		this.m_C3554254475[string_0] = gparam_0;
	}

	private void C3904355907<C3554254475>(string string_0, C3554254475 gparam_0) where C3554254475 : class
	{
		if (string.IsNullOrEmpty(string_0))
		{
			Debug.Assert(condition: false);
			return;
		}
		if (gparam_0 == null)
		{
			Debug.Assert(condition: false);
			return;
		}
		this.C3554254475(string_0, out C3554254475 _);
		this.m_C3554254475[string_0] = gparam_0;
	}

	public bool C3554254475(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			Debug.Assert(condition: false);
			return false;
		}
		return this.m_C3554254475.Remove(string_0);
	}

	public void C3554254475(C2013832146 c2013832146_0)
	{
		if (c2013832146_0 == null)
		{
			Debug.Assert(condition: false);
			return;
		}
		foreach (KeyValuePair<string, object> item in this.m_C3554254475)
		{
			c2013832146_0.m_C3554254475[item.Key] = item.Value;
		}
	}

	public Type C3904355907(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			Debug.Assert(condition: false);
			return null;
		}
		this.m_C3554254475.TryGetValue(string_0, out var value);
		return value?.GetType();
	}

	public uint C3554254475(string string_0, uint uint_0)
	{
		if (C3554254475(string_0, out uint gparam_))
		{
			return gparam_;
		}
		return uint_0;
	}

	public void C3904355907(string string_0, uint uint_0)
	{
		this.C3554254475<uint>(string_0, uint_0);
	}

	public ulong C3554254475(string string_0, ulong ulong_0)
	{
		if (C3554254475(string_0, out ulong gparam_))
		{
			return gparam_;
		}
		return ulong_0;
	}

	public void C3904355907(string string_0, ulong ulong_0)
	{
		this.C3554254475<ulong>(string_0, ulong_0);
	}

	public bool C3554254475(string string_0, bool bool_0)
	{
		if (C3554254475(string_0, out bool gparam_))
		{
			return gparam_;
		}
		return bool_0;
	}

	public void C3904355907(string string_0, bool bool_0)
	{
		this.C3554254475<bool>(string_0, bool_0);
	}

	public int C3554254475(string string_0, int int_0)
	{
		if (C3554254475(string_0, out int gparam_))
		{
			return gparam_;
		}
		return int_0;
	}

	public void C3904355907(string string_0, int int_0)
	{
		this.C3554254475<int>(string_0, int_0);
	}

	public long C3554254475(string string_0, long long_0)
	{
		if (C3554254475(string_0, out long gparam_))
		{
			return gparam_;
		}
		return long_0;
	}

	public void C3904355907(string string_0, long long_0)
	{
		this.C3554254475<long>(string_0, long_0);
	}

	public string C1255198513(string string_0)
	{
		C3554254475(string_0, out string gparam_);
		return gparam_;
	}

	public void C3554254475(string string_0, string string_1)
	{
		C3904355907(string_0, string_1);
	}

	public byte[] C1908338681(string string_0)
	{
		C3554254475(string_0, out byte[] gparam_);
		return gparam_;
	}

	public void C3554254475(string string_0, byte[] byte_0)
	{
		C3904355907(string_0, byte_0);
	}

	public virtual object Clone()
	{
		C2013832146 c = new C2013832146();
		foreach (KeyValuePair<string, object> item in this.m_C3554254475)
		{
			object obj = item.Value;
			if (obj == null)
			{
				Debug.Assert(condition: false);
				continue;
			}
			Type type = obj.GetType();
			if (type == typeof(byte[]))
			{
				byte[] array = (byte[])obj;
				byte[] array2 = new byte[array.Length];
				if (array.Length != 0)
				{
					Array.Copy(array, array2, array.Length);
				}
				obj = array2;
			}
			c.m_C3554254475[item.Key] = obj;
		}
		return c;
	}

	public static byte[] C3904355907(C2013832146 c2013832146_0)
	{
		if (c2013832146_0 == null)
		{
			Debug.Assert(condition: false);
			return null;
		}
		byte[] result;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			global::C3554254475.C2137352139.C3554254475(memoryStream, global::C3554254475.C2137352139.C3554254475((ushort)256));
			foreach (KeyValuePair<string, object> item in c2013832146_0.m_C3554254475)
			{
				string key = item.Key;
				if (string.IsNullOrEmpty(key))
				{
					Debug.Assert(condition: false);
					continue;
				}
				byte[] bytes = global::C3554254475.C1130791706.C1255198513().GetBytes(key);
				object value = item.Value;
				if (value == null)
				{
					Debug.Assert(condition: false);
					continue;
				}
				Type type = value.GetType();
				C3554254475 c3554254475 = C2013832146.C3554254475.C3554254475;
				byte[] array = null;
				if (type == typeof(uint))
				{
					c3554254475 = C2013832146.C3554254475.C3904355907;
					array = global::C3554254475.C2137352139.C3554254475((uint)value);
				}
				else if (type == typeof(ulong))
				{
					c3554254475 = C2013832146.C3554254475.C1255198513;
					array = global::C3554254475.C2137352139.C3554254475((ulong)value);
				}
				else if (type == typeof(bool))
				{
					c3554254475 = C2013832146.C3554254475.C1908338681;
					array = new byte[1] { (byte)(((bool)value) ? 1 : 0) };
				}
				else if (type == typeof(int))
				{
					c3554254475 = C2013832146.C3554254475.C1037565863;
					array = global::C3554254475.C2137352139.C3554254475((int)value);
				}
				else if (type == typeof(long))
				{
					c3554254475 = C2013832146.C3554254475.C112844655;
					array = global::C3554254475.C2137352139.C3554254475((long)value);
				}
				else if (type == typeof(string))
				{
					c3554254475 = C2013832146.C3554254475.C2746444292;
					array = global::C3554254475.C1130791706.C1255198513().GetBytes((string)value);
				}
				else
				{
					if (!(type == typeof(byte[])))
					{
						Debug.Assert(condition: false);
						continue;
					}
					c3554254475 = C2013832146.C3554254475.C2564639436;
					array = (byte[])value;
				}
				memoryStream.WriteByte((byte)c3554254475);
				global::C3554254475.C2137352139.C3554254475(memoryStream, global::C3554254475.C2137352139.C3554254475(bytes.Length));
				global::C3554254475.C2137352139.C3554254475(memoryStream, bytes);
				global::C3554254475.C2137352139.C3554254475(memoryStream, global::C3554254475.C2137352139.C3554254475(array.Length));
				global::C3554254475.C2137352139.C3554254475(memoryStream, array);
			}
			memoryStream.WriteByte(0);
			result = memoryStream.ToArray();
		}
		return result;
	}

	public static C2013832146 C3554254475(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			Debug.Assert(condition: false);
			return null;
		}
		C2013832146 c = new C2013832146();
		using (MemoryStream memoryStream = new MemoryStream(byte_0, writable: false))
		{
			ushort num = global::C3554254475.C2137352139.C1255198513(global::C3554254475.C2137352139.C3554254475(memoryStream, 2));
			if ((num & 0xFF00) > 256)
			{
				throw new FormatException(global::C3554254475.C4110462503.C2852464175());
			}
			while (true)
			{
				int num2 = memoryStream.ReadByte();
				if (num2 >= 0)
				{
					byte b = (byte)num2;
					if (b == 0)
					{
						break;
					}
					int num3 = global::C3554254475.C2137352139.C112844655(global::C3554254475.C2137352139.C3554254475(memoryStream, 4));
					byte[] array = global::C3554254475.C2137352139.C3554254475(memoryStream, num3);
					if (array.Length == num3)
					{
						string @string = global::C3554254475.C1130791706.C1255198513().GetString(array);
						int num4 = global::C3554254475.C2137352139.C112844655(global::C3554254475.C2137352139.C3554254475(memoryStream, 4));
						byte[] array2 = global::C3554254475.C2137352139.C3554254475(memoryStream, num4);
						if (array2.Length == num4)
						{
							switch (b)
							{
							case 12:
								if (num4 == 4)
								{
									c.C3904355907(@string, global::C3554254475.C2137352139.C112844655(array2));
								}
								else
								{
									Debug.Assert(condition: false);
								}
								break;
							case 4:
								if (num4 == 4)
								{
									c.C3904355907(@string, global::C3554254475.C2137352139.C1908338681(array2));
								}
								else
								{
									Debug.Assert(condition: false);
								}
								break;
							case 5:
								if (num4 == 8)
								{
									c.C3904355907(@string, global::C3554254475.C2137352139.C1037565863(array2));
								}
								else
								{
									Debug.Assert(condition: false);
								}
								break;
							case 8:
								if (num4 == 1)
								{
									c.C3904355907(@string, array2[0] != 0);
								}
								else
								{
									Debug.Assert(condition: false);
								}
								break;
							default:
								Debug.Assert(condition: false);
								break;
							case 66:
								c.C3554254475(@string, array2);
								break;
							case 24:
								c.C3554254475(@string, global::C3554254475.C1130791706.C1255198513().GetString(array2));
								break;
							case 13:
								if (num4 == 8)
								{
									c.C3904355907(@string, global::C3554254475.C2137352139.C2746444292(array2));
								}
								else
								{
									Debug.Assert(condition: false);
								}
								break;
							}
							continue;
						}
						throw new EndOfStreamException(global::C3554254475.C4110462503.C2564639436());
					}
					throw new EndOfStreamException(global::C3554254475.C4110462503.C2564639436());
				}
				throw new EndOfStreamException(global::C3554254475.C4110462503.C2564639436());
			}
			Debug.Assert(memoryStream.ReadByte() < 0);
		}
		return c;
	}
}
