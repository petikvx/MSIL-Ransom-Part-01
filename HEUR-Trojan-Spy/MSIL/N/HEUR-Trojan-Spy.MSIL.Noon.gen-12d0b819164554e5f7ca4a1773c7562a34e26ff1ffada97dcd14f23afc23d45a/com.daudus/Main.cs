using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using com.daudus.My;

namespace com.daudus;

[StandardModule]
internal sealed class Main
{
	private static object EAapp;

	private static object Model;

	private static object Repository;

	private static object Package;

	private static Hashtable mappedElementsFileARCHI = new Hashtable();

	private static string[] columsMappedElementsFileARCHI;

	private static Hashtable mappedPropertiesFileARCHI = new Hashtable();

	private static Hashtable mappedRelationsFileARCHI = new Hashtable();

	private static AppConfig appConfig;

	public static void Main(string[] sArgs)
	{
		try
		{
			initApp(ref sArgs);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Fatal", new object[1] { "Fatal Error occured. Can not continue due to: " + ex2.Message }, (string[])null, (Type[])null, (bool[])null, true);
			closeApp();
			ProjectData.ClearProjectError();
			return;
		}
		EAapp = RuntimeHelpers.GetObjectValue(EACommon.getApp());
		if (Information.IsNothing(RuntimeHelpers.GetObjectValue(EAapp)))
		{
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Fatal", new object[1] { "Sparx EA cannot start" }, (string[])null, (Type[])null, (bool[])null, true);
			closeApp();
			return;
		}
		Repository = RuntimeHelpers.GetObjectValue(EACommon.getRepository(ref EAapp));
		if (Information.IsNothing(RuntimeHelpers.GetObjectValue(Repository)))
		{
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Fatal", new object[1] { "Sparx EA has to have opened any repository" }, (string[])null, (Type[])null, (bool[])null, true);
			closeApp();
			return;
		}
		Model = RuntimeHelpers.GetObjectValue(EACommon.getModel(ref Repository));
		if (Information.IsNothing(RuntimeHelpers.GetObjectValue(Model)))
		{
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Fatal", new object[1] { "Sparx EA has to have model with given name: " + MySettingsProperty.Settings.SparxEATargetRepostoryModelArchiImported }, (string[])null, (Type[])null, (bool[])null, true);
			closeApp();
			return;
		}
		Package = RuntimeHelpers.GetObjectValue(EACommon.getPackageFromModel(ref Model));
		if (Information.IsNothing(RuntimeHelpers.GetObjectValue(Package)))
		{
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Fatal", new object[1] { "Sparx EA has to have repository with given name: " + MySettingsProperty.Settings.SparxEATargetRepostoryPackageArchiImported }, (string[])null, (Type[])null, (bool[])null, true);
			closeApp();
			return;
		}
		mappedPropertiesFileARCHI = ArchiCommon.loadPropertiesFileARCHI();
		mappedRelationsFileARCHI = ArchiCommon.loadRelationsFileARCHI();
		mappedElementsFileARCHI = ArchiCommon.loadElementsFileARCHI();
		columsMappedElementsFileARCHI = (string[])NewLateBinding.LateGet(mappedElementsFileARCHI[ArchiConstants.columsMappedElementsFileARCHI[0]], (Type)null, "toStringArray", new object[0], (string[])null, (Type[])null, (bool[])null);
		mappedElementsFileARCHI.Remove(ArchiConstants.columsMappedElementsFileARCHI[0]);
		createElementsInEA(ref Package, ref mappedElementsFileARCHI, ref mappedPropertiesFileARCHI);
		createRelationsInEA(ref Repository, ref mappedRelationsFileARCHI, ref mappedElementsFileARCHI, ref mappedPropertiesFileARCHI);
		ArchiCommon.saveElementsFileARCHI(ref columsMappedElementsFileARCHI, ref mappedElementsFileARCHI);
		closeApp();
	}

	public static void createRelationsInEA(ref object repository, ref Hashtable archiRelations, ref Hashtable archiElements, ref Hashtable archiProperties)
	{
	}

