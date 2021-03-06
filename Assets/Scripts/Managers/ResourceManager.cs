using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager
{
    public T Load<T>(string path) where T : Object
    {
        return Resources.Load<T>(path);
    }

    public GameObject Instantiate(string path, Transform parent = null)
    {
        GameObject prefab = Load<GameObject>($"Prefabs/{path}");
        return Object.Instantiate(prefab, parent);
    }

    public void Destroy(GameObject boom)
    {
        if (boom == null) { return; }
        Object.Destroy(boom);
    }
}
