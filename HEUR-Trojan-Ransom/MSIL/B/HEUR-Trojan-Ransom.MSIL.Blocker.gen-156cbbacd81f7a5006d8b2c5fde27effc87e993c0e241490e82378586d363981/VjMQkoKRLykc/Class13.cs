using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace VjMQkoKRLykc;

internal static class Class13
{
	private abstract class Class14
	{
		private readonly Dictionary<string, string> dictionary_0 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

		private static readonly char[] char_0 = new char[3]
		{
			Path.DirectorySeparatorChar,
			Path.AltDirectorySeparatorChar,
			Path.VolumeSeparatorChar
		};

		private bool bool_0;

		protected void method_0(string string_0, string string_1)
		{
			dictionary_0.Add(string_0, string_1);
		}

		private void method_1()
		{
			if (!dictionary_0.ContainsKey(".*"))
			{
				method_0(".*", "application/octet-stream");
			}
		}

		private void method_2()
		{
			if (bool_0)
			{
				return;
			}
			lock (this)
			{
				if (!bool_0)
				{
					vmethod_0();
					method_1();
					bool_0 = true;
				}
			}
		}

		protected abstract void vmethod_0();

		private static string smethod_0(string string_0)
		{
			int num = string_0.LastIndexOfAny(char_0);
			if (num < 0)
			{
				return string_0;
			}
			return string_0.Substring(num);
		}

		public string method_3(string string_0)
		{
			method_2();
			string_0 = smethod_0(string_0);
			int num = 0;
			string value;
			while (true)
			{
				if (num < string_0.Length)
				{
					if (string_0[num] == '.' && dictionary_0.TryGetValue(string_0.Substring(num), out value))
					{
						break;
					}
					num++;
					continue;
				}
				return dictionary_0[".*"];
			}
			return value;
		}
	}

	private sealed class Class15 : Class14
	{
		protected override void vmethod_0()
		{
		}
	}

	private sealed class Class16 : Class14
	{
		private readonly IntPtr intptr_0;

		public Class16(IntPtr intptr_1)
		{
			intptr_0 = intptr_1;
		}

		protected override void vmethod_0()
		{
			IntPtr zero = IntPtr.Zero;
			try
			{
				int errorCode = 0;
				int num = 0;
				Marshal.ThrowExceptionForHR(0);
				for (int i = 0; i < num; i++)
				{
					IntPtr zero2 = IntPtr.Zero;
					IntPtr zero3 = IntPtr.Zero;
					try
					{
						Marshal.ThrowExceptionForHR(errorCode);
						string string_ = null;
						string string_2 = null;
						method_0(string_, string_2);
					}
					finally
					{
						if (zero2 != IntPtr.Zero)
						{
							Marshal.FreeBSTR(zero2);
						}
						if (zero3 != IntPtr.Zero)
						{
							Marshal.FreeBSTR(zero3);
						}
					}
				}
			}
			finally
			{
				if (zero != IntPtr.Zero)
				{
					Marshal.Release(zero);
				}
			}
		}
	}

	private static Class14 class14_0 = new Class15();

	public static string smethod_0(string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException(" ");
		}
		return class14_0.method_3(string_0);
	}

	internal static void smethod_1(IntPtr intptr_0)
	{
		class14_0 = new Class16(intptr_0);
	}

	internal static bool smethod_2(object object_0, ResolveEventArgs resolveEventArgs_0, out Assembly assembly_0)
	{
		AppDomain appDomain_ = (AppDomain)object_0;
		if (Class17.smethod_0(resolveEventArgs_0, out assembly_0, appDomain_))
		{
			return true;
		}
		assembly_0 = null;
		return false;
	}
}
