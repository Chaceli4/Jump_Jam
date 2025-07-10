using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject Door;

    void Start()
    {
    }

    IEnumerator DeleteChildrenThenSelf()
    {
        // Copy children to a list first
        List<Transform> children = new List<Transform>();
        foreach (Transform child in Door.transform)
        {
            children.Add(child);
        }

        // Now destroy one by one with delay
        foreach (Transform child in children)
        {
            Destroy(child.gameObject);
            yield return new WaitForSeconds(0.2f);
        }

        // Wait before deleting parent
        yield return new WaitForSeconds(2f);
        Destroy(Door);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            StartCoroutine(DeleteChildrenThenSelf());
        }
    }

}
