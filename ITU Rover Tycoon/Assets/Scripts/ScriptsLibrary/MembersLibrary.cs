using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptsLibrary
{
    public static class MembersLibrary
    {

        public class Member // If Member[] is used, properties can be called like member[i].Name, member[i].Gender ...
        {
            private string _name;
            private int _gender; // 0 erkek 1 kız
            public Stats stat;

            void Start()
            {
                stat = new Stats();
                stat.InitialiseStats();
            }
            
            //public TeamEnum _team; 
            //public JobEnum assignedJob;

            public string Name { get => this._name; set => _name = value; }
            public int Gender { get => this._gender; set => _gender = value; }
        }
        
        public class Stats
        {
            private IDictionary<string,int> Statistics = new Dictionary<string,int>();

            void Start()
            {
                InitialiseStats();
            }

            public void InitialiseStats()
            {
                Statistics.Add("researching", default);
                Statistics.Add("presentation", default);
                Statistics.Add("persuasion", default);
                Statistics.Add("entertainment", default);
                Statistics.Add("creativity", default);
                Statistics.Add("finance", default);
                Statistics.Add("threeDThinking", default);
                Statistics.Add("engineering_Know", default);
                Statistics.Add("dexterity", default);
                Statistics.Add("algorithmic_Thinking", default);
                Statistics.Add("hardware", default);
                Statistics.Add("highLevelProgramming", default);
                Statistics.Add("lowLevelProgramming", default);
                Statistics.Add("chemistry", default);
                Statistics.Add("biology", default);
                Statistics.Add("geology", default);
                Statistics.Add("electronics", default);
                Statistics.Add("english", default);
            }

            public void SetStats(int Research,int Present,int Persuasion,int Entertainment,int Creativity, int Finance,int Threedthink, int EngKnow,
                                 int Dex,int Algo_think,int Hardware,int HighLevProg,int LowLevProg,int Chem,int Bio, int Geo,int Electro,int English)
            {
                Statistics["researching"] = Research;
                Statistics["presentation"] = Present;
                Statistics["persuasion"] = Persuasion;
                Statistics["entertainment"] = Entertainment;
                Statistics["creativity"] = Creativity;
                Statistics["finance"] = Finance;
                Statistics["threeDThinking"] = Threedthink;
                Statistics["engineering_Know"] = EngKnow;
                Statistics["dexterity"] = Dex;
                Statistics["algorithmic_Thinking"] = Algo_think;
                Statistics["hardware"] = Hardware;
                Statistics["highLevelProgramming"] = HighLevProg;
                Statistics["lowLevelProgramming"] = LowLevProg;
                Statistics["chemistry"] = Chem;
                Statistics["biology"] = Bio;
                Statistics["geology"] = Geo;
                Statistics["electronics"] = Electro;
                Statistics["english"] = English;
            }
        }

        public static string GetAttributes()
        {
            Member member = new Member();
            return member.Name;
        }
    }
}
