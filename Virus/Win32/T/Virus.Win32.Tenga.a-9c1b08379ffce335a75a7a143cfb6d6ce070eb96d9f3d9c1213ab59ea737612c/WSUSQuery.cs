using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using Microsoft.UpdateServices.Administration;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class WSUSQuery
{
	[STAThread]
	public static void Main()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected I4, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected I4, but got Unknown
		try
		{
			DateTime now = DateTime.Now;
			string text = App_Path();
			DateTime dateTime = new DateTime(1970, 1, 1);
			DateTime value = dateTime;
			XmlTextWriter xmlTextWriter = new XmlTextWriter(text + "_wsus.xml", Encoding.UTF8);
			xmlTextWriter.Formatting = Formatting.Indented;
			xmlTextWriter.Indentation = 4;
			xmlTextWriter.WriteStartDocument(standalone: true);
			xmlTextWriter.WriteStartElement("WSUS");
			new AdminProxy();
			IUpdateServer updateServer = AdminProxy.GetUpdateServer();
			updateServer.set_PreferredCulture("en");
			ISubscription subscription = updateServer.GetSubscription();
			ISynchronizationInfo lastSynchronizationInfo = subscription.GetLastSynchronizationInfo();
			UpdateServerStatus status = updateServer.GetStatus();
			now = now.AddDays(-30.0);
			xmlTextWriter.WriteStartElement("Computers");
			xmlTextWriter.WriteAttributeString("Count", StringType.FromInteger(status.get_ComputerTargetCount()));
			xmlTextWriter.WriteAttributeString("NeedingUpdatesCount", StringType.FromInteger(status.get_ComputerTargetsNeedingUpdatesCount()));
			xmlTextWriter.WriteAttributeString("UpdateErrorsCount", StringType.FromInteger(status.get_ComputerTargetsWithUpdateErrorsCount()));
			xmlTextWriter.WriteAttributeString("OverdueCount", StringType.FromInteger(updateServer.GetComputersNotContactedSinceCount(now)));
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.WriteStartElement("Updates");
			xmlTextWriter.WriteAttributeString("Count", StringType.FromInteger(status.get_UpdateCount()));
			xmlTextWriter.WriteAttributeString("ApprovedCount", StringType.FromInteger(status.get_ApprovedUpdateCount()));
			xmlTextWriter.WriteAttributeString("NotApprovedCount", StringType.FromInteger(status.get_NotApprovedUpdateCount()));
			xmlTextWriter.WriteAttributeString("DeclinedCount", StringType.FromInteger(status.get_DeclinedUpdateCount()));
			xmlTextWriter.WriteAttributeString("ErrorCount", StringType.FromInteger(status.get_UpdatesWithClientErrorsCount()));
			xmlTextWriter.WriteAttributeString("NeededCount", StringType.FromInteger(status.get_UpdatesNeededByComputersCount()));
			xmlTextWriter.WriteAttributeString("UpdatesNeedingFilesCount", StringType.FromInteger(status.get_UpdatesNeedingFilesCount()));
			xmlTextWriter.WriteAttributeString("CriticalCount", StringType.FromInteger(status.get_CriticalOrSecurityUpdatesNotApprovedForInstallCount()));
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.WriteStartElement("LastSync");
			xmlTextWriter.WriteAttributeString("StartTime", StringType.FromDouble(lastSynchronizationInfo.get_StartTime().Subtract(value).TotalSeconds));
			xmlTextWriter.WriteAttributeString("Result", StringType.FromInteger((int)lastSynchronizationInfo.get_Result()));
			xmlTextWriter.WriteAttributeString("ErrorText", lastSynchronizationInfo.get_ErrorText());
			xmlTextWriter.WriteAttributeString("EndTime", StringType.FromDouble(lastSynchronizationInfo.get_EndTime().Subtract(value).TotalSeconds));
			xmlTextWriter.WriteAttributeString("NextTime", StringType.FromDouble(subscription.GetNextSynchronizationTime().Subtract(value).TotalSeconds));
			xmlTextWriter.WriteAttributeString("Status", StringType.FromInteger((int)subscription.GetSynchronizationStatus()));
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.Close();
			Console.WriteLine("OK");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			WriteError(ex2.Message);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
	}

	public static string App_Path()
	{
		return AppDomain.CurrentDomain.BaseDirectory;
	}

	public static void WriteError(string insMsg)
	{
		string text = App_Path();
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject", ""));
		object objectValue2 = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(objectValue, (Type)null, "OpenTextFile", new object[3]
		{
			text + "debug.log",
			8,
			true
		}, (string[])null, (bool[])null));
		LateBinding.LateCall(objectValue2, (Type)null, "WriteLine", new object[1] { "WSUS.EXE: " + insMsg }, (string[])null, (bool[])null);
		LateBinding.LateCall(objectValue2, (Type)null, "Close", new object[0], (string[])null, (bool[])null);
	}
}
