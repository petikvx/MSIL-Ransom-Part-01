using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using e1t9ZoIMs7pU1MfVBaV;
using eNrrru930ECxo7KySq;
using elRV9N3vPjJN4FNmtXC;

namespace eHKJpTF7Sd82MgHeeV;

internal class eNJYnKxVthBjlLlacd
{
	internal struct eAe1jMO2DJuAhYgpQt
	{
		public string eKb3AYt8Z;

		public Version exwyp4bAY;

		public string e9IgDZCnQ;

		public string eWNbTSexZ;

		public string e4ZIbpnTa(bool bool_0)
		{
			StringBuilder stringBuilder = default(StringBuilder);
			try
			{
				stringBuilder = new StringBuilder();
				eCQH0u91GSyE2OuDGQG(stringBuilder, eKb3AYt8Z);
				if (bool_0 && eUa8CO9RDAoj2ErlNau(exwyp4bAY, null))
				{
					if (er0dZe9t02m8iYvV3Ro())
					{
					}
					eCQH0u91GSyE2OuDGQG(stringBuilder, eDuaTU3TDhsqeVkuTG8.eulODlten(408));
					esUgFe9qKiD4Scy3W3A(stringBuilder, exwyp4bAY);
				}
				eCQH0u91GSyE2OuDGQG(stringBuilder, eDuaTU3TDhsqeVkuTG8.eulODlten(432));
				eCQH0u91GSyE2OuDGQG(stringBuilder, (etwOAb9OUZSEHawTLX5(e9IgDZCnQ) == 0) ? eDuaTU3TDhsqeVkuTG8.eulODlten(456) : e9IgDZCnQ);
				eCQH0u91GSyE2OuDGQG(stringBuilder, eDuaTU3TDhsqeVkuTG8.eulODlten(474));
				eCQH0u91GSyE2OuDGQG(stringBuilder, (etwOAb9OUZSEHawTLX5(eWNbTSexZ) == 0) ? eDuaTU3TDhsqeVkuTG8.eulODlten(512) : eWNbTSexZ);
				return stringBuilder.ToString();
			}
			catch (Exception object_)
			{
				eVEKtS93qD2GSXD2enK(object_, stringBuilder, this, bool_0);
				throw;
			}
		}

		public eAe1jMO2DJuAhYgpQt(string string_0)
		{
			char[] array = default(char[]);
			string[] array2 = default(string[]);
			int num = default(int);
			string text = default(string);
			string text2 = default(string);
			try
			{
				exwyp4bAY = null;
				eVFWxa9G97QRI6iOKw1();
				if (!er0dZe9t02m8iYvV3Ro())
				{
					e9IgDZCnQ = string.Empty;
					eWNbTSexZ = string.Empty;
					eKb3AYt8Z = string.Empty;
					array = new char[1] { ',' };
					array2 = (string[])eU1UU79Fqyt9XrQnVie(string_0, array);
					if (!eVFWxa9G97QRI6iOKw1())
					{
						goto IL_011a;
					}
					num = 0;
				}
				goto IL_0132;
				IL_012e:
				num++;
				goto IL_0132;
				IL_0127:
				eKb3AYt8Z = text;
				goto IL_012e;
				IL_0132:
				if (num >= array2.Length)
				{
					return;
				}
				text2 = array2[num];
				while (true)
				{
					text = (string)e4xE9K9e9alMOM6IB5r(text2);
					if (eNyuIp9KqtranVstq9Z(text, eDuaTU3TDhsqeVkuTG8.eulODlten(524)))
					{
						break;
					}
					if (eNyuIp9KqtranVstq9Z(text, eDuaTU3TDhsqeVkuTG8.eulODlten(544)))
					{
						goto IL_00c4;
					}
					if (eNyuIp9KqtranVstq9Z(text, eDuaTU3TDhsqeVkuTG8.eulODlten(582)))
					{
						if (!eVFWxa9G97QRI6iOKw1())
						{
							continue;
						}
						goto IL_00f5;
					}
					goto IL_0127;
				}
				exwyp4bAY = new Version((string)ekHIvk9srehaCeQNKFn(text, 8));
				goto IL_012e;
				IL_00c4:
				e9IgDZCnQ = (string)ekHIvk9srehaCeQNKFn(text, 8);
				if (e2SMS69I3LCZVvmJWKF(e9IgDZCnQ, eDuaTU3TDhsqeVkuTG8.eulODlten(564)))
				{
					e9IgDZCnQ = string.Empty;
				}
				goto IL_012e;
				IL_00f5:
				eWNbTSexZ = (string)ekHIvk9srehaCeQNKFn(text, 15);
				if (e2SMS69I3LCZVvmJWKF(eWNbTSexZ, eDuaTU3TDhsqeVkuTG8.eulODlten(616)))
				{
					goto IL_011a;
				}
				goto IL_012e;
				IL_011a:
				eWNbTSexZ = string.Empty;
				goto IL_012e;
			}
			catch (Exception object_)
			{
				eO955F90veX7NuyunS2(object_, text2, text, array, array2, num, this, string_0);
				throw;
			}
		}

