using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameManager : MonoBehaviour
{
    List<string> names = new List<string>();

    private void Awake()
    {
        names.Add("荒木");
        names.Add("池田");
        names.Add("石川");
        names.Add("太田");
        names.Add("小山");
        names.Add("白石");
        names.Add("野口");
        names.Add("永井");
        names.Add("橋立");
        names.Add("羽生田");
        names.Add("馬場");
        names.Add("山口");
        names.Add("吉岡");
        names.Add("吉澤");
        names.Add("吉野");
        names.Add("尾﨑");
        names.Add("小林");
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < names.Count; i++)
        {
            Debug.Log(names[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
