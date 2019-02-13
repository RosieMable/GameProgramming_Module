using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.AI;

public class MotionWaypoint : MonoBehaviour
{
    [SerializeField]
    Transform[] waypoints;

    AICharacterControl mController;
    NavMeshAgent mAgent;

    int mIndex = -1;

    // Start is called before the first frame update
    void Start()
    {
        mController = GetComponent<AICharacterControl>();
        mAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mAgent.remainingDistance< 2.0f)
        {
            mController.target = NextwayPoint();
        }   
    }

    Transform NextwayPoint()
    {
        if (++mIndex >= waypoints.Length)
        {
            mIndex = 0;
        }
        return waypoints[mIndex];
    }
}
