using System.ComponentModel;
using TMPro.EditorUtilities;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private AnimationCurve moveCube;

    private float currentTime;
    private float totalTime;

    void Start()
    {
        totalTime = moveCube.keys[moveCube.keys.Length - 1].time;
    }

    
    void FixedUpdate()
    {
        gameObject.transform.position = new Vector3(transform.position.x, moveCube.Evaluate(currentTime), transform.position.z);
        currentTime += Time.fixedDeltaTime;
        if (currentTime >= totalTime)
        {
            currentTime = 0;
        }
    }
}
