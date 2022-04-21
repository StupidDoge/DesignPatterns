using UnityEngine;

public class AchievementSystem : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.DeleteAll();

        PointOfInterest.OnPointOfInterestEntered += UnlockAchievement;
    }

    private void OnDestroy()
    {
        PointOfInterest.OnPointOfInterestEntered -= UnlockAchievement;
    }

    private void UnlockAchievement(PointOfInterest point)
    {
        string achievementKey = "achievement_" + point.PointName;

        if (PlayerPrefs.GetInt(achievementKey) == 1)
            return;

        PlayerPrefs.SetInt(achievementKey, 1);
        AudioSystem.Instance.PlayAudio(); // Decided to add singleton here just for fun
        Debug.Log("Achievement " + point.PointName + " unlocked!");
    }
}
