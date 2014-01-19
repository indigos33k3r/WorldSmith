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
	[EditorGrammar("Create a thinking %ModifierName wall that is %Width by %Length units rotated %Rotation degrees at %Target")]
	public partial class CreateThinkerWall : CreateThinker
	{
		[Category("Misc")]
		[Description("int")]
		[DefaultValue("")]
		public string Width
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("int")]
		[DefaultValue("")]
		public string Length
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("rotation")]
		[DefaultValue("")]
		public string Rotation
		{
			get;
			set;
		}

	}
}
