using UnityEngine;

public class Bullet : MonoBehaviour {

    private Transform target;

    public float speed = 5f;

    public int damage = 50;
    public float explosionRadius = 0f;
    public GameObject impactEffect;

    private Vector3 dir;
    private Vector3 destroyed_Vector;
    float distanceThisFrame;

    public void Seek(Transform _target)
    {
        target = _target;
    }
	// Update is called once per frame
	void Update () {


        distanceThisFrame = speed * Time.deltaTime;

        if (target == null)
        {
            dir = destroyed_Vector - transform.position;
            Debug.Log("magnitude : " + dir.magnitude);
            Debug.Log("distanceThisFrame : " + distanceThisFrame);
            if (dir.magnitude <= distanceThisFrame)
            {
                
                HitTarget();
                return;
            }
            //Destroy(gameObject);
            //return;
        }
        else
        {
            dir = target.position - transform.position;
            
            if (dir.magnitude <= distanceThisFrame)
            {
                HitTarget();
                return;
            }
            destroyed_Vector = target.position;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        if(target != null)
            transform.LookAt(target); // make missile look at target
	}

    void HitTarget()
    {
        GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectIns, 5f);

        if(explosionRadius > 0f)
        {
            Explode();
        }
        else
        {
            if(target != null)
                Damage(target);
        }
        Destroy(gameObject);
    }

    void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach(Collider collider in colliders)
        {
            if(collider.tag == "Enemy")
            {
                Damage(collider.transform);
            }
        }
    }

    void Damage(Transform enemy)
    {
        Enemy e = enemy.GetComponent<Enemy>();

        if(e != null) {
            e.TakeDamage(damage);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }
}
