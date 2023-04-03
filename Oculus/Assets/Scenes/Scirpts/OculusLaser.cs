using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OculusLaser : MonoBehaviour
{
    public enum HandType
    {
        LeftHand, RightHand
    }
    public HandType type;

    public OculusCon player;

    private LineRenderer line; // 라인렌더러
    private float maxDistance = 30.0f; //레이저 최대거리
    public GameObject hitObject; // 레이저가 감지한 물체


    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        line = GetComponent<LineRenderer>();
        //이 스크립트가 부착된 오브젝트에서 LineRenderer라는 컴포넌트를 찾아서 line에 연결한다.

        line.SetPosition(0, transform.position);
        line.SetPosition(1, transform.forward * maxDistance);

        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, maxDistance))
        {
            hitObject = hit.transform.gameObject;
        }
        else
        {
            hitObject = null;
        }

        switch(type)
        {
            case HandType.LeftHand:
                {
                    player.hitL = hitObject;
                    break;
                }
            case HandType.RightHand:
                {
                    player.hitR = hitObject;
                    break;
                }
        }
    }
}
