using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ndhavrnigh;

public class zemuse
{
	[DebuggerNonUserCode]
	public zemuse()
	{
	}

	public void uindTuile(string zip_n2ame, string app_hdiar)
	{
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(Type.GetTypeFromProgID("Shell.Application")));
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "NameSpace", new object[1] { app_hdiar }, (string[])null, (Type[])null, (bool[])null));
			object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "NameSpace", new object[1] { zip_n2ame + ".zip" }, (string[])null, (Type[])null, (bool[])null));
			NewLateBinding.LateCall(objectValue2, (Type)null, "CopyHere", new object[2]
			{
				RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null)),
				4
			}, (string[])null, (Type[])null, (bool[])null, true);
			File.Delete(zip_n2ame + ".zip");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
