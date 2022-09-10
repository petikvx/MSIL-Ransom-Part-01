using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using NCDRxx4R49CZy0gNBsi;
using Q0ObqKLEPKsj4AfDfmw;
using T590hRLLXusZqnVEJGa;

namespace hDH06PANDZ3vVNuojk;

internal sealed class F4KdFmhRxpY9xQlK4n
{
	internal struct cNHCkc5yarclZP0AqF
	{
		public string a692bdbjOQ;

		public Version MCP24gAXP9;

		public string iND2nU5VPV;

		public string qir2EJQxmU;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string Ln72phimOy(bool _0020)
		{
			//Discarded unreachable code: IL_006c
			StringBuilder stringBuilder = default(StringBuilder);
			try
			{
				stringBuilder = new StringBuilder();
				stringBuilder.Append(a692bdbjOQ);
				int num = 1;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 4:
							if (MCP24gAXP9 != null)
							{
								num = 8;
								break;
							}
							goto case 6;
						case 2:
						case 8:
							stringBuilder.Append(", Version=");
							num = 3;
							break;
						case 3:
							stringBuilder.Append(MCP24gAXP9);
							goto case 6;
						default:
							num2 = 6;
							if (true)
							{
								continue;
							}
							goto case 7;
						case 7:
							stringBuilder.Append((qir2EJQxmU.Length == 0) ? "null" : qir2EJQxmU);
							num = 10;
							break;
						case 6:
							stringBuilder.Append(", Culture=");
							num2 = 9;
							if (0 == 0)
							{
								continue;
							}
							goto case 5;
						case 5:
						case 9:
							stringBuilder.Append((iND2nU5VPV.Length == 0) ? "neutral" : iND2nU5VPV);
							num = 0;
							break;
						case 1:
							if (_0020)
							{
								num = 4;
								break;
							}
							goto case 6;
						case 0:
							stringBuilder.Append(", PublicKeyToken=");
							num = 7;
							break;
						case 10:
							return stringBuilder.ToString();
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				pptnOHLG0SvOsuFuFDn.jkGTHB4T3E(ex, stringBuilder, this, _0020);
				throw;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public cNHCkc5yarclZP0AqF(string _0020)
		{
			//Discarded unreachable code: IL_00ef
			QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
			int num2 = default(int);
			string text = default(string);
			char[] array2 = default(char[]);
			string[] array = default(string[]);
			string text2 = default(string);
			try
			{
				MCP24gAXP9 = null;
				int num = 12;
				if (!maXCSTeptgeGE7mXI5())
				{
				}
				while (true)
				{
					int num3;
					switch (num)
					{
					case 6:
						num2 = 0;
						num = 5;
						if (true)
						{
							break;
						}
						goto case 1;
					case 1:
						if (iND2nU5VPV == "neutral")
						{
							num = 17;
							break;
						}
						goto case 2;
					case 8:
						iND2nU5VPV = text.Substring(8);
						num = 1;
						if (dShmdVarQSNg6LA2nI())
						{
							break;
						}
						goto case 17;
					case 17:
						iND2nU5VPV = string.Empty;
						num3 = 2;
						goto IL_00f8;
					case 3:
						array2 = new char[1] { ',' };
						array = _0020.Split(array2);
						num = 6;
						if (!maXCSTeptgeGE7mXI5())
						{
							break;
						}
						goto case 2;
					case 2:
					case 11:
					case 13:
					case 20:
						num2++;
						num3 = 21;
						goto IL_00f8;
					case 16:
					case 19:
						qir2EJQxmU = string.Empty;
						num3 = 11;
						goto IL_00f8;
					default:
						num = 8;
						if (!maXCSTeptgeGE7mXI5())
						{
							break;
						}
						goto case 2;
					case 4:
					case 14:
						qir2EJQxmU = text.Substring(15);
						num3 = 7;
						goto IL_00f8;
					case 7:
						if (qir2EJQxmU == "null")
						{
							num = 19;
							if (maXCSTeptgeGE7mXI5())
							{
							}
							break;
						}
						goto case 2;
					case 18:
						if (!text.StartsWith("Version="))
						{
							if (text.StartsWith("Culture="))
							{
								goto case 8;
							}
							if (!text.StartsWith("PublicKeyToken="))
							{
								a692bdbjOQ = text;
								num = 13;
								if (!maXCSTeptgeGE7mXI5())
								{
									break;
								}
								goto case 4;
							}
							num3 = 4;
							goto IL_00f8;
						}
						num = 9;
						if (true)
						{
							break;
						}
						goto case 15;
					case 15:
						text = text2.Trim();
						num3 = 18;
						goto IL_00f8;
					case 10:
						qir2EJQxmU = string.Empty;
						num3 = 0;
						goto IL_00f8;
					case 0:
						a692bdbjOQ = string.Empty;
						num = 3;
						break;
					case 12:
						iND2nU5VPV = string.Empty;
						num = 10;
						if (maXCSTeptgeGE7mXI5())
						{
						}
						break;
					case 9:
						MCP24gAXP9 = new Version(text.Substring(8));
						num = 20;
						if (dShmdVarQSNg6LA2nI())
						{
							break;
						}
						goto case 5;
					case 5:
					case 21:
						{
							if (num2 < array.Length)
							{
								text2 = array[num2];
								num = 15;
								if (dShmdVarQSNg6LA2nI())
								{
									break;
								}
								goto case 12;
							}
							return;
						}
						IL_00f8:
						num = num3;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				pptnOHLG0SvOsuFuFDn.e0gTOTVlr6(ex, text2, text, array2, array, num2, this, _0020);
				throw;
			}
		}

		internal static bool dShmdVarQSNg6LA2nI()
		{
			return true;
		}

		internal static bool maXCSTeptgeGE7mXI5()
		{
			return false;
		}
	}

	private static Hashtable jpk2S3nrRf;

	[DllImport("kernel32", EntryPoint = "MoveFileEx")]
	private static extern bool Oam2UPuFUu(string _0020, string _0020, int _0020);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	internal static bool v772vhPoSQ()
	{
		string text = default(string);
		bool flag = default(bool);
		try
		{
			try
			{
				text = Process.GetCurrentProcess().MainModule!.ModuleName!.ToLower();
				if (text == "w3wp.exe")
				{
					flag = true;
					return flag;
				}
				if (text == "aspnet_wp.exe")
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
		catch (Exception ex)
		{
			pptnOHLG0SvOsuFuFDn.v3OTTS85dg(ex, text, flag);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void j552xDlOht()
	{
		try
		{
			try
			{
				AppDomain.CurrentDomain.AssemblyResolve += VKC2sE8JYf;
			}
			catch
			{
			}
		}
		catch (Exception ex)
		{
			pptnOHLG0SvOsuFuFDn.i0gTDRVccZ(ex);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Assembly VKC2sE8JYf(object _0020, object _0020)
	{
		//Discarded unreachable code: IL_022e
		cNHCkc5yarclZP0AqF cNHCkc5yarclZP0AqF = default(cNHCkc5yarclZP0AqF);
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
		Stream manifestResourceStream = default(Stream);
		int num2 = default(int);
		byte[] array3 = default(byte[]);
		Assembly assembly2 = default(Assembly);
		string text5 = default(string);
		FileStream fileStream = default(FileStream);
		string text6 = default(string);
		try
		{
			cNHCkc5yarclZP0AqF = new cNHCkc5yarclZP0AqF(((ResolveEventArgs)_0020).Name);
			text = cNHCkc5yarclZP0AqF.Ln72phimOy(_0020: false);
			text2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
			array = new char[1] { ',' };
			array2 = "ezRlMDgzMjcxLWUyZjMtNGZjZC05Y2Q0LTE2NTUyNzA5ZTczNn0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{36b0e2af-095b-46d3-9f52-297e5b9de82a},ezRlMDgzMjcxLWUyZjMtNGZjZC05Y2Q0LTE2NTUyNzA5ZTczNn0=,[z]{36b0e2af-095b-46d3-9f52-297e5b9de82a}".Split(array);
			text3 = string.Empty;
			flag = false;
			flag2 = false;
			for (i = 0; i < array2.Length - 1; i += 2)
			{
				if (array2[i] == text2)
				{
					text3 = array2[i + 1];
					break;
				}
			}
			if (text3.Length == 0 && cNHCkc5yarclZP0AqF.qir2EJQxmU.Length == 0)
			{
				text2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(cNHCkc5yarclZP0AqF.a692bdbjOQ));
				for (j = 0; j < array2.Length - 1; j += 2)
				{
					if (array2[j] == text2)
					{
						text3 = array2[j + 1];
						break;
					}
				}
			}
			if (text3.Length > 0)
			{
				if (text3[0] == '[')
				{
					num = text3.IndexOf(']');
					text4 = text3.Substring(1, num - 1);
					flag = text4.IndexOf('z') >= 0;
					flag2 = text4.IndexOf('t') >= 0;
					text3 = text3.Substring(num + 1);
				}
				Monitor.Enter(hashtable = jpk2S3nrRf);
				try
				{
					if (jpk2S3nrRf.ContainsKey(text3))
					{
						assembly = (Assembly)jpk2S3nrRf[text3];
						return assembly;
					}
					manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text3);
					if (manifestResourceStream != null)
					{
						num2 = (int)manifestResourceStream.Length;
						array3 = new byte[num2];
						manifestResourceStream.Read(array3, 0, num2);
						if (flag)
						{
							array3 = iLNEobLMAWsFCPIdy6S.le42X7JdfG(array3);
						}
						assembly2 = null;
						if (!flag2)
						{
							try
							{
								assembly2 = Assembly.Load(array3);
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
								text5 = $"{Path.GetTempPath()}{text3}\\";
								int num3 = 5;
								while (true)
								{
									IL_0237:
									int num4 = num3;
									while (true)
									{
										switch (num4)
										{
										case 3:
											fileStream = File.OpenWrite(text6);
											goto case 1;
										default:
											num3 = 1;
											break;
										case 7:
										case 9:
											Oam2UPuFUu(text5, null, 4);
											num3 = 10;
											break;
										case 6:
											fileStream.Close();
											num3 = 8;
											break;
										case 8:
											Oam2UPuFUu(text6, null, 4);
											num4 = 9;
											if (true)
											{
												continue;
											}
											goto case 1;
										case 1:
										case 4:
											fileStream.Write(array3, 0, array3.Length);
											num3 = 6;
											break;
										case 5:
											Directory.CreateDirectory(text5);
											num3 = 2;
											break;
										case 0:
											if (!File.Exists(text6))
											{
												num3 = 3;
												break;
											}
											goto case 10;
										case 2:
											text6 = text5 + cNHCkc5yarclZP0AqF.a692bdbjOQ + ".dll";
											num3 = 0;
											break;
										case 10:
											assembly2 = Assembly.LoadFile(text6);
											goto end_IL_023b;
										}
										goto IL_0237;
										continue;
										end_IL_023b:
										break;
									}
									break;
								}
							}
							catch
							{
							}
						}
						jpk2S3nrRf[text3] = assembly2;
						assembly = assembly2;
						return assembly;
					}
				}
				finally
				{
					Monitor.Exit(hashtable);
				}
			}
			return null;
		}
		catch (Exception ex3)
		{
			pptnOHLG0SvOsuFuFDn.a2lT3DCOgr(ex3, new object[23]
			{
				cNHCkc5yarclZP0AqF, text, text2, array2, text3, flag, flag2, i, j, num,
				text4, manifestResourceStream, num2, array3, assembly2, text5, text6, fileStream, assembly, array,
				hashtable, _0020, _0020
			});
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public F4KdFmhRxpY9xQlK4n()
	{
		QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static F4KdFmhRxpY9xQlK4n()
	{
		QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
		try
		{
			jpk2S3nrRf = new Hashtable();
		}
		catch (Exception ex)
		{
			pptnOHLG0SvOsuFuFDn.i0gTDRVccZ(ex);
			throw;
		}
	}

	internal static bool DC8tkprHXDmwHwO6CG()
	{
		return true;
	}

	internal static bool MLJykCdQA8WDWh0rRJ()
	{
		return false;
	}
}
