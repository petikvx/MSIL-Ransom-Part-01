using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using com.daudus.My;

namespace com.daudus;

[StandardModule]
internal sealed class ArchiCommon
{
	private static bool ignoreRow = true;

	private static object objFSO;

	private static object objFile;

	private static string strLine;

	public static Hashtable loadElementsFileARCHI()
	{
		Hashtable hashtable = new Hashtable();
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "loadElementsFileARCHI started" }, (string[])null, (Type[])null, (bool[])null, true);
		if (Information.IsNothing(RuntimeHelpers.GetObjectValue(objFSO)))
		{
			objFSO = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject", ""));
		}
		objFile = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objFSO, (Type)null, "OpenTextFile", new object[2]
		{
			MySettingsProperty.Settings.ArchiImportDirectory + MySettingsProperty.Settings.ArchiImportFileElements,
			1
		}, (string[])null, (Type[])null, (bool[])null));
		while (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(objFile, (Type)null, "AtEndOfStream", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			strLine = Conversions.ToString(NewLateBinding.LateGet(objFile, (Type)null, "readline", new object[0], (string[])null, (Type[])null, (bool[])null));
			string[] array = Strings.Split(Strings.Replace(strLine, "\"", "", 1, -1, (CompareMethod)0), ",", -1, (CompareMethod)0);
			ArchiElement value = new ArchiElement(array[0], array[1], array[2], array[3]);
			hashtable.Add(array[0], value);
		}
		NewLateBinding.LateCall(objFile, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { Conversions.ToString(hashtable.Count) + " Elements have been read" }, (string[])null, (Type[])null, (bool[])null, true);
		Hashtable result = hashtable;
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "loadElementsFileARCHI finished" }, (string[])null, (Type[])null, (bool[])null, true);
		return result;
	}

	public static Hashtable loadPropertiesFileARCHI()
	{
		Hashtable hashtable = new Hashtable();
		int num = 0;
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "loadPropertiesFileARCHI started" }, (string[])null, (Type[])null, (bool[])null, true);
		ignoreRow = true;
		if (Information.IsNothing(RuntimeHelpers.GetObjectValue(objFSO)))
		{
			objFSO = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject", ""));
		}
		objFile = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objFSO, (Type)null, "OpenTextFile", new object[2]
		{
			MySettingsProperty.Settings.ArchiImportDirectory + MySettingsProperty.Settings.ArchiImportFileProperties,
			1
		}, (string[])null, (Type[])null, (bool[])null));
		while (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(objFile, (Type)null, "AtEndOfStream", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			strLine = Conversions.ToString(NewLateBinding.LateGet(objFile, (Type)null, "readline", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (ignoreRow)
			{
				ignoreRow = false;
				continue;
			}
			num = checked(num + 1);
			string[] array = Strings.Split(Strings.Replace(strLine, "\"", "", 1, -1, (CompareMethod)0), ",", -1, (CompareMethod)0);
			ArchiProperty archiProperty = new ArchiProperty(array[0], array[1], array[2]);
			ArrayList arrayList;
			if (hashtable.ContainsKey(archiProperty.ID))
			{
				arrayList = (ArrayList)hashtable[archiProperty.ID];
			}
			else
			{
				arrayList = new ArrayList();
				hashtable.Add(array[0], arrayList);
			}
			arrayList.Add(archiProperty);
		}
		NewLateBinding.LateCall(objFile, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { Conversions.ToString(hashtable.Count) + " Elements have Properties and they have been read. And also " + Conversions.ToString(num) + " Properties have been read" }, (string[])null, (Type[])null, (bool[])null, true);
		Hashtable result = hashtable;
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "loadPropertiesFileARCHI finished" }, (string[])null, (Type[])null, (bool[])null, true);
		return result;
	}

	public static Hashtable loadRelationsFileARCHI()
	{
		Hashtable hashtable = new Hashtable();
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "loadRelationsFileARCHI started" }, (string[])null, (Type[])null, (bool[])null, true);
		ignoreRow = true;
		if (Information.IsNothing(RuntimeHelpers.GetObjectValue(objFSO)))
		{
			objFSO = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject", ""));
		}
		objFile = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objFSO, (Type)null, "OpenTextFile", new object[2]
		{
			MySettingsProperty.Settings.ArchiImportDirectory + MySettingsProperty.Settings.ArchiImportFileRelations,
			1
		}, (string[])null, (Type[])null, (bool[])null));
		while (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(objFile, (Type)null, "AtEndOfStream", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			strLine = Conversions.ToString(NewLateBinding.LateGet(objFile, (Type)null, "readline", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (ignoreRow)
			{
				ignoreRow = false;
				continue;
			}
			string[] array = Strings.Split(Strings.Replace(strLine, "\"", "", 1, -1, (CompareMethod)0), ",", -1, (CompareMethod)0);
			ArchiRelation value = new ArchiRelation(array[0], array[1], array[2], array[3], array[4], array[5]);
			hashtable.Add(array[0], value);
		}
		NewLateBinding.LateCall(objFile, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { Conversions.ToString(hashtable.Count) + " Relations have been read" }, (string[])null, (Type[])null, (bool[])null, true);
		Hashtable result = hashtable;
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "loadRelationsFileARCHI finished" }, (string[])null, (Type[])null, (bool[])null, true);
		return result;
	}

	public static string saveElementsFileARCHI(ref string[] columsMappedElementsFileARCHI, ref Hashtable archiElements)
	{
		string result = null;
		StreamWriter streamWriter = File.CreateText("c:\\Users\\david.skarka\\Documents\\Priv\\MTU\\test.csv");
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "saveElementsFileARCHI started" }, (string[])null, (Type[])null, (bool[])null, true);
		ICollection keys = archiElements.Keys;
		ConsoleSpiner consoleSpiner = new ConsoleSpiner(keys.Count, 1);
		StringBuilder stringBuilder = _mappedScvRow(columsMappedElementsFileARCHI);
		streamWriter.Write(stringBuilder.ToString());
		streamWriter.Write(Environment.NewLine);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = keys.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string key = Conversions.ToString(enumerator.Current);
				consoleSpiner.Turn();
				ArchiElement archiElement = (ArchiElement)archiElements[key];
				stringBuilder = _mappedScvRow(archiElement.toStringArray());
				streamWriter.Write(stringBuilder.ToString());
				streamWriter.Write(Environment.NewLine);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		streamWriter.Close();
		stringBuilder = null;
		consoleSpiner.Finish();
		NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "saveElementsFileARCHI finished" }, (string[])null, (Type[])null, (bool[])null, true);
		return result;
	}

	private static StringBuilder _mappedScvRow(string[] columns)
	{
		StringBuilder stringBuilder = new StringBuilder();
		byte b = 1;
		checked
		{
			foreach (string value in columns)
			{
				stringBuilder.Append("\"").Append(value).Append("\"");
				if (b < columns.Length)
				{
					stringBuilder.Append(",");
				}
				b = (byte)(unchecked((int)b) + 1);
			}
			return stringBuilder;
		}
	}
}
