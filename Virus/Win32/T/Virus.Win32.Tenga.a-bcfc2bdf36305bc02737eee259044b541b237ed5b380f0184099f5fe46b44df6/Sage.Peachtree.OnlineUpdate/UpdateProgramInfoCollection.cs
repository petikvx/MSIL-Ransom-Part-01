using System;
using System.Collections;
using System.Text;

namespace Sage.Peachtree.OnlineUpdate;

internal class UpdateProgramInfoCollection : CollectionBase
{
	private const string INIValueVersionString = "Version";

	private const string INIValueImportanceString = "Importance";

	private const string INIValueShortDescriptionString = "ShortDescription";

	private const string INIValueLongDescriptionString = "LongDescription";

	private const string INIValueDescriptionURLString = "DescriptionURL";

	private const string INIValueDependencyString = "Dependency";

	private const string INIValueURLString = "URL";

	private const string INIValueDatabaseConversionString = "RequiresDatabaseConversion";

	private const string INIValueRequiresAdminRightsString = "RequiresAdminRights";

	private const string INIValueTaxUpdateString = "IsTaxUpdate";

	private const string INIValueServerPatchString = "ServerPatch";

	public UpdateProgramInfo this[int index]
	{
		get
		{
			return (UpdateProgramInfo)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public int Add(UpdateProgramInfo value)
	{
		return base.List.Add(value);
	}

	public int IndexOf(UpdateProgramInfo value)
	{
		return base.List.IndexOf(value);
	}

	public void Insert(int index, UpdateProgramInfo value)
	{
		base.List.Insert(index, value);
	}

	public void Remove(UpdateProgramInfo value)
	{
		base.List.Remove(value);
	}

	public bool Contains(UpdateProgramInfo value)
	{
		return base.List.Contains(value);
	}

	public ArrayList GetSortedArrayList()
	{
		ArrayList innerList = base.InnerList;
		innerList.Sort();
		return innerList;
	}

	protected override void OnInsert(int index, object value)
	{
	}

	protected override void OnRemove(int index, object value)
	{
	}

	protected override void OnSet(int index, object oldValue, object newValue)
	{
	}

	protected override void OnValidate(object value)
	{
		if ((object)value.GetType() != Type.GetType("Sage.Peachtree.OnlineUpdate.UpdateProgramInfo"))
		{
			throw new ArgumentException("value must be of type UpdateProgramInfo.", "value");
		}
	}

	public static void FillCollectionFromINI(UpdateProgramInfoCollection collection, string INIFile, CheckUpdateProgramValidToAdd Event)
	{
		collection.Clear();
		string[] privateProfileSectionNames = Win32.GetPrivateProfileSectionNames(INIFile);
		StringBuilder stringBuilder = new StringBuilder(1024);
		string value = OnlineUpdateApp.Instance.Flavor + ' ';
		string[] array = privateProfileSectionNames;
		foreach (string text in array)
		{
			if (text.StartsWith(value))
			{
				Win32.GetPrivateProfileStringA(text, "Version", "", stringBuilder, 1024, INIFile);
				string version = stringBuilder.ToString();
				Win32.GetPrivateProfileStringA(text, "Importance", "0", stringBuilder, 1024, INIFile);
				int importance = Convert.ToInt32(stringBuilder.ToString());
				Win32.GetPrivateProfileStringA(text, "ShortDescription", "", stringBuilder, 1024, INIFile);
				string shortDescription = stringBuilder.ToString();
				Win32.GetPrivateProfileStringA(text, "LongDescription", "", stringBuilder, 1024, INIFile);
				string longDescription = stringBuilder.ToString();
				Win32.GetPrivateProfileStringA(text, "DescriptionURL", "", stringBuilder, 1024, INIFile);
				string descriptionURL = stringBuilder.ToString();
				Win32.GetPrivateProfileStringA(text, "Dependency", "", stringBuilder, 1024, INIFile);
				string dependency = stringBuilder.ToString();
				Win32.GetPrivateProfileStringA(text, "URL", "", stringBuilder, 1024, INIFile);
				string url = stringBuilder.ToString();
				Win32.GetPrivateProfileStringA(text, "RequiresDatabaseConversion", "FALSE", stringBuilder, 1024, INIFile);
				bool requiresDBConversion = Convert.ToBoolean(stringBuilder.ToString());
				Win32.GetPrivateProfileStringA(text, "RequiresAdminRights", "FALSE", stringBuilder, 1024, INIFile);
				bool requiresAdminRights = Convert.ToBoolean(stringBuilder.ToString());
				Win32.GetPrivateProfileStringA(text, "IsTaxUpdate", "FALSE", stringBuilder, 1024, INIFile);
				bool isTaxUpdate = Convert.ToBoolean(stringBuilder.ToString());
				Win32.GetPrivateProfileStringA(text, "ServerPatch", "FALSE", stringBuilder, 1024, INIFile);
				bool isServerPatch = Convert.ToBoolean(stringBuilder.ToString());
				bool flag = true;
				if (Event != null)
				{
					flag = Event(text, version, url, isTaxUpdate);
				}
				if (flag)
				{
					collection.Add(new UpdateProgramInfo(text, version, importance, shortDescription, longDescription, descriptionURL, dependency, url, requiresDBConversion, requiresAdminRights, isTaxUpdate, isServerPatch));
				}
			}
		}
	}
}
