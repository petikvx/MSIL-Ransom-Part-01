using System;
using System.Runtime.Serialization;
using Microsoft.VisualBasic.CompilerServices;

internal sealed class JumboJelly : SerializationBinder
{
	public override Type BindToType(string junoArsLos, string fundyMundy)
	{
		try
		{
			return Type.GetType(fundyMundy, throwOnError: true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Type typeFromHandle = typeof(FoodistTaphinia);
			ProjectData.ClearProjectError();
			return typeFromHandle;
		}
	}
}
