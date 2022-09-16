using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace dfb44QxstTvciGRseP;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct D4mF2EGCjeRfy8Qwm5
{
	public uint naSsF8CKoZ;

	public uint wD6s2fsW4L;

	public uint LKnsqgVIUa;

	public uint Irgs3DooDT;

	public uint gLMsQUh4nM;

	public uint upFsiYaNv3;

	public ushort yZ3s68ZCjm;

	public ushort onNsNpwbYO;

	public ushort fyYsmV7fVe;

	public ushort PnpskHvSgk;

	public uint dEGs805iUk;

	public uint HQYsg7DF1F;

	public uint gTgsVUIFOt;

	public uint w9asOPBUnQ;

	public uint BW7sd0IFSv;

	public uint EaNsb9bmry;

	internal static object lCejslXbhMRTSxOrg7I;

	public static D4mF2EGCjeRfy8Qwm5 XQ2se4ZZoB(BinaryReader binaryReader_0)
	{
		return f0DCqnXJIfqwRHulys1(zYEpsBXWGYCV0bddAHO(binaryReader_0, VF7Uf0d8DQ5udITDQu.QLnsStWZHI()));
	}

	public static D4mF2EGCjeRfy8Qwm5 RMbsG9GYgT(byte[] byte_0)
	{
		byte[] array = new byte[VF7Uf0d8DQ5udITDQu.QLnsStWZHI()];
		Fpkr6CXQTOXWfjrFh9C(byte_0, array, woB0tLX459xBouAjy27());
		GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
		D4mF2EGCjeRfy8Qwm5 d4mF2EGCjeRfy8Qwm = (D4mF2EGCjeRfy8Qwm5)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), p9wtO9XH7oZgXC2ddUd(typeof(D4mF2EGCjeRfy8Qwm5).TypeHandle));
		gCHandle.Free();
		D4mF2EGCjeRfy8Qwm5 result = d4mF2EGCjeRfy8Qwm;
		if (!SK4cp8XtS1UBvbCMTFE())
		{
			switch (0)
			{
			}
		}
		return result;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("Length: ").Append(naSsF8CKoZ).Append("\n");
		lw6xNgX1AS690Loj9WF(stringBuilder.Append("Reserved: ").Append(wD6s2fsW4L), "\n");
		((StringBuilder)lw6xNgX1AS690Loj9WF(stringBuilder, "RecordNumber: ")).Append(LKnsqgVIUa).Append("\n");
		((StringBuilder)YPSNbDXeFrvRODJtgt4(stringBuilder.Append("TimeGenerated: "), DateTime.FromBinary(Irgs3DooDT))).Append("\n");
		((StringBuilder)YPSNbDXeFrvRODJtgt4(stringBuilder.Append("TimeWritten: "), DateTime.FromBinary(gLMsQUh4nM))).Append("\n");
		((StringBuilder)E71TfBXkVprW43PDcSQ(stringBuilder.Append("EventID: "), upFsiYaNv3)).Append("\n");
		stringBuilder.Append("EventType: ").Append(yZ3s68ZCjm).Append("\n");
		stringBuilder.Append("NumStrings: ").Append(onNsNpwbYO).Append("\n");
		((StringBuilder)QAcPwdXGVsMe8idHn4B(stringBuilder.Append("EventCategory: "), fyYsmV7fVe)).Append("\n");
		stringBuilder.Append("ReservedFlags: ").Append(PnpskHvSgk).Append("\n");
		int num = 1;
		if (!SK4cp8XtS1UBvbCMTFE())
		{
			goto IL_0253;
		}
		goto IL_0280;
		IL_0280:
		string result = default(string);
		do
		{
			IL_0280_2:
			switch (num)
			{
			case 3:
				stringBuilder.Append("StringOffset: ").Append(HQYsg7DF1F).Append("\n");
				lw6xNgX1AS690Loj9WF(stringBuilder.Append("UserSidLength: ").Append(gTgsVUIFOt), "\n");
				lw6xNgX1AS690Loj9WF(stringBuilder.Append("UserSidOffset: ").Append(w9asOPBUnQ), "\n");
				stringBuilder.Append("DataLength: ").Append(BW7sd0IFSv).Append("\n");
				num = 0;
				if (RqGFDOXF4C8uNDoXcLU() != null)
				{
					goto IL_0280_2;
				}
				break;
			case 1:
				stringBuilder.Append("ClosingRecordNumber: ").Append(dEGs805iUk).Append("\n");
				goto case 3;
			case 2:
				return result;
			}
			stringBuilder.Append("DataOffset: ").Append(EaNsb9bmry).Append("\n");
			result = stringBuilder.ToString();
			num = 2;
		}
		while (SK4cp8XtS1UBvbCMTFE());
		goto IL_0253;
		IL_0253:
		int num2 = default(int);
		num = num2;
		goto IL_0280;
	}

	internal static object zYEpsBXWGYCV0bddAHO(object object_0, int int_0)
	{
		return ((BinaryReader)object_0).ReadBytes(int_0);
	}

	internal static D4mF2EGCjeRfy8Qwm5 f0DCqnXJIfqwRHulys1(object object_0)
	{
		return RMbsG9GYgT((byte[])object_0);
	}

	internal static bool SK4cp8XtS1UBvbCMTFE()
	{
		return lCejslXbhMRTSxOrg7I == null;
	}

	internal static object RqGFDOXF4C8uNDoXcLU()
	{
		return lCejslXbhMRTSxOrg7I;
	}

	internal static int woB0tLX459xBouAjy27()
	{
		return VF7Uf0d8DQ5udITDQu.QLnsStWZHI();
	}

	internal static void Fpkr6CXQTOXWfjrFh9C(object object_0, object object_1, int int_0)
	{
		Array.Copy((Array)object_0, (Array)object_1, int_0);
	}

	internal static Type p9wtO9XH7oZgXC2ddUd(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object lw6xNgX1AS690Loj9WF(object object_0, object object_1)
	{
		return ((StringBuilder)object_0).Append((string?)object_1);
	}

	internal static object YPSNbDXeFrvRODJtgt4(object object_0, object object_1)
	{
		return ((StringBuilder)object_0).Append(object_1);
	}

	internal static object E71TfBXkVprW43PDcSQ(object object_0, uint uint_0)
	{
		return ((StringBuilder)object_0).Append(uint_0);
	}

	internal static object QAcPwdXGVsMe8idHn4B(object object_0, ushort ushort_0)
	{
		return ((StringBuilder)object_0).Append(ushort_0);
	}
}
