using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Shyuren : MonoBehaviour
{
    public GameObject player;
    public float sphereSpeed = 100.0f;
    public float mode = 1f;
    public string names;
    public GameObject box;

    // Start is called before the first frame update
    void Start()
    {
        if (mode == 2)
        {
            int rnd = Random.Range(1, 7);
            if (rnd == 1)
            {
                box.GetComponent<Renderer>().material.color = Color.red;
            }
            if (rnd == 2)
            {
                box.GetComponent<Renderer>().material.color = Color.blue;
            }
            if (rnd == 3)
            {
                box.GetComponent<Renderer>().material.color = Color.yellow;
            }
            if (rnd == 4)
            {
                box.GetComponent<Renderer>().material.color = Color.magenta;
            }
            if (rnd == 5)
            {
                box.GetComponent<Renderer>().material.color = Color.white;
            }
            if (rnd == 6)
            {
                box.GetComponent<Renderer>().material.color = Color.green;
            }
            if (rnd == 7)
            {
                box.GetComponent<Renderer>().material.color = Color.cyan;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (mode == 1)
        {
            if (Input.GetKey(KeyCode.Alpha0))
            {
                transform.LookAt(player.transform);
                //Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
                //Vector3 force = new Vector3(0.0f, 0.0f, 100.0f);    // 力を設定
                //rb.AddForce(force);  // 力を加える
                //this.GetComponent<Rigidbody>().AddForce(this.transform.forward + 100);
                transform.position += transform.forward * sphereSpeed * Time.deltaTime;
                GetComponent<NavMeshAgent>().enabled = false;
                //GetComponent<BoxCollider>().enabled = false;
                GetComponent<Rigidbody>().isKinematic = true;
            }

            if (Input.GetKeyUp(KeyCode.Alpha0))
            {

                GetComponent<NavMeshAgent>().enabled = true;
                //GetComponent<BoxCollider>().enabled = false;
                GetComponent<Rigidbody>().isKinematic = false;
            }
        }

        if(mode == 2)
        {
            transform.LookAt(player.transform);
            transform.position += transform.forward * sphereSpeed * Time.deltaTime;
            Vector3 dir = (player.transform.position - this.transform.position).normalized;
            float vx = dir.x * sphereSpeed;
            float vz = dir.z * sphereSpeed;
            //this.transform.Translate(vx / 50, 0, vz / 50);
            //GetComponent<Rigidbody>().isKinematic = false;
            Vector3 ra = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
            Debug.Log(vx);
            //transform.position += transform.forward * sphereSpeed * Time.deltaTime;






        }

        if (mode == 3)
        {
            player = GameObject.Find(names);
            transform.LookAt(player.transform);
            transform.position += transform.forward * sphereSpeed * Time.deltaTime;
            Vector3 dir = (player.transform.position - this.transform.position).normalized;
            float vx = dir.x * sphereSpeed;
            float vz = dir.z * sphereSpeed;
            //this.transform.Translate(vx / 50, 0, vz / 50);
            //GetComponent<Rigidbody>().isKinematic = false;
            Vector3 ra = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
            Debug.Log(vx);
            //transform.position += transform.forward * sphereSpeed * Time.deltaTime;






        }
    }
}
