using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace com.daudus;

internal class Gap
{
	private string pId;

	private string pName;

	private string pDescription;

	private string pImpact;

	private object pImpactedConcepts;

	public string Id
	{
		get
		{
			return pId;
		}
		set
		{
			pId = value;
		}
	}

	public string Name
	{
		get
		{
			return pName;
		}
		set
		{
			pName = value;
		}
	}

	public string Description
	{
		get
		{
			return pDescription;
		}
		set
		{
			pDescription = value;
		}
	}

	public string Impact
	{
		get
		{
			return pImpact;
		}
		set
		{
			pImpact = value;
		}
	}

	public object ImpactedConcepts
	{
		get
		{
			return pImpactedConcepts;
		}
		set
		{
		}
	}

	public Gap(string Id, string FullName, string GapDescription)
	{
		if (Strings.Len(FullName) > 0)
		{
			pDescription = GapDescription;
			object obj = Strings.InStr(FullName, ":", (CompareMethod)0);
			if (Operators.ConditionalCompareObjectEqual(obj, (object)0, false))
			{
				NewLateBinding.LateCall(Common.lLOG, (Type)null, "Error", new object[1] { "Gap <" + FullName + "> does not have impact or character \":\" is missing " }, (string[])null, (Type[])null, (bool[])null, true);
				pName = FullName;
			}
			else
			{
				pImpact = Strings.Mid(FullName, 1, Conversions.ToInteger(Operators.SubtractObject(obj, (object)1)));
				pName = Strings.Mid(FullName, Conversions.ToInteger(Operators.AddObject(obj, (object)1)), Strings.Len(FullName));
			}
		}
		else
		{
			NewLateBinding.LateCall(Common.lLOG, (Type)null, "Error", new object[1] { "Gap does not have name " }, (string[])null, (Type[])null, (bool[])null, true);
		}
		pId = Id;
	}
}
