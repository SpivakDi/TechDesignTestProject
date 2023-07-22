using UnityEngine;
using UnityEngine.EventSystems;

public class click_checker : MonoBehaviour, IPointerClickHandler
{
    private Animator anim;
    private AudioSource AS;
    private bool enemy_alive;

    public Animator enemy_anim;
    public GameObject button;
    public AudioClip swipe;
    public AudioClip Impact_sound;
    public AudioClip death_enemy_sound;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerId == -1)
        {
            anim.SetTrigger("attacks");
        }
    }

    public void play_enemy_death_animation()
    {
        enemy_anim.SetTrigger("dead");
    }

    public void enable_button()
    {
        button.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        AS = GetComponent<AudioSource>();
        enemy_alive = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Test()
    {
        Debug.Log("1");
    }

    public void play_swipe_sounde()
    {
        AS.PlayOneShot(swipe);
    }

    public void play_Impact_sound()
    {
        AS.PlayOneShot(Impact_sound);
    }

    public void play_death_enemy_sound()
    {
        if (enemy_alive)
        {
            AS.PlayOneShot(death_enemy_sound);
            enemy_alive = false;
            enemy_alive = false;
        }
    }
}
