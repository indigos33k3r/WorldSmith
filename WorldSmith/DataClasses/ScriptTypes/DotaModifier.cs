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
	public partial class DotaModifier : BaseScriptType
	{
		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(NumberValue), "")]
		public NumberValue Duration
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(false)]
		public bool IsDebuff
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(false)]
		public bool IsPurgable
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(false)]
		public bool IsHidden
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(false)]
		public bool RemoveOnDeath
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(false)]
		public bool AllowIllusionDuplicate
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue("")]
		public string EffectName
		{
			get;
			set;
		}

		public enum EffectAttachTypeEnum
		{
			start_at_origin,
			follow_origin,
			start_at_customorigin,
			follow_customorigin,
			start_at_attachment,
			follow_attachment,
			follow_eyes,
			follow_overhead,
			world_origin,
			follow_rootbone,
			follow_attachment_substepped,
			follow_renderorigin,
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(EffectAttachTypeEnum.follow_origin)]
		public EffectAttachTypeEnum EffectAttachType
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue("")]
		public string StatusEffectName
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(NumberValue), "")]
		public NumberValue StatusEffectPriority
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue("")]
		public string ModelName
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue("")]
		public string OverrideAnimation
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(NumberValue), "")]
		public NumberValue ThinkInterval
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue("")]
		public string Aura
		{
			get;
			set;
		}

		[Flags]
		public enum Aura_TeamsFlags
		{
			DOTA_UNIT_TARGET_TEAM_NONE = 0,
			DOTA_UNIT_TARGET_TEAM_ENEMY = 1 << 1,
			DOTA_UNIT_TARGET_TEAM_FRIENDLY = 1 << 2,
			DOTA_UNIT_TARGET_TEAM_CUSTOM = 1 << 3,
			DOTA_UNIT_TARGET_TEAM_BOTH = 1 << 4,
			DOTA_UNIT_TARGET_ALL = 0xFFFF,
		}

		[Editor(typeof(FlagEnumDialogUIEditor), typeof(System.Drawing.Design.UITypeEditor))]
		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(Aura_TeamsFlags.DOTA_UNIT_TARGET_TEAM_NONE)]
		public Aura_TeamsFlags Aura_Teams
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(NumberValue), "")]
		public NumberValue Aura_Radius
		{
			get;
			set;
		}

		[Flags]
		public enum Aura_TypesFlags
		{
			DOTA_UNIT_TARGET_NONE = 0,
			DOTA_UNIT_TARGET_HERO = 1 << 1,
			DOTA_UNIT_TARGET_CREEP = 1 << 2,
			DOTA_UNIT_TARGET_BUILDING = 1 << 3,
			DOTA_UNIT_TARGET_MECHANICAL = 1 << 4,
			DOTA_UNIT_TARGET_COURIER = 1 << 5,
			DOTA_UNIT_TARGET_OTHER = 1 << 6,
			DOTA_UNIT_TARGET_TREE = 1 << 7,
			DOTA_UNIT_TARGET_CUSTOM = 1 << 8,
			DOTA_UNIT_TARGET_BASIC = 1 << 9,
			DOTA_UNIT_TARGET_ALL = 0xFFFF,
		}

		[Editor(typeof(FlagEnumDialogUIEditor), typeof(System.Drawing.Design.UITypeEditor))]
		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(Aura_TypesFlags.DOTA_UNIT_TARGET_NONE)]
		public Aura_TypesFlags Aura_Types
		{
			get;
			set;
		}

		[Flags]
		public enum Aura_FlagsFlags
		{
			DOTA_UNIT_TARGET_FLAG_NONE = 0,
			DOTA_UNIT_TARGET_FLAG_RANGED_ONLY = 1 << 1,
			DOTA_UNIT_TARGET_FLAG_MELEE_ONLY = 1 << 2,
			DOTA_UNIT_TARGET_FLAG_DEAD = 1 << 3,
			DOTA_UNIT_TARGET_FLAG_MAGIC_IMMUNE_ENEMIES = 1 << 4,
			DOTA_UNIT_TARGET_FLAG_NOT_MAGIC_IMMUNE_ALLIES = 1 << 5,
			DOTA_UNIT_TARGET_FLAG_INVULNERABLE = 1 << 6,
			DOTA_UNIT_TARGET_FLAG_FOW_VISIBLE = 1 << 7,
			DOTA_UNIT_TARGET_FLAG_NO_INVIS = 1 << 8,
			DOTA_UNIT_TARGET_FLAG_NOT_ANCIENTS = 1 << 9,
			DOTA_UNIT_TARGET_FLAG_PLAYER_CONTROLLED = 1 << 10,
			DOTA_UNIT_TARGET_FLAG_NOT_DOMINATED = 1 << 11,
			DOTA_UNIT_TARGET_FLAG_NOT_SUMMONED = 1 << 12,
			DOTA_UNIT_TARGET_FLAG_NOT_ILLUSION = 1 << 13,
			DOTA_UNIT_TARGET_FLAG_NOT_ATTACK_IMMUNE = 1 << 14,
			DOTA_UNIT_TARGET_FLAG_MANA_ONLY = 1 << 15,
			DOTA_UNIT_TARGET_FLAG_CHECK_DISABLE_HELP = 1 << 16,
			DOTA_UNIT_TARGET_FLAG_NOT_CREEP_HERO = 1 << 17,
			DOTA_UNIT_TARGET_FLAG_OUT_OF_WORLD = 1 << 18,
			DOTA_UNIT_TARGET_FLAG_NOT_NIGHTMARED = 1 << 19,
		}

		[Editor(typeof(FlagEnumDialogUIEditor), typeof(System.Drawing.Design.UITypeEditor))]
		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(Aura_FlagsFlags.DOTA_UNIT_TARGET_FLAG_NONE)]
		public Aura_FlagsFlags Aura_Flags
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(false)]
		public bool Aura_ApplyToCaster
		{
			get;
			set;
		}

		public enum AttributesEnum
		{
			MODIFIER_ATTRIBUTE_NONE,
			MODIFIER_ATTRIBUTE_IGNORE_INVULNERABLE	,
			MODIFIER_ATTRIBUTE_MULTIPLE,
			MODIFIER_ATTRIBUTE_PERMANENT,
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(AttributesEnum.MODIFIER_ATTRIBUTE_NONE)]
		public AttributesEnum Attributes
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(ActionCollection), "OnCreated")]
		public ActionCollection OnCreated
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(ActionCollection), "OnIntervalThink")]
		public ActionCollection OnIntervalThink
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(ActionCollection), "OnAttacked")]
		public ActionCollection OnAttacked
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(ActionCollection), "OnAttackLanded")]
		public ActionCollection OnAttackLanded
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(ActionCollection), "OnTakeDamage")]
		public ActionCollection OnTakeDamage
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(ActionCollection), "OnDealDamage")]
		public ActionCollection OnDealDamage
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(ActionCollection), "OnDeath")]
		public ActionCollection OnDeath
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(ActionCollection), "OnKill")]
		public ActionCollection OnKill
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(ActionCollection), "OnAttackStart")]
		public ActionCollection OnAttackStart
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(ActionCollection), "OnDestroy")]
		public ActionCollection OnDestroy
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(ModifierPropertyCollection), "")]
		public ModifierPropertyCollection Properties
		{
			get;
			set;
		}

	}
}