		internal static object eCQH0u91GSyE2OuDGQG(object object_0, object object_1)
		{
			return ((StringBuilder)object_0).Append((string?)object_1);
		}

		internal static bool eUa8CO9RDAoj2ErlNau(object object_0, object object_1)
		{
			return (Version?)object_0 != (Version?)object_1;
		}

		internal static object esUgFe9qKiD4Scy3W3A(object object_0, object object_1)
		{
			return ((StringBuilder)object_0).Append(object_1);
		}

		internal static int etwOAb9OUZSEHawTLX5(object object_0)
		{
			return ((string)object_0).Length;
		}

		internal static void eVEKtS93qD2GSXD2enK(object object_0, object object_1, object object_2, object object_3)
		{
			eEJNauItTVW1j8pluTb.eeN1kpseb((Exception)object_0, object_1, object_2, object_3);
		}

		internal static bool eVFWxa9G97QRI6iOKw1()
		{
			return true;
		}

		internal static bool er0dZe9t02m8iYvV3Ro()
		{
			return false;
		}

		internal static object eU1UU79Fqyt9XrQnVie(object object_0, object object_1)
		{
			return ((string)object_0).Split((char[]?)object_1);
		}

		internal static object e4xE9K9e9alMOM6IB5r(object object_0)
		{
			return ((string)object_0).Trim();
		}

		internal static bool eNyuIp9KqtranVstq9Z(object object_0, object object_1)
		{
			return ((string)object_0).StartsWith((string)object_1);
		}

		internal static object ekHIvk9srehaCeQNKFn(object object_0, int int_0)
		{
			return ((string)object_0).Substring(int_0);
		}

		internal static bool e2SMS69I3LCZVvmJWKF(object object_0, object object_1)
		{
			return (string?)object_0 == (string?)object_1;
		}

		internal static void eO955F90veX7NuyunS2(object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
		{
			eEJNauItTVW1j8pluTb.eo2Gig6Qf((Exception)object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7);
		}
	}

	internal const string ew4GT3Vhv = "{71461f04-2faa-4bb9-a0dd-28a79101b599}";

	private const int eAWP0jj9I = 4;

	private static Hashtable ejUxAio5S;

	[DllImport("kernel32")]
	private static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	[SpecialName]
	internal static bool e9IgDZCnQ()
	{
		string text = default(string);
		bool flag = default(bool);
		try
		{
			try
			{
				text = (string)eKgee4PvqW022AUHIE(e3deXbnh1H5687boYC(eWCj1Yrd52nNSA0EPR(e6HOwJNuHCtsbUT1qg())));
				if (eldYdnmYjJoGiaYA6x(text, eDuaTU3TDhsqeVkuTG8.eulODlten(0)))
				{
					flag = true;
					return flag;
				}
				if (eldYdnmYjJoGiaYA6x(text, eDuaTU3TDhsqeVkuTG8.eulODlten(20)))
				{
					flag = true;
					return flag;
				}
			}
			catch
			{
			}
			return false;
		}
		catch (Exception object_)
		{
			eS22anxy35RL6uHjZE(object_, text, flag);
			throw;
		}
	}

