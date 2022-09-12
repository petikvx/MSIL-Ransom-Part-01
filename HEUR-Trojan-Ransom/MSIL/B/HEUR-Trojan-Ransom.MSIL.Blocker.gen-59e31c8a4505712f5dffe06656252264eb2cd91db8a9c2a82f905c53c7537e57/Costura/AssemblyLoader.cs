using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using fJpF6sGRwSPY0tjIER;
using zjWSh2Z73jBs4TcJ0x;

namespace Costura;

[CompilerGenerated]
internal static class AssemblyLoader
{
	private static object nullCacheLock;

	private static Dictionary<string, bool> nullCache;

	private static Dictionary<string, string> assemblyNames;

	private static Dictionary<string, string> symbolNames;

	private static int isAttached;

	internal static AssemblyLoader YKll0IGHSK9EKYkVHnO;

	private static string CultureToString(CultureInfo culture)
	{
		while (culture == null)
		{
			if (KgN0CxGdjOfCDACeBUP() == null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			return "";
		}
		return (string)q3GbX9Gw9aloQJJ2nti(culture);
	}

	private static Assembly ReadExistingAssembly(AssemblyName name)
	{
		int num = 2;
		int num3 = default(int);
		Assembly assembly = default(Assembly);
		AssemblyName object_ = default(AssemblyName);
		while (true)
		{
			Assembly[] array = (Assembly[])dW3ojoG2SMCXVNRSJod(uQ9HkIGioKbcJDHFZgB());
			int num2 = 1;
			if (!QgPH0QGPGBo8PWvbqjT())
			{
				goto IL_0058;
			}
			goto IL_00a6;
			IL_00a6:
			while (true)
			{
				switch (num2)
				{
				case 5:
				case 9:
					if (num3 < array.Length)
					{
						goto case 7;
					}
					goto case 10;
				case 7:
					assembly = array[num3];
					num2 = 0;
					if (KgN0CxGdjOfCDACeBUP() == null)
					{
						continue;
					}
					goto default;
				default:
					object_ = (AssemblyName)iVIewQGo68GkYwdvuQO(assembly);
					goto case 6;
				case 6:
					if (!string.Equals((string?)dmnu64GTVDcKPBSILDV(object_), (string?)dmnu64GTVDcKPBSILDV(name), StringComparison.InvariantCultureIgnoreCase))
					{
						goto IL_004b;
					}
					goto case 4;
				case 3:
					num3++;
					num2 = 9;
					if (QgPH0QGPGBo8PWvbqjT())
					{
						continue;
					}
					goto case 4;
				case 4:
					if (!iU33ihGlufNE5ybIAfZ(CultureToString((CultureInfo)eIs7XxGasTkKZRqRATk(object_)), OQUrnCGv9YUagSgmxAx(eIs7XxGasTkKZRqRATk(name)), StringComparison.InvariantCultureIgnoreCase))
					{
						goto case 3;
					}
					num2 = 3;
					if (KgN0CxGdjOfCDACeBUP() != null)
					{
						continue;
					}
					goto case 8;
				case 1:
					num3 = 0;
					goto case 5;
				case 2:
					break;
				case 8:
					return assembly;
				case 10:
					return null;
				}
				break;
				IL_004b:
				num2 = 3;
				if (KgN0CxGdjOfCDACeBUP() == null)
				{
					continue;
				}
				goto IL_0058;
			}
			continue;
			IL_0058:
			num2 = num;
			goto IL_00a6;
		}
	}

	private static void CopyTo(Stream source, Stream destination)
	{
		int num = 3;
		while (true)
		{
			byte[] array = new byte[81920];
			while (true)
			{
				int count;
				if ((count = wxRwGlGAog431KTHZ2Y(source, array, 0, array.Length)) == 0)
				{
					return;
				}
				while (true)
				{
					destination.Write(array, 0, count);
					int num2 = 4;
					if (KgN0CxGdjOfCDACeBUP() != null)
					{
						num2 = num;
					}
					switch (num2)
					{
					case 2:
					case 4:
						goto end_IL_000b;
					case 3:
						goto end_IL_0048;
					case 1:
						return;
					}
					continue;
					end_IL_000b:
					break;
				}
				continue;
				end_IL_0048:
				break;
			}
		}
	}

	private static Stream LoadStream(string fullName)
	{
		int num = 3;
		Stream stream = default(Stream);
		Stream result = default(Stream);
		int num4 = default(int);
		int num7 = default(int);
		while (true)
		{
			Assembly object_ = (Assembly)Qrin5aGZk3TbCgNavVg();
			while (true)
			{
				if (dl3suHGLSdhOhcfj77p(fullName, vP9ncaGeOvgKZcT4u2I(38676)))
				{
					goto IL_000b;
				}
				int num2 = 1;
				if (KgN0CxGdjOfCDACeBUP() != null)
				{
					goto IL_0021;
				}
				goto IL_0073;
				IL_0021:
				switch (num2)
				{
				case 5:
					break;
				case 2:
					continue;
				case 3:
					goto end_IL_0055;
				default:
					goto IL_0073;
				case 4:
					try
					{
						DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
						if (!QgPH0QGPGBo8PWvbqjT())
						{
							switch (0)
							{
							}
						}
						try
						{
							MemoryStream memoryStream = new MemoryStream();
							int num3 = 0;
							if (!QgPH0QGPGBo8PWvbqjT())
							{
								goto IL_00e4;
							}
							goto IL_00f5;
							IL_00f5:
							do
							{
								IL_00f5_2:
								switch (num3)
								{
								case 3:
									P0ZUYZGgA47rF6xRJ1L(memoryStream, 0L);
									num3 = 1;
									if (KgN0CxGdjOfCDACeBUP() != null)
									{
										goto IL_00f5_2;
									}
									break;
								case 2:
									break;
								default:
									CopyTo(deflateStream, memoryStream);
									goto case 3;
								case 1:
									return result;
								}
								result = memoryStream;
								num3 = 1;
							}
							while (QgPH0QGPGBo8PWvbqjT());
							goto IL_00e4;
							IL_00e4:
							num3 = num4;
							goto IL_00f5;
						}
						finally
						{
							if (deflateStream != null)
							{
								goto IL_0134;
							}
							int num5 = 0;
							if (QgPH0QGPGBo8PWvbqjT())
							{
								goto IL_0121;
							}
							goto end_IL_010e;
							IL_0121:
							switch (num5)
							{
							default:
								goto end_IL_010e;
							case 2:
								break;
							case 0:
							case 1:
								goto end_IL_010e;
							}
							goto IL_0134;
							IL_0134:
							InsinmGVdAoGQValZAT(deflateStream);
							num5 = 1;
							if (KgN0CxGdjOfCDACeBUP() == null)
							{
								goto IL_0121;
							}
							end_IL_010e:;
						}
					}
					finally
					{
						int num6;
						if (stream != null)
						{
							num6 = 0;
							if (QgPH0QGPGBo8PWvbqjT())
							{
								goto IL_015a;
							}
							goto IL_0172;
						}
						goto end_IL_0149;
						IL_015a:
						InsinmGVdAoGQValZAT(stream);
						num6 = 1;
						if (KgN0CxGdjOfCDACeBUP() != null)
						{
							num6 = num7;
						}
						goto IL_0172;
						IL_0172:
						switch (num6)
						{
						case 1:
							goto end_IL_0149;
						}
						goto IL_015a;
						end_IL_0149:;
					}
				}
				goto IL_000b;
				IL_000b:
				stream = (Stream)aEP0QtG5t3XjVqFxiAf(object_, fullName);
				num2 = 4;
				if (KgN0CxGdjOfCDACeBUP() != null)
				{
					num2 = num;
				}
				goto IL_0021;
				IL_0073:
				return (Stream)aEP0QtG5t3XjVqFxiAf(object_, fullName);
				continue;
				end_IL_0055:
				break;
			}
		}
	}

	private static Stream LoadStream(Dictionary<string, string> resourceNames, string name)
	{
		if (resourceNames.TryGetValue(name, out var value))
		{
			return LoadStream(value);
		}
		return null;
	}

	private static byte[] ReadStream(Stream stream)
	{
		int num = 1;
		while (true)
		{
			byte[] array = new byte[pA8RnwGyM263CX0ifTp(stream)];
			int num2 = 0;
			if (!QgPH0QGPGBo8PWvbqjT())
			{
				goto IL_0026;
			}
			goto IL_002a;
			IL_002a:
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_000b;
				case 1:
					break;
				case 2:
					return array;
				}
				break;
				IL_000b:
				stream.Read(array, 0, array.Length);
				num2 = 2;
				if (QgPH0QGPGBo8PWvbqjT())
				{
					continue;
				}
				goto IL_0026;
			}
			continue;
			IL_0026:
			num2 = num;
			goto IL_002a;
		}
	}

	private static Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName)
	{
		string text = requestedAssemblyName.Name!.ToLowerInvariant();
		if (requestedAssemblyName.CultureInfo != null && !string.IsNullOrEmpty(requestedAssemblyName.CultureInfo!.Name))
		{
			text = requestedAssemblyName.CultureInfo!.Name + XaXlykERDhtdRwMnBY.oXbWkAhpNa(38702) + text;
		}
		byte[] rawAssembly;
		using (Stream stream = LoadStream(assemblyNames, text))
		{
			if (stream == null)
			{
				return null;
			}
			rawAssembly = ReadStream(stream);
		}
		using (Stream stream2 = LoadStream(symbolNames, text))
		{
			if (stream2 != null)
			{
				byte[] rawSymbolStore = ReadStream(stream2);
				return Assembly.Load(rawAssembly, rawSymbolStore);
			}
		}
		return Assembly.Load(rawAssembly);
	}

	public static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
	{
		int num = 13;
		Assembly result = default(Assembly);
		int num4 = default(int);
		int num8 = default(int);
		while (true)
		{
			object obj = nullCacheLock;
			num = 12;
			while (true)
			{
				bool lockTaken = false;
				num = 2;
				while (true)
				{
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						int num2 = 0;
						if (KgN0CxGdjOfCDACeBUP() != null)
						{
							goto IL_0037;
						}
						goto IL_004b;
						IL_004b:
						switch (num2)
						{
						case 2:
							break;
						default:
							goto IL_0037;
						case 3:
							goto end_IL_000e;
						case 1:
							return result;
						}
						goto IL_0026;
						IL_0037:
						if (nullCache.ContainsKey((string)gWuvOfG4Xc6IKdioy5R(e)))
						{
							goto IL_0026;
						}
						goto end_IL_000e;
						IL_0026:
						result = null;
						num2 = 1;
						if (KgN0CxGdjOfCDACeBUP() != null)
						{
							return result;
						}
						goto IL_004b;
						end_IL_000e:;
					}
					finally
					{
						int num3;
						if (lockTaken)
						{
							num3 = 0;
							if (KgN0CxGdjOfCDACeBUP() != null)
							{
								goto IL_0094;
							}
							goto IL_0098;
						}
						goto end_IL_006d;
						IL_0094:
						num3 = num4;
						goto IL_0098;
						IL_0098:
						while (true)
						{
							switch (num3)
							{
							case 1:
								goto end_IL_0098;
							}
							Monitor.Exit(obj);
							num3 = 1;
							if (QgPH0QGPGBo8PWvbqjT())
							{
								continue;
							}
							goto IL_0094;
							continue;
							end_IL_0098:
							break;
						}
						end_IL_006d:;
					}
					while (true)
					{
						IL_015e:
						AssemblyName assemblyName = new AssemblyName((string)gWuvOfG4Xc6IKdioy5R(e));
						while (true)
						{
							IL_0153:
							Assembly assembly = (Assembly)D1hfCQGJTHGgBSfpkaN(assemblyName);
							while (true)
							{
								if (!SAjoitG9oPKGYnxJ9hb(assembly, null))
								{
									assembly = ReadFromEmbeddedResources(assemblyNames, symbolNames, assemblyName);
									goto IL_0129;
								}
								int num5 = 11;
								if (QgPH0QGPGBo8PWvbqjT())
								{
									goto IL_00d3;
								}
								goto IL_0123;
								IL_020b:
								if ((KwccgIGmCOV6DoKPUpu(assemblyName) & AssemblyNameFlags.Retargetable) != 0)
								{
									goto IL_021a;
								}
								goto IL_0223;
								IL_021a:
								assembly = (Assembly)TWvPMEGf9RZp1GGKP5S(assemblyName);
								goto IL_0223;
								IL_0129:
								if (FObAxkG6BHxbFNbaB2H(assembly, null))
								{
									goto IL_00bd;
								}
								num5 = 10;
								if (KgN0CxGdjOfCDACeBUP() == null)
								{
									goto IL_00d3;
								}
								goto IL_0123;
								IL_0223:
								return assembly;
								IL_0123:
								num5 = num;
								goto IL_00d3;
								IL_00bd:
								obj = nullCacheLock;
								num5 = 0;
								if (QgPH0QGPGBo8PWvbqjT())
								{
									goto IL_00d3;
								}
								goto IL_0194;
								IL_00d3:
								switch (num5)
								{
								case 2:
									break;
								case 3:
									goto IL_00bd;
								case 14:
									goto IL_0129;
								case 5:
									continue;
								case 7:
									goto IL_0153;
								case 8:
									goto IL_015e;
								case 12:
									goto end_IL_000e_2;
								case 13:
									goto end_IL_0173;
								default:
									goto IL_0194;
								case 9:
									goto IL_0197;
								case 1:
									goto IL_020b;
								case 6:
									goto IL_021a;
								case 4:
								case 10:
									goto IL_0223;
								case 11:
									return assembly;
								}
								break;
								IL_0194:
								lockTaken = false;
								goto IL_0197;
								IL_0197:
								try
								{
									Monitor.Enter(obj, ref lockTaken);
									int num6 = 1;
									if (QgPH0QGPGBo8PWvbqjT())
									{
										goto IL_01ae;
									}
									goto IL_01cb;
									IL_01cb:
									switch (num6)
									{
									case 1:
										break;
									default:
										goto end_IL_0198;
									case 0:
										goto end_IL_0198;
									}
									goto IL_01ae;
									IL_01ae:
									nullCache[(string)gWuvOfG4Xc6IKdioy5R(e)] = true;
									num6 = 0;
									if (KgN0CxGdjOfCDACeBUP() != null)
									{
										goto IL_01cb;
									}
									end_IL_0198:;
								}
								finally
								{
									if (!lockTaken)
									{
										int num7 = 1;
										if (!QgPH0QGPGBo8PWvbqjT())
										{
											num7 = num8;
										}
										switch (num7)
										{
										case 1:
										case 2:
											goto end_IL_01dd;
										}
									}
									SOCCD0G1UhdMXwQ9jYa(obj);
									end_IL_01dd:;
								}
								goto IL_020b;
							}
							break;
						}
						break;
					}
					continue;
					end_IL_000e_2:
					break;
				}
				continue;
				end_IL_0173:
				break;
			}
		}
	}

	static AssemblyLoader()
	{
		Pxx2r5GSUQ7NgqkSLgO();
		zB3PVH9hASM2TtLqpf.unC5KZCzPQ9Xt();
		nullCacheLock = new object();
		nullCache = new Dictionary<string, bool>();
		assemblyNames = new Dictionary<string, string>();
		symbolNames = new Dictionary<string, string>();
		assemblyNames.Add((string)vP9ncaGeOvgKZcT4u2I(38708), (string)vP9ncaGeOvgKZcT4u2I(38726));
		assemblyNames.Add((string)vP9ncaGeOvgKZcT4u2I(38790), (string)vP9ncaGeOvgKZcT4u2I(38816));
	}

	public static void Attach()
	{
		int num = 1;
		while (true)
		{
			int num2;
			if (Interlocked.Exchange(ref isAttached, 1) != 1)
			{
				((AppDomain)uQ9HkIGioKbcJDHFZgB()).AssemblyResolve += delegate(object sender, ResolveEventArgs e)
				{
					int num3 = 13;
					Assembly result = default(Assembly);
					int num6 = default(int);
					int num10 = default(int);
					while (true)
					{
						object obj = nullCacheLock;
						num3 = 12;
						while (true)
						{
							bool lockTaken = false;
							num3 = 2;
							while (true)
							{
								try
								{
									Monitor.Enter(obj, ref lockTaken);
									int num4 = 0;
									if (KgN0CxGdjOfCDACeBUP() != null)
									{
										goto IL_0037;
									}
									goto IL_004b;
									IL_004b:
									switch (num4)
									{
									case 2:
										break;
									default:
										goto IL_0037;
									case 3:
										goto end_IL_000e;
									case 1:
										return result;
									}
									goto IL_0026;
									IL_0037:
									if (nullCache.ContainsKey((string)gWuvOfG4Xc6IKdioy5R(e)))
									{
										goto IL_0026;
									}
									goto end_IL_000e;
									IL_0026:
									result = null;
									num4 = 1;
									if (KgN0CxGdjOfCDACeBUP() != null)
									{
										return result;
									}
									goto IL_004b;
									end_IL_000e:;
								}
								finally
								{
									int num5;
									if (lockTaken)
									{
										num5 = 0;
										if (KgN0CxGdjOfCDACeBUP() != null)
										{
											goto IL_0094;
										}
										goto IL_0098;
									}
									goto end_IL_006d;
									IL_0094:
									num5 = num6;
									goto IL_0098;
									IL_0098:
									while (true)
									{
										switch (num5)
										{
										case 1:
											goto end_IL_0098;
										}
										Monitor.Exit(obj);
										num5 = 1;
										if (QgPH0QGPGBo8PWvbqjT())
										{
											continue;
										}
										goto IL_0094;
										continue;
										end_IL_0098:
										break;
									}
									end_IL_006d:;
								}
								while (true)
								{
									IL_015e:
									AssemblyName assemblyName = new AssemblyName((string)gWuvOfG4Xc6IKdioy5R(e));
									while (true)
									{
										IL_0153:
										Assembly assembly = (Assembly)D1hfCQGJTHGgBSfpkaN(assemblyName);
										while (true)
										{
											int num7;
											if (SAjoitG9oPKGYnxJ9hb(assembly, null))
											{
												num7 = 11;
												if (QgPH0QGPGBo8PWvbqjT())
												{
													goto IL_00d3;
												}
												goto IL_0123;
											}
											assembly = ReadFromEmbeddedResources(assemblyNames, symbolNames, assemblyName);
											goto IL_0129;
											IL_020b:
											if ((KwccgIGmCOV6DoKPUpu(assemblyName) & AssemblyNameFlags.Retargetable) != 0)
											{
												goto IL_021a;
											}
											goto IL_0223;
											IL_021a:
											assembly = (Assembly)TWvPMEGf9RZp1GGKP5S(assemblyName);
											goto IL_0223;
											IL_0129:
											if (FObAxkG6BHxbFNbaB2H(assembly, null))
											{
												goto IL_00bd;
											}
											num7 = 10;
											if (KgN0CxGdjOfCDACeBUP() == null)
											{
												goto IL_00d3;
											}
											goto IL_0123;
											IL_0223:
											return assembly;
											IL_0123:
											num7 = num3;
											goto IL_00d3;
											IL_00bd:
											obj = nullCacheLock;
											num7 = 0;
											if (QgPH0QGPGBo8PWvbqjT())
											{
												goto IL_00d3;
											}
											goto IL_0194;
											IL_00d3:
											switch (num7)
											{
											case 2:
												break;
											case 3:
												goto IL_00bd;
											case 14:
												goto IL_0129;
											case 5:
												continue;
											case 7:
												goto IL_0153;
											case 8:
												goto IL_015e;
											case 12:
												goto end_IL_000e_2;
											case 13:
												goto end_IL_0173;
											default:
												goto IL_0194;
											case 9:
												goto IL_0197;
											case 1:
												goto IL_020b;
											case 6:
												goto IL_021a;
											case 4:
											case 10:
												goto IL_0223;
											case 11:
												return assembly;
											}
											break;
											IL_0194:
											lockTaken = false;
											goto IL_0197;
											IL_0197:
											try
											{
												Monitor.Enter(obj, ref lockTaken);
												int num8 = 1;
												if (QgPH0QGPGBo8PWvbqjT())
												{
													goto IL_01ae;
												}
												goto IL_01cb;
												IL_01cb:
												switch (num8)
												{
												case 1:
													break;
												default:
													goto end_IL_0198;
												case 0:
													goto end_IL_0198;
												}
												goto IL_01ae;
												IL_01ae:
												nullCache[(string)gWuvOfG4Xc6IKdioy5R(e)] = true;
												num8 = 0;
												if (KgN0CxGdjOfCDACeBUP() != null)
												{
													goto IL_01cb;
												}
												end_IL_0198:;
											}
											finally
											{
												if (!lockTaken)
												{
													int num9 = 1;
													if (!QgPH0QGPGBo8PWvbqjT())
													{
														num9 = num10;
													}
													switch (num9)
													{
													case 1:
													case 2:
														goto end_IL_01dd;
													}
												}
												SOCCD0G1UhdMXwQ9jYa(obj);
												end_IL_01dd:;
											}
											goto IL_020b;
										}
										break;
									}
									break;
								}
								continue;
								end_IL_000e_2:
								break;
							}
							continue;
							end_IL_0173:
							break;
						}
					}
				};
				num2 = 2;
				if (KgN0CxGdjOfCDACeBUP() != null)
				{
					goto IL_002e;
				}
			}
			else
			{
				num2 = 0;
				if (KgN0CxGdjOfCDACeBUP() != null)
				{
					goto IL_002e;
				}
			}
			goto IL_0032;
			IL_002e:
			num2 = num;
			goto IL_0032;
			IL_0032:
			switch (num2)
			{
			default:
				return;
			case 1:
				break;
			case 0:
				return;
			case 2:
				return;
			}
		}
	}

	internal static object q3GbX9Gw9aloQJJ2nti(object object_0)
	{
		return ((CultureInfo)object_0).Name;
	}

	internal static bool QgPH0QGPGBo8PWvbqjT()
	{
		return YKll0IGHSK9EKYkVHnO == null;
	}

	internal static AssemblyLoader KgN0CxGdjOfCDACeBUP()
	{
		return YKll0IGHSK9EKYkVHnO;
	}

	internal static object uQ9HkIGioKbcJDHFZgB()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object dW3ojoG2SMCXVNRSJod(object object_0)
	{
		return ((AppDomain)object_0).GetAssemblies();
	}

	internal static object iVIewQGo68GkYwdvuQO(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object dmnu64GTVDcKPBSILDV(object object_0)
	{
		return ((AssemblyName)object_0).Name;
	}

	internal static object eIs7XxGasTkKZRqRATk(object object_0)
	{
		return ((AssemblyName)object_0).CultureInfo;
	}

	internal static object OQUrnCGv9YUagSgmxAx(object object_0)
	{
		return CultureToString((CultureInfo)object_0);
	}

	internal static bool iU33ihGlufNE5ybIAfZ(object object_0, object object_1, StringComparison stringComparison_0)
	{
		return string.Equals((string?)object_0, (string?)object_1, stringComparison_0);
	}

	internal static int wxRwGlGAog431KTHZ2Y(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
	}

	internal static object Qrin5aGZk3TbCgNavVg()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static object vP9ncaGeOvgKZcT4u2I(int int_0)
	{
		return XaXlykERDhtdRwMnBY.oXbWkAhpNa(int_0);
	}

	internal static bool dl3suHGLSdhOhcfj77p(object object_0, object object_1)
	{
		return ((string)object_0).EndsWith((string)object_1);
	}

	internal static object aEP0QtG5t3XjVqFxiAf(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static void P0ZUYZGgA47rF6xRJ1L(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static void InsinmGVdAoGQValZAT(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static long pA8RnwGyM263CX0ifTp(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object gWuvOfG4Xc6IKdioy5R(object object_0)
	{
		return ((ResolveEventArgs)object_0).Name;
	}

	internal static object D1hfCQGJTHGgBSfpkaN(object object_0)
	{
		return ReadExistingAssembly((AssemblyName)object_0);
	}

	internal static bool SAjoitG9oPKGYnxJ9hb(object object_0, object object_1)
	{
		return (Assembly?)object_0 != (Assembly?)object_1;
	}

	internal static bool FObAxkG6BHxbFNbaB2H(object object_0, object object_1)
	{
		return (Assembly?)object_0 == (Assembly?)object_1;
	}

	internal static void SOCCD0G1UhdMXwQ9jYa(object object_0)
	{
		Monitor.Exit(object_0);
	}

	internal static AssemblyNameFlags KwccgIGmCOV6DoKPUpu(object object_0)
	{
		return ((AssemblyName)object_0).Flags;
	}

	internal static object TWvPMEGf9RZp1GGKP5S(object object_0)
	{
		return Assembly.Load((AssemblyName)object_0);
	}

	internal static void Pxx2r5GSUQ7NgqkSLgO()
	{
		XaXlykERDhtdRwMnBY.jXRWMU6APG();
	}
}
