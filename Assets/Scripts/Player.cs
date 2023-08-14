using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField]Rigidbody rb;
    [SerializeField] private Renderer Cube;
    [SerializeField] private float runSpeed = 300;
    [SerializeField] private float strafeSpeed = 300f;
    [SerializeField] private float jumpForce = 15f;
    private bool strafeLeft = false;
    private bool strafeRight = false;
    private int sumCube = 128;
    [SerializeField] private Material MaterialCube128;
    [SerializeField] private Material MaterialCube256;
    [SerializeField] private Material MaterialCube512;
    [SerializeField] private Material MaterialCube1024;
    [SerializeField] private Material MaterialCube2048;
    [SerializeField] private Material MaterialCube4096;
    [SerializeField] private Material MaterialCube8k;
    [SerializeField] private Material MaterialCube16k;
    [SerializeField] private Material MaterialCube32k;
    [SerializeField] private Material MaterialCube64k;
    [SerializeField]private TextMeshPro sumText;
    [SerializeField]private GameObject TryAgainUI;

    private void Start()
    {
        ChangeSumText();
    }
    public void ChangeSumText()
    {
        sumText.text = sumCube.ToString();
        if (sumCube == 128)   { Cube.material = MaterialCube128; }
        if (sumCube == 256)   { Cube.material = MaterialCube256; }
        if (sumCube == 512 )  {Cube.material = MaterialCube512; }
        if (sumCube == 1024)  { Cube.material = MaterialCube1024; }
        if (sumCube == 2048)  { Cube.material = MaterialCube2048; }
        if (sumCube == 4096)  { Cube.material = MaterialCube4096; }
        if (sumCube == 8192)  { Cube.material = MaterialCube8k; }
        if (sumCube == 16384) { Cube.material = MaterialCube16k; }
        if (sumCube == 32768) { Cube.material = MaterialCube32k; }
        if (sumCube == 65536) { Cube.material = MaterialCube64k; } /// Можно реализовать через цикл for,но строк меньше,не станет
    }

    private void FixedUpdate()
    {
        if(rb.velocity.magnitude != 333)
        {
            rb.AddForce(0, 0, runSpeed * Time.deltaTime);
        }
        if (strafeLeft)
        {
            rb.AddForce(strafeSpeed * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (strafeRight)
        {
            rb.AddForce(-strafeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
    private void OnTriggerEnter(Collider colis)
    {
        if(colis.gameObject.tag == "CubeAddSum")
        {

            GameObject cube = colis.gameObject;
            if(cube.GetComponent<AddSumCube>().CubeSum == sumCube)
            {
                sumCube += cube.GetComponent<AddSumCube>().CubeSum;
                ChangeSumText();
                DestroyObject(cube);
            }
            else
            {
                DestroyObject(cube);
            }
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Spike")
        {
            TryAgainUI.SetActive(true);
        }
    }

    private void Update()
    {
        if (Input.GetKey("d"))
        {
            strafeLeft = true;
        }
        else
        {
            strafeLeft = false;
        }
        if (Input.GetKey("a"))
        {
            strafeRight = true;
        }
        else
        {
            strafeRight = false;
        }
    }
}
