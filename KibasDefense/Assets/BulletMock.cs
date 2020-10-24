using UnityEngine;

public class BulletMock : MonoBehaviour
{

    private Transform target;

    public float speed = 70f;

    public void Seek(Transform _target)
    {
        target = _target;
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Debug.Log("Destroy bullet");
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;


        Debug.Log("bullet + dir.magnitude: " + dir.magnitude);
        if (dir.magnitude <= distanceThisFrame){
            
        }

    }
}
