using System;
using System.Collections.Generic;
using MySql.Data;
using MySqlX.XDevAPI.Common;
using Mysqlx.Crud;

namespace MySqlX.XDevAPI.CRUD;

public class ModifyStatement : FilterableStatement<ModifyStatement, Collection, Result>
{
	internal List<UpdateSpec> Updates;

	internal ModifyStatement(Collection collection, string condition)
		: base(collection, condition)
	{
		Updates = new List<UpdateSpec>();
	}

	public ModifyStatement Set(string docPath, object value)
	{
		Updates.Add(new UpdateSpec(UpdateOperation.Types.UpdateType.ItemSet, docPath).SetValue(value));
		SetChanged();
		return this;
	}

	public ModifyStatement Change(string docPath, object value)
	{
		Updates.Add(new UpdateSpec(UpdateOperation.Types.UpdateType.ItemReplace, docPath).SetValue(value));
		SetChanged();
		return this;
	}

	public ModifyStatement Unset(params string[] docPath)
	{
		if (docPath == null)
		{
			return this;
		}
		foreach (string text in docPath)
		{
			if (text != null)
			{
				Updates.Add(new UpdateSpec(UpdateOperation.Types.UpdateType.ItemRemove, text));
			}
		}
		SetChanged();
		return this;
	}

	public ModifyStatement Patch(object document)
	{
		if (document == null)
		{
			throw new ArgumentNullException("document");
		}
		if (document is string && string.IsNullOrWhiteSpace((string)document))
		{
			throw new ArgumentNullException("document", Resources.ParameterNullOrEmpty);
		}
		DbDoc dbDoc = ((document is DbDoc) ? (document as DbDoc) : new DbDoc(document));
		Updates.Add(new UpdateSpec(UpdateOperation.Types.UpdateType.MergePatch, string.Empty).SetValue(dbDoc.values));
		SetChanged();
		return this;
	}

	public ModifyStatement ArrayInsert(string field, object value)
	{
		if (value is string && value.ToString() == string.Empty)
		{
			throw new ArgumentException("value", Resources.StringEmpty);
		}
		Updates.Add(new UpdateSpec(UpdateOperation.Types.UpdateType.ArrayInsert, field).SetValue(value));
		SetChanged();
		return this;
	}

	public ModifyStatement ArrayAppend(string docPath, object value)
	{
		if (value is string && value.ToString() == string.Empty)
		{
			throw new ArgumentException("value", Resources.StringEmpty);
		}
		Updates.Add(new UpdateSpec(UpdateOperation.Types.UpdateType.ArrayAppend, docPath).SetValue(value));
		SetChanged();
		return this;
	}

	public ModifyStatement Sort(params string[] order)
	{
		base.FilterData.OrderBy = order;
		SetChanged();
		return this;
	}

	[Obsolete("Where(string condition) has been deprecated since version 8.0.17.")]
	public new ModifyStatement Where(string condition)
	{
		return base.Where(condition);
	}

	public override Result Execute()
	{
		return Execute(base.Target.Session.XSession.ModifyDocs, this);
	}
}
