using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 3f;    //移動速度
    public float lifeTime = 15f;    //滞在時間

    public Transform taget;         //ゴールオブジェクトを取得

    private float timer = 0f;       //現在の生存時間
    private bool isStopped = false; //状態(通常/足止め)
    private Transform target;       //監視室
    private NavMeshAgent agent;     //移動可能範囲

   
    void Start()
    {
        target = GameObject.Find("Goal").transform;//監視室の名前に合わせる
        agent = GetComponent<NavMeshAgent>();

        agent.SetDestination(target.position);
    }

  
    void Update()
    {
        timer += Time.deltaTime;

        //滞在時間が切れたら消える
        if(timer >= lifeTime)
        {
            Destroy(gameObject);
        }

        //agent.isStopped = isStopped;

        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    FindObjectOfType<EnemyController>().StopEnemy(3f);
        //}

    }

    public void StopEnemy(float stopTime)
    {
        if(!isStopped)
        {
            StartCoroutine(StopCoroutine(stopTime));
        }
    }
    System.Collections.IEnumerator StopCoroutine(float time)
    {
        isStopped = true;
        yield return new WaitForSeconds(time);
        isStopped = false;
    }
}
