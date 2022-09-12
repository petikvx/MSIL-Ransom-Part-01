using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using Y5Xx4QmcSB6oi5mC3f;
using yIxlhEdnrLb071mv9X;
using ypfRry07WdvpOwJeMe;

namespace dZQYBbg2BuYkQ0K79O;

internal class ARmJ7F3eZNuKLZmHTO
{
	private static object BWTOkvPA31;

	private static object x3lOXDxxe1;

	private static bool FjuO3UXl6w;

	internal static void lLHifFIsCLsZtjvFfN0i()
	{
		if (!FjuO3UXl6w)
		{
			FjuO3UXl6w = true;
			AppDomain object_ = (AppDomain)qsYMCuw0RY9jdlOvhKC();
			LNwUNGwd4GBPwUCQ2uN(object_, new ResolveEventHandler(aqoOixFOJR));
			S6OjYuwLGcexaAbll0V();
		}
	}

	private static Assembly aqoOixFOJR(object object_0, object object_1)
	{
		lock (BWTOkvPA31)
		{
			string text = (string)xHV6BwwWrMkUy8ATNhK(nI9RdCwE4G81m39QoqN(object_1));
			object obj = X6hFdcw6LY7QWlKgbZq(BWTOkvPA31, text);
			if (obj == null)
			{
				try
				{
					string text2 = (string)t2QCSswj8leKVkgoPBn(text);
					Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
					Assembly[] array = assemblies;
					foreach (Assembly assembly in array)
					{
						if (h2QGiww3WHauTpP6jTg(UGRiFUwg0GAps6Wn8jN(Pk7tkww2j80KvmpD9st(w5vuf7w4QitMgPdT5mU(assembly))), text2.ToUpper()))
						{
							return assembly;
						}
					}
				}
				catch
				{
				}
			}
			if (obj == null)
			{
				try
				{
					RSACryptoServiceProvider.UseMachineKeyStore = true;
					string text3 = (string)t2QCSswj8leKVkgoPBn(text);
					byte[] object_2 = (byte[])xKeAtywM5Rk5CmYHDHY(Encoding.Unicode, text3);
					string text4 = (string)iteTwww8L6fHmqmlvYf(vxemmYwpcQRDto4grXv(74384), Convert.ToBase64String((byte[])n4521EwOH9tbHWJ0JIX(object_2)));
					Stream manifestResourceStream = IgBKLSwGZQfShHwdfr8(xaJq9lwQaZvabTPVjkG(33554517)).Assembly.GetManifestResourceStream(text4);
					if (manifestResourceStream != null)
					{
						try
						{
							wpamenJan8gnAqcZW4.L7i5qrANpMbeFfdNum l7i5qrANpMbeFfdNum = new wpamenJan8gnAqcZW4.L7i5qrANpMbeFfdNum(manifestResourceStream);
							l7i5qrANpMbeFfdNum.KDikMXewCI().Position = 0L;
							byte[] array2 = new byte[n2hEHrwyaA5YwbIeOZZ(manifestResourceStream)];
							l7i5qrANpMbeFfdNum.IW6OB4dXEp(array2, 0, array2.Length);
							l7i5qrANpMbeFfdNum.MNFOo21gyO();
							bool flag = false;
							Assembly assembly2 = null;
							try
							{
								assembly2 = (Assembly)CaYVwQwc0VhwIRrXdU7(array2);
							}
							catch (FileLoadException)
							{
								flag = true;
							}
							catch (BadImageFormatException)
							{
								flag = true;
							}
							if (flag)
							{
								string object_3 = Path.Combine((string)PmtPGawYgymqwra27rY(), text4);
								string text5 = (string)DbZp9OweM9rSvNpvRce(object_3, text3 + (string?)vxemmYwpcQRDto4grXv(74416));
								if (!File.Exists(text5) || !HHMUk3wu3Tls834uKHA(x3lOXDxxe1, text5))
								{
									try
									{
										MyBLX9wHiENo40rq4yi(x3lOXDxxe1, text5, null);
										if (!Directory.Exists((string?)UxLVV5w5JTrv3eaX84L(text5)))
										{
											Directory.CreateDirectory((string)UxLVV5w5JTrv3eaX84L(text5));
										}
										FileStream fileStream = new FileStream(text5, FileMode.Create, FileAccess.Write);
										fileStream.Write(array2, 0, array2.Length);
										zloQ3kwJr8oY3uHxeB8(fileStream);
									}
									catch (Exception)
									{
									}
								}
								assembly2 = Assembly.LoadFile(text5);
								ajSA8NwtLrT4BKklMsc(BWTOkvPA31, text, assembly2);
							}
							else
							{
								ajSA8NwtLrT4BKklMsc(BWTOkvPA31, text, assembly2);
							}
							return assembly2;
						}
						catch (Exception)
						{
						}
					}
				}
				catch (Exception)
				{
				}
				return null;
			}
			return (Assembly)obj;
		}
	}

