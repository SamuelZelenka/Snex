using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPoolable
{
    void SetActive(bool active);
    GameObject gameObject { get; }
}
