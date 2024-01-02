using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollAbility : MonoBehaviour
{
    public int SelectedAbility = 0;

    private void Start()
    {
        SelectAbility();
    }

    private void Update()
    {
        int previousSelectedAbility = SelectedAbility;

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (SelectedAbility >= transform.childCount - 1)
                SelectedAbility = 0;
            else
                SelectedAbility++;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (SelectedAbility <= 0)
                SelectedAbility = transform.childCount - 1;
            else
                SelectedAbility--;
        }

        if(previousSelectedAbility != SelectedAbility)
        {
            SelectAbility();
        }
    }

    private void SelectAbility()
    {
        int i = 0;
        foreach (Transform Power in transform)
        {
            if (i == SelectedAbility)
                Power.gameObject.SetActive(true);
            else
                Power.gameObject.SetActive(false);

            i++;
        }
    }


}
