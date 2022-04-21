using System;
using UnityEngine;

public class PointOfInterest : MonoBehaviour
{
    public static event Action<PointOfInterest> OnPointOfInterestEntered;

    [SerializeField] private string _pointName;

    public string PointName => _pointName;

    private void OnTriggerEnter(Collider other)
    {
        OnPointOfInterestEntered?.Invoke(this);
    }
}
