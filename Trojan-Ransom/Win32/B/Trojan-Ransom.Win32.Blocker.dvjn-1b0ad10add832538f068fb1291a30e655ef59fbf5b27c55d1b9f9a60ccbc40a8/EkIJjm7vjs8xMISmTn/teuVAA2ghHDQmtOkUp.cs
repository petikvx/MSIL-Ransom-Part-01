using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using BEuKK08ypvmXWsfyOl;
using NCDRxx4R49CZy0gNBsi;
using Q0ObqKLEPKsj4AfDfmw;
using T590hRLLXusZqnVEJGa;
using aAh6Vr9wVYcmlnifp3;

namespace EkIJjm7vjs8xMISmTn;

internal sealed class teuVAA2ghHDQmtOkUp
{
	private static string iPS2LtF0Lt;

	private static string jdL2MuOQMk;

	private static byte[] uNq2CalCVO;

	private static Hashtable FDI29yGVVY;

	private static bool kji26ChZTb;

	private static int i6s2cwDabZ;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[lEpXqoZe8PcTr3fc2r]
	[uB7LLmP0fagqgKxvJU]
	public static string dYB2ebULO8(int _0020)
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
			_0020 -= i6s2cwDabZ;
			if (kji26ChZTb)
			{
				text = (string)FDI29yGVVY[_0020];
				if (text != null)
				{
					return text;
				}
			}
			num = 0;
			num2 = _0020;
			num3 = uNq2CalCVO[num2++];
			if (((uint)num3 & 0x80u) != 0)
			{
				num = ((((uint)num3 & 0x40u) != 0) ? (((num3 & 0x1F) << 24) + (uNq2CalCVO[num2++] << 16) + (uNq2CalCVO[num2++] << 8) + uNq2CalCVO[num2++]) : (((num3 & 0x3F) << 8) + uNq2CalCVO[num2++]));
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
				array = Convert.FromBase64String(Encoding.UTF8.GetString(uNq2CalCVO, num2, num));
				text2 = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
				if (kji26ChZTb)
				{
					try
					{
						FDI29yGVVY.Add(_0020, text2);
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
		catch (Exception ex)
		{
			pptnOHLG0SvOsuFuFDn.sGPT8AE9Rk(ex, text, num, num2, num3, array, text2, text3, _0020);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static teuVAA2ghHDQmtOkUp()
	{
		//Discarded unreachable code: IL_00b8
		QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
		Assembly executingAssembly = default(Assembly);
		Stream manifestResourceStream = default(Stream);
		int num = default(int);
		byte[] array = default(byte[]);
		try
		{
			iPS2LtF0Lt = "1";
			jdL2MuOQMk = "83";
			uNq2CalCVO = null;
			FDI29yGVVY = null;
			kji26ChZTb = false;
			i6s2cwDabZ = 0;
			if (iPS2LtF0Lt == "1")
			{
				kji26ChZTb = true;
				FDI29yGVVY = new Hashtable();
			}
			i6s2cwDabZ = Convert.ToInt32(jdL2MuOQMk);
			executingAssembly = Assembly.GetExecutingAssembly();
			manifestResourceStream = executingAssembly.GetManifestResourceStream("{d227a43d-8dc0-4b8f-a2b7-4677c7a3fca2}");
			try
			{
				num = Convert.ToInt32(manifestResourceStream.Length);
				int num2 = 4;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 0:
							uNq2CalCVO = iLNEobLMAWsFCPIdy6S.le42X7JdfG(array);
							num2 = 2;
							break;
						case 1:
						case 5:
							manifestResourceStream.Read(array, 0, num);
							goto case 0;
						default:
							num2 = 0;
							break;
						case 4:
							array = new byte[num];
							num3 = 5;
							if (!PLefEKsMMDyWMohKW6v())
							{
								continue;
							}
							goto case 2;
						case 2:
						case 3:
							array = null;
							num2 = 6;
							break;
						case 6:
							manifestResourceStream.Close();
							return;
						}
						break;
					}
				}
			}
			finally
			{
				((IDisposable)manifestResourceStream)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			pptnOHLG0SvOsuFuFDn.xQCTA4LbeV(ex, executingAssembly, manifestResourceStream, num, array);
			throw;
		}
	}

	internal static bool vJiUQWsLAHr3dxPmmju()
	{
		return true;
	}

	internal static bool PLefEKsMMDyWMohKW6v()
	{
		return false;
	}
}