	private static string L95OdgeghD(object object_0)
	{
		string text = (string)xHV6BwwWrMkUy8ATNhK(object_0);
		int num = dRXCQRwsjNGsUjNK3nv(text, ',');
		if (num >= 0)
		{
			text = (string)vmnYFHwC0HPdvIGFYYX(text, 0, num);
		}
		return text;
	}

	public ARmJ7F3eZNuKLZmHTO()
	{
		YkRnNEw1EODslKQfyMM();
		base._002Ector();
	}

	static ARmJ7F3eZNuKLZmHTO()
	{
		wpamenJan8gnAqcZW4.Gx7hZE7veE();
		YkRnNEw1EODslKQfyMM();
		BWTOkvPA31 = new Hashtable();
		x3lOXDxxe1 = new Hashtable();
		FjuO3UXl6w = false;
	}

	internal static object qsYMCuw0RY9jdlOvhKC()
	{
		return AppDomain.CurrentDomain;
	}

	internal static void LNwUNGwd4GBPwUCQ2uN(object object_0, object object_1)
	{
		((AppDomain)object_0).AssemblyResolve += (ResolveEventHandler?)object_1;
	}

	internal static void S6OjYuwLGcexaAbll0V()
	{
		hND75Ts2Shq9NVqGKZ.WJCnTD6zQoDyo();
	}

	internal static object nI9RdCwE4G81m39QoqN(object object_0)
	{
		return ((ResolveEventArgs)object_0).Name;
	}

	internal static object xHV6BwwWrMkUy8ATNhK(object object_0)
	{
		return ((string)object_0).Trim();
	}

	internal static object X6hFdcw6LY7QWlKgbZq(object object_0, object object_1)
	{
		return ((Hashtable)object_0)[object_1];
	}

	internal static object t2QCSswj8leKVkgoPBn(object object_0)
	{
		return L95OdgeghD(object_0);
	}

	internal static object w5vuf7w4QitMgPdT5mU(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object Pk7tkww2j80KvmpD9st(object object_0)
	{
		return ((AssemblyName)object_0).Name;
	}

	internal static object UGRiFUwg0GAps6Wn8jN(object object_0)
	{
		return ((string)object_0).ToUpper();
	}

	internal static bool h2QGiww3WHauTpP6jTg(object object_0, object object_1)
	{
		return (string?)object_0 == (string?)object_1;
	}

	internal static object xKeAtywM5Rk5CmYHDHY(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetBytes((string)object_1);
	}

	internal static object vxemmYwpcQRDto4grXv(int int_0)
	{
		return wpamenJan8gnAqcZW4.hdMh2PA5rG(int_0);
	}

	internal static object n4521EwOH9tbHWJ0JIX(object object_0)
	{
		return wpamenJan8gnAqcZW4.rUgh7rmkpE(object_0);
	}

	internal static object iteTwww8L6fHmqmlvYf(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static RuntimeTypeHandle xaJq9lwQaZvabTPVjkG(int token)
	{
		return p5WeETibmfEdnyNk3x.fH5nTDEMOe6Ul(token);
	}

	internal static Type IgBKLSwGZQfShHwdfr8(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static long n2hEHrwyaA5YwbIeOZZ(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object CaYVwQwc0VhwIRrXdU7(object object_0)
	{
		return Assembly.Load((byte[])object_0);
	}

	internal static object PmtPGawYgymqwra27rY()
	{
		return Path.GetTempPath();
	}

	internal static object DbZp9OweM9rSvNpvRce(object object_0, object object_1)
	{
		return Path.Combine((string)object_0, (string)object_1);
	}

	internal static bool HHMUk3wu3Tls834uKHA(object object_0, object object_1)
	{
		return ((Hashtable)object_0).ContainsKey(object_1);
	}

	internal static void MyBLX9wHiENo40rq4yi(object object_0, object object_1, object object_2)
	{
		((Hashtable)object_0)[object_1] = object_2;
	}

	internal static object UxLVV5w5JTrv3eaX84L(object object_0)
	{
		return Path.GetDirectoryName((string?)object_0);
	}

	internal static void zloQ3kwJr8oY3uHxeB8(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static void ajSA8NwtLrT4BKklMsc(object object_0, object object_1, object object_2)
	{
		((Hashtable)object_0).Add(object_1, object_2);
	}

	internal static int dRXCQRwsjNGsUjNK3nv(object object_0, char char_0)
	{
		return ((string)object_0).IndexOf(char_0);
	}

	internal static object vmnYFHwC0HPdvIGFYYX(object object_0, int int_0, int int_1)
	{
		return ((string)object_0).Substring(int_0, int_1);
	}

	internal static void YkRnNEw1EODslKQfyMM()
	{
		wpamenJan8gnAqcZW4.OwGhM5ce3U();
	}
}
