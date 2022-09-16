using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace dfb44QxstTvciGRseP;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal struct tbSPWBEhGneWxFC0xv
{
	public uint Nccs9f46tk;

	public uint B3Msyw2TZR;

	public uint MlksfXQogm;

	public uint hnLsD4kkAR;

	public uint zPpsBHxWb6;

	public uint utLsoQCy3F;

	public uint ll8s1L1TF1;

	public uint u8AsZ3ifyl;

	public uint W9msrmsC0k;

	public uint rcCsc7VCU9;

	public uint jm1s7PGpdL;

	public uint W3HsHlZVhM;

	private static object Uc6MPqXiIfsH2yDSJ7g;

	public static tbSPWBEhGneWxFC0xv oY6sP98dgQ(BinaryReader binaryReader_0)
	{
		((Stream)UbTU2aXfh9FmWBEibbc(binaryReader_0)).Seek(0L, SeekOrigin.Begin);
		byte[] value = binaryReader_0.ReadBytes(Marshal.SizeOf(typeof(tbSPWBEhGneWxFC0xv)));
		int num = 0;
		if (mxLvjGXVXXqq2ZtmuRp() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			GCHandle gCHandle = GCHandle.Alloc(value, GCHandleType.Pinned);
			tbSPWBEhGneWxFC0xv result = (tbSPWBEhGneWxFC0xv)mBG0obXr6LuWCwwNSam(gCHandle.AddrOfPinnedObject(), typeof(tbSPWBEhGneWxFC0xv));
			gCHandle.Free();
			return result;
		}
		}
	}

	public void zn6sXq4bLb()
	{
		if (B3Msyw2TZR != 1699505740)
		{
			throw new Exception();
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder;
		while (true)
		{
			stringBuilder = new StringBuilder();
			int num = 0;
			if (!WNMXWnXypUWPK8EaVky())
			{
				goto IL_0003;
			}
			goto IL_0053;
			IL_0053:
			switch (num)
			{
			case 1:
				continue;
			case 2:
				goto end_IL_0066;
			}
			goto IL_0003;
			IL_0003:
			((StringBuilder)sPJTjoXUmjgsVTtNetv(stringBuilder, "HeaderLength: ")).Append(Nccs9f46tk).Append("\n");
			sPJTjoXUmjgsVTtNetv(stringBuilder.Append("Signature: ").Append(B3Msyw2TZR), "\n");
			num = 2;
			if (mxLvjGXVXXqq2ZtmuRp() != null)
			{
				break;
			}
			goto IL_0053;
			continue;
			end_IL_0066:
			break;
		}
		((StringBuilder)MjG4OQX2pNJcgo0krst(stringBuilder.Append("FooterOffset: "), utLsoQCy3F)).Append("\n");
		stringBuilder.Append("NextIndex: ").Append(ll8s1L1TF1).Append("\n");
		stringBuilder.Append("FileLength: ").Append(u8AsZ3ifyl).Append("\n");
		sPJTjoXUmjgsVTtNetv(((StringBuilder)sPJTjoXUmjgsVTtNetv(stringBuilder, "EndHeaderLength: ")).Append(W3HsHlZVhM), "\n");
		return stringBuilder.ToString();
	}

	internal static object UbTU2aXfh9FmWBEibbc(object object_0)
	{
		return ((BinaryReader)object_0).BaseStream;
	}

	internal static object mBG0obXr6LuWCwwNSam(IntPtr intptr_0, Type type_0)
	{
		return Marshal.PtrToStructure(intptr_0, type_0);
	}

	internal static bool WNMXWnXypUWPK8EaVky()
	{
		return Uc6MPqXiIfsH2yDSJ7g == null;
	}

	internal static object mxLvjGXVXXqq2ZtmuRp()
	{
		return Uc6MPqXiIfsH2yDSJ7g;
	}

	internal static object sPJTjoXUmjgsVTtNetv(object object_0, object object_1)
	{
		return ((StringBuilder)object_0).Append((string?)object_1);
	}

	internal static object MjG4OQX2pNJcgo0krst(object object_0, uint uint_0)
	{
		return ((StringBuilder)object_0).Append(uint_0);
	}
}
