using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
	public float speed = 3f;
    private bool isRotating;
    [SerializeField] private Vector3 rotateAxis;

    private void Start()
    {
        isRotating = true;
        StartCoroutine(AngleRotation());
    }

    IEnumerator AngleRotation()
    {
        while (isRotating)
        {
        yield return new WaitForSeconds(0);
        transform.Rotate( rotateAxis *speed * Time.deltaTime / 0.01f, Space.Self);
        }
    }

    // Update is called once per frame
/*    void Update()
    {
		transform.Rotate(0f, 0f, speed * Time.deltaTime / 0.01f, Space.Self);
	}*/
}
