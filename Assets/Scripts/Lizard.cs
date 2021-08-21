using UnityEngine;

public class Lizard : MonoBehaviour
{
    public Animator lizardAnim;
    Attackers lizardAttacker;

    // Start is called before the first frame update
    void Start()
    {
        lizardAnim = GetComponent<Animator>();
        lizardAttacker = GetComponent<Attackers>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!obj.GetComponent<Defender>())
        {

        }
        else
        {
            lizardAnim.SetBool("IsAttacking", true);
            lizardAttacker.Attack(obj); ;
        }
    }*/
}
