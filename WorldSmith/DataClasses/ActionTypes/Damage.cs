/*****************************  NOTICE  ********************************************
* This file was autogenerated.  Do not edit.                                       *
* Instead, modify the schema in DataSchema related to this class and regenerate it *
***********************************************************************************/
using System;
using System.ComponentModel;
using WorldSmith.Panels;
using WorldSmith.Dialogs;

namespace WorldSmith.DataClasses
{
	[DotaAction]
	[EditorGrammar("Do %DamageAmount of %Type damage to %Target")]
	public partial class Damage : TargetedAction
	{
		public enum TypeEnum
		{
			DAMAGE_TYPE_COMPOSITE,
			DAMAGE_TYPE_HP_REMOVAL,
			DAMAGE_TYPE_MAGICAL,
			DAMAGE_TYPE_PHYSICAL,
			DAMAGE_TYPE_PURE,
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(TypeEnum.DAMAGE_TYPE_MAGICAL)]
		public TypeEnum Type
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("int")]
		[DefaultValue("")]
		public string DamageAmount
		{
			get;
			set;
		}

	}
}
