using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PlatformPrefab;
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            var platform = Instantiate(PlatformPrefab);
            platform.transform.position = new Vector3(i, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
