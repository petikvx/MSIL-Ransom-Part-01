#define DEBUG
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;

namespace C3554254475;

public static class C1812594589
{
	private delegate string C3554254475();

	[CompilerGenerated]
	private sealed class C3904355907
	{
		public string C3554254475;

		public string C3904355907;

		public bool C3554254475;

		public string C1255198513;

		public C2852464175 C3554254475;

		internal string C3554254475()
		{
			Process process = null;
			try
			{
				C1255198513 CS_0024_003C_003E8__locals0 = new C1255198513();
				ProcessStartInfo processStartInfo = new ProcessStartInfo
				{
					FileName = C1255198513(this.C3554254475)
				};
				if (!string.IsNullOrEmpty(C3904355907))
				{
					processStartInfo.Arguments = C3904355907;
				}
				processStartInfo.CreateNoWindow = true;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.UseShellExecute = false;
				processStartInfo.RedirectStandardOutput = this.C3554254475;
				if (C1255198513 != null)
				{
					processStartInfo.RedirectStandardInput = true;
				}
				CS_0024_003C_003E8__locals0.C3554254475 = Process.Start(processStartInfo);
				process = CS_0024_003C_003E8__locals0.C3554254475;
				if (C1255198513 != null)
				{
					C1812594589.C3554254475(CS_0024_003C_003E8__locals0.C3554254475.StandardInput);
					CS_0024_003C_003E8__locals0.C3554254475.StandardInput.Write(C1255198513);
					CS_0024_003C_003E8__locals0.C3554254475.StandardInput.Close();
				}
				string result = string.Empty;
				if (this.C3554254475)
				{
					result = CS_0024_003C_003E8__locals0.C3554254475.StandardOutput.ReadToEnd();
				}
				if ((this.C3554254475 & C2852464175.C1255198513) != 0)
				{
					CS_0024_003C_003E8__locals0.C3554254475.WaitForExit();
				}
				else if ((this.C3554254475 & C2852464175.C1908338681) != 0)
				{
					process = null;
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							CS_0024_003C_003E8__locals0.C3554254475.WaitForExit();
							CS_0024_003C_003E8__locals0.C3554254475.Dispose();
						}
						catch (Exception)
						{
							Debug.Assert(condition: false);
						}
					});
					thread.Start();
				}
				return result;
			}
			catch (Exception ex)
			{
				Debug.Assert(ex is ThreadAbortException);
			}
			finally
			{
				try
				{
					process?.Dispose();
				}
				catch (Exception)
				{
					Debug.Assert(condition: false);
				}
			}
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class C1255198513
	{
		public Process C3554254475;

		internal void C3554254475()
		{
			try
			{
				this.C3554254475.WaitForExit();
				this.C3554254475.Dispose();
			}
			catch (Exception)
			{
				Debug.Assert(condition: false);
			}
		}
	}

	private static bool m_C3554254475 = true;

	private static ulong? m_C3554254475 = null;

	private static bool? m_C3554254475 = null;

	private static PlatformID? m_C3554254475 = null;

	private static C3707901625? m_C3554254475 = null;

	[SpecialName]
	public static bool C3554254475()
	{
		return C1812594589.m_C3554254475;
	}

	[SpecialName]
	public static void C3554254475(bool bool_0)
	{
		C1812594589.m_C3554254475 = bool_0;
	}

	[SpecialName]
	public static ulong C3904355907()
	{
		if (C1812594589.m_C3554254475.HasValue)
		{
			return C1812594589.m_C3554254475.Value;
		}
		ulong num = 0uL;
		try
		{
			Type type = Type.GetType(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.CJ());
			if (type != null)
			{
				MethodInfo method = type.GetMethod(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Cj(), BindingFlags.Static | BindingFlags.NonPublic);
				if (method != null)
				{
					string text = method.Invoke(null, null) as string;
					if (!string.IsNullOrEmpty(text))
					{
						Match match = Regex.Match(text, DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.CK());
						if (match.Success)
						{
							num = C1130791706.C30677878(match.Value);
						}
						else
						{
							Debug.Assert(condition: false);
						}
					}
					else
					{
						Debug.Assert(condition: false);
					}
				}
				else
				{
					Debug.Assert(condition: false);
				}
			}
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
		C1812594589.m_C3554254475 = num;
		return num;
	}

	public static bool C1255198513()
	{
		byte[] byte_ = new byte[32];
		byte[] byte_2 = new byte[32];
		bool c3554254475 = C1812594589.m_C3554254475;
		C1812594589.m_C3554254475 = true;
		bool result = C3554254475(byte_, byte_2, 16uL);
		C1812594589.m_C3554254475 = c3554254475;
		return result;
	}

	public static bool C1908338681()
	{
		if (C1812594589.m_C3554254475.HasValue)
		{
			return C1812594589.m_C3554254475.Value;
		}
		PlatformID platformID = C1037565863();
		C1812594589.m_C3554254475 = platformID == PlatformID.Unix || platformID == PlatformID.MacOSX || platformID == (PlatformID)128;
		return C1812594589.m_C3554254475.Value;
	}

	public static PlatformID C1037565863()
	{
		if (C1812594589.m_C3554254475.HasValue)
		{
			return C1812594589.m_C3554254475.Value;
		}
		C1812594589.m_C3554254475 = Environment.OSVersion.Platform;
		if (C1812594589.m_C3554254475.Value == PlatformID.Unix && (C3554254475(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Ck(), null) ?? string.Empty).Trim().Equals(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.CL(), C1130791706.C3554254475))
		{
			C1812594589.m_C3554254475 = PlatformID.MacOSX;
		}
		return C1812594589.m_C3554254475.Value;
	}

	public static C3707901625 C112844655()
	{
		if (!C1812594589.m_C3554254475.HasValue)
		{
			C3707901625 value = C3707901625.C3554254475;
			if (!C1908338681())
			{
				value = C3707901625.C3904355907;
			}
			else
			{
				try
				{
					string text = (Environment.GetEnvironmentVariable(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Cl()) ?? string.Empty)!.Trim();
					string text2 = (Environment.GetEnvironmentVariable(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.CM()) ?? string.Empty)!.Trim();
					StringComparison c3554254475 = C1130791706.C3554254475;
					if (text.Equals(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Cm(), c3554254475))
					{
						value = C3707901625.C1037565863;
					}
					else if (text.Equals(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.CN(), c3554254475))
					{
						value = C3707901625.C112844655;
					}
					else if (text.Equals(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Cn(), c3554254475))
					{
						value = C3707901625.C2746444292;
					}
					else if (text.Equals(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.CO(), c3554254475))
					{
						value = C3707901625.C2564639436;
					}
					else if (text.Equals(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Co(), c3554254475))
					{
						value = C3707901625.C3568589458;
					}
					else if (text.Equals(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.CP(), c3554254475))
					{
						value = C3707901625.C4024072794;
					}
					else if (text.Equals(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Cp(), c3554254475) || text2.Equals(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.CQ(), c3554254475))
					{
						value = C3707901625.C1908338681;
					}
					else if (text.Equals(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Cq(), c3554254475))
					{
						value = ((!text2.Equals(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.CR(), c3554254475)) ? C3707901625.C1255198513 : C3707901625.C3568589458);
					}
					else if (text.Equals(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Cr(), c3554254475))
					{
						value = C3707901625.C1255198513;
					}
				}
				catch (Exception)
				{
					Debug.Assert(condition: false);
				}
			}
			C1812594589.m_C3554254475 = value;
		}
		return C1812594589.m_C3554254475.Value;
	}

	public static string C3554254475(string string_0, string string_1)
	{
		return C3554254475(string_0, string_1, null);
	}

	public static string C3554254475(string string_0, string string_1, string string_2)
	{
		return C3554254475(string_0, string_1, string_2, C2852464175.C3904355907 | C2852464175.C1255198513);
	}

	public static string C3554254475(string string_0, string string_1, string string_2, C2852464175 c2852464175_0)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.CS());
		}
		if (string_0.Length == 0)
		{
			throw new ArgumentException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.CS());
		}
		bool C3554254475 = (c2852464175_0 & C2852464175.C3904355907) != 0;
		Process C35542544752;
		C3554254475 c3554254475 = delegate
		{
			Process process = null;
			try
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo
				{
					FileName = C1255198513(string_0)
				};
				if (!string.IsNullOrEmpty(string_1))
				{
					processStartInfo.Arguments = string_1;
				}
				processStartInfo.CreateNoWindow = true;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.UseShellExecute = false;
				processStartInfo.RedirectStandardOutput = C3554254475;
				if (string_2 != null)
				{
					processStartInfo.RedirectStandardInput = true;
				}
				C35542544752 = Process.Start(processStartInfo);
				process = C35542544752;
				if (string_2 != null)
				{
					C1812594589.C3554254475(C35542544752.StandardInput);
					C35542544752.StandardInput.Write(string_2);
					C35542544752.StandardInput.Close();
				}
				string result2 = string.Empty;
				if (C3554254475)
				{
					result2 = C35542544752.StandardOutput.ReadToEnd();
				}
				if ((c2852464175_0 & C2852464175.C1255198513) != 0)
				{
					C35542544752.WaitForExit();
				}
				else if ((c2852464175_0 & C2852464175.C1908338681) != 0)
				{
					process = null;
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							C35542544752.WaitForExit();
							C35542544752.Dispose();
						}
						catch (Exception)
						{
							Debug.Assert(condition: false);
						}
					});
					thread.Start();
				}
				return result2;
			}
			catch (Exception ex)
			{
				Debug.Assert(ex is ThreadAbortException);
			}
			finally
			{
				try
				{
					process?.Dispose();
				}
				catch (Exception)
				{
					Debug.Assert(condition: false);
				}
			}
			return null;
		};
		if ((c2852464175_0 & C2852464175.C1037565863) != 0)
		{
			List<Form> list = new List<Form>();
			if ((c2852464175_0 & C2852464175.C112844655) != 0)
			{
				foreach (Form item in (ReadOnlyCollectionBase)(object)Application.get_OpenForms())
				{
					Form val = item;
					if (((Control)val).get_Enabled())
					{
						list.Add(val);
						((Control)val).set_Enabled(false);
					}
				}
			}
			IAsyncResult asyncResult = c3554254475.BeginInvoke(null, null);
			while (!asyncResult.AsyncWaitHandle.WaitOne(0))
			{
				Application.DoEvents();
				Thread.Sleep(2);
			}
			string result = c3554254475.EndInvoke(asyncResult);
			for (int num = list.Count - 1; num >= 0; num--)
			{
				((Control)list[num]).set_Enabled(true);
			}
			return result;
		}
		return c3554254475();
	}

	private static void C3554254475(StreamWriter streamWriter_0)
	{
		if (streamWriter_0 == null)
		{
			Debug.Assert(condition: false);
			return;
		}
		try
		{
			Encoding encoding = streamWriter_0.Encoding;
			if (encoding == null)
			{
				Debug.Assert(condition: false);
				return;
			}
			byte[] preamble = encoding.GetPreamble();
			if (preamble == null || preamble.Length == 0)
			{
				return;
			}
			try
			{
				FieldInfo field = typeof(StreamWriter).GetField(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Cs(), BindingFlags.Instance | BindingFlags.NonPublic);
				if (field != null)
				{
					field.SetValue(streamWriter_0, true);
					return;
				}
			}
			catch (Exception)
			{
				Debug.Assert(condition: false);
			}
			FieldInfo field2 = typeof(StreamWriter).GetField(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.CT(), BindingFlags.Instance | BindingFlags.NonPublic);
			if (field2 != null)
			{
				field2.SetValue(streamWriter_0, true);
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
	}

	public static bool C3554254475(byte[] byte_0, byte[] byte_1, ulong ulong_0)
	{
		if (!C1812594589.m_C3554254475)
		{
			return false;
		}
		KeyValuePair<IntPtr, IntPtr> keyValuePair_ = C3554254475(byte_0, byte_1);
		bool flag = false;
		try
		{
			flag = C543223747.C1255198513(keyValuePair_.Key, keyValuePair_.Value, ulong_0);
		}
		catch (Exception)
		{
			flag = false;
		}
		if (flag)
		{
			C3554254475(keyValuePair_, byte_0, byte_1);
		}
		C3554254475(keyValuePair_);
		return flag;
	}

	public static bool C3554254475(uint uint_0, out ulong ulong_0)
	{
		ulong_0 = 0uL;
		if (!C1812594589.m_C3554254475)
		{
			return false;
		}
		try
		{
			ulong_0 = C543223747.C1255198513(uint_0);
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	private static KeyValuePair<IntPtr, IntPtr> C3554254475(byte[] byte_0, byte[] byte_1)
	{
		Debug.Assert(byte_0 != null && byte_0.Length == 32);
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Ct());
		}
		if (byte_0.Length != 32)
		{
			throw new ArgumentException();
		}
		Debug.Assert(byte_1 != null && byte_1.Length == 32);
		if (byte_1 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.CU());
		}
		if (byte_1.Length != 32)
		{
			throw new ArgumentException();
		}
		IntPtr intPtr = Marshal.AllocHGlobal(byte_0.Length);
		Marshal.Copy(byte_0, 0, intPtr, byte_0.Length);
		IntPtr intPtr2 = Marshal.AllocHGlobal(byte_1.Length);
		Marshal.Copy(byte_1, 0, intPtr2, byte_1.Length);
		return new KeyValuePair<IntPtr, IntPtr>(intPtr, intPtr2);
	}

	private static void C3554254475(KeyValuePair<IntPtr, IntPtr> keyValuePair_0, byte[] byte_0, byte[] byte_1)
	{
		if (keyValuePair_0.Key != IntPtr.Zero)
		{
			Marshal.Copy(keyValuePair_0.Key, byte_0, 0, byte_0.Length);
		}
		if (keyValuePair_0.Value != IntPtr.Zero)
		{
			Marshal.Copy(keyValuePair_0.Value, byte_1, 0, byte_1.Length);
		}
	}

	private static void C3554254475(KeyValuePair<IntPtr, IntPtr> keyValuePair_0)
	{
		if (keyValuePair_0.Key != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(keyValuePair_0.Key);
		}
		if (keyValuePair_0.Value != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(keyValuePair_0.Value);
		}
	}

	internal static Type C3554254475(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			Debug.Assert(condition: false);
			return null;
		}
		return Type.GetType(string_0 + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Cu(), throwOnError: false);
	}

	internal static string C3904355907(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return string.Empty;
		}
		return string_0.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ah(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.CV());
	}

	internal static string C1255198513(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return string.Empty;
		}
		return string_0;
	}

	internal static string C1908338681(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return string.Empty;
		}
		return string_0;
	}
}
