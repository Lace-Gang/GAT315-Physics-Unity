using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    [SerializeField] AnimationEventRouter animationEventRouter;
    [SerializeField] GameObject fireDamage;
    [SerializeField] GameObject fireDamageOther;


    [SerializeField] ObserverExample observer;
    [SerializeField] IntDataSO scoreData;       //can use this to update score for the UI (or anyone else who wants to know)
    [SerializeField] EventChannelSO onPlayerDeath;
    [SerializeField] IntEventChannelSO scoreEvent;



    private void OnEnable()
    {
        //Subscribe using UnityActions
        //observer.onFunctionStart += Observer;
        //AddListener to subscribe through code when using UnityEvents
        scoreEvent.AddListener(onScore);
        
    }

    private void OnDisable()
    {
        //observer.onFunctionStart -= Observer;
    }

    public void Observer()
    {
        print(observer);
    }

    private void Awake()
    {
        animationEventRouter.AddListener("FireAttack", OnFireAttack);
    }

    void OnFireAttack(AnimationEvent animationEvent)
    {
        fireDamage.SetActive((animationEvent.intParameter == 1));
        fireDamageOther.SetActive((animationEvent.intParameter == 1));
    }

    public void onDeath()
    {
        onPlayerDeath.Raise();
    }

    public void onScore(int score)
    {
        scoreData.Value += score;
    }
}


