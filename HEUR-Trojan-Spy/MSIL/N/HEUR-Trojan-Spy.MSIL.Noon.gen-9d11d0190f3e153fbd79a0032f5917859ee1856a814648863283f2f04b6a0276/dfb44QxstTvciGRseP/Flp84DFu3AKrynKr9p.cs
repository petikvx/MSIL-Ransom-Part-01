using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace dfb44QxstTvciGRseP;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal struct Flp84DFu3AKrynKr9p
{
	public uint CaKjZ7Cp0;

	public uint NV2KC5u8A;

	public uint DKyYKulco;

	public uint HCZzaABxV;

	public uint fUHswco7J4;

	public uint jNfssfQrmT;

	public uint qussho1i7s;

	public uint RrusLIUL8v;

	public uint hCqspUjG8D;

	public uint MNhsTr92aS;

	private static object RaWLSxXX15MxkW8LFyw;

	public static Flp84DFu3AKrynKr9p iNlvn77sj(BinaryReader binaryReader_0)
	{
		binaryReader_0.BaseStream.Seek(-40L, SeekOrigin.End);
		byte[] object_ = binaryReader_0.ReadBytes(Marshal.SizeOf(GVbIPlXZmFCwYaNkb5Q(typeof(Flp84DFu3AKrynKr9p).TypeHandle)));
		GCHandle gCHandle = BEhGrtXsuZEWERaOhBn(object_, GCHandleType.Pinned);
		Flp84DFu3AKrynKr9p result = (Flp84DFu3AKrynKr9p)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), typeof(Flp84DFu3AKrynKr9p));
		gCHandle.Free();
		return result;
	}

	public void jkG0GnCiC()
	{
		bool flag = NV2KC5u8A != 286331153 || DKyYKulco != 572662306 || HCZzaABxV != 858993459 || fUHswco7J4 != 1145324612;
		int num = 0;
		if (hjbQsOX7RGAxT66QcwT() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			throw new Exception();
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		((StringBuilder)pScL0TXueR9JnQGLUvu(stringBuilder, "FooterLength: ")).Append(CaKjZ7Cp0).Append("\n");
		int num = 1;
		if (hjbQsOX7RGAxT66QcwT() != null)
		{
			goto IL_017d;
		}
		goto IL_0181;
		IL_0181:
		do
		{
			switch (num)
			{
			case 1:
				break;
			default:
				return stringBuilder.ToString();
			}
			stringBuilder.Append("Unknown0: ").Append(NV2KC5u8A).Append("\n");
			((StringBuilder)pScL0TXueR9JnQGLUvu(stringBuilder, "Unknown1: ")).Append(DKyYKulco).Append("\n");
			((StringBuilder)pScL0TXueR9JnQGLUvu(stringBuilder, "Unknown2: ")).Append(HCZzaABxV).Append("\n");
			stringBuilder.Append("Unknown3: ").Append(fUHswco7J4).Append("\n");
			((StringBuilder)pScL0TXueR9JnQGLUvu(stringBuilder, "Unknown4: ")).Append(jNfssfQrmT).Append("\n");
			((StringBuilder)pScL0TXueR9JnQGLUvu(stringBuilder, "FooterOffset: ")).Append(qussho1i7s).Append("\n");
			((StringBuilder)I1jdqJXR0rvlLNGNfPf(stringBuilder.Append("NextIndex: "), RrusLIUL8v)).Append("\n");
			((StringBuilder)pScL0TXueR9JnQGLUvu(stringBuilder, "Unknown7: ")).Append(hCqspUjG8D).Append("\n");
			stringBuilder.Append("EndFooterLength: ").Append(MNhsTr92aS).Append("\n");
			num = 0;
		}
		while (mxvh2iXDopsEuHoQmHI());
		goto IL_017d;
		IL_017d:
		int num2 = default(int);
		num = num2;
		goto IL_0181;
	}

	internal static Type GVbIPlXZmFCwYaNkb5Q(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static GCHandle BEhGrtXsuZEWERaOhBn(object object_0, GCHandleType gchandleType_0)
	{
		return GCHandle.Alloc(object_0, gchandleType_0);
	}

	internal static bool mxvh2iXDopsEuHoQmHI()
	{
		return RaWLSxXX15MxkW8LFyw == null;
	}

	internal static object hjbQsOX7RGAxT66QcwT()
	{
		return RaWLSxXX15MxkW8LFyw;
	}

	internal static object pScL0TXueR9JnQGLUvu(object object_0, object object_1)
	{
		return ((StringBuilder)object_0).Append((string?)object_1);
	}

	internal static object I1jdqJXR0rvlLNGNfPf(object object_0, uint uint_0)
	{
		return ((StringBuilder)object_0).Append(uint_0);
	}
}
