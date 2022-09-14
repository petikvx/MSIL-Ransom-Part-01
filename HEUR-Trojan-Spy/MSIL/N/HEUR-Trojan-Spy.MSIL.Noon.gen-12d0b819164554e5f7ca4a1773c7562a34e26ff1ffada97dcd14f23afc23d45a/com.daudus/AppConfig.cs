using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace com.daudus;

public class AppConfig
{
	private const string cParameterSwitch = "-";

	private const string cParameterSeparator = "=";

	private const string cOperationSwitch = "op";

	private const string cOperationCleanImport = "cleanimport";

	private const string cOperationImport = "import";

	private bool pOperationCleanImport;

	private bool pOperationImport;

	public string OperationCleanImport => Conversions.ToString(pOperationCleanImport);

	public string OperationImport => Conversions.ToString(pOperationImport);

	public AppConfig(ref string[] sArgs)
		: this(OperationCleanImport: false, OperationImport: false)
	{
		string text = "";
		if (sArgs.Length == 0)
		{
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Fatal", new object[1] { "No arguments passed in command line. Try '-op=cleanimport'" }, (string[])null, (Type[])null, (bool[])null, true);
		}
		else
		{
			dumpArguments(ref sArgs);
			string[] array = sArgs;
			for (int i = 0; i < array.Length; i = checked(i + 1))
			{
				string text2 = array[i];
				text2 = text2.ToLower();
				if (text2.StartsWith("-op=".ToLower()))
				{
					string text3 = text2.Remove(0, "-op=".Length);
					string text4 = text3;
					if (Operators.CompareString(text4, "cleanimport".ToLower(), false) == 0)
					{
						pOperationCleanImport = true;
					}
					else if (Operators.CompareString(text4, "import".ToLower(), false) == 0)
					{
						pOperationImport = true;
					}
				}
			}
		}
		text = validate();
		if (!Information.IsNothing((object)text))
		{
			object lLOG = Common.lLOG;
			object[] obj = new object[1] { text };
			object[] array2 = obj;
			bool[] obj2 = new bool[1] { true };
			bool[] array3 = obj2;
			NewLateBinding.LateCall(lLOG, (Type)null, "Fatal", obj, (string[])null, (Type[])null, obj2, true);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
			}
			throw new Exception(text);
		}
	}

	public AppConfig(bool OperationCleanImport, bool OperationImport)
	{
		pOperationCleanImport = false;
		pOperationImport = false;
		pOperationCleanImport = OperationCleanImport;
		pOperationImport = OperationImport;
	}

	private string validate()
	{
		string result = null;
		if (!(pOperationCleanImport | pOperationImport))
		{
			result = "No valid arguments passed in command line";
		}
		else if (pOperationCleanImport & pOperationImport)
		{
			result = "Incompatible arguments passed";
		}
		else if (pOperationCleanImport)
		{
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "System will perform cleanimport" }, (string[])null, (Type[])null, (bool[])null, true);
		}
		else if (pOperationImport)
		{
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "System will perform import" }, (string[])null, (Type[])null, (bool[])null, true);
		}
		return result;
	}

	private void dumpArguments(ref string[] sArgs)
	{
		for (int i = 0; i < sArgs.Length; i = checked(i + 1))
		{
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Info", new object[1] { "param: " + sArgs[i] }, (string[])null, (Type[])null, (bool[])null, true);
		}
	}
}
