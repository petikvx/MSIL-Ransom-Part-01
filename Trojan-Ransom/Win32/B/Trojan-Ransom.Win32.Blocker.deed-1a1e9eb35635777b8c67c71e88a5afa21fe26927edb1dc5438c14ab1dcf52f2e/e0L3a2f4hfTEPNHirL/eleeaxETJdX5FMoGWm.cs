using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;
using e1t9ZoIMs7pU1MfVBaV;
using eNrrru930ECxo7KySq;
using elRV9N3vPjJN4FNmtXC;

namespace e0L3a2f4hfTEPNHirL;

internal class eleeaxETJdX5FMoGWm
{
	private static string eKb3AYt8Z;

	private static string exwyp4bAY;

	private static byte[] e9IgDZCnQ;

	private static Hashtable eWNbTSexZ;

	private static bool ew4GT3Vhv;

	private static int eAWP0jj9I;

	public static string e4ZIbpnTa(int int_0)
	{
		string text = default(string);
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		byte[] array = default(byte[]);
		string text2 = default(string);
		string text3 = default(string);
		try
		{
			int_0 -= eAWP0jj9I;
			if (ew4GT3Vhv)
			{
				text = (string)ekWdLEQOhpX5IrwFf1j(eWNbTSexZ, int_0);
				if (text != null)
				{
					return text;
				}
			}
			num = 0;
			num2 = int_0;
			num3 = e9IgDZCnQ[num2++];
			if (((uint)num3 & 0x80u) != 0)
			{
				num = ((((uint)num3 & 0x40u) != 0) ? (((num3 & 0x1F) << 24) + (e9IgDZCnQ[num2++] << 16) + (e9IgDZCnQ[num2++] << 8) + e9IgDZCnQ[num2++]) : (((num3 & 0x3F) << 8) + e9IgDZCnQ[num2++]));
			}
			else
			{
				num = num3;
				if (num == 0)
				{
					return string.Empty;
				}
			}
			try
			{
				array = (byte[])etEBG8QehABhoQr5PYs(e1jvRbQF8839wZbX2YP(eidvkAQ36Dn7J96ILSN(), e9IgDZCnQ, num2, num));
				text2 = (string)ep5W7TQKfPg8gJBSDsa(e1jvRbQF8839wZbX2YP(eidvkAQ36Dn7J96ILSN(), array, 0, array.Length));
				if (ew4GT3Vhv)
				{
					try
					{
						eS6pwAQsfy5FiRhP9v8(eWNbTSexZ, int_0, text2);
					}
					catch
					{
					}
				}
				text3 = text2;
				return text3;
			}
			catch
			{
				text3 = null;
				return text3;
			}
		}
		catch (Exception object_)
		{
			eXBbrHQISDSaLnA645N(object_, text, num, num2, num3, array, text2, text3, int_0);
			throw;
		}
	}

	static eleeaxETJdX5FMoGWm()
	{
		Assembly assembly = default(Assembly);
		Stream stream = default(Stream);
		int num = default(int);
		byte[] array = default(byte[]);
		try
		{
			eKb3AYt8Z = eDuaTU3TDhsqeVkuTG8.eulODlten(774);
			exwyp4bAY = eDuaTU3TDhsqeVkuTG8.eulODlten(780);
			e9IgDZCnQ = null;
			eWNbTSexZ = null;
			ew4GT3Vhv = false;
			eAWP0jj9I = 0;
			if (eb7evUQ0oZV0WuGoqa2(eKb3AYt8Z, eDuaTU3TDhsqeVkuTG8.eulODlten(788)))
			{
				ew4GT3Vhv = true;
				eWNbTSexZ = new Hashtable();
			}
			eAWP0jj9I = ejdJ2sQhZTthVdq6pHV(exwyp4bAY);
			assembly = (Assembly)eXVuWwQAjhSx8BtCuG9();
			stream = (Stream)e3WCdtQBULuup98EkPS(assembly, eDuaTU3TDhsqeVkuTG8.eulODlten(794));
			try
			{
				num = eF2S4UQWndVL1hg40Yn(e2qmiYQHEv5FBkBMgO5(stream));
				array = new byte[num];
				eQT9BXQccSjq96yPlsW(stream, array, 0, num);
				_ = 1;
				if (!eRgZ3rQqYj6JdkLCKkX())
				{
					e9IgDZCnQ = (byte[])eE5lmgQUqf62FxoY3Lw(array);
					array = null;
				}
				e49WFiQlV76LxGet80k(stream);
			}
			finally
			{
				if (stream != null)
				{
					e8d6wuQNRICv1UCDk01(stream);
				}
			}
		}
		catch (Exception object_)
		{
			ebxRFLQrdMXWGjNGApl(object_, assembly, stream, num, array);
			throw;
		}
	}

	internal static object ekWdLEQOhpX5IrwFf1j(object object_0, object object_1)
	{
		return ((Hashtable)object_0)[object_1];
	}

	internal static object eidvkAQ36Dn7J96ILSN()
	{
		return Encoding.UTF8;
	}

	internal static object e1jvRbQF8839wZbX2YP(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1, int_0, int_1);
	}

	internal static object etEBG8QehABhoQr5PYs(object object_0)
	{
		return Convert.FromBase64String((string)object_0);
	}

	internal static object ep5W7TQKfPg8gJBSDsa(object object_0)
	{
		return string.Intern((string)object_0);
	}

	internal static void eS6pwAQsfy5FiRhP9v8(object object_0, object object_1, object object_2)
	{
		((Hashtable)object_0).Add(object_1, object_2);
	}

	internal static void eXBbrHQISDSaLnA645N(object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8)
	{
		eEJNauItTVW1j8pluTb.e8AuvEGCG((Exception)object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8);
	}

	internal static bool eravXFQRrf1s4IT5xj0()
	{
		return true;
	}

	internal static bool eRgZ3rQqYj6JdkLCKkX()
	{
		return false;
	}

	internal static bool eb7evUQ0oZV0WuGoqa2(object object_0, object object_1)
	{
		return (string?)object_0 == (string?)object_1;
	}

	internal static int ejdJ2sQhZTthVdq6pHV(object object_0)
	{
		return Convert.ToInt32((string?)object_0);
	}

	internal static object eXVuWwQAjhSx8BtCuG9()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static object e3WCdtQBULuup98EkPS(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static long e2qmiYQHEv5FBkBMgO5(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static int eF2S4UQWndVL1hg40Yn(long long_0)
	{
		return Convert.ToInt32(long_0);
	}

	internal static int eQT9BXQccSjq96yPlsW(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
	}

	internal static object eE5lmgQUqf62FxoY3Lw(object object_0)
	{
		return eYI9awdB2K5eDrteaC.eKb3AYt8Z((byte[])object_0);
	}

	internal static void e49WFiQlV76LxGet80k(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static void e8d6wuQNRICv1UCDk01(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static void ebxRFLQrdMXWGjNGApl(object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		eEJNauItTVW1j8pluTb.elN6Gg9Qb((Exception)object_0, object_1, object_2, object_3, object_4);
	}
}
