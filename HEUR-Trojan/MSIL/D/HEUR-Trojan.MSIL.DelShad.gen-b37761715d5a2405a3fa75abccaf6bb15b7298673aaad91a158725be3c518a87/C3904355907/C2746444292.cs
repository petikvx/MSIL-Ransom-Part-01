#define DEBUG
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using C3554254475;

namespace C3904355907;

public sealed class C2746444292
{
	[CompilerGenerated]
	private sealed class C3554254475
	{
		public SHA512Managed C3554254475;

		public byte[] C3554254475;

		public C3081909835<byte[], bool> C3554254475;

		public byte[] C3904355907;

		internal void C3554254475(byte[] byte_0, bool bool_0)
		{
			if (byte_0 == null)
			{
				Debug.Assert(condition: false);
			}
			else if (byte_0.Length != 0)
			{
				this.C3554254475.TransformBlock(byte_0, 0, byte_0.Length, byte_0, 0);
				if (bool_0)
				{
					global::C3554254475.C2137352139.C3904355907(byte_0);
				}
			}
		}

		internal void C3554254475(int int_0)
		{
			global::C3554254475.C2137352139.C3554254475(int_0, this.C3554254475, 0);
			this.C3554254475(this.C3554254475, gparam_1: false);
		}

		internal void C3554254475(long long_0)
		{
			global::C3554254475.C2137352139.C3554254475(long_0, C3904355907, 0);
			this.C3554254475(C3904355907, gparam_1: false);
		}

		internal void C3554254475(string string_0)
		{
			if (string_0 == null)
			{
				Debug.Assert(condition: false);
			}
			else if (string_0.Length != 0)
			{
				this.C3554254475(global::C3554254475.C1130791706.C1255198513().GetBytes(string_0), gparam_1: false);
			}
		}
	}

	private global::C3554254475.C3110715001 m_C3554254475 = new global::C3554254475.C3110715001(bool_0: true, new byte[64]);

	private RNGCryptoServiceProvider m_C3554254475 = new RNGCryptoServiceProvider();

	private ulong m_C3554254475;

	private ulong m_C3904355907 = 0uL;

	private static readonly object m_C3554254475 = new object();

	private readonly object m_C3904355907 = new object();

	private static C2746444292 m_C3554254475 = null;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler m_C3554254475;

	private static int m_C3554254475 = 0;

	[SpecialName]
	public static C2746444292 C3554254475()
	{
		C2746444292 c2746444292;
		lock (C2746444292.m_C3554254475)
		{
			c2746444292 = C2746444292.m_C3554254475;
			if (c2746444292 == null)
			{
				c2746444292 = (C2746444292.m_C3554254475 = new C2746444292());
			}
		}
		return c2746444292;
	}

