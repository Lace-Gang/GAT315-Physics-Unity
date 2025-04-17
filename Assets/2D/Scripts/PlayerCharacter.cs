using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    [SerializeField] AnimationEventRouter animationEventRouter;
    [SerializeField] GameObject fireDamage;

    private void Awake()
    {
        animationEventRouter.AddListener("FireAttack", OnFireAttack);
    }

    void OnFireAttack(AnimationEvent animationEvent)
    {
        fireDamage.SetActive((animationEvent.intParameter == 1));
    }
}


