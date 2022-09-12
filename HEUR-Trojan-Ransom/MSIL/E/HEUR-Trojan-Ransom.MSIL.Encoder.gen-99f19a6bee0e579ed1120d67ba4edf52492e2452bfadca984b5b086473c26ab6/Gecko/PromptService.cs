using System;

namespace Gecko;

public class PromptService : nsIPrompt, nsIAuthPrompt2, nsIAuthPrompt
{
	public virtual void Alert(string dialogTitle, string text)
	{
		DefaultPromptFactory.GetPrompt<nsIPrompt>().Alert(dialogTitle, text);
	}

	public virtual void AlertCheck(string dialogTitle, string text, string checkMsg, ref bool checkValue)
	{
		DefaultPromptFactory.GetPrompt<nsIPrompt>().AlertCheck(dialogTitle, text, checkMsg, ref checkValue);
	}

	public virtual bool Confirm(string dialogTitle, string text)
	{
		return DefaultPromptFactory.GetPrompt<nsIPrompt>().Confirm(dialogTitle, text);
	}

	public virtual bool ConfirmCheck(string dialogTitle, string text, string checkMsg, ref bool checkValue)
	{
		return DefaultPromptFactory.GetPrompt<nsIPrompt>().ConfirmCheck(dialogTitle, text, checkMsg, ref checkValue);
	}

	public virtual int ConfirmEx(string dialogTitle, string text, uint buttonFlags, string button0Title, string button1Title, string button2Title, string checkMsg, ref bool checkValue)
	{
		return DefaultPromptFactory.GetPrompt<nsIPrompt>().ConfirmEx(dialogTitle, text, buttonFlags, button0Title, button1Title, button2Title, checkMsg, ref checkValue);
	}

	public virtual bool Prompt(string dialogTitle, string text, ref string value, string checkMsg, ref bool checkValue)
	{
		return DefaultPromptFactory.GetPrompt<nsIPrompt>().Prompt(dialogTitle, text, ref value, checkMsg, ref checkValue);
	}

	public virtual bool PromptPassword(string dialogTitle, string text, ref string password, string checkMsg, ref bool checkValue)
	{
		return DefaultPromptFactory.GetPrompt<nsIPrompt>().PromptPassword(dialogTitle, text, ref password, checkMsg, ref checkValue);
	}

	public virtual bool PromptUsernameAndPassword(string dialogTitle, string text, ref string username, ref string password, string checkMsg, ref bool checkValue)
	{
		return DefaultPromptFactory.GetPrompt<nsIPrompt>().PromptUsernameAndPassword(dialogTitle, text, ref username, ref password, checkMsg, ref checkValue);
	}

	public virtual bool Select(string dialogTitle, string text, uint count, IntPtr[] selectList, ref int outSelection)
	{
		return DefaultPromptFactory.GetPrompt<nsIPrompt>().Select(dialogTitle, text, count, selectList, ref outSelection);
	}

	public virtual bool PromptAuth(nsIChannel aChannel, uint level, nsIAuthInformation authInfo)
	{
		return DefaultPromptFactory.GetPrompt<nsIAuthPrompt2>().PromptAuth(aChannel, level, authInfo);
	}

	public virtual nsICancelable AsyncPromptAuth(nsIChannel aChannel, nsIAuthPromptCallback aCallback, nsISupports aContext, uint level, nsIAuthInformation authInfo)
	{
		return DefaultPromptFactory.GetPrompt<nsIAuthPrompt2>().AsyncPromptAuth(aChannel, aCallback, aContext, level, authInfo);
	}

	public virtual bool Prompt(string dialogTitle, string text, string passwordRealm, uint savePassword, string defaultText, ref string result)
	{
		return DefaultPromptFactory.GetPrompt<nsIAuthPrompt>().Prompt(dialogTitle, text, passwordRealm, savePassword, defaultText, ref result);
	}

	public virtual bool PromptUsernameAndPassword(string dialogTitle, string text, string passwordRealm, uint savePassword, ref string user, ref string pwd)
	{
		return DefaultPromptFactory.GetPrompt<nsIAuthPrompt>().PromptUsernameAndPassword(dialogTitle, text, passwordRealm, savePassword, ref user, ref pwd);
	}

	public virtual bool PromptPassword(string dialogTitle, string text, string passwordRealm, uint savePassword, ref string pwd)
	{
		return DefaultPromptFactory.GetPrompt<nsIAuthPrompt>().PromptPassword(dialogTitle, text, passwordRealm, savePassword, ref pwd);
	}
}
