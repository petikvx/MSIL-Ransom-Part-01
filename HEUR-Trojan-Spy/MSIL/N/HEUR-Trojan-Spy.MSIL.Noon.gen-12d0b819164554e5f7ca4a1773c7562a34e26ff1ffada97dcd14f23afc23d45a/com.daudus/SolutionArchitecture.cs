using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace com.daudus;

[StandardModule]
internal sealed class SolutionArchitecture
{
	private static object Repository;

	public static void MainHCI(ref object EAapp)
	{
	}

	public static void getImpactsForDiagram(ref object diagram, ref object gaps)
	{
	}

	public static void populateElementsForGap(ref Gap gap)
	{
	}

	public static void printGaps(ref object gaps)
	{
	}

	public static void printImpactedConcepts(ref Gap gap)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(gap.ImpactedConcepts, (Type)null, "GetEnumerator", new object[0], (string[])null, (Type[])null, (bool[])null));
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "Number of impacts: " + Conversions.ToString(NewLateBinding.LateGet(gap.ImpactedConcepts, (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "Application\tConcept\tName\tImpact\tGAP" }, (string[])null, (Type[])null, (bool[])null, true);
		while (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue, (Type)null, "MoveNext", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			Concept concept = (Concept)NewLateBinding.LateGet(objectValue, (Type)null, "Current", new object[0], (string[])null, (Type[])null, (bool[])null);
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Debug", new object[1] { Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)(concept.Application + "\t"), concept.ConceptType), (object)'\t'), concept.ConceptName), (object)'\t'), (object)gap.Impact), (object)'\t'), (object)gap.Name) }, (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	public static string getPBRForDiagram(object diagram)
	{
		bool flag = false;
		bool flag2 = false;
		string result = "";
		int num = Conversions.ToInteger(NewLateBinding.LateGet(diagram, (Type)null, "PackageID", new object[0], (string[])null, (Type[])null, (bool[])null));
		while (!flag && !flag2)
		{
			object[] array;
			bool[] array2;
			object obj = NewLateBinding.LateGet(Repository, (Type)null, "GetPackageByID", array = new object[1] { num }, (string[])null, (Type[])null, array2 = new bool[1] { true });
			if (array2[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			object objectValue = RuntimeHelpers.GetObjectValue(obj);
			int num2 = Strings.InStr(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)), "PBR", (CompareMethod)0);
			if (num2 == 1)
			{
				flag = true;
				result = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null));
				continue;
			}
			num = Conversions.ToInteger(NewLateBinding.LateGet(objectValue, (Type)null, "ParentID", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (num == 0)
			{
				flag2 = true;
			}
		}
		return result;
	}

	public static object getComponentForInterface(object intrface)
	{
		object result = default(object);
		return result;
	}

	public static object getFunctionForService(object service)
	{
		object result = default(object);
		return result;
	}

	public static object getComponentForFunction(object fnction)
	{
		object result = default(object);
		return result;
	}

	public static string getApplicationForComponent(object component)
	{
		bool flag = false;
		bool flag2 = false;
		while (!flag && !flag2)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(findRelation(RuntimeHelpers.GetObjectValue(component), "ArchiMate_Composition", 1));
			if (Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue)))
			{
				flag2 = true;
				continue;
			}
			object repository = Repository;
			object[] array = new object[1];
			object obj = objectValue;
			array[0] = NewLateBinding.LateGet(obj, (Type)null, "SupplierID", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array2 = array;
			bool[] obj2 = new bool[1] { true };
			bool[] array3 = obj2;
			object obj3 = NewLateBinding.LateGet(repository, (Type)null, "GetElementByID", array, (string[])null, (Type[])null, obj2);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "SupplierID", new object[1] { array2[0] }, (string[])null, (Type[])null, true, false);
			}
			component = RuntimeHelpers.GetObjectValue(obj3);
		}
		return Conversions.ToString(NewLateBinding.LateGet(component, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null));
	}

	public static object findRelation(object component, string stereotypeRelation, short direction)
	{
		object result = default(object);
		return result;
	}
}
