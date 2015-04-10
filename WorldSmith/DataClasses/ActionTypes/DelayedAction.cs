/*****************************  NOTICE  ********************************************
* This file was autogenerated.  Do not edit.                                       *
* Instead, modify the schema in DataSchema related to this class and regenerate it *
***********************************************************************************/
using System;
using System.ComponentModel;
using WorldSmith.Panels;
using WorldSmith.Dialogs;
using KVLib;

namespace WorldSmith.DataClasses
{
	[DotaAction]
	[EditorGrammar("Do %Action after a %Delay second delay")]
	public partial class DelayedAction : BaseAction
	{
		public DelayedAction(KeyValue kv)
			: base(kv)
		{
		}
		public DelayedAction(string className)
			: base(className)
		{
		}
		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(null)]
		public DotaActionCollection Action
		{
			get
			{
				return default(DotaActionCollection);
			}
			set
			{
				KeyValue kv = GetSubkey("Action");
				if(kv == null)
				{
					kv = new KeyValue("Action");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Misc")]
		[Description("float")]
		[DefaultValue(typeof(NumberValue), "")]
		public NumberValue Delay
		{
			get
			{
				KeyValue kv = GetSubkey("Delay");
				return (kv == null ? new NumberValue("") : kv.GetNumberValue());
			}
			set
			{
				KeyValue kv = GetSubkey("Delay");
				if(kv == null)
				{
					kv = new KeyValue("Delay");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

	}
}
