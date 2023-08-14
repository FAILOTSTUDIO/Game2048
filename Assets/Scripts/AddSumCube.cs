using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddSumCube : MonoBehaviour
{
    [SerializeField] private TextMeshPro[] Texts;
    [SerializeField]private int SelectedNumber;
    [SerializeField]private Renderer Cube;
    [SerializeField]private Material MaterialCube128;
    [SerializeField]private Material MaterialCube256;
    [SerializeField]private Material MaterialCube512;
    [SerializeField]private Material MaterialCube1024;
    [SerializeField]private Material MaterialCube2048;
    [SerializeField]private Material MaterialCube4096;
    [SerializeField]private Material MaterialCube8k;
    [SerializeField]private Material MaterialCube16k;
    [SerializeField]private Material MaterialCube32k;
    [SerializeField]private Material MaterialCube64k;
    public int CubeSum;
    private void Start()
    {
        SelectedNumber = Random.RandomRange(0, 9);
        if (SelectedNumber == 0) { CubeSum = 128; Cube.material = MaterialCube128; }
        if (SelectedNumber == 1) { CubeSum = 256; Cube.material = MaterialCube256; }
        if (SelectedNumber == 2) { CubeSum = 512; Cube.material = MaterialCube512; }
        if (SelectedNumber == 3) { CubeSum = 1024; Cube.material = MaterialCube1024; }
        if (SelectedNumber == 4) { CubeSum = 2048; Cube.material = MaterialCube2048; }
        if (SelectedNumber == 5) { CubeSum = 4096; Cube.material = MaterialCube4096; }
        if (SelectedNumber == 6) { CubeSum = 8192; Cube.material = MaterialCube8k; }
        if (SelectedNumber == 7) { CubeSum = 16384; Cube.material = MaterialCube16k; }
        if (SelectedNumber == 8) { CubeSum = 32768; Cube.material = MaterialCube32k; }
        if (SelectedNumber == 9) { CubeSum = 65536; Cube.material = MaterialCube64k; }
        for (int i = 0;i != 4; i++)
        {
            if(CubeSum < 4096)
            {
                Texts[i].text = CubeSum.ToString();
            }
            if(CubeSum == 4096)
            {
                Texts[i].text = "4K";
            }
            if (CubeSum == 8192)
            {
                Texts[i].text = "8K";
            }
            if(CubeSum == 16384)
            {
                Texts[i].text = "16K";
            }
            if(CubeSum == 32768)
            {
                Texts[i].text = "32K";
            }
            if(CubeSum == 65536)
            {
                Texts[i].text = "64K";
            }
        }
    }
}
  
