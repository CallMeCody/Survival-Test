using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipTool : Equip
{
    public float attackRate;
    private bool attacking;
    public float attackDistance;


    [Header("Resource Gathering")]
    public bool doesGatherResources;

    [Header("Combat")]
    public bool doesDealDamage;
    public int damage;

    // components
    private Animator anim;
    private Camera cam;

    void Awake()
    {
        // get our components
        anim = GetComponent<Animator>();
        cam = Camera.main;
    }

    // called when we pass the attack input
    public override void OnAttackInput()
    {
        if (!attacking)
        {
            attacking = true;
            anim.SetTrigger("Attack");
            Invoke("OnCanAttack", attackRate);
        }
    }

    // called when we're able to attack again
    void OnCanAttack()
    {
        attacking = false;
    }

    void OnHit()
    {
        Ray ray = cam.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, attackDistance))
        {
            // did we hit a resource?

            // did we hit a damagable?
        }
    }
}