	public static void createElementsInEA(ref object package, ref Hashtable archiElements, ref Hashtable archiProperties)
	{
		ArrayList arrayList = new ArrayList();
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "createElementsInEA started" }, (string[])null, (Type[])null, (bool[])null, true);
		ICollection keys = archiElements.Keys;
		ConsoleSpiner consoleSpiner = new ConsoleSpiner(keys.Count, 1);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = keys.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string key = Conversions.ToString(enumerator.Current);
				consoleSpiner.Turn();
				ArchiElement archiElement = (ArchiElement)archiElements[key];
				string text = EAConstants.typeArchi2StereotypeEA(archiElement.Type);
				if (!archiElement.Type.Equals("ArchimateModel"))
				{
					string text2 = Conversions.ToString(EAConstants.stereotype2type[text]);
					object obj = NewLateBinding.LateGet(package, (Type)null, "Elements", new object[0], (string[])null, (Type[])null, (bool[])null);
					ArchiElement archiElement2;
					object[] obj2 = new object[2]
					{
						(archiElement2 = archiElement).Name,
						text2
					};
					object[] array = obj2;
					bool[] obj3 = new bool[2] { true, true };
					bool[] array2 = obj3;
					object obj4 = NewLateBinding.LateGet(obj, (Type)null, "AddNew", obj2, (string[])null, (Type[])null, obj3);
					if (array2[0])
					{
						archiElement2.Name = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					if (array2[1])
					{
						text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
					}
					object elementEA = RuntimeHelpers.GetObjectValue(obj4);
					object obj5 = elementEA;
					NewLateBinding.LateSet(obj5, (Type)null, "Stereotype", new object[1] { "ArchiMate3::" + text }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(obj5, (Type)null, "Author", new object[1] { MySettingsProperty.Settings.Author }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(obj5, (Type)null, "Notes", new object[1] { archiElement.Documentation }, (string[])null, (Type[])null);
					obj4 = archiElement;
					string text3 = _addTaggedValues(ref elementEA, ref obj4, ref archiProperties);
					archiElement = (ArchiElement)obj4;
					string text4 = text3;
					if (!Information.IsNothing((object)text4))
					{
						arrayList.Add(text4);
					}
					archiElement.GUIDEA = Conversions.ToString(NewLateBinding.LateGet(obj5, (Type)null, "ElementGUID", new object[0], (string[])null, (Type[])null, (bool[])null));
					archiElement.ElementIDEA = Conversions.ToString(NewLateBinding.LateGet(obj5, (Type)null, "ElementID", new object[0], (string[])null, (Type[])null, (bool[])null));
					NewLateBinding.LateCall(NewLateBinding.LateGet(obj5, (Type)null, "TaggedValues", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Refresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(obj5, (Type)null, "Update", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					obj5 = null;
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
		consoleSpiner.Finish();
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "Package is being refreshed" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(package, (Type)null, "Elements", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Refresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "Package is refreshed" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "Package is being updated. It will take a while ..." }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(package, (Type)null, "Update", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "Package is updated" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "createElementsInEA finished" }, (string[])null, (Type[])null, (bool[])null, true);
	}

	public static string _addTaggedValuesConnector(ref object connectorEA, ref ArchiRelation relationArchi, ref Hashtable archiProperties)
	{
		string result = null;
		ArrayList arrayList = (ArrayList)archiProperties[relationArchi.ID];
		object obj;
		object[] array;
		bool[] array2;
		object objectValue;
		if (!Information.IsNothing((object)arrayList))
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = arrayList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ArchiProperty archiProperty = (ArchiProperty)enumerator.Current;
					ArchiProperty archiProperty2;
					ArchiProperty archiProperty3;
					obj = NewLateBinding.LateGet(NewLateBinding.LateGet(connectorEA, (Type)null, "TaggedValues", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AddNew", array = new object[2]
					{
						(archiProperty2 = archiProperty).Key,
						(archiProperty3 = archiProperty).Value
					}, (string[])null, (Type[])null, array2 = new bool[2] { true, true });
					if (array2[0])
					{
						archiProperty2.Key = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					if (array2[1])
					{
						archiProperty3.Value = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
					}
					objectValue = RuntimeHelpers.GetObjectValue(obj);
					if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(objectValue, (Type)null, "Update", new object[0], (string[])null, (Type[])null, (bool[])null))))
					{
						NewLateBinding.LateCall(Common.lLOG, (Type)null, "Error", new object[1] { Operators.AddObject((object)("Tagged Value with Archi ID " + archiProperty.ID + " not created: "), NewLateBinding.LateGet(objectValue, (Type)null, "GetLastError", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, (bool[])null, true);
						continue;
					}
					string text = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "Notes", new object[0], (string[])null, (Type[])null, (bool[])null));
					text += Strings.Replace("{ARCHIPROPID:%s:}", "%s", archiProperty.ID, 1, -1, (CompareMethod)0);
					NewLateBinding.LateSet(objectValue, (Type)null, "Notes", new object[1] { text }, (string[])null, (Type[])null);
					if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(objectValue, (Type)null, "Update", new object[0], (string[])null, (Type[])null, (bool[])null))))
					{
						NewLateBinding.LateCall(Common.lLOG, (Type)null, "Error", new object[1] { Operators.AddObject((object)("Tagged Value with Archi ID " + archiProperty.ID + " not created: "), NewLateBinding.LateGet(objectValue, (Type)null, "GetLastError", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, (bool[])null, true);
					}
					archiProperty.GUIDEA = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "TagGUID", new object[0], (string[])null, (Type[])null, (bool[])null));
					archiProperty.TagValueIDEA = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "TagID", new object[0], (string[])null, (Type[])null, (bool[])null));
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
		else
		{
			result = "Element does not have any property. So, no Tag_Value was created for archi element: " + relationArchi.ID + ":" + relationArchi.Type + ":" + relationArchi.Name;
		}
		ArchiRelation archiRelation;
		obj = NewLateBinding.LateGet(NewLateBinding.LateGet(connectorEA, (Type)null, "TaggedValues", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AddNew", array = new object[2]
		{
			"ARCHI_ID",
			(archiRelation = relationArchi).ID
		}, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
		if (array2[1])
		{
			archiRelation.ID = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
		}
		objectValue = RuntimeHelpers.GetObjectValue(obj);
		if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(objectValue, (Type)null, "Update", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			Console.WriteLine(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "GetLastError", new object[0], (string[])null, (Type[])null, (bool[])null)));
		}
		return result;
	}

	public static string _addTaggedValues(ref object elementEA, ref object elementArchi, ref Hashtable archiProperties)
	{
		string result = null;
		ArrayList arrayList = (ArrayList)archiProperties[RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(elementArchi, (Type)null, "ID", new object[0], (string[])null, (Type[])null, (bool[])null))];
		object obj;
		object[] array;
		bool[] array2;
		object objectValue;
		if (!Information.IsNothing((object)arrayList))
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = arrayList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ArchiProperty archiProperty = (ArchiProperty)enumerator.Current;
					ArchiProperty archiProperty2;
					ArchiProperty archiProperty3;
					obj = NewLateBinding.LateGet(NewLateBinding.LateGet(elementEA, (Type)null, "TaggedValues", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AddNew", array = new object[2]
					{
						(archiProperty2 = archiProperty).Key,
						(archiProperty3 = archiProperty).Value
					}, (string[])null, (Type[])null, array2 = new bool[2] { true, true });
					if (array2[0])
					{
						archiProperty2.Key = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					if (array2[1])
					{
						archiProperty3.Value = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
					}
					objectValue = RuntimeHelpers.GetObjectValue(obj);
					if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(objectValue, (Type)null, "Update", new object[0], (string[])null, (Type[])null, (bool[])null))))
					{
						NewLateBinding.LateCall(Common.lLOG, (Type)null, "Error", new object[1] { Operators.AddObject((object)("Tagged Value with Archi ID " + archiProperty.ID + " not created: "), NewLateBinding.LateGet(objectValue, (Type)null, "GetLastError", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, (bool[])null, true);
						continue;
					}
					string text = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "Notes", new object[0], (string[])null, (Type[])null, (bool[])null));
					text += Strings.Replace("{ARCHIPROPID:%s:}", "%s", archiProperty.ID, 1, -1, (CompareMethod)0);
					NewLateBinding.LateSet(objectValue, (Type)null, "Notes", new object[1] { text }, (string[])null, (Type[])null);
					if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(objectValue, (Type)null, "Update", new object[0], (string[])null, (Type[])null, (bool[])null))))
					{
						NewLateBinding.LateCall(Common.lLOG, (Type)null, "Error", new object[1] { Operators.AddObject((object)("Tagged Value with Archi ID " + archiProperty.ID + " not created: "), NewLateBinding.LateGet(objectValue, (Type)null, "GetLastError", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, (bool[])null, true);
					}
					archiProperty.GUIDEA = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "PropertyGUID", new object[0], (string[])null, (Type[])null, (bool[])null));
					archiProperty.TagValueIDEA = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "PropertyID", new object[0], (string[])null, (Type[])null, (bool[])null));
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
		else
		{
			result = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"Element does not have any property. So, no Tag_Value was created for archi element: ", NewLateBinding.LateGet(elementArchi, (Type)null, "ID", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)":"), NewLateBinding.LateGet(elementArchi, (Type)null, "Type", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)":"), NewLateBinding.LateGet(elementArchi, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)));
		}
		object obj2 = NewLateBinding.LateGet(elementEA, (Type)null, "TaggedValues", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] obj3 = new object[2] { "ARCHI_ID", null };
		obj = elementArchi;
		obj3[1] = NewLateBinding.LateGet(obj, (Type)null, "ID", new object[0], (string[])null, (Type[])null, (bool[])null);
		array = obj3;
		object obj4 = NewLateBinding.LateGet(obj2, (Type)null, "AddNew", obj3, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
		if (array2[1])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "ID", new object[1] { array[1] }, (string[])null, (Type[])null, true, false);
		}
		objectValue = RuntimeHelpers.GetObjectValue(obj4);
		NewLateBinding.LateCall(objectValue, (Type)null, "Update", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		return result;
	}

	public static void initApp(ref string[] sArgs)
	{
		appConfig = new AppConfig(ref sArgs);
	}

	public static void closeApp()
	{
		mappedElementsFileARCHI.Clear();
		mappedElementsFileARCHI = null;
		mappedPropertiesFileARCHI.Clear();
		mappedPropertiesFileARCHI = null;
		mappedRelationsFileARCHI.Clear();
		mappedRelationsFileARCHI = null;
		EACommon.close(ref EAapp, ref Repository, close: false);
		Console.WriteLine("PRESS ANY KEY TO EXIT");
		Console.ReadKey();
	}
}
