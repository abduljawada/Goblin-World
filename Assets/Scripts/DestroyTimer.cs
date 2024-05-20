using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    [SerializeField] float timeToDestroy;
    public GameObject originalObj;

    private void Start()
    {
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(timeToDestroy);

        if (originalObj != null)
        {
            originalObj.SetActive(true);
        }

        Destroy(this.gameObject);
    }
}
