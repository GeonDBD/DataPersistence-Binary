using System;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    private void Start()
    {
        byte[] bytes = BitConverter.GetBytes(100);
        foreach (int item in bytes)
        {
            print(item);
        }

        int i = BitConverter.ToInt32(bytes, 0);
        print(i);
    }
}
