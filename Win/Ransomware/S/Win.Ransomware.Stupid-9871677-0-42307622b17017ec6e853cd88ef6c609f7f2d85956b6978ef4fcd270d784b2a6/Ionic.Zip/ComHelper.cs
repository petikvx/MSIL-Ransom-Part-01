using System.Runtime.InteropServices;

namespace Ionic.Zip;

[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
[Guid("ebc25cf6-9120-4283-b972-0e5520d0000F")]
public class ComHelper
{
	public bool IsZipFile(string filename)
	{
		//Discarded unreachable code: IL_000b, IL_000d
		//IL_0005: Expected I8, but got Unknown
		do
		{
			((long[])checked((short)/*Error near IL_0001: Stack underflow*/))[/*Error near IL_0001: ldloca 0 (out-of-bounds)*/] = (long)/*Error near IL_0003: ldloc 3 (out-of-bounds)*/;
		}
		while (/*Error near IL_000a: Stack underflow*/ > /*Error near IL_000a: Stack underflow*/);
		/*Error near IL_000a: Unknown opcode: 0xFA*/;
	}

	public bool IsZipFileWithExtract(string filename)
	{
		//Discarded unreachable code: IL_0002, IL_0010, IL_0015, IL_001b, IL_002b, IL_0034
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Incompatible stack heights: 0 vs 1
		//IL_0034: Unsupported input type for neg.
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
		_ = ((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0001: Unknown opcode: 0xF8*/;
	}

	public extern bool CheckZip(string filename);

	public extern bool CheckZipPassword(string filename, string password);

	public extern void FixZipDirectory(string filename);

	public string GetZipLibraryVersion()
	{
		//Discarded unreachable code: IL_0006, IL_000f, IL_001c, IL_001d, IL_0024, IL_0028
		//IL_000a: Incompatible stack heights: 0 vs 1
		//IL_000f: Unsupported input type for neg.
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		//IL_001f: Invalid comparison between Unknown and I8
		//IL_0026: Invalid comparison between Unknown and I8
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected I4, but got I8
		/*Error near IL_0001: Invalid metadata token*/;
	}

	public extern ComHelper();
}
