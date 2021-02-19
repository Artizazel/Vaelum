using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SaveLists : MonoBehaviour
{

    public GameObject billy;

    // Start is called before the first frame update
    void Start()
    {
        //PrefabUtility.SaveAsPrefabAssetAndConnect(billy, "Assets/UserPrefabs" + "billo" + ".prefab", InteractionMode.UserAction);
        //Invoke("GetPrefab", 5f);
        //PrefabUtility.FindPrefabRoot(billy);

    }

    void GetPrefab()
    {
        //AssetImporter.GetAtPath("Assets/billo.prefab").SetAssetBundleNameAndVariant("test", "");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
