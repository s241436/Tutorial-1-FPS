using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{

    public float projectileLife = 3.0f;
    public int damageAmount = 1;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, projectileLife);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        TargetHealth targetHit = null;

        if (collision != null)
        {
             targetHit = collision.gameObject.GetComponent<TargetHealth>();
        }

        if (targetHit == null)
        {
            targetHit = collision.transform.parent.GetComponent<TargetHealth>();
        }

        print(targetHit);
        
        if (targetHit != null)
        {
            targetHit.Damage(damageAmount);
        }
        Destroy(gameObject);
    }

}
