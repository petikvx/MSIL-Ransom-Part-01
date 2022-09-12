using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using Kr3jVfRSxQNwo1ILQG;
using fJpF6sGRwSPY0tjIER;
using kkAEHaj9gSo0R5GEKh;
using zjWSh2Z73jBs4TcJ0x;

namespace tSe1CRpiF15bxG3WUA;

internal class ufdDVdCNkhDWde66wH
{
	private object kfvWngeQM1;

	private object cXiWccAbVt;

	internal static object B7V7h6DVHAeDQi0HapT;

	public ufdDVdCNkhDWde66wH()
	{
		a0Ml98DJY1BMfRwss52();
		zB3PVH9hASM2TtLqpf.unC5KZCzPQ9Xt();
		base._002Ector();
		cXiWccAbVt = P7xW1ToH6Q();
	}

	public void DgDWsIWRea()
	{
		int num = 1;
		while (true)
		{
			kfvWngeQM1 = new Timer(delegate
			{
				while (true)
				{
					nYiWaT3mLB();
					if (id7ED5DyHkBoYJPWH2A())
					{
						break;
					}
					switch (0)
					{
					case 1:
						break;
					default:
						return;
					case 0:
						return;
					}
				}
			}, null, 5000, -1);
			int num2 = 0;
			if (jHk2UKD4rLwr1ngo004() != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				break;
			default:
				return;
			case 0:
				return;
			}
		}
	}

