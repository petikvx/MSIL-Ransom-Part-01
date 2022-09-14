using System;
using System.Collections.Generic;
using System.Linq;

namespace HOAProject;

public class CPU
{
	private static string PXZ;

	private static string PXY;

	private Dictionary<string, Func<long>> _getIntRegister;

	private Dictionary<string, Action<long>> _setIntRegister;

	private Dictionary<string, Func<double>> _getFloatRegister;

	private Dictionary<string, Action<double>> _setFloatRegister;

	public int IntRegisterOffset;

	public int IntRegisterCount;

	public Func<long>[] IntRegisterGetter;

	public Action<long>[] IntRegisterSetter;

	public int FloatRegisterOffset;

	public int FloatRegisterCount;

	public Func<double>[] FloatRegisterGetter;

	public Action<double>[] FloatRegisterSetter;

	public int RegisterCount;

	public string[] RegisterName;

	public Dictionary<string, int> RegisterID;

	private int ebp_id;

	private int esp_id;

	public long eax;

	public long ebx;

	public long ecx;

	public long edx;

	public long ebp;

	public long esp;

	public long ebfp;

	public long esfp;

	public long eip;

	public long r0;

	public long r1;

	public long r2;

	public long r3;

	public long r4;

	public long r5;

	public long r6;

	public long r7;

	public double f0;

	public double f1;

	public double f2;

	public double f3;

	public double f4;

	public double f5;

	public double f6;

	public double f7;

	public static string F_0
	{
		get
		{
			return "XgNk";
		}
		set
		{
			PXZ = value;
		}
	}

	public static string F_1
	{
		get
		{
			return "VURAE";
		}
		set
		{
			PXY = value;
		}
	}

	private void initRegister()
	{
		initIntRegister();
		initFloatRegister();
		MakeRegisterCache();
	}

	private void initIntRegister()
	{
		_getIntRegister = new Dictionary<string, Func<long>>
		{
			{
				"eax",
				() => eax
			},
			{
				"ax",
				() => eax & 0xFFFFL
			},
			{
				"al",
				() => eax & 0xFFL
			},
			{
				"ah",
				() => (eax & 0xFF00L) >> 8
			},
			{
				"ebx",
				() => eax
			},
			{
				"bx",
				() => ebx & 0xFFFFL
			},
			{
				"bl",
				() => ebx & 0xFFL
			},
			{
				"bh",
				() => (ebx & 0xFF00L) >> 8
			},
			{
				"ecx",
				() => ecx
			},
			{
				"cx",
				() => ecx & 0xFFFFL
			},
			{
				"cl",
				() => ecx & 0xFFL
			},
			{
				"ch",
				() => (ecx & 0xFF00L) >> 8
			},
			{
				"edx",
				() => edx
			},
			{
				"dx",
				() => edx & 0xFFFFL
			},
			{
				"dl",
				() => edx & 0xFFL
			},
			{
				"dh",
				() => (edx & 0xFF00L) >> 8
			},
			{
				"esp",
				() => esp
			},
			{
				"sp",
				() => esp & 0xFFFFL
			},
			{
				"ebp",
				() => ebp
			},
			{
				"bp",
				() => ebp & 0xFFFFL
			},
			{
				"esfp",
				() => esfp
			},
			{
				"sfp",
				() => esfp & 0xFFFFL
			},
			{
				"ebfp",
				() => esfp
			},
			{
				"bfp",
				() => esfp & 0xFFFFL
			},
			{
				"eip",
				() => eip
			},
			{
				"ip",
				() => eip & 0xFFFFL
			},
			{
				"r0",
				() => r0
			},
			{
				"r1",
				() => r1
			},
			{
				"r2",
				() => r2
			},
			{
				"r3",
				() => r3
			},
			{
				"r4",
				() => r4
			},
			{
				"r5",
				() => r5
			},
			{
				"r6",
				() => r6
			},
			{
				"r7",
				() => r7
			}
		};
		_setIntRegister = new Dictionary<string, Action<long>>
		{
			{
				"eax",
				delegate(long data)
				{
					eax = data;
				}
			},
			{
				"ax",
				delegate(long data)
				{
					eax = (eax & -4294901761L) | ((data & 0xFFFFL) << 16);
				}
			},
			{
				"al",
				delegate(long data)
				{
					eax = (eax & -256L) | (data & 0xFFL);
				}
			},
			{
				"ah",
				delegate(long data)
				{
					eax = (eax & -65281L) | ((data & 0xFFL) << 8);
				}
			},
			{
				"ebx",
				delegate(long data)
				{
					ebx = data;
				}
			},
			{
				"bx",
				delegate(long data)
				{
					ebx = (ebx & -4294901761L) | ((data & 0xFFFFL) << 16);
				}
			},
			{
				"bl",
				delegate(long data)
				{
					ebx = (ebx & -256L) | (data & 0xFFL);
				}
			},
			{
				"bh",
				delegate(long data)
				{
					ebx = (ebx & -65281L) | ((data & 0xFFL) << 8);
				}
			},
			{
				"ecx",
				delegate(long data)
				{
					ecx = data;
				}
			},
			{
				"cx",
				delegate(long data)
				{
					ecx = (ecx & -4294901761L) | ((data & 0xFFFFL) << 16);
				}
			},
			{
				"cl",
				delegate(long data)
				{
					ecx = (ecx & -256L) | (data & 0xFFL);
				}
			},
			{
				"ch",
				delegate(long data)
				{
					ecx = (ecx & -65281L) | ((data & 0xFFL) << 8);
				}
			},
			{
				"edx",
				delegate(long data)
				{
					edx = data;
				}
			},
			{
				"dx",
				delegate(long data)
				{
					edx = (edx & -4294901761L) | ((data & 0xFFFFL) << 16);
				}
			},
			{
				"dl",
				delegate(long data)
				{
					edx = (edx & -256L) | (data & 0xFFL);
				}
			},
			{
				"dh",
				delegate(long data)
				{
					edx = (edx & -65281L) | ((data & 0xFFL) << 8);
				}
			},
			{
				"esp",
				delegate(long data)
				{
					esp = data;
				}
			},
			{
				"sp",
				delegate(long data)
				{
					esp = (esp & -4294901761L) | ((data & 0xFFFFL) << 16);
				}
			},
			{
				"ebp",
				delegate(long data)
				{
					ebp = data;
				}
			},
			{
				"bp",
				delegate(long data)
				{
					ebp = (ebp & -4294901761L) | ((data & 0xFFFFL) << 16);
				}
			},
			{
				"esfp",
				delegate(long data)
				{
					esfp = data;
				}
			},
			{
				"sfp",
				delegate(long data)
				{
					esfp = (esfp & -4294901761L) | ((data & 0xFFFFL) << 16);
				}
			},
			{
				"ebfp",
				delegate(long data)
				{
					ebfp = data;
				}
			},
			{
				"bfp",
				delegate(long data)
				{
					ebfp = (ebfp & -4294901761L) | ((data & 0xFFFFL) << 16);
				}
			},
			{
				"eip",
				delegate(long data)
				{
					eip = data;
				}
			},
			{
				"ip",
				delegate(long data)
				{
					eip = (eip & -4294901761L) | ((data & 0xFFFFL) << 16);
				}
			},
			{
				"r0",
				delegate(long data)
				{
					r0 = data;
				}
			},
			{
				"r1",
				delegate(long data)
				{
					r1 = data;
				}
			},
			{
				"r2",
				delegate(long data)
				{
					r2 = data;
				}
			},
			{
				"r3",
				delegate(long data)
				{
					r3 = data;
				}
			},
			{
				"r4",
				delegate(long data)
				{
					r4 = data;
				}
			},
			{
				"r5",
				delegate(long data)
				{
					r5 = data;
				}
			},
			{
				"r6",
				delegate(long data)
				{
					r6 = data;
				}
			},
			{
				"r7",
				delegate(long data)
				{
					r7 = data;
				}
			}
		};
	}