	internal static void eKb3AYt8Z()
	{
		try
		{
			try
			{
				e2bgyN97C9DStahN7jR(euZRCmzOv1rIh3Ydwh(), new ResolveEventHandler(exwyp4bAY));
			}
			catch
			{
			}
		}
		catch (Exception object_)
		{
			eHqyGF99bKPvJVV1dxv(object_);
			throw;
		}
	}

	internal static Assembly exwyp4bAY(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		eAe1jMO2DJuAhYgpQt eAe1jMO2DJuAhYgpQt = default(eAe1jMO2DJuAhYgpQt);
		string text = default(string);
		string text2 = default(string);
		char[] array = default(char[]);
		string[] array2 = default(string[]);
		string text3 = default(string);
		bool flag = default(bool);
		bool flag2 = default(bool);
		int i = default(int);
		int j = default(int);
		int num = default(int);
		string text4 = default(string);
		Hashtable hashtable = default(Hashtable);
		Assembly assembly = default(Assembly);
		Stream stream = default(Stream);
		int num2 = default(int);
		byte[] array3 = default(byte[]);
		Assembly assembly2 = default(Assembly);
		string text5 = default(string);
		string text6 = default(string);
		FileStream fileStream = default(FileStream);
		try
		{
			eAe1jMO2DJuAhYgpQt = new eAe1jMO2DJuAhYgpQt((string)eowrm09kOZ0ALnNZBW8(resolveEventArgs_0));
			text = eAe1jMO2DJuAhYgpQt.e4ZIbpnTa(bool_0: false);
			text2 = (string)eGwFnn9JySdSq8Sr5Dx(e9uhEb9LWa6WuqoNes4(e86qGE9QH64ymrMgGFw(), text));
			string object_ = eDuaTU3TDhsqeVkuTG8.eulODlten(50);
			array = new char[1] { ',' };
			array2 = (string[])eLtjKS9jMyMDnQFFRGs(object_, array);
			text3 = string.Empty;
			flag = false;
			flag2 = false;
			for (i = 0; i < array2.Length - 1; i += 2)
			{
				if (eldYdnmYjJoGiaYA6x(array2[i], text2))
				{
					text3 = array2[i + 1];
					break;
				}
			}
			if (eB9jgb95EOyRF22Uj48(text3) == 0 && eB9jgb95EOyRF22Uj48(eAe1jMO2DJuAhYgpQt.eWNbTSexZ) == 0)
			{
				text2 = (string)eGwFnn9JySdSq8Sr5Dx(e9uhEb9LWa6WuqoNes4(e86qGE9QH64ymrMgGFw(), eAe1jMO2DJuAhYgpQt.eKb3AYt8Z));
				for (j = 0; j < array2.Length - 1; j += 2)
				{
					if (eldYdnmYjJoGiaYA6x(array2[j], text2))
					{
						text3 = array2[j + 1];
						break;
					}
				}
			}
			if (eB9jgb95EOyRF22Uj48(text3) > 0)
			{
				if (eXPmMX9CWeW1FuisNPg(text3, 0) == '[')
				{
					num = esa0rW9ZwLW8aa4OSi7(text3, ']');
					text4 = (string)elAtXc9gKZifgeTPldD(text3, 1, num - 1);
					flag = esa0rW9ZwLW8aa4OSi7(text4, 'z') >= 0;
					flag2 = esa0rW9ZwLW8aa4OSi7(text4, 't') >= 0;
					text3 = (string)eZNr6I92f9uovJYDRRy(text3, num + 1);
				}
				eEPbKi9iVcjso6xYOKW(hashtable = ejUxAio5S);
				try
				{
					if (e0kmgf9Eq8uaEjCdBpv(ejUxAio5S, text3))
					{
						assembly = (Assembly)eMUJIl9YXbs2E09rf0c(ejUxAio5S, text3);
						return assembly;
					}
					stream = (Stream)e5E9KL9ostXlVvMTv2o(ePXswf9fnp3DVDECaKK(), text3);
					if (stream != null)
					{
						num2 = (int)ebDcwk9XAc3nqpTanIk(stream);
						array3 = new byte[num2];
						e2eRBT966pPLdSrvslg(stream, array3, 0, num2);
						if (flag)
						{
							array3 = (byte[])eiOGpT9dilwxxwvLUKe(array3);
						}
						assembly2 = null;
						if (!flag2)
						{
							try
							{
								assembly2 = (Assembly)eFuiqb9ailDnfs3aBFi(array3);
							}
							catch (FileLoadException)
							{
								flag2 = true;
							}
							catch (BadImageFormatException)
							{
								flag2 = true;
							}
						}
						if (flag2)
						{
							try
							{
								text5 = (string)eETMuN9MXEtR2qvoxPo(eDuaTU3TDhsqeVkuTG8.eulODlten(378), eQBD4W9yxgcilC5tYnY(), text3);
								if (ePwa7HU0XwINOSoQG4())
								{
									eqoWyo9u0H38rtUT1h7(text5);
									text6 = (string)ekxDEG9boU4IpOgN4gb(text5, eAe1jMO2DJuAhYgpQt.eKb3AYt8Z, eDuaTU3TDhsqeVkuTG8.eulODlten(396));
									ePwa7HU0XwINOSoQG4();
									if (!ebXjV2lAkS16kKsHQQ() && eTRUAg9SmDjQkJRPNyF(text6))
									{
										goto IL_0269;
									}
									fileStream = (FileStream)eBxy8L9DuDYNENNXLH3(text6);
								}
								euyGGI9vaEH790lku5d(fileStream, array3, 0, array3.Length);
								do
								{
									eM17PU987IPKxVxZDvG(fileStream);
									MoveFileEx(text6, null, 4);
									MoveFileEx(text5, null, 4);
								}
								while (ebXjV2lAkS16kKsHQQ());
								goto IL_0269;
								IL_0269:
								assembly2 = (Assembly)eFosDV9wQqAPEKhLiF9(text6);
							}
							catch
							{
							}
						}
						ehZgHD948gVDnbRBose(ejUxAio5S, text3, assembly2);
						assembly = assembly2;
						return assembly;
					}
				}
				finally
				{
					eU3g3M9pelB2YOIZR8J(hashtable);
				}
			}
			return null;
		}
		catch (Exception object_2)
		{
			eh415y9VJPEUF1Cs5V6(object_2, new object[23]
			{
				eAe1jMO2DJuAhYgpQt, text, text2, array2, text3, flag, flag2, i, j, num,
				text4, stream, num2, array3, assembly2, text5, text6, fileStream, assembly, array,
				hashtable, object_0, resolveEventArgs_0
			});
			throw;
		}
	}

