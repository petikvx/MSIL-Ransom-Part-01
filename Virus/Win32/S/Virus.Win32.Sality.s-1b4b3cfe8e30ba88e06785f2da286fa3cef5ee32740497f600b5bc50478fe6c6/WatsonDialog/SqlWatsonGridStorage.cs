using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using MSClusterLib;
using Microsoft.SqlServer;
using Microsoft.SqlServer.Management.Diagnostics;
using Microsoft.SqlServer.Management.UI.Grid;
using Microsoft.Win32;

namespace WatsonDialog;

internal class SqlWatsonGridStorage : IGridStorage
{
	private List<Instance> m_instances;

	private InstanceComparer m_comparer;

	internal SqlWatsonGridStorage()
	{
		m_instances = new List<Instance>();
		m_comparer = new InstanceComparer(Comparer.Default);
		InitializeInstanceAgnosticComponents(wow: false);
		InitializeInstanceAgnosticComponents(wow: true);
		InitializeInstanceAwareComponents(wow: false);
		InitializeInstanceAwareComponents(wow: true);
	}

	internal void SortByColumn(int column, bool descending)
	{
		m_comparer.Column = column;
		m_comparer.Descending = descending;
		m_instances.Sort(m_comparer);
	}

	private void InitializeInstanceAgnosticComponents(bool wow)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		string text = (wow ? "SOFTWARE\\Wow6432Node\\Microsoft\\Microsoft SQL Server\\90" : "SOFTWARE\\Microsoft\\Microsoft SQL Server\\90");
		if (RegistryInteractor.KeyExists(Constants.BASE_REGKEY, text))
		{
			object obj = null;
			Instance instance = new Instance();
			instance.instanceName = Constants.INSTANCE_AGNOSTIC_STRING;
			instance.instanceType = (wow ? Constants.WOW_COMPONENT_AGNOSTIC_STRING : Constants.COMPONENT_AGNOSTIC_STRING);
			instance.instanceID = (wow ? "<WOW_AGNOSTIC>" : "<AGNOSTIC>");
			obj = RegistryInteractor.GetRegKeyValue(Constants.BASE_REGKEY, text, "CustomerFeedback", Constants.USAGE_CHECKBOX_COLUMN_HEADER, instance.DisplayName);
			instance.usageChecked = (GridCheckBoxState)((!1.Equals(obj)) ? 1 : 0);
			obj = RegistryInteractor.GetRegKeyValue(Constants.BASE_REGKEY, text, "EnableErrorReporting", Constants.ERROR_CHECKBOX_COLUMN_HEADER, instance.DisplayName);
			instance.errorChecked = (GridCheckBoxState)((!1.Equals(obj)) ? 1 : 0);
			obj = RegistryInteractor.GetRegKeyValue(Constants.BASE_REGKEY, text, "ErrorReportingDir", Constants.ERROR_REPORTS_COLUMN_HEADER, instance.DisplayName);
			instance.errorDir = ((obj != null) ? obj.ToString() : "");
			instance.isWow = wow;
			instance.canWrite = true;
			m_instances.Add(instance);
		}
	}

	private void InitializeInstanceAwareComponents(bool wow)
	{
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		string keyStr = (wow ? "SOFTWARE\\Wow6432Node\\Microsoft\\Microsoft SQL Server\\Instance Names" : "SOFTWARE\\Microsoft\\Microsoft SQL Server\\Instance Names");
		RegistryKey regKey = RegistryInteractor.GetRegKey(Constants.BASE_REGKEY, keyStr, null, showError: false);
		if (regKey == null)
		{
			return;
		}
		RegistryKey[] subRegKeys = RegistryInteractor.GetSubRegKeys(regKey);
		if (subRegKeys == null)
		{
			return;
		}
		RegistryKey[] array = subRegKeys;
		foreach (RegistryKey registryKey in array)
		{
			string[] valueNames = registryKey.GetValueNames();
			foreach (string text in valueNames)
			{
				Instance instance = new Instance();
				instance.instanceID = registryKey.GetValue(text, "") as string;
				if (instance.instanceID == null)
				{
					instance.instanceID = "";
				}
				if (!(instance.instanceID == "MSSQL.2005"))
				{
					if ("MSSQLSERVER".Equals(text))
					{
						instance.instanceName = Constants.DEFAULT_INSTANCE_DISPLAY_NAME;
					}
					else
					{
						instance.instanceName = text;
					}
					string text2 = registryKey.Name;
					if (text2 == null)
					{
						text2 = "";
					}
					try
					{
						text2 = registryKey.Name.Substring(registryKey.Name.LastIndexOf("\\") + 1);
					}
					catch (ArgumentOutOfRangeException ex)
					{
						STrace.LogExCatch((Exception)ex);
					}
					string instanceType = "";
					switch (text2)
					{
					case "RS":
						instanceType = Constants.COMPONENT_REPORT_SERVER_STRING;
						break;
					case "OLAP":
						instanceType = Constants.COMPONENT_ANALYSIS_SERVER_STRING;
						break;
					case "SQL":
						instanceType = Constants.COMPONENT_SQL_SERVER_STRING;
						break;
					}
					instance.instanceType = instanceType;
					string text3 = (wow ? "SOFTWARE\\Wow6432Node\\Microsoft\\Microsoft SQL Server" : "SOFTWARE\\Microsoft\\Microsoft SQL Server");
					string keyStr2 = text3 + "\\" + instance.instanceID + "\\CPE";
					string keyStr3 = text3 + "\\" + instance.instanceID + "\\Cluster";
					if (!(RegistryInteractor.GetRegKeyValue(Constants.BASE_REGKEY, keyStr3, "ClusterName") is string networkName))
					{
						instance.canWrite = true;
					}
					else if (instance.instanceType == Constants.COMPONENT_SQL_SERVER_STRING)
					{
						instance.canWrite = IsSqlServerInstanceWriteable(networkName);
					}
					else if (instance.instanceType == Constants.COMPONENT_ANALYSIS_SERVER_STRING)
					{
						string instanceFriendlyName = ((instance.instanceName == Constants.DEFAULT_INSTANCE_DISPLAY_NAME) ? "MSSQLSERVER" : instance.instanceName);
						instance.canWrite = IsOlapInstanceWriteable(instanceFriendlyName);
					}
					else
					{
						instance.canWrite = true;
					}
					if (instance.canWrite)
					{
						object obj = null;
						obj = RegistryInteractor.GetRegKeyValue(Constants.BASE_REGKEY, keyStr2, "CustomerFeedback", Constants.USAGE_CHECKBOX_COLUMN_HEADER, instance.DisplayName);
						instance.usageChecked = (GridCheckBoxState)((!1.Equals(obj)) ? 1 : 0);
						obj = RegistryInteractor.GetRegKeyValue(Constants.BASE_REGKEY, keyStr2, "EnableErrorReporting", Constants.ERROR_CHECKBOX_COLUMN_HEADER, instance.DisplayName);
						instance.errorChecked = (GridCheckBoxState)((!1.Equals(obj)) ? 1 : 0);
						obj = RegistryInteractor.GetRegKeyValue(Constants.BASE_REGKEY, keyStr2, "ErrorDumpDir", Constants.ERROR_REPORTS_COLUMN_HEADER, instance.DisplayName);
						instance.errorDir = ((obj == null) ? "" : (obj as string));
					}
					else
					{
						instance.usageChecked = (GridCheckBoxState)3;
						instance.errorChecked = (GridCheckBoxState)3;
						instance.errorDir = "";
					}
					instance.isWow = wow;
					m_instances.Add(instance);
				}
			}
		}
	}

	private static ISClusResource FindResourceFromPrivateProperty(string resourceType, string propertyName, string propertyValue)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		ISCluster val = (ISCluster)new ClusterClass();
		val.Open(string.Empty);
		ISClusResTypeResources resources = (ISClusResTypeResources)(object)((ISClusResType)((ISClusResTypes)val.get_ResourceTypes()).get_Item((object)resourceType)).get_Resources();
		foreach (ISClusResource item in resources)
		{
			ISClusResource val2 = item;
			if (string.Compare((string)((ISClusProperty)((ISClusProperties)val2.get_PrivateProperties()).get_Item((object)propertyName)).get_Value(), propertyValue, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
			{
				return val2;
			}
		}
		return null;
	}

	private static bool IsInstanceWriteable(string resourceType, string propertyName, string propertyValue)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ISClusResource val = FindResourceFromPrivateProperty(resourceType, propertyName, propertyValue);
			if (val == null)
			{
				ErrorHandler.Error(Constants.GENERIC_CONFIGURATION_ERROR);
				return false;
			}
			if (string.Compare(Environment.MachineName, ((ISClusNode)val.get_OwnerNode()).get_Name(), ignoreCase: true, CultureInfo.InvariantCulture) != 0)
			{
				return false;
			}
			if ((int)val.get_State() != 2)
			{
				return false;
			}
			return true;
		}
		catch (COMException ex)
		{
			STrace.LogExCatch((Exception)ex);
			ErrorHandler.Error(Constants.GENERIC_CONFIGURATION_ERROR);
			return false;
		}
	}

	private static bool IsSqlServerInstanceWriteable(string networkName)
	{
		return IsInstanceWriteable("SQL Server", "VirtualServerName", networkName);
	}

	private static bool IsOlapInstanceWriteable(string instanceFriendlyName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		INST_ID val = new INST_ID();
		bool svcInstanceIDFromName;
		if (!(svcInstanceIDFromName = InstAPI.GetSvcInstanceIDFromName(instanceFriendlyName, (SQL_SVCS)3, val)))
		{
			ErrorHandler.Error(Constants.GENERIC_CONFIGURATION_ERROR);
			return false;
		}
		StringBuilder stringBuilder = new StringBuilder();
		uint capacity = (uint)stringBuilder.Capacity;
		if (!(svcInstanceIDFromName = InstAPI.GetSQLServiceByID(val, (SQL_SVCS)3, stringBuilder, ref capacity)) && (int)capacity > stringBuilder.Capacity)
		{
			stringBuilder.Capacity = (int)capacity;
			svcInstanceIDFromName = InstAPI.GetSQLServiceByID(val, (SQL_SVCS)3, stringBuilder, ref capacity);
		}
		if (!svcInstanceIDFromName)
		{
			ErrorHandler.Error(Constants.GENERIC_CONFIGURATION_ERROR);
			return false;
		}
		return IsInstanceWriteable("Generic Service", "ServiceName", stringBuilder.ToString());
	}

	public long NumRows()
	{
		return m_instances.Count;
	}

	public long EnsureRowsInBuf(long FirstRowIndex, long LastRowIndex)
	{
		return m_instances.Count;
	}

	public string GetCellDataAsString(long nRowIndex, int nColIndex)
	{
		return GetInstanceData(nRowIndex, nColIndex) as string;
	}

	public int IsCellEditable(long nRowIndex, int nColIndex)
	{
		switch (nColIndex)
		{
		default:
			if (GetInstance(nRowIndex).canWrite)
			{
				return 1;
			}
			return 0;
		case 2:
		case 3:
			return 0;
		case 0:
		case 1:
		case 5:
			return 0;
		}
	}

	public Bitmap GetCellDataAsBitmap(long nRowIndex, int nColIndex)
	{
		return null;
	}

	public void GetCellDataForButton(long nRowIndex, int nColIndex, out ButtonCellState state, out Bitmap image, out string buttonLabel)
	{
		state = (ButtonCellState)1;
		image = null;
		buttonLabel = Constants.BROWSE_BUTTON_TEXT;
	}

	public GridCheckBoxState GetCellDataForCheckBox(long nRowIndex, int nColIndex)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		AssertColumnIsCheckBox(nColIndex);
		return (GridCheckBoxState)GetInstanceData(nRowIndex, nColIndex);
	}

	public void FillControlWithData(long nRowIndex, int nColIndex, IGridEmbeddedControl control)
	{
		control.AddDataAsString(GetInstanceData(nRowIndex, nColIndex) as string);
	}

	public bool SetCellDataFromControl(long nRowIndex, int nColIndex, IGridEmbeddedControl control)
	{
		SetInstanceData(nRowIndex, nColIndex, TruncateString(control.GetCurSelectionAsString()));
		return true;
	}

	private static void AssertColumnIsCheckBox(int nColIndex)
	{
	}

	private static GridCheckBoxState GetResultingState(GridCheckBoxState initialState)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)initialState != 0)
		{
			if ((int)initialState != 1)
			{
				return (GridCheckBoxState)4;
			}
			return (GridCheckBoxState)0;
		}
		return (GridCheckBoxState)1;
	}

	internal void ToggleCheckBox(long nRowIndex, int nColIndex)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		AssertColumnIsCheckBox(nColIndex);
		SetInstanceData(nRowIndex, nColIndex, GetResultingState((GridCheckBoxState)GetInstanceData(nRowIndex, nColIndex)));
	}

	internal bool AreAllCheckBoxesChecked(int nColIndex)
	{
		AssertColumnIsCheckBox(nColIndex);
		int num = 0;
		while (true)
		{
			if (num < m_instances.Count)
			{
				if (m_instances[num].canWrite && !((object)(GridCheckBoxState)0).Equals(GetInstanceData(num, nColIndex)))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	internal bool AreAllCheckBoxesUnchecked(int nColIndex)
	{
		AssertColumnIsCheckBox(nColIndex);
		int num = 0;
		while (true)
		{
			if (num < m_instances.Count)
			{
				if (m_instances[num].canWrite && !((object)(GridCheckBoxState)1).Equals(GetInstanceData(num, nColIndex)))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	internal void SelectAllCheckBoxes(int nColIndex, bool toCheck)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		AssertColumnIsCheckBox(nColIndex);
		GridCheckBoxState val = (GridCheckBoxState)((!toCheck) ? 1 : 0);
		for (int i = 0; i < m_instances.Count; i++)
		{
			if (m_instances[i].canWrite)
			{
				SetInstanceData(i, nColIndex, val);
			}
		}
	}

	internal Instance GetInstance(long nRowIndex)
	{
		return m_instances[(int)nRowIndex];
	}

	internal long GetRow(Instance inst)
	{
		return m_instances.IndexOf(inst);
	}

	internal object GetInstanceData(long nRowIndex, int nColIndex)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		Instance instance = GetInstance(nRowIndex);
		return nColIndex switch
		{
			0 => instance.instanceName, 
			1 => instance.instanceType, 
			2 => instance.usageChecked, 
			3 => instance.errorChecked, 
			4 => instance.errorDir, 
			_ => null, 
		};
	}

	internal void SetInstanceData(long nRowIndex, int nColIndex, object value)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Instance instance = GetInstance(nRowIndex);
		string text = value as string;
		switch (nColIndex)
		{
		case 0:
			instance.instanceName = text;
			break;
		case 1:
			instance.instanceType = text;
			break;
		case 2:
			instance.usageChecked = (GridCheckBoxState)value;
			break;
		case 3:
			instance.errorChecked = (GridCheckBoxState)value;
			break;
		case 4:
			instance.errorDir = TruncateString(value);
			break;
		}
	}

	private static string TruncateString(object obj)
	{
		string text = obj as string;
		if (text != null && text.Length > 247)
		{
			text = text.Substring(0, 247);
		}
		return text;
	}
}
