using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class UnitBehavior : MonoBehaviour
{

    private Rigidbody myRigidBody;

    // Use this for initialization
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        //StartCoroutine(JumpAround());
    }

    // Update is called once per frame
    void Update()
    {
        ;
    }

    void LeftClick()
    {
        GameManager.instance.SelectItem(this.gameObject);
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) {
            LeftClick();
        }
    }

        IEnumerator JumpAround()
    {
        while (true)
        {
            Vector3 dir = Random.insideUnitCircle;
            dir.z = 1;
            myRigidBody.AddForce(dir * 120);
            yield return new WaitForSeconds(1f);
        }
    }
}
