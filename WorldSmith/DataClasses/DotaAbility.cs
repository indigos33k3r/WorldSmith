﻿/*****************************  NOTICE  ********************************************
* This file was autogenerated.  Do not edit.                                       *
* Instead, modify the schema in DataSchema related to this class and regenerate it *
***********************************************************************************/
using System;
using System.ComponentModel;

namespace WorldSmith.DataClasses
{
	class DotaAbility : DotaDataObject
	{
		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(0)]
		public int ID
		{
			get;
			set;
		}

		public enum AbilityTypeEnum
		{
			DOTA_ABILITY_TYPE_BASIC,
			DOTA_ABILITY_TYPE_ATTRIBUTES,
			DOTA_ABILITY_TYPE_ULTIMATE,
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(AbilityTypeEnum.DOTA_ABILITY_TYPE_BASIC)]
		public AbilityTypeEnum AbilityType
		{
			get;
			set;
		}

		[Flags]
		public enum AbilityBehaviorFlags
		{
			DOTA_ABILITY_BEHAVIOR_NONE = 0,
			DOTA_ABILITY_BEHAVIOR_HIDDEN = 1,
			DOTA_ABILITY_BEHAVIOR_PASSIVE = 2,
			DOTA_ABILITY_BEHAVIOR_NO_TARGET = 4,
			DOTA_ABILITY_BEHAVIOR_UNIT_TARGET = 8,
			DOTA_ABILITY_BEHAVIOR_POINT = 16,
			DOTA_ABILITY_BEHAVIOR_AOE = 32,
			DOTA_ABILITY_BEHAVIOR_NOT_LEARNABLE = 64,
			DOTA_ABILITY_BEHAVIOR_CHANNELLED = 128,
			DOTA_ABILITY_BEHAVIOR_ITEM = 256,
			DOTA_ABILITY_BEHAVIOR_TOGGLE = 512,
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(AbilityBehaviorFlags.DOTA_ABILITY_BEHAVIOR_NONE)]
		public AbilityBehaviorFlags AbilityBehavior
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue("")]
		public string AbilityTextureName
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(true)]
		public bool OnCastbar
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(true)]
		public bool OnLearnbar
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(0)]
		public int AbilityCastRange
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(250)]
		public int AbilityCastRangeBuffer
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(PerLevel), "0.0 0.0 0.0 0.0")]
		public PerLevel AbilityCastPoint
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(PerLevel), "0.0 0.0 0.0 0.0")]
		public PerLevel AbilityChannelTime
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(PerLevel), "0.0 0.0 0.0 0.0")]
		public PerLevel AbilityCooldown
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(PerLevel), "0.0 0.0 0.0 0.0")]
		public PerLevel AbilityDuration
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue("")]
		public string AbilitySharedCooldown
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(PerLevel), "0 0 0 0")]
		public PerLevel AbilityDamage
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(PerLevel), "0 0 0 0")]
		public PerLevel AbilityManaCost
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(1.0)]
		public float AbilityModifierSupportValue
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(0)]
		public float AbilityModifierSupportBonus
		{
			get;
			set;
		}

	}
}