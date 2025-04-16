using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    [SerializeField] AnimationEventRouter animationEventRouter;
    [SerializeField] GameObject meleeWeapon;

    private void Awake()
    {
        animationEventRouter.AddListener("FireAttack", OnFireAttack);
    }

    void OnFireAttack(AnimationEvent animationEvent)
    {
        meleeWeapon.SetActive((animationEvent.intParameter == 1));
    }
}

}
