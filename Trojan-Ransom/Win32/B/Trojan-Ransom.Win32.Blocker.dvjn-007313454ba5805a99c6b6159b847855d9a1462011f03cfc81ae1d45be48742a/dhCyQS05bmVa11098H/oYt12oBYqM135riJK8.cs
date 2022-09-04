using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using wJDjjyMYp3BjGdXkEiH;

namespace dhCyQS05bmVa11098H;

internal sealed class oYt12oBYqM135riJK8
{
	internal struct ntHqAYZY1yZQfZ3o9c
	{
		public string KgUYEtKON1;

		public Version CtmYaGRGss;

		public string UbtYB8mtk6;

		public string pXlY0R9aSV;

		public string njrYo1eq8R(bool bool_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(KgUYEtKON1);
			if (bool_0 && CtmYaGRGss != null)
			{
				stringBuilder.Append(", Version=");
				stringBuilder.Append(CtmYaGRGss);
			}
			stringBuilder.Append(", Culture=");
			stringBuilder.Append((UbtYB8mtk6.Length == 0) ? "neutral" : UbtYB8mtk6);
			stringBuilder.Append(", PublicKeyToken=");
			stringBuilder.Append((pXlY0R9aSV.Length == 0) ? "null" : pXlY0R9aSV);
			return stringBuilder.ToString();
		}

		public ntHqAYZY1yZQfZ3o9c(string string_0)
		{
			CtmYaGRGss = null;
			while (true)
			{
				UbtYB8mtk6 = string.Empty;
				pXlY0R9aSV = string.Empty;
				while (true)
				{
					KgUYEtKON1 = string.Empty;
					while (true)
					{
						string[] array = string_0.Split(new char[1] { ',' });
						while (true)
						{
							IL_012a:
							int num = 0;
							while (true)
							{
								IL_011f:
								if (num >= array.Length)
								{
									return;
								}
								string text = array[num];
								string text2 = text.Trim();
								if (text2.StartsWith("Version="))
								{
									goto IL_00b5;
								}
								if (text2.StartsWith("Culture="))
								{
									goto IL_00e8;
								}
								if (text2.StartsWith("PublicKeyToken="))
								{
									while (true)
									{
										pXlY0R9aSV = text2.Substring(15);
										if (!COIZqNaWUSdcH1Hy3R())
										{
											break;
										}
										switch (13)
										{
										case 8:
											break;
										case 2:
											goto IL_00b5;
										case 13:
											if (pXlY0R9aSV == "null")
											{
												goto case 5;
											}
											goto IL_011b;
										case 5:
											pXlY0R9aSV = string.Empty;
											goto IL_011b;
										case 14:
											goto IL_00e8;
										default:
											goto IL_00f5;
										case 0:
										case 6:
										case 7:
										case 11:
										case 12:
											goto IL_011b;
										case 1:
										case 4:
										case 17:
											goto IL_011f;
										case 10:
											goto IL_012a;
										case 3:
											goto end_IL_0049;
										case 15:
											goto end_IL_012f;
										case 16:
											goto end_IL_0145;
										}
										continue;
										end_IL_0049:
										break;
									}
									break;
								}
								KgUYEtKON1 = text2;
								goto IL_011b;
								IL_00b5:
								CtmYaGRGss = new Version(text2.Substring(8));
								goto IL_011b;
								IL_00e8:
								UbtYB8mtk6 = text2.Substring(8);
								goto IL_00f5;
								IL_00f5:
								if (UbtYB8mtk6 == "neutral")
								{
									UbtYB8mtk6 = string.Empty;
								}
								goto IL_011b;
								IL_011b:
								num++;
							}
							break;
						}
						continue;
						end_IL_012f:
						break;
					}
					continue;
					end_IL_0145:
					break;
				}
			}
		}

		internal static bool COIZqNaWUSdcH1Hy3R()
		{
			return true;
		}

		internal static bool B4KnmQSAoQm13nqUGA()
		{
			return false;
		}
	}

	private static Hashtable flXY6uC0se = new Hashtable();

	[DllImport("kernel32")]
	private static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	[SpecialName]
	internal static bool X6oYqmFIac()
	{
		bool result;
		try
		{
			string text = Process.GetCurrentProcess().MainModule!.ModuleName!.ToLower();
			if (text == "w3wp.exe")
			{
				result = true;
			}
			else
			{
				if (!(text == "aspnet_wp.exe"))
				{
					goto IL_003c;
				}
				result = true;
			}
		}
		catch
		{
			goto IL_003c;
		}
		return result;
		IL_003c:
		return false;
	}