	public eNJYnKxVthBjlLlacd()
	{
		eACUr59TtHHMf16jetC(this);
	}

	static eNJYnKxVthBjlLlacd()
	{
		try
		{
			ejUxAio5S = new Hashtable();
		}
		catch (Exception object_)
		{
			eHqyGF99bKPvJVV1dxv(object_);
			throw;
		}
	}

	internal static object e6HOwJNuHCtsbUT1qg()
	{
		return Process.GetCurrentProcess();
	}

	internal static object eWCj1Yrd52nNSA0EPR(object object_0)
	{
		return ((Process)object_0).MainModule;
	}

	internal static object e3deXbnh1H5687boYC(object object_0)
	{
		return ((ProcessModule)object_0).ModuleName;
	}

	internal static object eKgee4PvqW022AUHIE(object object_0)
	{
		return ((string)object_0).ToLower();
	}

	internal static bool eldYdnmYjJoGiaYA6x(object object_0, object object_1)
	{
		return (string?)object_0 == (string?)object_1;
	}

	internal static void eS22anxy35RL6uHjZE(object object_0, object object_1, object object_2)
	{
		eEJNauItTVW1j8pluTb.e9jslfSvk((Exception)object_0, object_1, object_2);
	}

	internal static bool ePwa7HU0XwINOSoQG4()
	{
		return true;
	}

	internal static bool ebXjV2lAkS16kKsHQQ()
	{
		return false;
	}

	internal static object euZRCmzOv1rIh3Ydwh()
	{
		return AppDomain.CurrentDomain;
	}

	internal static void e2bgyN97C9DStahN7jR(object object_0, object object_1)
	{
		((AppDomain)object_0).AssemblyResolve += (ResolveEventHandler?)object_1;
	}

