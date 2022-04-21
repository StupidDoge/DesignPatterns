using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] private int _points;
    [SerializeField] private float _cooldownTime;

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        ScoreController.Instance.AddScore(_points);
        Invoke(nameof(EnableObjectAfterCooldown), _cooldownTime);
    }

    private void EnableObjectAfterCooldown()
    {
        gameObject.SetActive(true);
    }
}
