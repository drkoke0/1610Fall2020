using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour
{
    public List<Collectible> collectibleList;

    private void Start()
    {
        foreach (var item:Collectible in collectibleList)
        {
            print(item);
        }
    }
}