	internal static void QatYjc8MIg()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += zbgYCXZC0o;
		}
		catch
		{
		}
	}

	internal static Assembly zbgYCXZC0o(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		ntHqAYZY1yZQfZ3o9c ntHqAYZY1yZQfZ3o9c = new ntHqAYZY1yZQfZ3o9c(resolveEventArgs_0.Name);
		string s = ntHqAYZY1yZQfZ3o9c.njrYo1eq8R(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "e2JmNzNjNjEyLWI1NzctNGFjMC04OGVjLTU4MDdmYWU4YzMwMH0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{1ec6fd00-3a63-43b0-a1aa-3466dc84cd92},e2JmNzNjNjEyLWI1NzctNGFjMC04OGVjLTU4MDdmYWU4YzMwMH0=,[z]{1ec6fd00-3a63-43b0-a1aa-3466dc84cd92}".Split(new char[1] { ',' });
		string text2 = string.Empty;
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < array.Length - 1; i += 2)
		{
			if (array[i] == text)
			{
				text2 = array[i + 1];
				break;
			}
		}
		if (text2.Length == 0 && ntHqAYZY1yZQfZ3o9c.pXlY0R9aSV.Length == 0)
		{
			text = Convert.ToBase64String(Encoding.UTF8.GetBytes(ntHqAYZY1yZQfZ3o9c.KgUYEtKON1));
			for (int j = 0; j < array.Length - 1; j += 2)
			{
				if (array[j] == text)
				{
					text2 = array[j + 1];
					break;
				}
			}
		}
		if (text2.Length > 0)
		{
			if (text2[0] == '[')
			{
				int num = text2.IndexOf(']');
				string text3 = text2.Substring(1, num - 1);
				flag = text3.IndexOf('z') >= 0;
				flag2 = text3.IndexOf('t') >= 0;
				text2 = text2.Substring(num + 1);
			}
			Assembly result;
			lock (flXY6uC0se)
			{
				if (flXY6uC0se.ContainsKey(text2))
				{
					result = (Assembly)flXY6uC0se[text2];
				}
				else
				{
					Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
					if (manifestResourceStream == null)
					{
						goto IL_02c0;
					}
					int num2 = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[num2];
					manifestResourceStream.Read(array2, 0, num2);
					if (flag)
					{
						array2 = Xt0rZtMMyc257ciMNOG.M9AuJbZsh2(array2);
					}
					Assembly assembly = null;
					if (!flag2)
					{
						try
						{
							assembly = Assembly.Load(array2);
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
							string text4 = $"{Path.GetTempPath()}{text2}\\";
							int num3 = 0;
							if (YDFlZGrrM667uTLMfj())
							{
								goto IL_021e;
							}
							goto IL_0228;
							IL_0228:
							switch (num3)
							{
							case 1:
							case 3:
								break;
							case 2:
								goto IL_0207;
							case 0:
								goto IL_021e;
							case 8:
								goto IL_025c;
							default:
								goto IL_0265;
							case 9:
								goto IL_0273;
							case 5:
								goto IL_027a;
							case 6:
								goto IL_0284;
							case 10:
								goto IL_028e;
							}
							goto IL_01f2;
							IL_021e:
							Directory.CreateDirectory(text4);
							goto IL_01f2;
							IL_01f2:
							string text5 = text4 + ntHqAYZY1yZQfZ3o9c.KgUYEtKON1 + ".dll";
							goto IL_0207;
							IL_0207:
							if (!File.Exists(text5))
							{
								num3 = 8;
								if (IL2EyrTNJpC33WemNV())
								{
									goto IL_0228;
								}
								goto IL_025c;
							}
							goto IL_028e;
							IL_028e:
							assembly = Assembly.LoadFile(text5);
							goto end_IL_01d0;
							IL_025c:
							FileStream fileStream = File.OpenWrite(text5);
							goto IL_0265;
							IL_0265:
							fileStream.Write(array2, 0, array2.Length);
							goto IL_0273;
							IL_0273:
							fileStream.Close();
							goto IL_027a;
							IL_027a:
							MoveFileEx(text5, null, 4);
							goto IL_0284;
							IL_0284:
							MoveFileEx(text4, null, 4);
							goto IL_028e;
							end_IL_01d0:;
						}
						catch
						{
						}
					}
					flXY6uC0se[text2] = assembly;
					result = assembly;
				}
			}
			return result;
		}
		goto IL_02c0;
		IL_02c0:
		return null;
	}

	internal static bool IL2EyrTNJpC33WemNV()
	{
		return true;
	}

	internal static bool YDFlZGrrM667uTLMfj()
	{
		return false;
	}
}
