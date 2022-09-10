using System.Data.OleDb;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Boggle;

[StandardModule]
internal sealed class modGlobal
{
	public enum Interval
	{
		Sec030,
		Sec100,
		Sec130,
		Sec200,
		Sec230,
		Sec300,
		Sec330,
		Sec400,
		Sec430,
		Sec500
	}

	public enum Direction
	{
		Right,
		LowerRight,
		Below,
		LowerLeft,
		Left,
		UpperLeft,
		Above,
		UpperRight
	}

	public enum Level
	{
		Easy,
		Medium,
		Hard,
		Impossible
	}

	public enum Mode
	{
		Vs,
		BoardGame,
		Teaching
	}

	public static string AppPath = Strings.Mid(Application.get_StartupPath(), 1, Strings.InStr(Application.get_StartupPath(), "\\Boggle", (CompareMethod)0)) + Application.get_ProductName();

	public static OleDbConnection conBoggle = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Password=\"\";User ID=Admin;Data Source=" + AppPath + "\\Boggle.mdb;Mode=Share Deny None;Extended Properties=" + "\"" + "\"" + ";Jet OLEDB:System database=" + "\"" + "\"" + ";Jet OLEDB:Registry Path=" + "\"" + "\"" + ";Jet OLEDB:Database Password=" + "\"" + "\"" + ";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password=" + "\"" + "\"" + ";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False");

	public static OleDbCommand cmdBog = new OleDbCommand("Space Fill", conBoggle);

	public static CubesCollection Cubes = new CubesCollection();

	public static Cube myCube;

	public static Mode GameMode;

	public static Level GameLevel;

	public static Interval TimerInterval;
}
