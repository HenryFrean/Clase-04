using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimiento : MonoBehaviour
{
    public int life = 100;
    public float speed = 5f;
    public int sumLife = 0;
    public int restLife = 0;
    public Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        Cure(sumLife);
        Damage(restLife);
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer(dir);
    }

    void MovePlayer(Vector3 direction)
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    void Cure(int value)
    {
        life = life + value;
    }

    void Damage(int value)
    {
        life = life - value;
    }
}
