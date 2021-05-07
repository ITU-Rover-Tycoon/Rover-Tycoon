using UnityEngine;

namespace ScriptsLibrary
{


    public class MembersLibrary : MonoBehaviour
    {
        public class Member
        {
            private string name;
            private int gender; // 0 erkek 1 kız
            private Stats stat;
        }
        
        public class Stats
        {
            int threeDThinking;
        }

        public static void GetAttribute()
        {
            
        }
    }
}
