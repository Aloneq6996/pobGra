using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathManager : Singleton<pathManager>
{
    [field : SerializeField]
    public List<Transform> Path { get; private set; }
}
