using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using com.daudus.My;

namespace com.daudus;

[StandardModule]
internal sealed class EACommon
{
	public static object getApp()
	{
		object EAapp = null;
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "Getting the Sparx EA application instance" }, (string[])null, (Type[])null, (bool[])null, true);
		try
		{
			EAapp = RuntimeHelpers.GetObjectValue(Interaction.GetObject((string)null, "EA.App"));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "No Sparx EA instance is running ..." }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Debug", new object[1] { ex2.Message }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Information.IsNothing(RuntimeHelpers.GetObjectValue(EAapp)))
			{
				NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "Try to create new Sparx EA instance ..." }, (string[])null, (Type[])null, (bool[])null, true);
				EAapp = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("EA.App", ""));
				NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "New Sparx EA application instance was created" }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(EAapp, (Type)null, "Repository", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OpenFile", new object[1] { MySettingsProperty.Settings.SparxEATargetRepostoryDirectory + MySettingsProperty.Settings.SparxEATargetRepostoryFile }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "Repository loaded: " + MySettingsProperty.Settings.SparxEATargetRepostoryDirectory + MySettingsProperty.Settings.SparxEATargetRepostoryFile }, (string[])null, (Type[])null, (bool[])null, true);
			}
			else
			{
				NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "Running Sparx EA application instance will be used" }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { Operators.ConcatenateObject((object)"Repository already opened: ", NewLateBinding.LateGet(NewLateBinding.LateGet(EAapp, (Type)null, "Repository", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ConnectionString", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, (bool[])null, true);
			}
			NewLateBinding.LateSet(EAapp, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			object[] array;
			bool[] array2;
			object obj;
			object obj2 = NewLateBinding.LateGet((object)null, typeof(Strings), "UCase", array = new object[1] { NewLateBinding.LateGet(obj = NewLateBinding.LateGet(EAapp, (Type)null, "Repository", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ConnectionString", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, array2 = new bool[1] { true });
			if (array2[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "ConnectionString", new object[1] { array[0] }, (string[])null, (Type[])null, true, true);
			}
			if (string.Compare(Conversions.ToString(obj2), Strings.UCase(MySettingsProperty.Settings.SparxEATargetRepostoryDirectory + MySettingsProperty.Settings.SparxEATargetRepostoryFile)) != 0)
			{
				NewLateBinding.LateCall(Common.lLOG, (Type)null, "Fatal", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Wrong Repository Detected. Opened <", NewLateBinding.LateGet(NewLateBinding.LateGet(EAapp, (Type)null, "Repository", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ConnectionString", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"> but expected <"), (object)MySettingsProperty.Settings.SparxEATargetRepostoryDirectory), (object)MySettingsProperty.Settings.SparxEATargetRepostoryFile), (object)"> ") }, (string[])null, (Type[])null, (bool[])null, true);
				obj = EAapp;
				obj2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Repository", new object[0], (string[])null, (Type[])null, (bool[])null));
				close(ref EAapp, ref obj2, close: true);
				NewLateBinding.LateSetComplex(obj, (Type)null, "Repository", new object[1] { obj2 }, (string[])null, (Type[])null, true, false);
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Fatal", new object[1] { "something wrong during creating the Sparx EA instance ... " + ex4.Message }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.ClearProjectError();
		}
		return EAapp;
	}

	public static object getRepository(ref object EAapp)
	{
		return NewLateBinding.LateGet(EAapp, (Type)null, "Repository", new object[0], (string[])null, (Type[])null, (bool[])null);
	}

	public static object getModel(ref object repository)
	{
		bool flag = false;
		object obj = null;
		int i = 0;
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "Finding model in EA Repository: " + MySettingsProperty.Settings.SparxEATargetRepostoryModelArchiImported }, (string[])null, (Type[])null, (bool[])null, true);
		for (; Conversions.ToBoolean(Operators.AndObject((object)(!flag), Operators.CompareObjectLess((object)i, NewLateBinding.LateGet(NewLateBinding.LateGet(repository, (Type)null, "Models", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), false))); i = checked(i + 1))
		{
			obj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(repository, (Type)null, "Models", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetAt", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null));
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Debug", new object[1] { Operators.AddObject((object)"EA model: ", NewLateBinding.LateGet(obj, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, (bool[])null, true);
			if (NewLateBinding.LateGet(obj, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).Equals(MySettingsProperty.Settings.SparxEATargetRepostoryModelArchiImported))
			{
				flag = true;
			}
		}
		if (i == 0)
		{
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Error", new object[1] { "No Model found in Sparx EA repository." }, (string[])null, (Type[])null, (bool[])null, true);
		}
		if (!flag)
		{
			obj = null;
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Error", new object[1] { "Model " + MySettingsProperty.Settings.SparxEATargetRepostoryModelArchiImported + " not found." }, (string[])null, (Type[])null, (bool[])null, true);
		}
		return obj;
	}

	public static void close(ref object EAapp, ref object Repository, bool close)
	{
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "System is being to be closed" }, (string[])null, (Type[])null, (bool[])null, true);
		if (close)
		{
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "Sparx EA Repository as well as Sparx EA Application is being to be closed" }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(Repository, (Type)null, "Exit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Repository = null;
			EAapp = null;
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
		else
		{
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "Sparx EA Repository is still running!" }, (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	public static string GUIDGenerateGUID()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scriptlet.TypeLib", ""));
		return Strings.Left(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "Guid", new object[0], (string[])null, (Type[])null, (bool[])null)), 38);
	}

	public static object getPackageFromModel(ref object model)
	{
		bool flag = false;
		object obj = null;
		int num = 0;
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "Finding package in EA Repository: " + MySettingsProperty.Settings.SparxEATargetRepostoryPackageArchiImported }, (string[])null, (Type[])null, (bool[])null, true);
		while (Conversions.ToBoolean(Operators.AndObject((object)(!flag), Operators.CompareObjectLess((object)num, NewLateBinding.LateGet(NewLateBinding.LateGet(model, (Type)null, "Packages", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), false))))
		{
			object[] array;
			bool[] array2;
			object obj2 = NewLateBinding.LateGet(NewLateBinding.LateGet(model, (Type)null, "Packages", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetAt", array = new object[1] { num }, (string[])null, (Type[])null, array2 = new bool[1] { true });
			if (array2[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			obj = RuntimeHelpers.GetObjectValue(obj2);
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Debug", new object[1] { Operators.AddObject((object)"Package: ", NewLateBinding.LateGet(obj, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, (bool[])null, true);
			if (NewLateBinding.LateGet(obj, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).Equals(MySettingsProperty.Settings.SparxEATargetRepostoryPackageArchiImported))
			{
				flag = true;
				continue;
			}
			num = checked(num + 1);
			MySettings settings;
			string name = (settings = MySettingsProperty.Settings).SparxEATargetRepostoryPackageArchiImported;
			object package = getPackage(ref name, RuntimeHelpers.GetObjectValue(obj));
			settings.SparxEATargetRepostoryPackageArchiImported = name;
			obj = RuntimeHelpers.GetObjectValue(package);
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(obj)))
			{
				flag = true;
			}
		}
		if (!flag)
		{
			obj = null;
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Error", new object[1] { "Package " + MySettingsProperty.Settings.SparxEATargetRepostoryPackageArchiImported + " not found." }, (string[])null, (Type[])null, (bool[])null, true);
		}
		return obj;
	}

	public static object getPackage(ref string name, object contextPackage)
	{
		object obj = null;
		bool flag = false;
		int num = 0;
		while (Conversions.ToBoolean(Operators.AndObject((object)(!flag), Operators.CompareObjectLess((object)num, NewLateBinding.LateGet(NewLateBinding.LateGet(contextPackage, (Type)null, "Packages", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), false))))
		{
			object[] array;
			bool[] array2;
			object obj2 = NewLateBinding.LateGet(NewLateBinding.LateGet(contextPackage, (Type)null, "Packages", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetAt", array = new object[1] { num }, (string[])null, (Type[])null, array2 = new bool[1] { true });
			if (array2[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			obj = RuntimeHelpers.GetObjectValue(obj2);
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Debug", new object[1] { Operators.AddObject((object)"Package: ", NewLateBinding.LateGet(obj, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, (bool[])null, true);
			if (NewLateBinding.LateGet(obj, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).Equals(name))
			{
				flag = true;
				continue;
			}
			num = checked(num + 1);
			obj = RuntimeHelpers.GetObjectValue(getPackage(ref name, RuntimeHelpers.GetObjectValue(obj)));
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(obj)))
			{
				flag = true;
			}
		}
		if (!flag)
		{
			obj = null;
		}
		return obj;
	}
}
