using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class LoadAssetBundles : MonoBehaviour
{

    GameObject item;

    AssetBundle myloadedAssetBundle;

    public string bundlePath;
    public string assetNameOri;

    // Start is called before the first frame update
    void Start()
    {
        print("startLoad");

        LoadAssetBundle(bundlePath);

        InstantiateObjectfromBundle(assetNameOri);
    }

    void LoadAssetBundle(string bundleUrl)
    {
        myloadedAssetBundle = AssetBundle.LoadFromFile(@"Assets\AssetBundles\test");

        print((myloadedAssetBundle == null) ? "didn't load" : "loaded");

    }

    void InstantiateObjectfromBundle(string assetName)
    {
        var prefab = myloadedAssetBundle.LoadAsset(assetName);

        Instantiate(prefab, gameObject.transform);

    }


}
