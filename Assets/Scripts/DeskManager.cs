using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskManager : MonoBehaviour
{
    GameObject deskPrefab;

    public Vector3 deskPosOrigin = Vector3.zero;

    public float deskOffsetX = 2.0f;
    public float deskOffsetZ = -2.0f;
    public float deskPosY = 0.5f;

    const int DESK_X_NUM = 3;
    const int DESK_Z_NUM = 6;

    private void Awake()
    {
        deskPrefab = Resources.Load<GameObject>("Prefabs/StudentDesk");
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int zindex = 0; zindex < DESK_Z_NUM; zindex++)
        {
            for (int xindex = 0; xindex < DESK_X_NUM; xindex++)
            {
                GameObject deskInstance = Instantiate(deskPrefab);
                deskInstance.transform.position= deskPosOrigin + new Vector3(deskOffsetX * xindex, deskPosY, deskOffsetZ * zindex);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