	internal static void eHqyGF99bKPvJVV1dxv(object object_0)
	{
		eEJNauItTVW1j8pluTb.eulODlten((Exception)object_0);
	}

	internal static object eowrm09kOZ0ALnNZBW8(object object_0)
	{
		return ((ResolveEventArgs)object_0).Name;
	}

	internal static object e86qGE9QH64ymrMgGFw()
	{
		return Encoding.UTF8;
	}

	internal static object e9uhEb9LWa6WuqoNes4(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetBytes((string)object_1);
	}

	internal static object eGwFnn9JySdSq8Sr5Dx(object object_0)
	{
		return Convert.ToBase64String((byte[])object_0);
	}

	internal static object eLtjKS9jMyMDnQFFRGs(object object_0, object object_1)
	{
		return ((string)object_0).Split((char[]?)object_1);
	}

	internal static int eB9jgb95EOyRF22Uj48(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static char eXPmMX9CWeW1FuisNPg(object object_0, int int_0)
	{
		return ((string)object_0)[int_0];
	}

	internal static int esa0rW9ZwLW8aa4OSi7(object object_0, char char_0)
	{
		return ((string)object_0).IndexOf(char_0);
	}

	internal static object elAtXc9gKZifgeTPldD(object object_0, int int_0, int int_1)
	{
		return ((string)object_0).Substring(int_0, int_1);
	}

	internal static object eZNr6I92f9uovJYDRRy(object object_0, int int_0)
	{
		return ((string)object_0).Substring(int_0);
	}

	internal static void eEPbKi9iVcjso6xYOKW(object object_0)
	{
		Monitor.Enter(object_0);
	}

	internal static bool e0kmgf9Eq8uaEjCdBpv(object object_0, object object_1)
	{
		return ((Hashtable)object_0).ContainsKey(object_1);
	}

	internal static object eMUJIl9YXbs2E09rf0c(object object_0, object object_1)
	{
		return ((Hashtable)object_0)[object_1];
	}

	internal static object ePXswf9fnp3DVDECaKK()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static object e5E9KL9ostXlVvMTv2o(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static long ebDcwk9XAc3nqpTanIk(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static int e2eRBT966pPLdSrvslg(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
	}

	internal static object eiOGpT9dilwxxwvLUKe(object object_0)
	{
		return eYI9awdB2K5eDrteaC.eKb3AYt8Z((byte[])object_0);
	}

	internal static object eFuiqb9ailDnfs3aBFi(object object_0)
	{
		return Assembly.Load((byte[])object_0);
	}

	internal static object eQBD4W9yxgcilC5tYnY()
	{
		return Path.GetTempPath();
	}

	internal static object eETMuN9MXEtR2qvoxPo(object object_0, object object_1, object object_2)
	{
		return string.Format((string)object_0, object_1, object_2);
	}

	internal static object eqoWyo9u0H38rtUT1h7(object object_0)
	{
		return Directory.CreateDirectory((string)object_0);
	}

	internal static object ekxDEG9boU4IpOgN4gb(object object_0, object object_1, object object_2)
	{
		return (string?)object_0 + (string?)object_1 + (string?)object_2;
	}

	internal static bool eTRUAg9SmDjQkJRPNyF(object object_0)
	{
		return File.Exists((string?)object_0);
	}

	internal static object eBxy8L9DuDYNENNXLH3(object object_0)
	{
		return File.OpenWrite((string)object_0);
	}

	internal static void euyGGI9vaEH790lku5d(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void eM17PU987IPKxVxZDvG(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static object eFosDV9wQqAPEKhLiF9(object object_0)
	{
		return Assembly.LoadFile((string)object_0);
	}

	internal static void ehZgHD948gVDnbRBose(object object_0, object object_1, object object_2)
	{
		((Hashtable)object_0)[object_1] = object_2;
	}

	internal static void eU3g3M9pelB2YOIZR8J(object object_0)
	{
		Monitor.Exit(object_0);
	}

	internal static void eh415y9VJPEUF1Cs5V6(object object_0, object object_1)
	{
		eEJNauItTVW1j8pluTb.ep2oBURlk((Exception)object_0, (object[])object_1);
	}

	internal static void eACUr59TtHHMf16jetC(object object_0)
	{
		object_0._002Ector();
	}
}
