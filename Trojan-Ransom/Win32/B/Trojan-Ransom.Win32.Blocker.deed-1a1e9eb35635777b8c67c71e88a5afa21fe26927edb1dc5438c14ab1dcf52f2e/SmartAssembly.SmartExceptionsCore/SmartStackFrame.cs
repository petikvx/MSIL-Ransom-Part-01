using System;
using System.Runtime.Serialization;
using eC98jAqdnPLlDITmK6;
using etKNQTu9kgqwCqmIAv;

namespace SmartAssembly.SmartExceptionsCore;

[Serializable]
public class SmartStackFrame : ISerializable
{
	public readonly int MethodID;

	public readonly object[] Objects;

	public readonly int ILOffset;

	public readonly int ExceptionStackDepth;

	[NonSerialized]
	internal static eDHHd4vO3FpvmheVMk eulODlten;

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		eVF87k2pTRka92DjccO(info, eulODlten(24513), MethodID, eqfcEX2wM5TUjnm7lin(typeof(int).TypeHandle));
		eVF87k2pTRka92DjccO(info, eulODlten(24550), ILOffset, eqfcEX2wM5TUjnm7lin(typeof(int).TypeHandle));
		eVF87k2pTRka92DjccO(info, eulODlten(24587), ExceptionStackDepth, eqfcEX2wM5TUjnm7lin(typeof(int).TypeHandle));
		int num = ((Objects != null) ? Objects.Length : 0);
		eVF87k2pTRka92DjccO(info, eulODlten(24640), num, eqfcEX2wM5TUjnm7lin(typeof(int).TypeHandle));
		for (int i = 0; i < num; i++)
		{
			string object_ = (string)eAY95p24T4t8B59c4Sx(eulODlten(24685), i);
			try
			{
				if (Objects[i] == null)
				{
					ekKnaQ2vcuD614b3sRS();
					if (!eEtSPM28g5rwnsit9L0() && ekKnaQ2vcuD614b3sRS())
					{
						eVF87k2pTRka92DjccO(info, object_, null, eqfcEX2wM5TUjnm7lin(typeof(object).TypeHandle));
					}
				}
				else
				{
					eVF87k2pTRka92DjccO(info, object_, eADWAt2VLC0MBtuBZb6(Objects[i].GetType(), eulODlten(24730), Objects[i]), eqfcEX2wM5TUjnm7lin(typeof(string).TypeHandle));
				}
			}
			catch (Exception)
			{
			}
		}
	}

	internal SmartStackFrame(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
	{
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			eN8liu2TxYM6vC3RCRp(this);
			int num = 3;
			while (true)
			{
				IL_0010:
				MethodID = eDNohW2GVN9HWF5jnBw(serializationInfo_0, eulODlten(24513));
				while (true)
				{
					IL_002b:
					ILOffset = eDNohW2GVN9HWF5jnBw(serializationInfo_0, eulODlten(24550));
					num = 6;
					while (true)
					{
						ExceptionStackDepth = eDNohW2GVN9HWF5jnBw(serializationInfo_0, eulODlten(24587));
						eEtSPM28g5rwnsit9L0();
						if (!ekKnaQ2vcuD614b3sRS())
						{
							num = 10;
							if (eEtSPM28g5rwnsit9L0())
							{
								goto IL_008a;
							}
							goto IL_00e2;
						}
						goto IL_0126;
						IL_00e2:
						switch (num)
						{
						case 1:
							break;
						case 3:
							goto IL_0010;
						case 8:
							goto IL_002b;
						case 6:
							continue;
						case 7:
						case 9:
						case 10:
							goto IL_008a;
						default:
							num = 5;
							goto IL_013c;
						case 2:
						case 4:
							goto IL_0126;
						case 5:
							goto IL_013c;
						case 0:
							goto IL_0151;
						case 11:
							return;
						}
						break;
						IL_0126:
						num2 = eDNohW2GVN9HWF5jnBw(serializationInfo_0, eulODlten(24640));
						goto IL_013c;
						IL_013c:
						Objects = new object[num2];
						num = 0;
						goto IL_0151;
						IL_0151:
						num3 = 0;
						goto IL_008a;
						IL_008a:
						if (num3 < num2)
						{
							try
							{
								Objects[num3] = eG4cwA2tiUxgIcDVrIY(serializationInfo_0, eAY95p24T4t8B59c4Sx(eulODlten(24685), num3), eqfcEX2wM5TUjnm7lin(typeof(string).TypeHandle));
							}
							catch (Exception)
							{
								Objects[num3] = eulODlten(24735);
							}
							num3++;
							num = 9;
							if (ekKnaQ2vcuD614b3sRS())
							{
								goto IL_00e2;
							}
							goto IL_0126;
						}
						num = 11;
						return;
					}
					break;
				}
				break;
			}
		}
	}

	internal SmartStackFrame(int int_0, object[] object_0, int int_1, int int_2)
	{
		eN8liu2TxYM6vC3RCRp(this);
		ekKnaQ2vcuD614b3sRS();
		if (!eEtSPM28g5rwnsit9L0())
		{
			MethodID = int_0;
			ExceptionStackDepth = int_2;
			ILOffset = int_1;
		}
		Objects = object_0;
	}

	static SmartStackFrame()
	{
		esln1F21ZYGPIELSeWE(eqfcEX2wM5TUjnm7lin(typeof(SmartStackFrame).TypeHandle));
	}

	internal static Type eqfcEX2wM5TUjnm7lin(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object eAY95p24T4t8B59c4Sx(object object_0, object object_1)
	{
		return string.Format((string)object_0, object_1);
	}

	internal static void eVF87k2pTRka92DjccO(object object_0, object object_1, object object_2, Type type_0)
	{
		((SerializationInfo)object_0).AddValue((string)object_1, object_2, type_0);
	}

	internal static object eADWAt2VLC0MBtuBZb6(object object_0, object object_1, object object_2)
	{
		return string.Concat(object_0, object_1, object_2);
	}

	internal static bool ekKnaQ2vcuD614b3sRS()
	{
		return true;
	}

	internal static bool eEtSPM28g5rwnsit9L0()
	{
		return false;
	}

	internal static void eN8liu2TxYM6vC3RCRp(object object_0)
	{
		object_0._002Ector();
	}

	internal static int eDNohW2GVN9HWF5jnBw(object object_0, object object_1)
	{
		return ((SerializationInfo)object_0).GetInt32((string)object_1);
	}

	internal static object eG4cwA2tiUxgIcDVrIY(object object_0, object object_1, Type type_0)
	{
		return ((SerializationInfo)object_0).GetValue((string)object_1, type_0);
	}

	internal static void esln1F21ZYGPIELSeWE(Type type_0)
	{
		eMbooerndU5ci2DHIZ.e4ZIbpnTa(type_0);
	}
}
