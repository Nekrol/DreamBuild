namespace DreamBuild.Models
{
    public class Ability
    {
        public float id { get; set; }
        public string name { get; set; }
        public string name_loc { get; set; }
        public string desc_loc { get; set; }
        public string lore_loc { get; set; }
        public List<string> notes_loc { get; set; }
        public string shard_loc { get; set; }
        public string scepter_loc { get; set; }
        public float type { get; set; }
        public string behavior { get; set; }
        public float target_team { get; set; }
        public float target_type { get; set; }
        public float flags { get; set; }
        public float damage { get; set; }
        public float immunity { get; set; }
        public float dispellable { get; set; }
        public float max_level { get; set; }
        public List<float> cast_ranges { get; set; }
        public List<double> cast_pofloats { get; set; }
        public List<float> channel_times { get; set; }
        public List<double> cooldowns { get; set; }
        public List<float> durations { get; set; }
        public List<float> damages { get; set; }
        public List<float> mana_costs { get; set; }
        public List<object> gold_costs { get; set; }
        public List<object> health_costs { get; set; }
        public List<SpecialValue> special_values { get; set; }
        public bool is_item { get; set; }
        public bool ability_has_scepter { get; set; }
        public bool ability_has_shard { get; set; }
        public bool ability_is_granted_by_scepter { get; set; }
        public bool ability_is_granted_by_shard { get; set; }
        public float item_cost { get; set; }
        public float item_initial_charges { get; set; }
        public object item_neutral_tier { get; set; }
        public float item_stock_max { get; set; }
        public float item_stock_time { get; set; }
        public float item_quality { get; set; }
    }

    public class Bonuse
    {
        public string name { get; set; }
        public double value { get; set; }
        public float operation { get; set; }
    }

    public class Data
    {
        public List<HeroAPI> heroes { get; set; }
    }

    public class HeroAPI
    {
        public float id { get; set; }
        public string name { get; set; }
        public float order_id { get; set; }
        public string name_loc { get; set; }
        public string bio_loc { get; set; }
        public string hype_loc { get; set; }
        public string npe_desc_loc { get; set; }
        public float str_base { get; set; }
        public double str_gain { get; set; }
        public float agi_base { get; set; }
        public double agi_gain { get; set; }
        public float float_base { get; set; }
        public double float_gain { get; set; }
        public float primary_attr { get; set; }
        public float complexity { get; set; }
        public float attack_capability { get; set; }
        public List<float> role_levels { get; set; }
        public float damage_min { get; set; }
        public float damage_max { get; set; }
        public double attack_rate { get; set; }
        public float attack_range { get; set; }
        public float projectile_speed { get; set; }
        public float armor { get; set; }
        public float magic_resistance { get; set; }
        public float movement_speed { get; set; }
        public double turn_rate { get; set; }
        public float sight_range_day { get; set; }
        public float sight_range_night { get; set; }
        public float max_health { get; set; }
        public double health_regen { get; set; }
        public float max_mana { get; set; }
        public double mana_regen { get; set; }
        public List<Ability> abilities { get; set; }
        public List<Talent> talents { get; set; }
    }

    public class Result
    {
        public Data data { get; set; }
        public float status { get; set; }
    }

    public class Root
    {
        public Result result { get; set; }
    }

    public class SpecialValue
    {
        public string name { get; set; }
        public List<double> values_float { get; set; }
        public bool is_percentage { get; set; }
        public string heading_loc { get; set; }
        public List<Bonuse> bonuses { get; set; }
        public List<object> values_shard { get; set; }
        public List<object> values_scepter { get; set; }
    }

    public class Talent
    {
        public float id { get; set; }
        public string name { get; set; }
        public string name_loc { get; set; }
        public string desc_loc { get; set; }
        public string lore_loc { get; set; }
        public List<object> notes_loc { get; set; }
        public string shard_loc { get; set; }
        public string scepter_loc { get; set; }
        public float type { get; set; }
        public string behavior { get; set; }
        public float target_team { get; set; }
        public float target_type { get; set; }
        public float flags { get; set; }
        public float damage { get; set; }
        public float immunity { get; set; }
        public float dispellable { get; set; }
        public float max_level { get; set; }
        public List<float> cast_ranges { get; set; }
        public List<float> cast_pofloats { get; set; }
        public List<float> channel_times { get; set; }
        public List<float> cooldowns { get; set; }
        public List<float> durations { get; set; }
        public List<float> damages { get; set; }
        public List<float> mana_costs { get; set; }
        public List<object> gold_costs { get; set; }
        public List<object> health_costs { get; set; }
        public List<SpecialValue> special_values { get; set; }
        public bool is_item { get; set; }
        public bool ability_has_scepter { get; set; }
        public bool ability_has_shard { get; set; }
        public bool ability_is_granted_by_scepter { get; set; }
        public bool ability_is_granted_by_shard { get; set; }
        public float item_cost { get; set; }
        public float item_initial_charges { get; set; }
        public object item_neutral_tier { get; set; }
        public float item_stock_max { get; set; }
        public float item_stock_time { get; set; }
        public float item_quality { get; set; }
    }
}
