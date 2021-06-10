using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDapp.Models
{
    public class AbilityScores
    {


        public int count { get; set; }
        public List<Result> results { get; set; }


    }
    public class Result
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Charisma
    {
        public string index { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public List<string> desc { get; set; }
        public List<Skill> skills { get; set; }
        public string url { get; set; }
    }

    public class Constitution
    {
        public string index { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public List<string> desc { get; set; }
        public List<Skill> skills { get; set; }
        public string url { get; set; }
    }

    public class Dexterity
    {
        public string index { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public List<string> desc { get; set; }
        public List<Skill> skills { get; set; }
        public string url { get; set; }
    }

    public class Intelligence
    {
        public string index { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public List<string> desc { get; set; }
        public List<Skill> skills { get; set; }
        public string url { get; set; }
    }

    public class Strength
    {
        public string index { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public List<string> desc { get; set; }
        public List<Skill> skills { get; set; }
        public string url { get; set; }
    }

    public class Wisdom
    {
        public string index { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public List<string> desc { get; set; }
        public List<Skill> skills { get; set; }
        public string url { get; set; }
    }

    public class Skill
    {
        public string name { get; set; }
        public string index { get; set; }
        public string url { get; set; }
    }







}