	[SpecialName]
	public ulong C3904355907()
	{
		lock (this.m_C3904355907)
		{
			return this.m_C3904355907;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public void C3554254475(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = this.m_C3554254475;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref this.m_C3554254475, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void C3904355907(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = this.m_C3554254475;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref this.m_C3554254475, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	private C2746444292()
	{
		this.m_C3554254475 = (ulong)DateTime.UtcNow.ToBinary();
		byte[] byte_ = C1255198513();
		C3554254475(byte_);
		global::C3554254475.C2137352139.C3904355907(byte_);
	}

	public void C3554254475(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			Debug.Assert(condition: false);
			return;
		}
		if (byte_0.Length == 0)
		{
			Debug.Assert(condition: false);
			return;
		}
		byte[] array = byte_0;
		if (byte_0.Length > 64)
		{
			using SHA512Managed sHA512Managed = new SHA512Managed();
			array = sHA512Managed.ComputeHash(byte_0);
		}
		lock (this.m_C3904355907)
		{
			byte[] array2 = this.m_C3554254475.C2746444292();
			int num = array2.Length;
			int num2 = array.Length;
			byte[] array3 = new byte[num + num2];
			Array.Copy(array2, array3, num);
			Array.Copy(array, 0, array3, num, num2);
			using (SHA512Managed sHA512Managed2 = new SHA512Managed())
			{
				byte[] byte_ = sHA512Managed2.ComputeHash(array3);
				this.m_C3554254475 = new global::C3554254475.C3110715001(bool_0: true, byte_);
				global::C3554254475.C2137352139.C3904355907(byte_);
			}
			global::C3554254475.C2137352139.C3904355907(array3);
			global::C3554254475.C2137352139.C3904355907(array2);
		}
		if (array != byte_0)
		{
			global::C3554254475.C2137352139.C3904355907(array);
		}
	}

	private byte[] C1255198513()
	{
		SHA512Managed C35542544753 = new SHA512Managed();
		byte[] C35542544752 = new byte[4];
		byte[] C3904355907 = new byte[8];
		C3081909835<byte[], bool> C3554254475 = delegate(byte[] byte_0, bool bool_0)
		{
			if (byte_0 == null)
			{
				Debug.Assert(condition: false);
			}
			else if (byte_0.Length != 0)
			{
				C35542544753.TransformBlock(byte_0, 0, byte_0.Length, byte_0, 0);
				if (bool_0)
				{
					global::C3554254475.C2137352139.C3904355907(byte_0);
				}
			}
		};
		Action<int> action = delegate(int int_0)
		{
			global::C3554254475.C2137352139.C3554254475(int_0, C35542544752, 0);
			C3554254475(C35542544752, gparam_1: false);
		};
		Action<long> action2 = delegate(long long_0)
		{
			global::C3554254475.C2137352139.C3554254475(long_0, C3904355907, 0);
			C3554254475(C3904355907, gparam_1: false);
		};
		Action<string> action3 = delegate(string string_0)
		{
			if (string_0 == null)
			{
				Debug.Assert(condition: false);
			}
			else if (string_0.Length != 0)
			{
				C3554254475(global::C3554254475.C1130791706.C1255198513().GetBytes(string_0), gparam_1: false);
			}
		};
		action(Environment.TickCount);
		action2(DateTime.UtcNow.ToBinary());
		try
		{
			Point position = Cursor.get_Position();
			action(position.X);
			action(position.Y);
		}
		catch (Exception)
		{
			Debug.Assert(global::C3554254475.C1812594589.C1908338681());
		}
		try
		{
			action((int)global::C3554254475.C1812594589.C1037565863());
			action3(Environment.OSVersion.VersionString);
			action(Environment.ProcessorCount);
			action3(Environment.CommandLine);
			action2(Environment.WorkingSet);
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
		try
		{
			foreach (DictionaryEntry environmentVariable in Environment.GetEnvironmentVariables())
			{
				action3(environmentVariable.Key as string);
				action3(environmentVariable.Value as string);
			}
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
		try
		{
			using Process process = Process.GetCurrentProcess();
			action2(process.Handle.ToInt64());
			action(process.HandleCount);
			action(process.Id);
			action2(process.NonpagedSystemMemorySize64);
			action2(process.PagedMemorySize64);
			action2(process.PagedSystemMemorySize64);
			action2(process.PeakPagedMemorySize64);
			action2(process.PeakVirtualMemorySize64);
			action2(process.PeakWorkingSet64);
			action2(process.PrivateMemorySize64);
			action2(process.StartTime.ToBinary());
			action2(process.VirtualMemorySize64);
			action2(process.WorkingSet64);
		}
		catch (Exception)
		{
			Debug.Assert(global::C3554254475.C1812594589.C1908338681());
		}
		try
		{
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			if (currentCulture != null)
			{
				action(currentCulture.GetHashCode());
			}
			else
			{
				Debug.Assert(condition: false);
			}
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
		C3554254475(Guid.NewGuid().ToByteArray(), gparam_1: false);
		C3554254475(C1908338681(), gparam_1: true);
		C35542544753.TransformFinalBlock(global::C3554254475.C2137352139.C3554254475, 0, 0);
		byte[] hash = C35542544753.Hash;
		C35542544753.Clear();
		global::C3554254475.C2137352139.C3904355907(C35542544752);
		global::C3554254475.C2137352139.C3904355907(C3904355907);
		return hash;
	}

	private byte[] C1908338681()
	{
		byte[] array = new byte[32];
		try
		{
			this.m_C3554254475.GetBytes(array);
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
			global::C3554254475.C2137352139.C3554254475(DateTime.UtcNow.ToBinary(), array, 0);
		}
		return array;
	}

	private byte[] C1037565863()
	{
		if (this.m_C3554254475 != null)
		{
			this.m_C3554254475(this, EventArgs.Empty);
		}
		byte[] array4;
		lock (this.m_C3904355907)
		{
			this.m_C3554254475 += 8419675896339292513uL;
			byte[] array = global::C3554254475.C2137352139.C3554254475(this.m_C3554254475);
			byte[] array2 = C1908338681();
			byte[] array3 = this.m_C3554254475.C2746444292();
			int num = array3.Length;
			int num2 = array.Length;
			int num3 = array2.Length;
			array4 = new byte[num + num2 + num3];
			Array.Copy(array3, array4, num);
			Array.Copy(array, 0, array4, num, num2);
			Array.Copy(array2, 0, array4, num + num2, num3);
			global::C3554254475.C2137352139.C3904355907(array2);
			global::C3554254475.C2137352139.C3904355907(array3);
			this.m_C3904355907 += 32uL;
		}
		byte[] result = C1304234792.C3554254475(array4);
		global::C3554254475.C2137352139.C3904355907(array4);
		return result;
	}

	public byte[] C3554254475(uint uint_0)
	{
		if (uint_0 == 0)
		{
			return global::C3554254475.C2137352139.C3554254475;
		}
		if (uint_0 > int.MaxValue)
		{
			Debug.Assert(condition: false);
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Cz());
		}
		int num = (int)uint_0;
		byte[] array = new byte[num];
		int num2 = 0;
		while (num != 0)
		{
			byte[] array2 = C1037565863();
			Debug.Assert(array2.Length == 32);
			int num3 = Math.Min(num, array2.Length);
			Array.Copy(array2, 0, array, num2, num3);
			global::C3554254475.C2137352139.C3904355907(array2);
			num2 += num3;
			num -= num3;
		}
		Debug.Assert(num2 == array.Length);
		return array;
	}

	public static Random C112844655()
	{
		long num = DateTime.UtcNow.ToBinary();
		int num2 = (int)((num >> 32) ^ num);
		lock (C2746444292.m_C3554254475)
		{
			C2746444292.m_C3554254475 += 2024326327;
			num2 ^= C2746444292.m_C3554254475;
		}
		if (num2 == int.MinValue)
		{
			num2 = int.MaxValue;
		}
		return new Random(num2);
	}
}
