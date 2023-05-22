using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class CountDown : MonoBehaviour
{
    [SerializeField] int duration;
    public UnityEvent OnCountFinished = new UnityEvent();
    public UnityEvent<int> OnCount = new UnityEvent<int>();
    bool isCounting;
    Coroutine countCoroutine;
    public void StartCount () 
    {
        if(countCoroutine != null)
            return;

        countCoroutine = StartCoroutine(CountCoroutine());
    }
    private IEnumerator CountCoroutine() 
    {
        for (int i = duration; i >= 0; i--)
        {
            OnCount.Invoke(i);
            yield return new WaitForSecondsRealtime(1);
        }
        OnCountFinished.Invoke();
    }

}
