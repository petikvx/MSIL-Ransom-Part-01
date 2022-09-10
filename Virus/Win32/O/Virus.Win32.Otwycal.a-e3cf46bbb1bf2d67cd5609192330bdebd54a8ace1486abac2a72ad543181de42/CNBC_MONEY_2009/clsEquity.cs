using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CNBC.DAL;
using CNBC_MONEY_2009.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

public class clsEquity
{
	private string strSQL;

	[DebuggerNonUserCode]
	public clsEquity()
	{
	}

	public string getMyIP()
	{
		string result = "";
		string hostName = Dns.GetHostName();
		IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
		IPAddress[] addressList = hostEntry.AddressList;
		int upperBound = addressList.GetUpperBound(0);
		int num = 0;
		while (true)
		{
			int num2 = num;
			int num3 = upperBound;
			if (num2 > num3)
			{
				break;
			}
			result = addressList[num].ToString();
			num = checked(num + 1);
		}
		return result;
	}

	public void AddLookUp(string strBridgeSymbol, string strExchangeSymbol, string strTabName, int Tab_Index, string strExchange = "", string strOldBridgeSymbol = "")
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		try
		{
			string myIP = getMyIP();
			string value = ((!((Strings.InStr(myIP, "192.168.23.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.24.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.26.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.27.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.28.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.3.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.1.", (CompareMethod)0) > 0))) ? "M" : "M");
			SqlParameter[] array = (SqlParameter[])(object)new SqlParameter[10]
			{
				new SqlParameter(),
				default(SqlParameter),
				default(SqlParameter),
				default(SqlParameter),
				default(SqlParameter),
				default(SqlParameter),
				default(SqlParameter),
				default(SqlParameter),
				default(SqlParameter),
				default(SqlParameter)
			};
			array[0].set_Direction(ParameterDirection.Input);
			array[0].set_ParameterName("@IP");
			array[0].set_DbType(DbType.String);
			array[0].set_Value((object)getMyIP());
			array[1] = new SqlParameter();
			array[1].set_Direction(ParameterDirection.Input);
			array[1].set_ParameterName("@USERNAME");
			array[1].set_DbType(DbType.String);
			array[1].set_Value((object)mdlMain.gUserName);
			array[2] = new SqlParameter();
			array[2].set_Direction(ParameterDirection.Input);
			array[2].set_ParameterName("@USERDOMAIN");
			array[2].set_DbType(DbType.String);
			array[2].set_Value((object)mdlMain.gDomain);
			array[3] = new SqlParameter();
			array[3].set_Direction(ParameterDirection.Input);
			array[3].set_ParameterName("@TABINDEX");
			array[3].set_DbType(DbType.Int64);
			array[3].set_Value((object)Tab_Index);
			array[4] = new SqlParameter();
			array[4].set_Direction(ParameterDirection.Input);
			array[4].set_ParameterName("@TABNAME");
			array[4].set_DbType(DbType.String);
			array[4].set_Value((object)strTabName);
			array[5] = new SqlParameter();
			array[5].set_Direction(ParameterDirection.Input);
			array[5].set_ParameterName("@BRIDGESYMBOL");
			array[5].set_DbType(DbType.String);
			array[5].set_Value((object)strBridgeSymbol);
			array[6] = new SqlParameter();
			array[6].set_Direction(ParameterDirection.Input);
			array[6].set_ParameterName("@EXCHANGESYMBOL");
			array[6].set_DbType(DbType.String);
			array[6].set_Value((object)strExchangeSymbol);
			array[7] = new SqlParameter();
			array[7].set_Direction(ParameterDirection.Input);
			array[7].set_ParameterName("@EXCHANGE");
			array[7].set_DbType(DbType.String);
			array[7].set_Value((object)strExchange);
			array[8] = new SqlParameter();
			array[8].set_Direction(ParameterDirection.Input);
			array[8].set_ParameterName("@OLDBRIDGESYMBOL");
			array[8].set_DbType(DbType.String);
			array[8].set_Value((object)strOldBridgeSymbol);
			array[9] = new SqlParameter();
			array[9].set_Direction(ParameterDirection.Input);
			array[9].set_ParameterName("@LOC");
			array[9].set_DbType(DbType.String);
			array[9].set_Value((object)value);
			strSQL = "sp_SAVE_CNBCMONEY_USERDATA";
			SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.StoredProcedure, strSQL, array);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void DeletePortFolio(string strTabName, int Tab_Index)
	{
		try
		{
			strSQL = "SELECT USERID FROM CNBCMONEY_USERS_MST WHERE TABINDEX = " + Conversions.ToString(Tab_Index) + " AND USERNAME = '" + mdlMain.gUserName + "'";
			int num = Conversions.ToInteger(SqlHelper.ExecuteScalar(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL));
			strSQL = "UPDATE CNBCMONEY_USERS_MST SET STRSQL = NULL WHERE TABINDEX = " + Conversions.ToString(Tab_Index) + " AND USERNAME = '" + mdlMain.gUserName + "'";
			SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL);
			strSQL = "DELETE FROM CNBCMONEY_DETAILS WHERE USERID = " + Conversions.ToString(num);
			SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void ShowNews(string strNewsID, string strFeedSource, string Scrip = "0")
	{
		if (Operators.CompareString(Strings.Trim(Strings.UCase(strFeedSource)), "FEED", false) == 0)
		{
			strSQL = "Select *, 'FEED'  as FEEDSOURCE from bse_announcements_wire where newsid='" + Strings.Trim(strNewsID) + "'";
		}
		else if (Operators.CompareString(Strings.Trim(Strings.UCase(strFeedSource)), "WEB", false) == 0)
		{
			strSQL = "Select *,'WEB'  as FEEDSOURCE from bse_announcements_wire_Gamma where newsid='" + Strings.Trim(strNewsID) + "'";
		}
		else if (Operators.CompareString(Strings.Trim(Strings.UCase(strFeedSource)), "NSE_XML_RESULTS", false) == 0)
		{
			strSQL = "Select id AS NEWSID, Dated, NewsSub, 'NSE_XML_RESULTS' AS FeedSource, '' AS Attachment, '' AS NewsBody from Earnings_Results where id='" + Strings.Trim(strNewsID) + "'";
		}
		else if (Operators.CompareString(Scrip, "0", false) != 0)
		{
			strSQL = "Select TOP 1 DATED,NEWSSUB,NEWSID, NEWSBODY, COMPANYNAME=ISNULL((Select top 1 shortname from Equity_transaction_data where exchangesymbol=a.scrip),''),'WEB' as FEEDSOURCE,  ATTACHMENT from BSE_Announcements_WIRE_Gamma a where scrip =  '" + Scrip + "' UNION  Select Dated, NewsSub, 'NSE_XML_RESULTS' AS FeedSource, '' AS Attachment, '' AS NewsBody,  COMPANYNAME=ISNULL((Select top 1 shortname from Equity_transaction_data where exchangesymbol=a.exchangesymbol),''),'NSE_XML_RESULTS'  as FEEDSOURCE from Earnings_Results a where exchangesymbol  = '" + Scrip + "' UNION  Select DATED,NEWSSUB,NEWSID, NEWSBODY,  COMPANYNAME=ISNULL((Select top 1 shortname from Equity_transaction_data where exchangesymbol=a.scrip),''),'FEED'  as FEEDSOURCE, ATTACHMENT from bse_announcements_wire a where scrip = '" + Scrip + "' order by dated DESC";
		}
		DataTable dataTable = new DataTable();
		dataTable = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
		if (dataTable.Rows.Count == 0)
		{
			return;
		}
		FileStream stream = new FileStream(Application.get_StartupPath() + "/BSEWIRESTEMP.html", FileMode.Create, FileAccess.Write);
		StreamWriter streamWriter = new StreamWriter(stream);
		int num = 0;
		do
		{
			string text = "";
			string text2 = Conversions.ToString(DateAndTime.DatePart((DateInterval)2, Conversions.ToDate(dataTable.Rows[num]["DAted"]), (FirstDayOfWeek)1, (FirstWeekOfYear)1)) + Conversions.ToString(DateAndTime.DatePart((DateInterval)4, Conversions.ToDate(dataTable.Rows[num]["DAted"]), (FirstDayOfWeek)1, (FirstWeekOfYear)1)) + Conversions.ToString(DateAndTime.DatePart((DateInterval)0, Conversions.ToDate(dataTable.Rows[num]["DAted"]), (FirstDayOfWeek)1, (FirstWeekOfYear)1));
			object[] array3;
			DataRow dataRow;
			string columnName;
			object[] array;
			bool[] array5;
			if (Operators.CompareString(Strings.Trim(Conversions.ToString(dataTable.Rows[num]["Attachment"])), "", false) != 0)
			{
				text = "\r\n\r\n";
				Type typeFromHandle = typeof(Strings);
				array = new object[1];
				object[] array2 = array;
				dataRow = dataTable.Rows[num];
				DataRow dataRow2 = dataRow;
				columnName = "Feedsource";
				array2[0] = RuntimeHelpers.GetObjectValue(dataRow2[columnName]);
				array3 = array;
				object[] array4 = array3;
				array5 = new bool[1] { true };
				object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array4, (string[])null, (Type[])null, array5);
				if (array5[0])
				{
					dataRow[columnName] = RuntimeHelpers.GetObjectValue(array3[0]);
				}
				if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj)), "FEED", false) == 0)
				{
					text = text + "<a href=http://192.168.30.152/BSE_Wire/" + Strings.Trim(text2) + "/" + Strings.Trim(Conversions.ToString(dataTable.Rows[num]["Attachment"])) + "><b>ATTACHMENT [" + Strings.Trim(Conversions.ToString(dataTable.Rows[num]["Attachment"])) + "]</b></a>";
				}
				else
				{
					Type typeFromHandle2 = typeof(Strings);
					array3 = new object[1];
					object[] array6 = array3;
					dataRow = dataTable.Rows[num];
					DataRow dataRow3 = dataRow;
					columnName = "Feedsource";
					array6[0] = RuntimeHelpers.GetObjectValue(dataRow3[columnName]);
					array = array3;
					object[] array7 = array;
					array5 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "UCase", array7, (string[])null, (Type[])null, array5);
					if (array5[0])
					{
						dataRow[columnName] = RuntimeHelpers.GetObjectValue(array[0]);
					}
					if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj2)), "WEB", false) == 0)
					{
						text = text + "<a href=http://192.168.30.152/BSE_WIRE_WEBNEWS/" + Strings.Trim(text2) + "/" + Strings.Trim(Conversions.ToString(dataTable.Rows[num]["Attachment"])) + "><b>ATTACHMENT [" + Strings.Trim(Conversions.ToString(dataTable.Rows[num]["Attachment"])) + "]</b></a>";
					}
				}
			}
			string text3 = "<HTML><HEAD>";
			Type typeFromHandle3 = typeof(Strings);
			array3 = new object[1];
			object[] array8 = array3;
			dataRow = dataTable.Rows[num];
			DataRow dataRow4 = dataRow;
			columnName = "Feedsource";
			array8[0] = RuntimeHelpers.GetObjectValue(dataRow4[columnName]);
			array = array3;
			object[] array9 = array;
			array5 = new bool[1] { true };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "UCase", array9, (string[])null, (Type[])null, array5);
			if (array5[0])
			{
				dataRow[columnName] = RuntimeHelpers.GetObjectValue(array[0]);
			}
			if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj3)), "FEED", false) == 0)
			{
				text3 += "<link REL='SHORTCUT ICON' HREF='http://192.168.30.152/BSE_WIRE/cnbc_money.ico'>";
			}
			else
			{
				Type typeFromHandle4 = typeof(Strings);
				array3 = new object[1];
				object[] array10 = array3;
				dataRow = dataTable.Rows[num];
				DataRow dataRow5 = dataRow;
				columnName = "Feedsource";
				array10[0] = RuntimeHelpers.GetObjectValue(dataRow5[columnName]);
				array = array3;
				object[] array11 = array;
				array5 = new bool[1] { true };
				object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "UCase", array11, (string[])null, (Type[])null, array5);
				if (array5[0])
				{
					dataRow[columnName] = RuntimeHelpers.GetObjectValue(array[0]);
				}
				if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj4)), "WEB", false) == 0)
				{
					text3 += "<link REL='SHORTCUT ICON' HREF='http://192.168.30.152/BSE_WIRE_WEBNEWS/cnbc_money.ico'>";
				}
			}
			text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text3 + " <TITLE>CNBC MONEY 2010 :: "), dataTable.Rows[num]["NewsSub"]), (object)"</TITLE></HEAD><BODY><table width='100%' border = '0' style='border-collapse: collapse; font-family: Verdana; font-size: 10pt'><tr><td>"));
			text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text3 + "<B>SUBJECT : </B>"), dataTable.Rows[num]["NewsSub"]), (object)"<BR>"));
			streamWriter.WriteLine(text3);
			text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"<B>DATE : </B>", dataTable.Rows[num]["Dated"]), (object)"<BR>"));
			streamWriter.WriteLine(text3 + "\r\n");
			streamWriter.WriteLine("<hr size='1' color='navy'><BR>");
			if (Operators.ConditionalCompareObjectNotEqual(dataTable.Rows[num]["NewsBody"], (object)"", false))
			{
				text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"<B>BODY : </B>", dataTable.Rows[num]["NewsBody"]), (object)"<BR>"));
				streamWriter.WriteLine(text3 + "\r\n");
				streamWriter.WriteLine("<hr size='1' color='navy'><BR>");
			}
			if (Operators.CompareString(Strings.Trim(text.Replace("\r\n", "")), "", false) != 0)
			{
				streamWriter.WriteLine("<B>ATTACHMENT : </B>" + text);
			}
			streamWriter.WriteLine("<BR></td></tr></table></BODY></HTML>");
			num = checked(num + 1);
		}
		while (num <= 0);
		streamWriter.Close();
		try
		{
			Process.Start(Application.get_StartupPath() + "/BSEWIRESTEMP.html");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public string BytesToString(ref byte[] Data)
	{
		try
		{
			string text = "";
			byte[] array = Data;
			foreach (byte b in array)
			{
				if (b != 0)
				{
					char c = Strings.Chr((int)b);
					text += Conversions.ToString(c);
				}
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void GetSettingsFromDB(int iTab_Index)
	{
		try
		{
			strSQL = "SELECT * FROM CNBCMONEY_USERS_MST WHERE USERNAME = '" + mdlMain.gUserName + "' AND TABINDEX = " + Conversions.ToString(iTab_Index);
			DataTable dataTable = new DataTable();
			dataTable = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
			if (dataTable.Rows.Count > 0)
			{
				if (dataTable.Rows[0]["COLOR_BACKGROUND"] != DBNull.Value)
				{
					((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("COLOR_BACKGROUND", (object)Color.FromArgb(Conversions.ToInteger(dataTable.Rows[0]["COLOR_BACKGROUND"])));
				}
				if (dataTable.Rows[0]["COLOR_CHANGE_L_ZERO"] != DBNull.Value)
				{
					((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("COLOR_CHANGE_L_ZERO", (object)Color.FromArgb(Conversions.ToInteger(dataTable.Rows[0]["COLOR_CHANGE_L_ZERO"])));
				}
				if (dataTable.Rows[0]["COLOR_CHANGE_G_ZERO"] != DBNull.Value)
				{
					((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("COLOR_CHANGE_G_ZERO", (object)Color.FromArgb(Conversions.ToInteger(dataTable.Rows[0]["COLOR_CHANGE_G_ZERO"])));
				}
				if (dataTable.Rows[0]["COLOR_CHANGE_E_ZERO"] != DBNull.Value)
				{
					((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("COLOR_CHANGE_E_ZERO", (object)Color.FromArgb(Conversions.ToInteger(dataTable.Rows[0]["COLOR_CHANGE_E_ZERO"])));
				}
				if (dataTable.Rows[0]["FONT_DATA"] != DBNull.Value)
				{
					((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("FONT_DATA", RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["FONT_DATA"]));
				}
				if (dataTable.Rows[0]["FONT_SIZE"] != DBNull.Value)
				{
					((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("FONT_SIZE", RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["FONT_SIZE"]));
				}
				((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Update_DateTime(int iTab_Index)
	{
		try
		{
			string myIP = getMyIP();
			string text = ((!((Strings.InStr(myIP, "192.168.23.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.24.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.26.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.27.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.28.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.3.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.1.", (CompareMethod)0) > 0))) ? "M" : "M");
			strSQL = "UPDATE CNBCMONEY_USERS_MST SET LOCATION = '" + text + "', UPDATED_DATETIME = GETDATE() WHERE USERNAME = '" + mdlMain.gUserName + "' AND TABINDEX IN (111, 0, -3, " + Conversions.ToString(iTab_Index) + ")";
			SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL);
			strSQL = "UPDATE CNBCMONEY_DETAILS SET UPDATED_DATETIME = GETDATE() WHERE USERID IN (SELECT USERID FROM CNBCMONEY_USERS_MST WHERE USERNAME = '" + mdlMain.gUserName + "' AND TABINDEX IN (111, 0," + Conversions.ToString(iTab_Index) + "))";
			SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void DeActivateTab(int iTab_Index, string sortcol, string sortindicator)
	{
		try
		{
			strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"UPDATE CNBCMONEY_USERS_MST SET ISACTIVE = 0, SORT_INDICATOR = '", Interaction.IIf(Operators.CompareString(sortindicator, "True", false) == 0, (object)2, (object)1)), (object)"', SORT_COLUMN = '"), (object)sortcol), (object)"'"), (object)" WHERE TABINDEX = "), (object)iTab_Index), (object)" AND USERNAME = '"), (object)mdlMain.gUserName), (object)"'"));
			SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void DisConnectUser()
	{
		try
		{
			strSQL = "UPDATE CNBCMONEY_USERS_MST SET ISACTIVE = 0  WHERE USERNAME = '" + mdlMain.gUserName + "'";
			SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Update_ConnectedUsers(int iTab_Index)
	{
		try
		{
			string myIP = getMyIP();
			string text = ((!((Strings.InStr(myIP, "192.168.23.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.24.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.26.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.27.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.28.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.3.", (CompareMethod)0) > 0) | (Strings.InStr(myIP, "192.168.1.", (CompareMethod)0) > 0))) ? "M" : "M");
			strSQL = "UPDATE CNBCMONEY_USERS_MST SET LOCATION = '" + text + "', ISACTIVE = 1, UPDATED_DATETIME = GETDATE() WHERE TABINDEX = " + Conversions.ToString(iTab_Index) + " AND  USERNAME = '" + mdlMain.gUserName + "'";
			SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void UpdateSettingsToDB()
	{
		try
		{
			strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("UPDATE CNBCMONEY_USERS_MST SET COLOR_BACKGROUND = '" + Conversions.ToString(MySettingsProperty.Settings.COLOR_BACKGROUND.ToArgb()), "', "), " COLOR_CHANGE_L_ZERO = '"), Conversions.ToString(MySettingsProperty.Settings.COLOR_CHANGE_L_ZERO.ToArgb())), "', COLOR_CHANGE_E_ZERO = '"), Conversions.ToString(MySettingsProperty.Settings.COLOR_CHANGE_E_ZERO.ToArgb())), "', "), " COLOR_CHANGE_G_ZERO = '"), Conversions.ToString(MySettingsProperty.Settings.COLOR_CHANGE_G_ZERO.ToArgb())), "', FONT_DATA ='"), Interaction.IIf(Operators.CompareString(MySettingsProperty.Settings.FONT_DATA, "", false) == 0, (object)"Verdana", (object)MySettingsProperty.Settings.FONT_DATA)), (object)"', "), (object)" FONT_SIZE = '"), (object)MySettingsProperty.Settings.FONT_SIZE), (object)"', COLOR_SCHEME = '"), (object)mdlMain.INIRead(Application.get_StartupPath() + "/Money_Config.ini", "MAIN", "COLOR_SCHEME", "")), (object)"' WHERE USERNAME = '"), (object)mdlMain.gUserName), (object)"'"));
			SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void ShowNewsHistory(string strNewsID, string strFeedSource, string Scrip = "0", string ScripName = "")
	{
		string text = "";
		if (Operators.CompareString(Strings.Trim(Strings.UCase(strFeedSource)), "FEED", false) == 0)
		{
			strSQL = "Select *, 'FEED'  as FEEDSOURCE from bse_announcements_wire where newsid='" + Strings.Trim(strNewsID) + "'";
		}
		else if (Operators.CompareString(Strings.Trim(Strings.UCase(strFeedSource)), "WEB", false) == 0)
		{
			strSQL = "Select *,'WEB'  as FEEDSOURCE from bse_announcements_wire_Gamma where newsid='" + Strings.Trim(strNewsID) + "'";
		}
		else if (Operators.CompareString(Strings.Trim(Strings.UCase(strFeedSource)), "NSE_XML_RESULTS", false) == 0)
		{
			strSQL = "Select id AS NEWSID, Dated, NewsSub, 'NSE_XML_RESULTS' AS FeedSource, '' AS Attachment, '' AS NewsBody from Earnings_Results where id='" + Strings.Trim(strNewsID) + "'";
		}
		else if (Operators.CompareString(Scrip, "0", false) != 0)
		{
			strSQL = "Select TOP 1 DATED,NEWSSUB,NEWSID, NEWSBODY, COMPANYNAME=ISNULL((Select top 1 shortname from Equity_transaction_data where exchangesymbol=a.scrip),''),'WEB' as FEEDSOURCE,  ATTACHMENT from BSE_Announcements_WIRE_Gamma a where scrip =  '" + Scrip + "' UNION  Select Dated, NewsSub, 'NSE_XML_RESULTS' AS FeedSource, '' AS Attachment, '' AS NewsBody,  COMPANYNAME=ISNULL((Select top 1 shortname from Equity_transaction_data where exchangesymbol=a.exchangesymbol),''),'NSE_XML_RESULTS'  as FEEDSOURCE from Earnings_Results a where exchangesymbol  = '" + Scrip + "' UNION  Select DATED,NEWSSUB,NEWSID, NEWSBODY,  COMPANYNAME=ISNULL((Select top 1 shortname from Equity_transaction_data where exchangesymbol=a.scrip),''),'FEED'  as FEEDSOURCE, ATTACHMENT from bse_announcements_wire a where scrip = '" + Scrip + "' order by dated DESC";
			text = "Select DATED,NEWSSUB,NEWSID, NEWSBODY, COMPANYNAME=ISNULL((Select top 1 shortname from Equity_transaction_data where exchangesymbol=a.scrip),''),'FEED' as FEEDSOURCE,  ATTACHMENT from BSE_Announcements_WIRE_History a where scrip =  '" + Scrip + "' UNION  Select Dated, NewsSub, 'NSE_XML_RESULTS' AS FeedSource, '' AS Attachment, '' AS NewsBody,  COMPANYNAME=ISNULL((Select top 1 shortname from Equity_transaction_data where exchangesymbol=a.exchangesymbol),''),'NSE_XML_RESULTS'  as FEEDSOURCE from Earnings_Results_History a where exchangesymbol  = '" + Scrip + "'";
			text += " order by dated DESC";
		}
		DataTable dataTable = new DataTable();
		dataTable = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, text).Tables[0];
		DataTable dataTable2 = new DataTable();
		dataTable2 = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
		if (dataTable2.Rows.Count > 0)
		{
			DataRow dataRow = dataTable.NewRow();
			dataRow.ItemArray = dataTable2.Rows[0].ItemArray;
			dataTable.Rows.Add(dataRow);
		}
		if (dataTable.Rows.Count == 0)
		{
			mdlMain.ShowMessage("No News History for " + ScripName);
			return;
		}
		dataTable.DefaultView.Sort = "DATED DESC";
		FileStream stream = new FileStream(Application.get_StartupPath() + "/BSEWIRESTEMP.html", FileMode.Create, FileAccess.Write);
		StreamWriter streamWriter = new StreamWriter(stream);
		string text2 = "<HTML><HEAD>";
		text2 += " <TITLE>CNBC MONEY 2010</TITLE></HEAD><BODY>";
		checked
		{
			int num = dataTable.DefaultView.Count - 1;
			int num2 = 0;
			int num5 = default(int);
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (Operators.CompareString(Strings.Format(RuntimeHelpers.GetObjectValue(dataTable.DefaultView[num2]["dated"]), "dd/MM/yyyy"), Strings.Format((object)DateAndTime.get_Now().Date, "dd/MM/yyyy"), false) == 0)
				{
					num5++;
					string text3 = "";
					string text4 = Conversions.ToString(DateAndTime.DatePart((DateInterval)2, Conversions.ToDate(dataTable.DefaultView[num2]["DAted"]), (FirstDayOfWeek)1, (FirstWeekOfYear)1)) + Conversions.ToString(DateAndTime.DatePart((DateInterval)4, Conversions.ToDate(dataTable.DefaultView[num2]["DAted"]), (FirstDayOfWeek)1, (FirstWeekOfYear)1)) + Conversions.ToString(DateAndTime.DatePart((DateInterval)0, Conversions.ToDate(dataTable.DefaultView[num2]["DAted"]), (FirstDayOfWeek)1, (FirstWeekOfYear)1));
					if (Operators.CompareString(Strings.Trim(Conversions.ToString(dataTable.DefaultView[num2]["Attachment"])), "", false) != 0)
					{
						text3 = "\r\n\r\n";
						Type typeFromHandle = typeof(Strings);
						object[] array = new object[1];
						object[] array2 = array;
						DataRowView dataRowView = dataTable.DefaultView[num2];
						DataRowView dataRowView2 = dataRowView;
						string property = "Feedsource";
						array2[0] = RuntimeHelpers.GetObjectValue(dataRowView2[property]);
						object[] array3 = array;
						object[] array4 = array3;
						bool[] array5 = new bool[1] { true };
						object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array4, (string[])null, (Type[])null, array5);
						if (array5[0])
						{
							dataRowView[property] = RuntimeHelpers.GetObjectValue(array3[0]);
						}
						if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj)), "FEED", false) == 0)
						{
							text3 = text3 + "<a target='_blank' href=http://192.168.30.152/BSE_Wire/" + Strings.Trim(text4) + "/" + Strings.Trim(Conversions.ToString(dataTable.DefaultView[num2]["Attachment"])) + "><b>ATTACHMENT [" + Strings.Trim(Conversions.ToString(dataTable.DefaultView[num2]["Attachment"])) + "]</b></a>";
						}
						else
						{
							Type typeFromHandle2 = typeof(Strings);
							array3 = new object[1];
							object[] array6 = array3;
							dataRowView = dataTable.DefaultView[num2];
							DataRowView dataRowView3 = dataRowView;
							property = "Feedsource";
							array6[0] = RuntimeHelpers.GetObjectValue(dataRowView3[property]);
							array = array3;
							object[] array7 = array;
							array5 = new bool[1] { true };
							object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "UCase", array7, (string[])null, (Type[])null, array5);
							if (array5[0])
							{
								dataRowView[property] = RuntimeHelpers.GetObjectValue(array[0]);
							}
							if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj2)), "WEB", false) == 0)
							{
								text3 = text3 + "<a href=http://192.168.30.152/BSE_WIRE_WEBNEWS/" + Strings.Trim(text4) + "/" + Strings.Trim(Conversions.ToString(dataTable.DefaultView[num2]["Attachment"])) + "><b>ATTACHMENT [" + Strings.Trim(Conversions.ToString(dataTable.DefaultView[num2]["Attachment"])) + "]</b></a>";
							}
						}
					}
					text2 += "<table border='1' cellpadding='3' bordercolor='#000000' width='100%' style='border-collapse: collapse; font-family: Verdana; font-size: 10pt'>";
					text2 += "<tr><td>";
					text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text2 + "<B>SUBJECT : </B>"), dataTable.DefaultView[num2]["NewsSub"]), (object)"<BR>"));
					text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text2 + "<B>DATE : </B>"), dataTable.DefaultView[num2]["Dated"]), (object)"<BR>"), (object)"\r\n"));
					text2 += "<hr size='1' color='navy'><BR>";
					if (Operators.ConditionalCompareObjectNotEqual(dataTable.DefaultView[num2]["NewsBody"], (object)"", false))
					{
						text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text2 + "<B>BODY : </B>"), dataTable.DefaultView[num2]["NewsBody"]), (object)"<BR>"), (object)"\r\n"));
						text2 += "<hr size='1' color='navy'><BR>";
					}
					if (Operators.CompareString(Strings.Trim(text3.Replace("\r\n", "")), "", false) != 0)
					{
						text2 = text2 + "<B>ATTACHMENT : </B>" + text3;
					}
					text2 += "<BR></td></tr></table>";
				}
				else
				{
					if (num5 == 0)
					{
						text2 += "<table width='100%' border = '0' style='border-collapse: collapse; font-family: Verdana; font-size: 10pt'>";
						text2 += "<tr><td align='center'><H3>No News for Today</H3></td></tr></table>";
						break;
					}
					text2 += "<br/>";
				}
				num2++;
			}
			streamWriter.WriteLine(text2);
			text2 = "";
			int num6 = num5;
			int num7 = dataTable.DefaultView.Count - 1;
			int num8 = num6;
			while (true)
			{
				int num9 = num8;
				int num4 = num7;
				if (num9 > num4)
				{
					break;
				}
				if (num8 == num5)
				{
					text2 = "<table border='1' cellpadding='3' bordercolor='#000000' style='font-family: Verdana; font-size: 10pt'><tr><td></td></tr> <tr><td align='center' bgcolor='#CC9900' style='height:20px' bordercolor='#000000'  style='border-bottom-style: solid; border-bottom-width: 1'><b>HISTORY</b></td></tr><tr><td style='height:5px'></td></tr><tr><td>";
				}
				string text5 = "";
				string text6 = Conversions.ToString(DateAndTime.DatePart((DateInterval)2, Conversions.ToDate(dataTable.DefaultView[num8]["DAted"]), (FirstDayOfWeek)1, (FirstWeekOfYear)1)) + Conversions.ToString(DateAndTime.DatePart((DateInterval)4, Conversions.ToDate(dataTable.DefaultView[num8]["DAted"]), (FirstDayOfWeek)1, (FirstWeekOfYear)1)) + Conversions.ToString(DateAndTime.DatePart((DateInterval)0, Conversions.ToDate(dataTable.DefaultView[num8]["DAted"]), (FirstDayOfWeek)1, (FirstWeekOfYear)1));
				if (Operators.CompareString(Strings.Trim(Conversions.ToString(dataTable.DefaultView[num8]["Attachment"])), "", false) != 0)
				{
					text5 = "\r\n\r\n";
					Type typeFromHandle3 = typeof(Strings);
					object[] array3 = new object[1];
					object[] array8 = array3;
					DataRowView dataRowView = dataTable.DefaultView[num8];
					DataRowView dataRowView4 = dataRowView;
					string property = "Feedsource";
					array8[0] = RuntimeHelpers.GetObjectValue(dataRowView4[property]);
					object[] array = array3;
					object[] array9 = array;
					bool[] array5 = new bool[1] { true };
					object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle3, "UCase", array9, (string[])null, (Type[])null, array5);
					if (array5[0])
					{
						dataRowView[property] = RuntimeHelpers.GetObjectValue(array[0]);
					}
					if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj3)), "FEED", false) == 0)
					{
						text5 = text5 + "<a target='_blank' href=http://192.168.30.152/BSE_Wire/" + Strings.Trim(text6) + "/" + Strings.Trim(Conversions.ToString(dataTable.DefaultView[num8]["Attachment"])) + "><b>ATTACHMENT [" + Strings.Trim(Conversions.ToString(dataTable.DefaultView[num8]["Attachment"])) + "]</b></a>";
					}
					else
					{
						Type typeFromHandle4 = typeof(Strings);
						array3 = new object[1];
						object[] array10 = array3;
						dataRowView = dataTable.DefaultView[num8];
						DataRowView dataRowView5 = dataRowView;
						property = "Feedsource";
						array10[0] = RuntimeHelpers.GetObjectValue(dataRowView5[property]);
						array = array3;
						object[] array11 = array;
						array5 = new bool[1] { true };
						object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle4, "UCase", array11, (string[])null, (Type[])null, array5);
						if (array5[0])
						{
							dataRowView[property] = RuntimeHelpers.GetObjectValue(array[0]);
						}
						if (Operators.CompareString(Strings.Trim(Conversions.ToString(obj4)), "WEB", false) == 0)
						{
							text5 = text5 + "<a target='_blank' href=http://192.168.30.152/BSE_WIRE_WEBNEWS/" + Strings.Trim(text6) + "/" + Strings.Trim(Conversions.ToString(dataTable.DefaultView[num8]["Attachment"])) + "><b>ATTACHMENT [" + Strings.Trim(Conversions.ToString(dataTable.DefaultView[num8]["Attachment"])) + "]</b></a>";
						}
					}
				}
				text2 += "<table width='100%' border = '0' style='border-collapse: collapse; font-family: Verdana; font-size: 10pt'>";
				text2 += "<tr><td>";
				text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text2 + "<B>SUBJECT : </B>"), dataTable.DefaultView[num8]["NewsSub"]), (object)"<BR>"));
				streamWriter.WriteLine(text2);
				text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"<B>DATE : </B>", dataTable.DefaultView[num8]["Dated"]), (object)"<BR>"), (object)"\r\n"));
				text2 += "<hr size='1' color='navy'><BR>";
				if (Operators.ConditionalCompareObjectNotEqual(dataTable.DefaultView[num8]["NewsBody"], (object)"", false))
				{
					text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text2 + "<B>BODY : </B>"), dataTable.DefaultView[num8]["NewsBody"]), (object)"<BR>"), (object)"\r\n"));
					text2 += "<hr size='1' color='navy'><BR>";
				}
				if (Operators.CompareString(Strings.Trim(text5.Replace("\r\n", "")), "", false) != 0)
				{
					text2 = text2 + "<B>ATTACHMENT : </B>" + text5;
				}
				text2 += "<BR></td></tr>";
				if (num8 == num5)
				{
					text2 += "<BR></td></tr></table>";
				}
				num8++;
			}
			text2 += "</BODY></HTML>";
			streamWriter.WriteLine(text2);
			streamWriter.Close();
			try
			{
				Process.Start(Application.get_StartupPath() + "/BSEWIRESTEMP.html");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
