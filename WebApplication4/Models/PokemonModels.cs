﻿using System.Collections.Generic;

namespace WebApplication4.Models
{
    public class Ability2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Ability
    {
        public Ability2 ability { get; set; }
        public bool is_hidden { get; set; }
        public int slot { get; set; }
    }

    public class Form
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class GameIndice
    {
        public int game_index { get; set; }
        public Version version { get; set; }
    }

    public class Move2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class MoveLearnMethod
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class VersionGroup
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class VersionGroupDetail
    {
        public int level_learned_at { get; set; }
        public MoveLearnMethod move_learn_method { get; set; }
        public VersionGroup version_group { get; set; }
    }

    public class Move
    {
        public Move2 move { get; set; }
        public List<VersionGroupDetail> version_group_details { get; set; }
    }

    public class Species
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Sprites
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Stat2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Stat
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public Stat2 stat { get; set; }
    }

    public class Type2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Type
    {
        public int slot { get; set; }
        public Type2 type { get; set; }
    }

    public class Pokemon
    {
        public List<Ability> abilities { get; set; }
        public int base_experience { get; set; }
        public List<Form> forms { get; set; }
        public List<GameIndice> game_indices { get; set; }
        public int height { get; set; }
        public List<object> held_items { get; set; }
        public int id { get; set; }
        public bool is_default { get; set; }
        public string location_area_encounters { get; set; }
        public List<Move> moves { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public Species species { get; set; }
        public Sprites sprites { get; set; }
        public List<Stat> stats { get; set; }
        public List<Type> types { get; set; }
        public int weight { get; set; }
    }
}