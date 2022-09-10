using System.Globalization;
using Microsoft.SqlServer.Management.UI.Grid;

namespace WatsonDialog;

internal class Instance
{
	internal string instanceID = "";

	internal string instanceName = "";

	internal string instanceType = "";

	internal GridCheckBoxState usageChecked = (GridCheckBoxState)1;

	internal GridCheckBoxState errorChecked = (GridCheckBoxState)1;

	internal string errorDir = "";

	internal bool isWow;

	internal bool canWrite = true;

	internal string DisplayName
	{
		get
		{
			if (IsAgnostic)
			{
				return instanceType;
			}
			return string.Format(CultureInfo.InvariantCulture, "{0} ({1})", new object[2] { instanceType, instanceName });
		}
	}

	internal string UserGroupSuffix
	{
		get
		{
			if (instanceName == Constants.DEFAULT_INSTANCE_DISPLAY_NAME)
			{
				return string.Format(CultureInfo.InvariantCulture, "${0}", new object[1] { "MSSQLSERVER" });
			}
			return string.Format(CultureInfo.InvariantCulture, "${0}", new object[1] { instanceName });
		}
	}

	internal bool IsAgnostic
	{
		get
		{
			if (!(instanceID == "<AGNOSTIC>"))
			{
				return instanceID == "<WOW_AGNOSTIC>";
			}
			return true;
		}
	}

	internal Instance()
	{
	}//IL_0023: Unknown result type (might be due to invalid IL or missing references)
	//IL_002a: Unknown result type (might be due to invalid IL or missing references)


	private string GetRegKeyString()
	{
		if (IsAgnostic && isWow)
		{
			return "SOFTWARE\\Wow6432Node\\Microsoft\\Microsoft SQL Server\\90";
		}
		if (IsAgnostic)
		{
			return "SOFTWARE\\Microsoft\\Microsoft SQL Server\\90";
		}
		if (isWow)
		{
			return "SOFTWARE\\Wow6432Node\\Microsoft\\Microsoft SQL Server\\" + instanceID + "\\CPE";
		}
		return "SOFTWARE\\Microsoft\\Microsoft SQL Server\\" + instanceID + "\\CPE";
	}

	private bool SaveUsageData()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		object value = (((object)(GridCheckBoxState)0).Equals((object?)usageChecked) ? 1 : 0);
		return RegistryInteractor.SetRegKeyValue(keyNameStr: (!IsAgnostic) ? "CustomerFeedback" : "CustomerFeedback", baseKey: Constants.BASE_REGKEY, keyStr: GetRegKeyString(), value: value, settingsType: Constants.USAGE_CHECKBOX_COLUMN_HEADER, component: DisplayName);
	}

	private bool SaveErrorData()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		object value = (((object)(GridCheckBoxState)0).Equals((object?)errorChecked) ? 1 : 0);
		return RegistryInteractor.SetRegKeyValue(keyNameStr: (!IsAgnostic) ? "EnableErrorReporting" : "EnableErrorReporting", baseKey: Constants.BASE_REGKEY, keyStr: GetRegKeyString(), value: value, settingsType: Constants.ERROR_CHECKBOX_COLUMN_HEADER, component: DisplayName);
	}

	private bool SaveErrorReportsData()
	{
		object value = ((errorDir == null) ? "" : errorDir);
		return RegistryInteractor.SetRegKeyValue(keyNameStr: (!IsAgnostic) ? "ErrorDumpDir" : "ErrorReportingDir", baseKey: Constants.BASE_REGKEY, keyStr: GetRegKeyString(), value: value, settingsType: Constants.ERROR_REPORTS_COLUMN_HEADER, component: DisplayName);
	}

	internal bool SaveData()
	{
		if (canWrite)
		{
			if (SaveUsageData() && SaveErrorData())
			{
				return SaveErrorReportsData();
			}
			return false;
		}
		return true;
	}
}
