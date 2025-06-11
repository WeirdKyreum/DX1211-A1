using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Timeline;
[System.Serializable]

public class ActivationRule : MonoBehaviour
{
    public GameObject objectToActivate;
    public float delay;
    public float lifetime;
}
public class GameManager : MonoBehaviour
{
    public ActivationRule[] rules;
    void Start()
    {
        foreach (ActivationRule rule in rules)
        {
            StartCoroutine(Activate(rule));
        }
    }

    private IEnumerator Activate(ActivationRule rule)
    {
        yield return new WaitForSeconds(rule.delay);

        rule.objectToActivate.SetActive(true);
    }

   

}