	private void initFloatRegister()
	{
		_getFloatRegister = new Dictionary<string, Func<double>>
		{
			{
				"f0",
				() => f0
			},
			{
				"f1",
				() => f1
			},
			{
				"f2",
				() => f2
			},
			{
				"f3",
				() => f3
			},
			{
				"f4",
				() => f4
			},
			{
				"f5",
				() => f5
			},
			{
				"f6",
				() => f6
			},
			{
				"f7",
				() => f7
			}
		};
		_setFloatRegister = new Dictionary<string, Action<double>>
		{
			{
				"f0",
				delegate(double data)
				{
					f0 = data;
				}
			},
			{
				"f1",
				delegate(double data)
				{
					f1 = data;
				}
			},
			{
				"f2",
				delegate(double data)
				{
					f2 = data;
				}
			},
			{
				"f3",
				delegate(double data)
				{
					f3 = data;
				}
			},
			{
				"f4",
				delegate(double data)
				{
					f4 = data;
				}
			},
			{
				"f5",
				delegate(double data)
				{
					f5 = data;
				}
			},
			{
				"f6",
				delegate(double data)
				{
					f6 = data;
				}
			},
			{
				"f7",
				delegate(double data)
				{
					f7 = data;
				}
			}
		};
	}

	public void MakeRegisterCache()
	{
		IntRegisterCount = _getIntRegister.Count;
		IntRegisterGetter = _getIntRegister.Values.ToArray();
		IntRegisterSetter = _setIntRegister.Values.ToArray();
		FloatRegisterCount = _getFloatRegister.Count;
		FloatRegisterGetter = _getFloatRegister.Values.ToArray();
		FloatRegisterSetter = _setFloatRegister.Values.ToArray();
		checked
		{
			RegisterCount = IntRegisterCount + FloatRegisterCount;
			RegisterName = new string[IntRegisterCount + FloatRegisterCount - 1 + 1];
			Array.Copy(_getIntRegister.Keys.ToArray(), RegisterName, IntRegisterCount);
			Array.Copy(_getFloatRegister.Keys.ToArray(), 0, RegisterName, IntRegisterCount, FloatRegisterCount);
			RegisterID = new Dictionary<string, int>();
			int num = RegisterName.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				RegisterID.Add(RegisterName[i], i);
			}
			IntRegisterOffset = 0;
			FloatRegisterOffset = IntRegisterCount;
			ebp_id = RegisterID["ebp"];
			esp_id = RegisterID["esp"];
		}
	}

	public void PrintRegisters()
	{
		Console.WriteLine("Registers:");
		Console.WriteLine("eax={0}, ebx={1}, ecx={2}, edx={3}, ebp={4}, esp={5}, ebfp={6}, esfp={7}, eip={8}", eax, ebx, ecx, edx, ebp, esp, ebfp, esfp, eip);
		Console.WriteLine("r0={0}, r1={1}, r2={2}, r3={3}, r4={4}, r5={5}, r6={6}, r7={7}", r0, r1, r2, r3, r4, r5, r6, r7);
		Console.WriteLine("f0={0}, f1={1}, f2={2}, f3={3}, f4={4}, f5={5}, f6={6}, f7={7}", f0, f1, f2, f3, f4, f5, f6, f7);
	}
}
