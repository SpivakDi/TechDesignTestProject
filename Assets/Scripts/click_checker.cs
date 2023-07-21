using UnityEngine;
using UnityEngine.EventSystems;

public class click_checker : MonoBehaviour, IPointerClickHandler
{
    private Animator anim;

    public Animator enemy_anim;
    public GameObject button;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerId == -1)
        {
            anim.SetTrigger("attacks");
            enemy_anim.SetTrigger("dead");
            button.SetActive(true);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
