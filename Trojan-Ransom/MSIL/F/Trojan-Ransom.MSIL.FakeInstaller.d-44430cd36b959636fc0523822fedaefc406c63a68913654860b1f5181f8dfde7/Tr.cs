using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class Tr : Panel
{
	public string TypeObj;

	public string defaultName;

	public Propertys Props;

	public string LastProp;

	public string LastSobyt;

	public object MyObj;

	public TextBox TextB;

	public Button Buttn;

	public Tr()
	{
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		TypeObj = "Obi4niy";
		defaultName = peremens.trans("Триал");
		Props = new Propertys(this);
		LastProp = peremens.trans("Включить триальный отсчет");
		LastSobyt = peremens.trans("Клик");
		bool[] array3;
		if (peremens2.proj == null)
		{
			((Control)this).set_Name(defaultName + "1");
		}
		else
		{
			Propertys props = Props;
			object proj = peremens2.proj;
			object[] array = new object[1] { defaultName };
			object[] array2 = array;
			array3 = new bool[1] { true };
			object obj = NewLateBinding.LateGet(proj, (Type)null, "GiveName", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				defaultName = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			props.Name = Conversions.ToString(obj);
		}
		Propertys props2 = Props;
		object proj2 = peremens2.proj;
		object[] array4 = new object[1] { defaultName };
		object[] array5 = array4;
		array3 = new bool[1] { true };
		object obj2 = NewLateBinding.LateGet(proj2, (Type)null, "GiveName", array5, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			defaultName = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
		}
		props2.Name = Conversions.ToString(obj2);
		Props.Text = Props.Name;
		Props.BorderStyle = peremens.trans("линия");
		Props.Height = 29;
		Props.Width = 291;
		Buttn = new Button();
		((Control)this).get_Controls().Add((Control)(object)Buttn);
		((Control)Buttn).set_Width(90);
		checked
		{
			((Control)Buttn).set_Left(((Control)this).get_Width() - ((Control)Buttn).get_Width() - 3);
			((Control)Buttn).set_Top(3);
			((Control)Buttn).set_Anchor((AnchorStyles)10);
			((ButtonBase)Buttn).set_UseVisualStyleBackColor(true);
			TextB = new TextBox();
			((Control)this).get_Controls().Add((Control)(object)TextB);
			((Control)TextB).set_Width(((Control)this).get_Width() - ((Control)Buttn).get_Width() - 9);
			((Control)TextB).set_Left(3);
			((Control)TextB).set_Top(3);
			((Control)TextB).set_Anchor((AnchorStyles)15);
			TextB.set_Multiline(true);
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			Props.KeyEncryption = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true);
			Random random = new Random();
			Props.IdProgram = Conversions.ToString(random.Next(1000, int.MaxValue));
			Props.IdRegistryProgram = Conversions.ToString(random.Next(1000, int.MaxValue));
			((ButtonBase)Buttn).set_Text(peremens.trans("Активировать"));
		}
	}
}
