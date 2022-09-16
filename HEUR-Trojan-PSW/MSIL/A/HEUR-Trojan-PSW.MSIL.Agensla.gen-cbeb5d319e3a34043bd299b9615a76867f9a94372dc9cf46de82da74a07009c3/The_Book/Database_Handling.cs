using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace The_Book;

public class Database_Handling
{
	private OleDbConnection con;

	private string dbProvider;

	private string dbSource;

	public static DataSet ds = new DataSet();

	public static OleDbDataAdapter da;

	private string sql;

	private Child Load_Child;

	public Database_Handling()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		con = new OleDbConnection();
		Load_Child = new Child();
	}

	public void Open()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		if (File.Exists("The_Book!_Database.accdb"))
		{
			dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;";
			dbSource = "Data Source = The_Book!_Database.accdb";
			con.set_ConnectionString(dbProvider + dbSource);
			sql = "SELECT * FROM Child";
			da = new OleDbDataAdapter(sql, con);
			((DbDataAdapter)(object)da).Fill(ds, "Child");
			con.Open();
			con.Close();
		}
	}

	public void LoadList(ref int inc)
	{
		Load_Child = new Child();
		checked
		{
			try
			{
				Load_Child.strLastName = ds.Tables["Child"]!.Rows[inc][1].ToString();
				Load_Child.strFirstName = ds.Tables["Child"]!.Rows[inc][2].ToString();
				Load_Child.strBirthday = ds.Tables["Child"]!.Rows[inc][3].ToString();
				Load_Child.strFlagDate = ds.Tables["Child"]!.Rows[inc][4].ToString();
				Load_Child.intAge = Conversions.ToInteger(ds.Tables["Child"]!.Rows[inc][5]);
				Load_Child.intMonths = Conversions.ToInteger(ds.Tables["Child"]!.Rows[inc][6]);
				Load_Child.strCurrentClassroom = ds.Tables["Child"]!.Rows[inc][7].ToString();
				Load_Child.strNextClassroom = ds.Tables["Child"]!.Rows[inc][8].ToString();
				Load_Child.strCurrentSpecificClassroom = ds.Tables["Child"]!.Rows[inc][9].ToString();
				Load_Child.strNextSpecificClassroom = ds.Tables["Child"]!.Rows[inc][10].ToString();
				Load_Child.strMonday = ds.Tables["Child"]!.Rows[inc][11].ToString();
				Load_Child.strTuesday = ds.Tables["Child"]!.Rows[inc][12].ToString();
				Load_Child.strWednesday = ds.Tables["Child"]!.Rows[inc][13].ToString();
				Load_Child.strThursday = ds.Tables["Child"]!.Rows[inc][14].ToString();
				Load_Child.strFriday = ds.Tables["Child"]!.Rows[inc][15].ToString();
				Load_Child.intUnique = Conversions.ToInteger(ds.Tables["Child"]!.Rows[inc][16]);
				Load_Child.strStartDate = ds.Tables["Child"]!.Rows[inc][17].ToString();
				Load_Child.strEndDate = ds.Tables["Child"]!.Rows[inc][18].ToString();
				Child.lstChild.Add(Load_Child);
				inc++;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void AddChild(string strLastName, string strFirstName, string strBirthday, int intAge, int intMonths, string strFlagDate, string strCurrentClassroom, string strNextClassroom, string strCurrentSpecificClassroom, string strNextSpecificClassroom, string strMonday, string strTuesday, string strWednesday, string strThursday, string strFriday, int intUnique, string strStartDate, string strEndDate)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		OleDbCommandBuilder val = new OleDbCommandBuilder(da);
		((DbCommandBuilder)(object)val).QuotePrefix = "[";
		((DbCommandBuilder)(object)val).QuoteSuffix = "]";
		DataRow dataRow = ds.Tables["Child"]!.NewRow();
		dataRow["Last Name"] = strLastName;
		dataRow["First Name"] = strFirstName;
		dataRow["Birthday"] = strBirthday;
		dataRow["Flag Date"] = strFlagDate;
		dataRow["Age"] = intAge;
		dataRow["Months"] = intMonths;
		dataRow["Current Classroom"] = strCurrentClassroom;
		dataRow["Next Classroom"] = strNextClassroom;
		dataRow["Current Specific Classroom"] = strCurrentSpecificClassroom;
		dataRow["Next Specific Classroom"] = strNextSpecificClassroom;
		dataRow["Monday"] = strMonday;
		dataRow["Tuesday"] = strTuesday;
		dataRow["Wednesday"] = strWednesday;
		dataRow["Thursday"] = strThursday;
		dataRow["Friday"] = strFriday;
		dataRow["Unique Identifier"] = intUnique;
		dataRow["Start Date"] = strStartDate;
		dataRow["End Date"] = strEndDate;
		ds.Tables["Child"]!.Rows.Add(dataRow);
		((DbDataAdapter)(object)da).Update(ds, "Child");
	}

	public void GetNextID(ref int intID)
	{
		int count = ds.Tables["Child"]!.Rows.Count;
		checked
		{
			if (count != 0)
			{
				int num = count - 1;
				for (int i = 0; i <= num; i++)
				{
					int num2 = Conversions.ToInteger(ds.Tables["Child"]!.Rows[i][16]);
					if (num2 > intID)
					{
						intID = num2;
					}
				}
				intID++;
			}
			else
			{
				intID = 1;
			}
		}
	}

	public void EditChild(string strLastName, string strFirstName, string strBirthday, string strFlagDate, string strCurrentClassroom, string strNextClassroom, string strCurrentSpecificClassroom, string strNextSpecificClassroom, string strMonday, string strTuesday, string strWednesday, string strThursday, string strFriday, string strStartDate, string strEndDate, int intAge, int intMonths, int intUnique)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		Open();
		OleDbCommandBuilder val = new OleDbCommandBuilder(da);
		((DbCommandBuilder)(object)val).QuotePrefix = "[";
		((DbCommandBuilder)(object)val).QuoteSuffix = "]";
		int count = ds.Tables["Child"]!.Rows.Count;
		checked
		{
			int num = count - 1;
			int index = default(int);
			for (int i = 0; i <= num; i++)
			{
				int num2 = Conversions.ToInteger(ds.Tables["Child"]!.Rows[i][16]);
				if (num2 == intUnique)
				{
					index = i;
				}
			}
			ds.Tables["Child"]!.Rows[index]["Last Name"] = strLastName;
			ds.Tables["Child"]!.Rows[index]["First Name"] = strFirstName;
			ds.Tables["Child"]!.Rows[index]["Birthday"] = strBirthday;
			ds.Tables["Child"]!.Rows[index]["Flag Date"] = strFlagDate;
			ds.Tables["Child"]!.Rows[index]["Age"] = intAge;
			ds.Tables["Child"]!.Rows[index]["Months"] = intMonths;
			ds.Tables["Child"]!.Rows[index]["Current Classroom"] = strCurrentClassroom;
			ds.Tables["Child"]!.Rows[index]["Next Classroom"] = strNextClassroom;
			ds.Tables["Child"]!.Rows[index]["Current Specific Classroom"] = strCurrentSpecificClassroom;
			ds.Tables["Child"]!.Rows[index]["Next Specific Classroom"] = strNextSpecificClassroom;
			ds.Tables["Child"]!.Rows[index]["Monday"] = strMonday;
			ds.Tables["Child"]!.Rows[index]["Tuesday"] = strTuesday;
			ds.Tables["Child"]!.Rows[index]["Wednesday"] = strWednesday;
			ds.Tables["Child"]!.Rows[index]["Thursday"] = strThursday;
			ds.Tables["Child"]!.Rows[index]["Friday"] = strFriday;
			ds.Tables["Child"]!.Rows[index]["Start Date"] = strStartDate;
			ds.Tables["Child"]!.Rows[index]["End Date"] = strEndDate;
			((DbDataAdapter)(object)da).Update(ds, "Child");
		}
	}

	public void DeleteChild(int intUnique)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		Open();
		OleDbCommandBuilder val = new OleDbCommandBuilder(da);
		((DbCommandBuilder)(object)val).QuotePrefix = "[";
		((DbCommandBuilder)(object)val).QuoteSuffix = "]";
		int count = ds.Tables["Child"]!.Rows.Count;
		checked
		{
			int num = count - 1;
			int index = default(int);
			for (int i = 0; i <= num; i++)
			{
				int num2 = Conversions.ToInteger(ds.Tables["Child"]!.Rows[i][16]);
				if (num2 == intUnique)
				{
					index = i;
				}
			}
			ds.Tables["Child"]!.Rows[index].Delete();
			((DbDataAdapter)(object)da).Update(ds, "Child");
		}
	}
}
