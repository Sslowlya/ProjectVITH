using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextMeshProFade : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(IdleFarm());
    }
    public GameObject TextQuest;
    IEnumerator IdleFarm()
    {
        // ждем 
        yield return new WaitForSeconds(10f);
        // теккст пропадает.
        TextQuest.SetActive(false);
    }
}
