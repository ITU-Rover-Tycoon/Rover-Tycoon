using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Managers;
using ScriptsLibrary;
using UnityEngine;

public class MemberSubwindow : MonoBehaviour
{
    [SerializeField] private GameObject MemberDisplay;
    private GameObject[] _memberDisplayArray;
    private MembersManager _membersManager;
    private MemberLibrary.Member[] _members;
    private int membersLength;

    // Start is called before the first frame update
    void Start()
    {
        getMembers();
    }

    private void getMembers()
    {
        _members = _membersManager.MembersList;
        membersLength = _members.Length;
        
        for (int i = 0; i < membersLength; i++)
        {
            CreateMemberDisplay(_members[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    GameObject CreateMemberDisplay(MemberLibrary.Member member)
    {
        var memDisBuffer = Instantiate(MemberDisplay);
        // burada oluşturulan memberın içi doldurulacak
        _memberDisplayArray.Append(memDisBuffer);
        return memDisBuffer;
        
    }
}
