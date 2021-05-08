using UnityEngine;

namespace ScriptsLibrary
{


    public class MembersLibrary : MonoBehaviour
    {
        public class Member // If Member[] is used, properties can be called like member[i].Name, member[i].Gender ...
        {
            private string _name;
            private int _gender; // 0 erkek 1 kız
            public Stats stat;
            //public TeamEnum _team; 
            //public JobEnum assignedJob;

            public string Name { get => this._name; set => _name = value; }
            public int Gender { get => this._gender; set => _gender = value; }
            
        }
        
        public class Stats
        {
            public int researching, presentation, persuasion, entertainment, creativity, finance, threeDThinking, engineering_Know,
                dexterity, algorithmic_Thinking, hardware, highLevelProgramming, lowLevelProgramming, chemistry, biology, geology, electronics, english;
            
            public void SetStats(int Research,int Present,int Persuasion,int Entertainment,int Creativity, int Finance,int Threedthink, int EngKnow,
                                 int Dex,int Algo_think,int Hardware,int HighLevProg,int LowLevProg,int Chem,int Bio, int Geo,int Electro,int English)
            {
                researching = Research;
                presentation = Present;
                persuasion = Persuasion;
                entertainment = Entertainment;
                creativity = Creativity;
                finance = Finance;
                threeDThinking = Threedthink;
                engineering_Know = EngKnow;
                dexterity = Dex;
                algorithmic_Thinking = Algo_think;
                hardware = Hardware;
                highLevelProgramming = HighLevProg;
                lowLevelProgramming = LowLevProg;
                chemistry = Chem;
                biology = Bio;
                geology = Geo;
                electronics = Electro;
                english = English;
            }
        }

        public static string GetAttributes()
        {
            Member member = new Member();
            return member.Name;
        }
    }
}