	private void nYiWaT3mLB()
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		while (true)
		{
			((Timer)kfvWngeQM1).Dispose();
			num = 2;
			while (true)
			{
				IL_0073:
				bool flag = !ReWs9mD9elWD7cQ0ToV(P7xW1ToH6Q(), cXiWccAbVt);
				int num2 = 1;
				if (id7ED5DyHkBoYJPWH2A())
				{
					goto IL_002d;
				}
				goto IL_0040;
				IL_0040:
				while (true)
				{
					switch (num2)
					{
					case 6:
					case 9:
						break;
					case 1:
						goto end_IL_0040;
					case 2:
						goto IL_0073;
					case 3:
						goto end_IL_0073;
					default:
						goto IL_00ae;
					case 7:
						goto IL_00b4;
					case 8:
						goto IL_00cc;
					case 4:
					case 10:
						goto IL_00d6;
					case 5:
						return;
					}
					cXiWccAbVt = P7xW1ToH6Q();
					num2 = 4;
					if (jHk2UKD4rLwr1ngo004() == null)
					{
						continue;
					}
					goto IL_0027;
					continue;
					end_IL_0040:
					break;
				}
				goto IL_002d;
				IL_002d:
				if (!flag)
				{
					num2 = 6;
					if (jHk2UKD4rLwr1ngo004() != null)
					{
						goto IL_0027;
					}
					goto IL_0040;
				}
				goto IL_00ae;
				IL_0027:
				num2 = num;
				goto IL_0040;
				IL_00ae:
				PSBsMOAwNSnspvxvRf.WJklRgc2pV = true;
				goto IL_00b4;
				IL_00b4:
				PmwxMoD18dKpdJU419j(SRV3pdD6oidFOBKQiku(38484), PUaN1Tc5YiXwAk2vvB.nvgNVCmTwD, (MessageBoxButton)0, (MessageBoxImage)16);
				goto IL_00cc;
				IL_00cc:
				QV9Y3qDfwbbEuDHwDTH(HqWV86DmQ7f1gojJkJx());
				goto IL_00d6;
				IL_00d6:
				kfvWngeQM1 = new Timer(delegate
				{
					while (true)
					{
						nYiWaT3mLB();
						if (!id7ED5DyHkBoYJPWH2A())
						{
							break;
						}
						switch (0)
						{
						case 1:
							break;
						default:
							return;
						case 0:
							return;
						}
					}
				}, null, 5000, -1);
				return;
				continue;
				end_IL_0073:
				break;
			}
		}
	}

	public static IPAddress nuUWAtilpu()
	{
		int num = 2;
		while (true)
		{
			IPAddress result = (from a in (from n in (IEnumerable<NetworkInterface>)CiD95SDS1yeD7rRimsw()
					where _003C_003Ec.bnpVeWGWQ7y91B5viKs(n) == OperationalStatus.Up
					where _003C_003Ec.uHODT5GrhQiWGhgPM7N(n) != NetworkInterfaceType.Loopback
					select n).SelectMany((NetworkInterface n) => n.GetIPProperties()?.GatewayAddresses).Select(delegate(GatewayIPAddressInformation g)
				{
					int num3 = 2;
					object result2;
					while (true)
					{
						if (g != null)
						{
							int num4 = 1;
							if (!_003C_003Ec.vKM6xrDuQlXNFVfjLAP())
							{
								num4 = num3;
							}
							switch (num4)
							{
							case 2:
								break;
							case 1:
								goto IL_0034;
							default:
								goto IL_003c;
							}
							continue;
						}
						goto IL_003c;
						IL_0034:
						result2 = _003C_003Ec.y5F7K8GhqgyKvIXB2HR(g);
						break;
						IL_003c:
						result2 = null;
						break;
					}
					return (IPAddress)result2;
				})
				where a != null
				select a).FirstOrDefault();
			int num2 = 1;
			if (!id7ED5DyHkBoYJPWH2A())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 2:
				continue;
			}
			return result;
		}
	}

	private string EnMWjiUY4C()
	{
		int num = 5;
		Process process = default(Process);
		int num4 = default(int);
		int num6 = default(int);
		int num8 = default(int);
		string result = default(string);
		while (true)
		{
			string text = (string)t7aIaGDnmO4mL7SBq3x(fOyJTgDRe0IVAt97veR());
			while (true)
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				int num2 = 9;
				if (jHk2UKD4rLwr1ngo004() != null)
				{
					goto IL_0033;
				}
				goto IL_0084;
				IL_0084:
				while (true)
				{
					switch (num2)
					{
					case 9:
						break;
					case 8:
						A2kaO3DQYwCm2tk84FX(processStartInfo, bool_0: true);
						num2 = 7;
						if (jHk2UKD4rLwr1ngo004() == null)
						{
							continue;
						}
						goto IL_0033;
					case 2:
						JBwMm6DxFTmdKHxJfxv(processStartInfo, bool_0: true);
						goto case 8;
					case 1:
						VvG4xrDcy63RJfGB0J3(processStartInfo, bool_0: false);
						goto case 2;
					default:
						processStartInfo.Arguments = (string)SRV3pdD6oidFOBKQiku(38616);
						num2 = 1;
						if (jHk2UKD4rLwr1ngo004() == null)
						{
							continue;
						}
						goto case 1;
					case 4:
						goto end_IL_0084;
					case 5:
						goto end_IL_00b3;
					case 7:
						process = (Process)JnuDcPD8Jd794oqAfgT(processStartInfo);
						num = 6;
						goto case 6;
					case 6:
						try
						{
							StreamReader streamReader = (StreamReader)A8DHr0DpFBfBuFOZIKs(process);
							int num3 = 0;
							if (!id7ED5DyHkBoYJPWH2A())
							{
								num3 = num4;
							}
							switch (num3)
							{
							default:
								try
								{
									result = (string)Rw0vFCDCvVQ10O3VTdP(streamReader);
									if (jHk2UKD4rLwr1ngo004() == null)
									{
										return 0 switch
										{
											_ => result, 
										};
									}
									return result;
								}
								finally
								{
									int num5;
									if (streamReader != null)
									{
										num5 = 1;
										if (jHk2UKD4rLwr1ngo004() != null)
										{
											goto IL_015b;
										}
										goto IL_015f;
									}
									goto end_IL_0134;
									IL_015b:
									num5 = num6;
									goto IL_015f;
									IL_015f:
									while (true)
									{
										switch (num5)
										{
										case 1:
											break;
										default:
											goto end_IL_015f;
										}
										((IDisposable)streamReader).Dispose();
										num5 = 0;
										if (jHk2UKD4rLwr1ngo004() == null)
										{
											continue;
										}
										goto IL_015b;
										continue;
										end_IL_015f:
										break;
									}
									end_IL_0134:;
								}
							}
						}
						finally
						{
							int num7;
							if (process != null)
							{
								num7 = 1;
								if (jHk2UKD4rLwr1ngo004() != null)
								{
									goto IL_0194;
								}
								goto IL_0198;
							}
							goto end_IL_016d;
							IL_0194:
							num7 = num8;
							goto IL_0198;
							IL_0198:
							while (true)
							{
								switch (num7)
								{
								case 1:
									break;
								default:
									goto end_IL_0198;
								}
								LSHjOQD3HcBJFofu6vt(process);
								num7 = 0;
								if (id7ED5DyHkBoYJPWH2A())
								{
									continue;
								}
								goto IL_0194;
								continue;
								end_IL_0198:
								break;
							}
							end_IL_016d:;
						}
					case 3:
						return result;
					}
					L5gushDNxtA1vLqS9Il(processStartInfo, text + (string?)SRV3pdD6oidFOBKQiku(38564));
					num2 = 0;
					if (jHk2UKD4rLwr1ngo004() == null)
					{
						continue;
					}
					goto IL_0033;
					continue;
					end_IL_0084:
					break;
				}
				continue;
				IL_0033:
				num2 = num;
				goto IL_0084;
				continue;
				end_IL_00b3:
				break;
			}
		}
	}

	private string P7xW1ToH6Q()
	{
		string result = default(string);
		Regex object_2 = default(Regex);
		Match object_3 = default(Match);
		while (true)
		{
			string object_ = nuUWAtilpu().ToString();
			while (true)
			{
				string pattern = (string)cUALjsDshWJY0bPHKSP(SRV3pdD6oidFOBKQiku(38624), object_);
				int num = 0;
				if (jHk2UKD4rLwr1ngo004() == null)
				{
					goto IL_0003;
				}
				goto IL_0018;
				IL_0018:
				switch (num)
				{
				case 1:
					break;
				case 4:
					continue;
				case 5:
					goto end_IL_003b;
				default:
					goto IL_006c;
				case 3:
					goto IL_007b;
				case 2:
				case 6:
					return result;
				}
				goto IL_0003;
				IL_0003:
				object_2 = new Regex(pattern);
				num = 0;
				if (id7ED5DyHkBoYJPWH2A())
				{
					goto IL_0018;
				}
				goto IL_006c;
				IL_006c:
				object_3 = (Match)LtWlOtDUFG574AOoktm(object_2, EnMWjiUY4C());
				goto IL_007b;
				IL_007b:
				return NukwHoDkBnqK8Jdqx5P(ybLj9rDKPEExh0aEKWY(object_3), 2).ToString();
				continue;
				end_IL_003b:
				break;
			}
		}
	}

	[CompilerGenerated]
	private void WOQWwMOu0R(object object_0)
	{
		while (true)
		{
			nYiWaT3mLB();
			if (!id7ED5DyHkBoYJPWH2A())
			{
				switch (0)
				{
				case 1:
					break;
				default:
					return;
				case 0:
					return;
				}
				continue;
			}
			break;
		}
	}

	[CompilerGenerated]
	private void PExWXFokGT(object object_0)
	{
		while (true)
		{
			nYiWaT3mLB();
			if (id7ED5DyHkBoYJPWH2A())
			{
				switch (0)
				{
				case 1:
					break;
				default:
					return;
				case 0:
					return;
				}
				continue;
			}
			break;
		}
	}

	internal static void a0Ml98DJY1BMfRwss52()
	{
		XaXlykERDhtdRwMnBY.jXRWMU6APG();
	}

	internal static bool id7ED5DyHkBoYJPWH2A()
	{
		return B7V7h6DVHAeDQi0HapT == null;
	}

	internal static ufdDVdCNkhDWde66wH jHk2UKD4rLwr1ngo004()
	{
		return (ufdDVdCNkhDWde66wH)B7V7h6DVHAeDQi0HapT;
	}

	internal static bool ReWs9mD9elWD7cQ0ToV(object object_0, object object_1)
	{
		return (string?)object_0 == (string?)object_1;
	}

	internal static object SRV3pdD6oidFOBKQiku(int int_0)
	{
		return XaXlykERDhtdRwMnBY.oXbWkAhpNa(int_0);
	}

	internal static MessageBoxResult PmwxMoD18dKpdJU419j(object object_0, object object_1, MessageBoxButton messageBoxButton_0, MessageBoxImage messageBoxImage_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show((string)object_0, (string)object_1, messageBoxButton_0, messageBoxImage_0);
	}

	internal static object HqWV86DmQ7f1gojJkJx()
	{
		return Process.GetCurrentProcess();
	}

	internal static void QV9Y3qDfwbbEuDHwDTH(object object_0)
	{
		((Process)object_0).Kill();
	}

	internal static object CiD95SDS1yeD7rRimsw()
	{
		return NetworkInterface.GetAllNetworkInterfaces();
	}

	internal static object fOyJTgDRe0IVAt97veR()
	{
		return Environment.SystemDirectory;
	}

	internal static object t7aIaGDnmO4mL7SBq3x(object object_0)
	{
		return Path.GetPathRoot((string?)object_0);
	}

	internal static void L5gushDNxtA1vLqS9Il(object object_0, object object_1)
	{
		((ProcessStartInfo)object_0).FileName = (string)object_1;
	}

	internal static void VvG4xrDcy63RJfGB0J3(object object_0, bool bool_0)
	{
		((ProcessStartInfo)object_0).UseShellExecute = bool_0;
	}

	internal static void JBwMm6DxFTmdKHxJfxv(object object_0, bool bool_0)
	{
		((ProcessStartInfo)object_0).RedirectStandardOutput = bool_0;
	}

	internal static void A2kaO3DQYwCm2tk84FX(object object_0, bool bool_0)
	{
		((ProcessStartInfo)object_0).CreateNoWindow = bool_0;
	}

	internal static object JnuDcPD8Jd794oqAfgT(object object_0)
	{
		return Process.Start((ProcessStartInfo)object_0);
	}

	internal static object A8DHr0DpFBfBuFOZIKs(object object_0)
	{
		return ((Process)object_0).StandardOutput;
	}

	internal static object Rw0vFCDCvVQ10O3VTdP(object object_0)
	{
		return ((TextReader)object_0).ReadToEnd();
	}

	internal static void LSHjOQD3HcBJFofu6vt(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static object cUALjsDshWJY0bPHKSP(object object_0, object object_1)
	{
		return string.Format((string)object_0, object_1);
	}

	internal static object LtWlOtDUFG574AOoktm(object object_0, object object_1)
	{
		return ((Regex)object_0).Match((string)object_1);
	}

	internal static object ybLj9rDKPEExh0aEKWY(object object_0)
	{
		return ((Match)object_0).Groups;
	}

	internal static object NukwHoDkBnqK8Jdqx5P(object object_0, int int_0)
	{
		return ((GroupCollection)object_0)[int_0];
	}
}
