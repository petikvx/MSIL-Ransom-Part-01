using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using t0B;

namespace r9A;

[StandardModule]
internal sealed class m4B
{
	private static object connectionString = m2A.Forms.At0().connectionString;

	public static void b2S()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		OleDbConnection val = new OleDbConnection(Conversions.ToString(connectionString));
		string text = $"{DateTime.Now.AddDays(5.0):dd-MM-yyyy}";
		string text2 = "SELECT BorrowerId,ISBN FROM Borrowed where ReturnDate like '" + text + "' and IsIssued like True order by BorrowerId";
		val.Open();
		OleDbCommand val2 = new OleDbCommand(text2, val);
		OleDbDataReader val3 = val2.ExecuteReader();
		OleDbCommand val4 = new OleDbCommand(text2, val);
		string text3 = "";
		List<string> list = new List<string>();
		checked
		{
			OleDbDataReader val5;
			while (val3.Read())
			{
				if (Operators.ConditionalCompareObjectEqual(val3.get_Item("BorrowerId"), (object)text3, false))
				{
					val4.set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Select Title from Books where ISBN like '", val3.get_Item("ISBN")), (object)"'")));
					val5 = val4.ExecuteReader();
					val5.Read();
					list.Add(Conversions.ToString(val5.get_Item("Title")));
					val5.Close();
				}
				else if (Operators.CompareString(text3, "", false) != 0)
				{
					val4.set_CommandText("Select * from Users where UserName like '" + text3 + "'");
					val5 = val4.ExecuteReader();
					val5.Read();
					string p1C = Conversions.ToString(val5.get_Item("Email"));
					val5.Close();
					string xw = "Reminder to return Books";
					string text4 = "Your lease of Books is ending shortly.Please Take note of the Books you have to return to the library:\r\n";
					int num = list.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						text4 = string.Concat(text4, "\t" + Conversions.ToString(i) + ") " + list[i] + " \r\n");
					}
					x7Z(p1C, text4, xw);
					Console.WriteLine("Message Sent");
					list.Clear();
					text3 = Conversions.ToString(val3.get_Item("BorrowerId"));
					val4.set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Select Title from Books where ISBN like '", val3.get_Item("ISBN")), (object)"'")));
					val5 = val4.ExecuteReader();
					val5.Read();
					list.Add(Conversions.ToString(val5.get_Item("Title")));
					val5.Close();
				}
				else
				{
					text3 = Conversions.ToString(val3.get_Item("BorrowerId"));
					val4.set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Select Title from Books where ISBN like '", val3.get_Item("ISBN")), (object)"'")));
					val5 = val4.ExecuteReader();
					val5.Read();
					list.Add(Conversions.ToString(val5.get_Item("Title")));
					val5.Close();
				}
			}
			Console.WriteLine(text3);
			val4.set_CommandText("Select * from Users where UserName like '" + text3 + "'");
			val5 = val4.ExecuteReader();
			if (val5.get_HasRows())
			{
				val5.Read();
				string p1C = Conversions.ToString(val5.get_Item("Email"));
				val5.Close();
				string xw = "Reminder to return Books";
				string text4 = "Your lease of Books is ending shortly.Please Take note of the Books you have to return to the library:\r\n";
				int num2 = list.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					text4 = string.Concat(text4, "\t" + Conversions.ToString(j) + ") " + list[j] + " \r\n");
				}
				text4 = text4 + "The last date to return the book is " + text + " beyond which a fine per day will be applicable.";
				x7Z(p1C, text4, xw);
				Console.Write(p1C, text4);
			}
		}
	}

	public static object x7Z(string p1C, string e1N, string Xw3)
	{
		try
		{
			SmtpClient smtpClient = new SmtpClient();
			MailMessage mailMessage = new MailMessage();
			smtpClient.UseDefaultCredentials = false;
			smtpClient.Credentials = new NetworkCredential("iitglibrarymanagement@gmail.com", "Group0015");
			smtpClient.Port = 587;
			smtpClient.EnableSsl = true;
			smtpClient.Host = "smtp.gmail.com";
			mailMessage = new MailMessage();
			mailMessage.From = new MailAddress("iitglibrarymanagement@gmail.com");
			mailMessage.To.Add(p1C);
			mailMessage.Subject = Xw3;
			mailMessage.IsBodyHtml = false;
			mailMessage.Body = e1N;
			smtpClient.Send(mailMessage);
			return 1;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = 0;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void Nc1()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		OleDbConnection val = new OleDbConnection(Conversions.ToString(connectionString));
		string text = "SELECT BorrowerId FROM Borrowed WHERE isIssued=True and Date()>returnDate";
		val.Open();
		OleDbCommand val2 = new OleDbCommand(text, val);
		OleDbDataReader val3 = val2.ExecuteReader();
		OleDbCommand val4 = new OleDbCommand(text, val);
		while (val3.Read())
		{
			object objectValue = RuntimeHelpers.GetObjectValue(val3.get_Item("BorrowerId"));
			val4.set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"SELECT * from Users where UserName = '", objectValue), (object)"'")));
			OleDbDataReader val5 = val4.ExecuteReader();
			Console.WriteLine(val5.get_HasRows());
			val5.Read();
			object obj = Operators.AddObject(val5.get_Item("TotalFine"), (object)1);
			val4.set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"UPDATE Users SET TotalFine = ", obj), (object)" WHERE userName = '"), objectValue), (object)"'")));
			val5.Close();
			val4.ExecuteScalar();
		}
	}
}
