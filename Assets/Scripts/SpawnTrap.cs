using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrap : MonoBehaviour
{
    [SerializeField]private GameObject[] Trap1;
    [SerializeField]private GameObject[] Trap2;
    [SerializeField]private GameObject[] Trap3;
    [SerializeField]private GameObject[] Trap4;
    [SerializeField]private GameObject[] Trap5;
    [SerializeField]private GameObject[] Trap6;
    [SerializeField]private GameObject[] Trap7;
    [SerializeField] private GameObject[] Trap8;
    [SerializeField] private GameObject[] Trap9;
    [SerializeField] private GameObject[] Trap10;
    [SerializeField] private GameObject[] Trap11;
    [SerializeField] private GameObject[] Trap12;
    [SerializeField] private GameObject[] Trap13;
    [SerializeField] private GameObject[] Trap14;
    [SerializeField] private GameObject[] Trap15;

    private void Start()
    {
        for (int i = 0;i < Trap1.Length;i++)
        {
            Trap1[Random.RandomRange(1,3)].SetActive(false);
        }
        for (int i = 0; i < Trap2.Length; i++)
        {
            Trap2[Random.RandomRange(1,3)].SetActive(false);
        }
        for (int i = 0; i < Trap3.Length; i++)
        {
            Trap3[Random.RandomRange(1, 3)].SetActive(false);
        }
        for (int i = 0; i < Trap4.Length; i++)
        {
            Trap4[Random.RandomRange(1, 3)].SetActive(false);
        }
        for (int i = 0; i < Trap5.Length; i++)
        {
            Trap5[Random.RandomRange(1, 3)].SetActive(false);
        }
        for (int i = 0; i < Trap6.Length; i++)
        {
            Trap6[Random.RandomRange(1, 3)].SetActive(false);
        }
        for (int i = 0; i < Trap7.Length; i++)
        {
            Trap7[Random.RandomRange(1, 3)].SetActive(false);
        }
        for (int i = 0; i < Trap8.Length; i++)
        {
            Trap8[Random.RandomRange(1, 3)].SetActive(false);
        }
        for (int i = 0; i < Trap9.Length; i++)
        {
            Trap9[Random.RandomRange(1, 3)].SetActive(false);
        }
        for (int i = 0; i < Trap10.Length; i++)
        {
            Trap10[Random.RandomRange(1,3)].SetActive(false);
        }
        for (int i = 0; i < Trap11.Length; i++)
        {
            Trap11[Random.RandomRange(1, 3)].SetActive(false);
        }
        for (int i = 0; i < Trap12.Length; i++)
        {
            Trap12[Random.RandomRange(1, 3)].SetActive(false);
        }
        for (int i = 0; i < Trap13.Length; i++)
        {
            Trap13[Random.RandomRange(1, 3)].SetActive(false);
        }
        for (int i = 0; i < Trap14.Length; i++)
        {
            Trap14[Random.RandomRange(1, 3)].SetActive(false);
        }
        for (int i = 0; i < Trap15.Length; i++)
        {
            Trap15[Random.RandomRange(1, 3)].SetActive(false);
        }

    }
}
