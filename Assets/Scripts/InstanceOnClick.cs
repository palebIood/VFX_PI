using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceOnClick : MonoBehaviour
{
    [SerializeField] GameObject ps;
    
    int layerMask = 6;
    bool click;

    private void Update()
    {
        click = Input.GetMouseButtonDown(0);

        int layerMask = 1 << 6;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        {
            if (click)
            {
                GameObject inst = Instantiate(ps, hit.point, Quaternion.identity);
                inst.transform.parent = null;
            }

        }
    }

}
